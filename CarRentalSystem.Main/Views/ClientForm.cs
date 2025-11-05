using CarRentalSystem.Models;
using CarRentalSystem.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem
{
    public partial class ClientForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        public ClientForm()
        {
            InitializeComponent();

            _context = new RentalCarContext();

            LoadCarsToListView();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(this);
            adminForm.Show();
        }
        private void payBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm paymentForm = new PaymentForm(this);
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

            if (!int.TryParse(rentalDaysTextBox.Text, out int rentalDays) || rentalDays <= 0)
            {
                MessageBox.Show("Rental days must be a positive whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // Query 2: Find client by Email
                var existingClient = await _context.Clients
                                                   .TagWith("Find Client by Email")
                                                   .FirstOrDefaultAsync(c => c.Email == emailTextBox.Text);

                Client client;
                if (existingClient != null)
                {
                    client = existingClient;
                    client.Name = nameTextBox.Text;
                    client.PassportDetails = passportTextBox.Text;
                }
                else
                {
                    client = new Client
                    {
                        Name = nameTextBox.Text,
                        Email = emailTextBox.Text,
                        PassportDetails = passportTextBox.Text
                    };
                    _context.Clients.Add(client);
                    await _context.SaveChangesAsync();
                }
                // Query 3: Create new order and update car status
                var newOrder = new Order
                {
                    ClientID = client.Id,
                    Client = client,
                    CarID = selectedCar.Id,
                    RentedCar = selectedCar,
                    RentalDays = rentalDays,
                    TotalPrice = selectedCar.PricePerDay * rentalDays,
                    Status = "Pending"
                };

                _context.Orders.Add(newOrder);
                _context.Cars.Update(selectedCar);
                selectedCar.Status = "Rented";
                await _context.SaveChangesAsync();

                MessageBox.Show("Order successfully created! Car status updated to 'Rented'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCarsToListView();
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
                var availableCars = await _context.Cars
                                                  .TagWith("Get all available cars")
                                                  .AsNoTracking()
                                                  .Where(c => c.Status == "Available")
                                                  .OrderBy(c => c.Model)
                                                  .ToListAsync();
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
    }
}
