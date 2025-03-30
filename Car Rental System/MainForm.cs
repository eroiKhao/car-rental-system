using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                var cars = FileManager.Read("cars.txt").OfType<Car>().ToList();

                var selectedItem = listBoxCars.SelectedItem;

                if (selectedItem == null)
                {
                    MessageBox.Show("Please select a car from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCarText = selectedItem.Text;
                var carDetails = selectedCarText.Split('|');

                if (carDetails.Length < 2)
                {
                    MessageBox.Show("Invalid car selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCarModel = carDetails[0].Trim(); 
                var selectedCarStatus = carDetails[1].Trim().Replace("Status: ", "");

                if (selectedCarStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The selected car is damaged and cannot be rented.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCar = cars.FirstOrDefault(c => c.Model.Equals(selectedCarModel, StringComparison.OrdinalIgnoreCase));

                if (selectedCar == null)
                {
                    MessageBox.Show("Selected car is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassportDetails.Text) || string.IsNullOrWhiteSpace(txtRentalDays.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtRentalDays.Text, out int rentalDays) || rentalDays <= 0)
                {
                    MessageBox.Show("Please enter a valid number for rental days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var order = new Order
                {
                    PassportDetails = txtPassportDetails.Text.Trim(),
                    RentedCar = selectedCar, 
                    RentalDays = rentalDays,
                    StatusOrder = "Pending", 
                    RejectionReason = ""
                };

                FileManager.Add(order);
                MessageBox.Show("Car rented successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPassportDetails.Clear();
                txtRentalDays.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing the rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClient_Click_1(object sender, EventArgs e)
        {
            LoadCarsToListBox();
            panelClient.Visible = true;
            panelClient.BringToFront();
        }

        private void btnBackClient_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
            panelAdmin.Visible = false;
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelClient.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            panelClient.Visible = false;
        }
        public void LoadCarsToListBox()
        {
            try
            {
                var cars = FileManager.Read("cars.txt").OfType<Car>().ToList();

                listBoxCars.Items.Clear(); 

                if (cars.Count == 0)
                {
                    MessageBox.Show("No cars found in the file.");
                }

                foreach (var car in cars)
                {
                    var item = new MaterialSkin.MaterialListBoxItem();

                    item.Text = $"{car.Model} | Status: {car.CarStatus}";

                    listBoxCars.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        }
        }
}
