using System.Diagnostics;
using CarRentalSystem.Generic.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Views
{
    public partial class PaymentForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        private ClientForm _clientForm;
        public PaymentForm(ClientForm clientForm)
        {
            InitializeComponent();

            _context = new RentalCarContext();
            _clientForm = clientForm;
            LoadPendingOrdersAsync();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);
        }
        private void clientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _clientForm.Show();
            this.Close();
        }
        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_clientForm != null && !_clientForm.IsDisposed)
            {
                _clientForm.Show();
            }
        }

        private async Task LoadPendingOrdersAsync()
        {
            try
            {
                ordersListView.Items.Clear();

                var pendingOrders = await _context.Orders
                    .FromSqlRaw("SELECT * FROM Orders WHERE Status = 'Pending'")
                    .Include(o => o.Client)
                    .Include(o => o.RentedCar)
                    .ToListAsync();

                int itemNumber = 1;

                foreach (var order in pendingOrders)
                {
                    string clientName = order.Client?.Name ?? "N/A";
                    string carModel = order.RentedCar?.Model ?? "N/A";
                    int rentalDays = order.RentalDays ?? 0;
                    decimal totalPrice = order.TotalPrice;

                    var item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(clientName);
                    item.SubItems.Add(carModel);
                    item.SubItems.Add(rentalDays.ToString());
                    item.SubItems.Add(totalPrice.ToString("F2"));
                    item.Tag = order.Id;

                    ordersListView.Items.Add(item);
                    itemNumber++;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading pending orders.");
            }
        }

        private async void payBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ordersListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an order to pay.");
                    return;
                }

                if (!decimal.TryParse(moneyTextBox.Text, out decimal enteredAmount))
                {
                    MessageBox.Show("Invalid amount entered.");
                    return;
                }

                var selectedItem = ordersListView.SelectedItems[0];
                Guid orderId = (Guid)selectedItem.Tag;

                var order = await _context.Orders.FindAsync(orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found.");
                    return;
                }

                if (enteredAmount != order.TotalPrice)
                {
                    MessageBox.Show("Entered amount does not match the order total.");
                    return;
                }

                order.Status = "Paid";
                await _context.SaveChangesAsync();

                MessageBox.Show("Payment completed successfully.");
                await LoadPendingOrdersAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred during payment.");
            }
        }
    }
}
