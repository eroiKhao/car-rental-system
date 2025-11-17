using CarRentalSystem.Generic.Repositories;
using CarRentalSystem.Models;
using CarRentalSystem.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Views
{
    public partial class AdminForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        private readonly OrderService _orderService;

        private ClientForm _clientForm;
        private int currentPage = 1;
        private int pageSize = 5;
        public AdminForm(ClientForm clientForm)
        {
            InitializeComponent();
            _clientForm = clientForm;
            _context = new RentalCarContext();

            var carRepository = new Repository<Car>(_context);
            var clientRepository = new Repository<Client>(_context);
            var orderRepository = new Repository<Order>(_context);

            _orderService = new OrderService(orderRepository, carRepository, clientRepository, _context);
            LoadAllOrders();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_clientForm != null && !_clientForm.IsDisposed)
            {
                _clientForm.Show();
            }
        }
        private void clientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _clientForm.Show();
            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var carRepository = new Repository<Car>(_context);
            var carService = new CarService(carRepository, _context);
            ModifyCarForm modifyCarForm = new ModifyCarForm(this, carService);
            modifyCarForm.ShowDialog();
        }

        private async void LoadAllOrders()
        {
            ordersListView.Items.Clear();
            try
            {
                var result = await _orderService.GetOrdersPaged(currentPage, pageSize);
                var orders = result.Orders;
                var totalOrders = result.TotalCount;

                currentPageLbl.Text = $"Page {currentPage}";

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = totalOrders > (currentPage * pageSize);

                int itemNumber = (currentPage - 1) * pageSize + 1;
                foreach (var order in orders)
                {
                    var item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(order.Client?.Name ?? "N/A");
                    item.SubItems.Add(order.RentedCar?.Model ?? "N/A");
                    item.SubItems.Add(order.RentalDays?.ToString() ?? "N/A");
                    item.SubItems.Add(order.TotalPrice.ToString("F2"));
                    item.SubItems.Add(order.Status);
                    item.SubItems.Add(order.RejectionReason ?? "");
                    item.SubItems.Add(order.CreatedAt.ToLocalTime().ToString("yyyy-MM-dd HH:mm"));
                    item.Tag = order.Id;
                    ordersListView.Items.Add(item);
                    itemNumber++;
                }

                totalOrdersLbl.Text = $"Total Orders: {totalOrders}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Guid orderIdToDelete = (Guid)ordersListView.SelectedItems[0].Tag;

            try
            {
                await _orderService.DeleteOrder(orderIdToDelete);

                MessageBox.Show($"Order ID {orderIdToDelete} successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error deleting order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void approveOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to approve.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid orderIdToApprove = (Guid)ordersListView.SelectedItems[0].Tag;

            try
            {
                await _orderService.ApproveOrder(orderIdToApprove);

                MessageBox.Show($"Order ID {orderIdToApprove} successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error approving order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while approving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void rejectOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to reject.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rejectionReason = reasonTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(rejectionReason))
            {
                MessageBox.Show("Please enter a rejection reason.", "Rejection Reason Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid orderIdToReject = (Guid)ordersListView.SelectedItems[0].Tag;

            try
            {
                await _orderService.RejectOrder(orderIdToReject, rejectionReason);

                MessageBox.Show($"Order ID {orderIdToReject} successfully rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
                reasonTextBox.Clear();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Rejection Reason Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Already Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error rejecting order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while rejecting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadAllOrders();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadAllOrders();
        }
        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();
            ordersListView.Items.Clear();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a name or car model to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var orders = await _orderService.SearchOrders(searchTerm);

                if (orders.Count() == 0)
                {
                    MessageBox.Show("No matching orders found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int itemNumber = 1;
                foreach (var order in orders)
                {
                    var item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(order.Client?.Name ?? "N/A");
                    item.SubItems.Add(order.RentedCar?.Model ?? "N/A");
                    item.SubItems.Add(order.RentalDays?.ToString() ?? "N/A");
                    item.SubItems.Add(order.TotalPrice.ToString("F2"));
                    item.SubItems.Add(order.Status);
                    item.SubItems.Add(order.RejectionReason ?? "");
                    item.SubItems.Add(order.CreatedAt.ToLocalTime().ToString("yyyy-MM-dd HH:mm"));
                    item.Tag = order.Id;
                    ordersListView.Items.Add(item);
                    itemNumber++;
                }

                currentPageLbl.Text = "Search result";
                prevBtn.Enabled = false;
                nextBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            LoadAllOrders();
        }
    }
}
