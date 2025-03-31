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
using System.Runtime.Remoting.Contexts;

namespace Car_Rental_System
{
    public partial class MainForm : MaterialForm
    {
        private readonly DataManager dataManager;
        public MainForm()
        {
            InitializeComponent();

            dataManager = new DataManager();

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
                var selectedItem = listBoxCars.SelectedItem;

                if (selectedItem == null)
                {
                    MessageBox.Show("Please select a car from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCarText = selectedItem.Text;
                var carDetails = selectedCarText.Split('|');

                if (carDetails.Length < 3)
                {
                    MessageBox.Show("Invalid car selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCarModel = carDetails[0].Trim();
                if (!int.TryParse(carDetails[1].Trim(), out int selectedCarYear))
                {
                    MessageBox.Show("Invalid car year format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var selectedCarStatus = carDetails[2].Trim().Replace("Status: ", "");

                if (selectedCarStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The selected car is damaged and cannot be rented.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var rentedCar = new Car(Guid.NewGuid(), selectedCarModel, selectedCarStatus, selectedCarYear);

                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    PassportDetails = txtPassportDetails.Text.Trim(),
                    RentedCar = rentedCar,
                    RentalDays = rentalDays,
                    StatusOrder = "Pending",
                    RejectionReason = ""
                };

                FileManager.WriteToFile(order);
                dataManager.Add(order);
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

        private void btnPayment_Click(object sender, EventArgs e)
        {

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
            LoadOrdersToListView();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

        private void btnDamaged_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dataManager.Entities.Any())
                {
                    return;
                }

                orderListView.Items.Clear();


                IEnumerable<IEntity> foundEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    foundEntities = dataManager.Entities;
                }
                else
                {
                    foundEntities = dataManager.Search(searchTextBox.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    var orderEntity = entity as Order;

                    if (orderEntity != null)
                    {
                        var item = new ListViewItem(orderListView.Items.Count + 1 + "");
                        item.SubItems.Add(orderEntity.RentedCar.Model);
                        item.SubItems.Add(orderEntity.RentedCar.Year.ToString());
                        item.SubItems.Add(orderEntity.PassportDetails);
                        item.SubItems.Add(orderEntity.RentalDays.ToString());
                        item.SubItems.Add(orderEntity.StatusOrder);
                        item.SubItems.Add(string.IsNullOrWhiteSpace(orderEntity.RejectionReason) ? "N/A" : orderEntity.RejectionReason); // Причина відмови
                        item.SubItems.Add(orderEntity.Id.ToString());
                        
                        orderListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dataManager.Entities.Any())
                {
                    return;
                }
                orderListView.Items.Clear();

                IEnumerable<IEntity> filteredEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(yearFromTextBox.Text) || string.IsNullOrEmpty(yearToTextBox.Text))
                {
                    filteredEntities = dataManager.Entities;
                }
                else
                {
                    filteredEntities = dataManager.Filter(entity =>
                    {
                        if (entity is Order orderEntity)
                        {
                            if (int.TryParse(yearFromTextBox.Text, out int yearFrom) &&
                                int.TryParse(yearToTextBox.Text, out int yearTo))
                            {
                                return orderEntity.RentedCar.Year >= yearFrom && orderEntity.RentedCar.Year <= yearTo;
                            }
                        }
                        return false;
                    });
                }

                foreach (IEntity entity in filteredEntities)
                {
                    if (entity is Order orderEntity)
                    {
                        var item = new ListViewItem(orderListView.Items.Count + 1 + "");
                        item.SubItems.Add(orderEntity.RentedCar.Model); 
                        item.SubItems.Add(orderEntity.RentedCar.Year.ToString());
                        item.SubItems.Add(orderEntity.PassportDetails);
                        item.SubItems.Add(orderEntity.RentalDays.ToString());
                        item.SubItems.Add(orderEntity.StatusOrder);
                        item.SubItems.Add(string.IsNullOrWhiteSpace(orderEntity.RejectionReason) ? "N/A" : orderEntity.RejectionReason);
                        item.SubItems.Add(orderEntity.Id.ToString());

                        orderListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }


        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                string selectedGuidText = orderListView.SelectedItems[0].SubItems[7].Text;

                if (Guid.TryParse(selectedGuidText, out Guid id))
                {
                    IEntity? entity = dataManager[id];
                    if (entity is Order order)
                    {
                        var formattedText = order.Format();
                        selectedItemTextBox.Text = formattedText;
                    }
                }
                else
                {
                    MaterialMessageBox.Show("Invalid GUID format in the selected row.");
                }
            }
        }
        private void LoadOrdersToListView()
        {
            try
            {
                orderListView.Items.Clear();

                var orders = File.ReadAllLines("orders.txt");

                foreach (var line in orders)
                {
                    var order = new Order();
                    order.Parse(line);
                    var item = new ListViewItem(orderListView.Items.Count + 1 + "");

                    item.SubItems.Add(order.RentedCar.Model);
                    item.SubItems.Add(order.RentedCar.Year.ToString());
                    item.SubItems.Add(order.PassportDetails);
                    item.SubItems.Add(order.RentalDays.ToString());
                    item.SubItems.Add(order.StatusOrder);
                    item.SubItems.Add(string.IsNullOrEmpty(order.RejectionReason) ? "N/A" : order.RejectionReason);
                    item.SubItems.Add(order.Id.ToString());


                    orderListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Error loading orders: " + ex.Message);
            }
        }
        private void LoadCarsToListBox()
        {
            try
            {
                if (!File.Exists("cars.txt"))
                {
                    MessageBox.Show("Cars file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listBoxCars.Items.Clear();

                var lines = File.ReadAllLines("cars.txt");

                foreach (var line in lines)
                {
                    var parts = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

                    if (parts.Length != 4)
                    {
                        MessageBox.Show($"Invalid car data format: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    if (!Guid.TryParse(parts[0], out Guid carId))
                    {
                        MessageBox.Show($"Invalid car ID format: {parts[0]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    var model = parts[1].Trim();
                    var status = parts[2].Trim();
                    if (!int.TryParse(parts[3].Trim(), out int year))
                    {
                        MessageBox.Show($"Invalid car year format: {parts[3]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    var item = new MaterialSkin.MaterialListBoxItem
                    {
                        Text = $"{model} | {year} | Status: {status}"
                    };

                    listBoxCars.Items.Add(item);
                }

                if (listBoxCars.Items.Count == 0)
                {
                    MessageBox.Show("No cars found in the file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
