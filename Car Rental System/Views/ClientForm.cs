using System.Threading;
using CarRentalSystem.Main;
using CarRentalSystem.Models;
using CarRentalSystem.Services;
using CarRentalSystem.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem
{
    public partial class ClientForm : MaterialForm
    {
        private readonly CarService _carService;
        private readonly ClientService _clientService;
        private readonly OrderService _orderService;
        private readonly IFormFactory _formFactory;

        private CancellationTokenSource? _cancellationTokenSource;
        public ClientForm(CarService carService,
        ClientService clientService,
        OrderService orderService,
        IFormFactory formFactory)
        {
            InitializeComponent();

            _carService = carService;
            _clientService = clientService;
            _orderService = orderService;
            _formFactory = formFactory;

            LoadCarsToListView();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
            }

            base.OnFormClosed(e);

            Application.Exit();
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminForm adminForm = _formFactory.CreateForm<AdminForm>();
            adminForm.Show();
        }
        private void payBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm paymentForm = _formFactory.CreateForm<PaymentForm>();
            paymentForm.ShowDialog();
        }

        private async void rentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passportTextBox.Text) ||
                string.IsNullOrWhiteSpace(rentalDaysTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(rentalDaysTextBox.Text, out int rentalDays))
            {
                MessageBox.Show("Please enter a valid number for rental days.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (carsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a car to rent.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCar = carsListView.SelectedItems[0].Tag as Car;
            if (selectedCar == null)
            {
                MessageBox.Show("An error occurred while selecting the car. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string passportDetails = passportTextBox.Text;
                Guid carId = selectedCar.Id;

                var client = _clientService.GetOrCreateClient(name, email, passportDetails);

                _orderService.CreateNewOrder(client, carId, rentalDays);

                MessageBox.Show("Order successfully created! Car status updated to 'Rented'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCarsToListView();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DbUpdateException dbEx)
            {
                if (dbEx.InnerException?.Message.Contains("Duplicate entry") == true && dbEx.InnerException?.Message.Contains("for key 'Email'") == true)
                {
                    MessageBox.Show("A user with this email already exists. Please use a different email or check the entered data.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Database error saving order: {dbEx.Message}\nInner error: {dbEx.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadCarsToListView()
        {
            carsListView.Items.Clear();
            try
            {
                var availableCars = _carService.GetAllAvailableCars();

                int itemNumber = 1;
                foreach (var car in availableCars)
                {
                    var item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(car.Model);
                    item.SubItems.Add(car.Status);
                    item.SubItems.Add(car.PricePerDay.ToString("F2"));
                    item.Tag = car;
                    carsListView.Items.Add(item);
                    itemNumber++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured when loading cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsListView.SelectedItems.Count == 0)
            {
                selectedTextBox.Text = string.Empty;
                return;
            }

            ListViewItem selectedListViewItem = carsListView.SelectedItems[0];

            Car selectedCar = selectedListViewItem.Tag as Car;

            if (selectedCar != null)
            {
                string carInfo =
                    $"[{selectedCar.Model}]" +
                    $"[{selectedCar.Status}]" +
                    $"[{selectedCar.PricePerDay.ToString("C")}]" +
                    $"[{selectedCar.Id.ToString()}]";
                selectedTextBox.Text = carInfo;


            }
            else
            {
                selectedTextBox.Text = "Error getting selected car";
            }
        }

        private async void searchCarBtn_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = new CancellationTokenSource();

            string searchTerm = searchTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            carsListView.Items.Clear();
            MessageBox.Show("Starting long-running search. Press 'Cancel Search' to stop.", "Searching...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                var foundCars = await _carService.SearchCarsExternalAsync(searchTerm, _cancellationTokenSource.Token);

                int itemNumber = 1;
                foreach (var car in foundCars)
                {
                    var item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(car.Model);
                    item.SubItems.Add(car.Status);
                    item.SubItems.Add(car.PricePerDay.ToString("F2"));
                    item.Tag = car;
                    carsListView.Items.Add(item);
                    itemNumber++;
                }
                MessageBox.Show($"Search completed. Found {foundCars.Count()} cars.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Search was canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
            }
        }
        private void cancelSearchBtn_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }
    }
}
