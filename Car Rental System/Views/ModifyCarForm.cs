using System.Diagnostics;
using CarRentalSystem.Models;
using CarRentalSystem.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Views
{
    public partial class ModifyCarForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        private AdminForm _adminForm;
        private readonly CarService _carService;
        public ModifyCarForm(AdminForm adminForm, CarService carService)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _context = new RentalCarContext();
            _carService = carService;
            LoadCarsAsync();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen200, TextShade.WHITE);
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _adminForm.Show();
            this.Close();
        }
        private void ModifyCarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_adminForm != null && !_adminForm.IsDisposed)
            {
                _adminForm.Show();
            }
        }
        private async void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string model = modelTextBox.Text;
                decimal price = Convert.ToDecimal(priceTextBox.Text);

                _carService.AddNewCar(model, price);

                MessageBox.Show("Car added successfully.");

                await LoadCarsAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding the car.");
            }
        }

        private async void markAsDamagedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (carsListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a car to mark as damaged.");
                    return;
                }

                var selectedItem = carsListView.SelectedItems[0];
                var carId = Guid.Parse(selectedItem.SubItems[5].Text);

                _carService.MarkCarStatus(carId, "Damaged");

                MessageBox.Show("Car marked as damaged successfully.");

                await LoadCarsAsync();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while marking the car as damaged.");
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (carsListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a car to delete.");
                    return;
                }

                var selectedItem = carsListView.SelectedItems[0];
                var carId = Guid.Parse(selectedItem.SubItems[5].Text);

                _carService.DeleteCar(carId);

                MessageBox.Show("Car deleted successfully.");

                await LoadCarsAsync();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while deleting the car.");
            }
        }
        private async Task LoadCarsAsync()
        {
            try
            {
                carsListView.Items.Clear();

                var cars = _carService.GetAllCars();

                foreach (var car in cars)
                {
                    var item = new ListViewItem((carsListView.Items.Count + 1).ToString());
                    item.SubItems.Add(car.Model);
                    item.SubItems.Add(car.PricePerDay.ToString("F2"));
                    item.SubItems.Add(car.Status);
                    item.SubItems.Add(car.CreatedAt.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(car.Id.ToString());

                    carsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading cars.");
            }
        }

        private async void markAsAvailable_Click(object sender, EventArgs e)
        {
            try
            {
                if (carsListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a car to mark as damaged.");
                    return;
                }

                var selectedItem = carsListView.SelectedItems[0];
                var carId = Guid.Parse(selectedItem.SubItems[5].Text);

                _carService.MarkCarStatus(carId, "Available");

                MessageBox.Show("Car marked as available successfully.");

                await LoadCarsAsync();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while marking the car as available.");
            }
        }
    }
}
