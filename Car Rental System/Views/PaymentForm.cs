using System.Diagnostics;
using CarRentalSystem.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CarRentalSystem.Views
{
    public partial class PaymentForm : MaterialForm
    {
        private readonly OrderService _orderService;
        private readonly ClientForm _clientForm;
        public PaymentForm(
        OrderService orderService,
        ClientForm clientForm)
        {
            InitializeComponent();

            _orderService = orderService;
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

                var pendingOrders = _orderService.GetPendingOrders();

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

                await _orderService.PayOrder(orderId, enteredAmount);

                MessageBox.Show("Payment completed successfully.");
                await LoadPendingOrdersAsync();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred during payment.");
            }
        }
    }
}
