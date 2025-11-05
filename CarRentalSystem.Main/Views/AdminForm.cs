using CarRentalSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Views
{
    public partial class AdminForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        private ClientForm _clientForm;
        private int currentPage = 1;
        private int pageSize = 5;
        public AdminForm(ClientForm clientForm)
        {
            InitializeComponent();
            _clientForm = clientForm;
            _context = new RentalCarContext();
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
            ModifyCarForm modifyCarForm = new ModifyCarForm(this);
            modifyCarForm.ShowDialog();
        }

        private async void LoadAllOrders()
        {
            ordersListView.Items.Clear();
            try
            {
                IQueryable<Order> query = _context.Orders
                                                .TagWith("Load all orders")
                                                .AsNoTracking()
                                                .Include(o => o.Client)
                                                .Include(o => o.RentedCar);
                query = query.OrderByDescending(o => o.CreatedAt);
                var orders = await query
                                    .Skip((currentPage - 1) * pageSize)
                                    .Take(pageSize + 1)
                                    .ToListAsync();
                currentPageLbl.Text = $"Page {currentPage}";

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = orders.Count > pageSize;

                if (orders.Count > pageSize)
                {
                    orders.RemoveAt(pageSize);
                }

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
                GetTotalOrderCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GetTotalOrderCount()
        {
            try
            {
                int totalOrders = await _context.Orders
                                                .TagWith("Get Total Order Count")
                                                .AsNoTracking()
                                                .CountAsync();

                totalOrdersLbl.Text = $"Total Orders: {totalOrders}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total order count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalOrdersLbl.Text = "Total Orders: Error";
            }
        }

        private async void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid orderIdToDelete;
            if (ordersListView.SelectedItems[0].Tag is Guid)
            {
                orderIdToDelete = (Guid)ordersListView.SelectedItems[0].Tag;
            }
            else
            {
                MessageBox.Show("Could not retrieve Order ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orderToDelete = await _context.Orders
                                                  .TagWith($"Delete order by ID")
                                                  .FirstOrDefaultAsync(o => o.Id == orderIdToDelete);

                if (orderToDelete == null)
                {
                    MessageBox.Show($"Order with ID {orderIdToDelete} not found. It might have been deleted already.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _context.Orders.Remove(orderToDelete);
                await _context.SaveChangesAsync();

                MessageBox.Show($"Order ID {orderIdToDelete} successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
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

            Guid orderIdToApprove;
            if (ordersListView.SelectedItems[0].Tag is Guid)
            {
                orderIdToApprove = (Guid)ordersListView.SelectedItems[0].Tag;
            }
            else
            {
                MessageBox.Show("Could not retrieve Order ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var orderToApprove = await _context.Orders
                                                   .TagWith($"Approve Order ID {orderIdToApprove}")
                                                   .FirstOrDefaultAsync(o => o.Id == orderIdToApprove);

                if (orderToApprove == null)
                {
                    MessageBox.Show($"Order with ID {orderIdToApprove} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    await transaction.RollbackAsync();
                    return;
                }

                if (orderToApprove.Status != "Paid")
                {
                    MessageBox.Show($"Order ID {orderIdToApprove} cannot be approved. Current status is '{orderToApprove.Status}'. Only orders with 'Paid' status can be approved.", "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await transaction.RollbackAsync();
                    return;
                }

                orderToApprove.Status = "Approved";

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                MessageBox.Show($"Order ID {orderIdToApprove} successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
            }
            catch (DbUpdateException dbEx)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($"Database error approving order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
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

            Guid orderIdToReject;
            if (ordersListView.SelectedItems[0].Tag is Guid)
            {
                orderIdToReject = (Guid)ordersListView.SelectedItems[0].Tag;
            }
            else
            {
                MessageBox.Show("Could not retrieve Order ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var orderToReject = await _context.Orders
                                                   .TagWith($"Reject Order ID {orderIdToReject}")
                                                   .FirstOrDefaultAsync(o => o.Id == orderIdToReject);

                if (orderToReject == null)
                {
                    MessageBox.Show($"Order with ID {orderIdToReject} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    await transaction.RollbackAsync();
                    return;
                }

                if (orderToReject.Status == "Rejected")
                {
                    MessageBox.Show($"Order ID {orderIdToReject} is already rejected.", "Already Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await transaction.RollbackAsync();
                    return;
                }

                orderToReject.Status = "Rejected";
                orderToReject.RejectionReason = rejectionReason;

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                MessageBox.Show($"Order ID {orderIdToReject} successfully rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllOrders();
                reasonTextBox.Clear();
            }
            catch (DbUpdateException dbEx)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($"Database error rejecting order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
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
                var orders = await _context.Orders
                    .AsNoTracking()
                    .Include(o => o.Client)
                    .Include(o => o.RentedCar)
                    .Where(o =>
                        o.Client.Name.ToLower().Contains(searchTerm) ||
                        o.RentedCar.Model.ToLower().Contains(searchTerm))
                    .OrderByDescending(o => o.CreatedAt)
                    .ToListAsync();

                if (orders.Count == 0)
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
