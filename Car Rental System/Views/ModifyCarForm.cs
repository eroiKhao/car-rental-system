using System.Diagnostics;
using Car_Rental_System.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_System.Views
{
    public partial class ModifyCarForm : MaterialForm
    {
        private readonly RentalCarContext _context;
        public ModifyCarForm()
        {
            InitializeComponent();

            _context = new RentalCarContext();
            LoadCarsAsync();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private async void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CreatedAt = DateTime.Now,
                    Model = modelTextBox.Text,
                    PricePerDay = Convert.ToDecimal(priceTextBox.Text),
                    Status = "Available"
                };

                _context.Cars.Add(car);
                await _context.SaveChangesAsync();

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

                var car = await _context.Cars.FindAsync(carId);
                if (car == null)
                {
                    MessageBox.Show("Car not found.");
                    return;
                }

                car.Status = "Damaged";
                await _context.SaveChangesAsync();
                MessageBox.Show("Car marked as damaged successfully.");

                await LoadCarsAsync();
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

                var car = await _context.Cars.FindAsync(carId);
                if (car == null)
                {
                    MessageBox.Show("Car not found.");
                    return;
                }

                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                MessageBox.Show("Car deleted successfully.");

                await LoadCarsAsync();
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

                var cars = await _context.Cars.ToListAsync();

                foreach (var car in cars)
                {
                    var item = new ListViewItem((carsListView.Items.Count + 1).ToString());
                    item.SubItems.Add(car.Model);
                    item.SubItems.Add(car.PricePerDay.HasValue ? car.PricePerDay.Value.ToString("F2") : "N/A");
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
    }
}
