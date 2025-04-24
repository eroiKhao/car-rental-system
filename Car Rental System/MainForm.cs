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
using System.Drawing.Text;

namespace Car_Rental_System
{
    public partial class MainForm : MaterialForm
    {
        private readonly DataManager<Order> dataManager;
        private const int PAGE_LIMIT = 5;
        private int currentPage = 0;
        public MainForm()
        {
            InitializeComponent();

            dataManager = new DataManager<Order>();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderListView.Items.Clear();


                IEnumerable<Order> foundEntities = new List<Order>();
                if (string.IsNullOrEmpty(searchTextBox.Text) &&
                    string.IsNullOrEmpty(yearFromTextBox.Text) &&
                    string.IsNullOrEmpty(yearToTextBox.Text))
                {
                    foundEntities = dataManager.Entities
                        .OrderBy(x => x.RentedCar.Model)
                        .ThenByDescending(x => x.RentedCar.Year)
                        .Paginate(currentPage, PAGE_LIMIT);
                }
                else
                {
                    int? yearFrom = null;
                    if (int.TryParse(yearFromTextBox.Text, out var yearFromResult))
                        yearFrom = yearFromResult;

                    int? yearTo = null;
                       if (int.TryParse(yearToTextBox.Text, out var yearToResult))
                        yearTo = yearToResult;
                    foundEntities = dataManager.Entities
                        .Where(e => (string.IsNullOrEmpty(searchTextBox.Text) || e.Search(searchTextBox.Text)) &&
                                    (yearFrom == null || yearTo == null ||
                                    (e.RentedCar.Year >= yearFrom && e.RentedCar.Year <= yearTo)))
                        .OrderBy(x => x.RentedCar.Model)
                        .ThenByDescending(x => x.RentedCar.Year)
                        .Paginate(currentPage, PAGE_LIMIT);

                }
                foundEntities.ToList().ForEach(e =>
                {
                    var orderEntity = e as Order;

                    if (orderEntity != null)
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
                });

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
                int selectedIndex = orderListView.SelectedIndices[0];
                string selectedItemText = orderListView.SelectedItems[0].SubItems[7].Text;
                var id = Guid.Parse(selectedItemText);

                var data = dataManager.Entities
                    .Where(x => x.Id == id)
                    .Select(x => x.RentedCar.Model + " " +
                                x.PassportDetails + " " +
                                x.StatusOrder + " " +
                                x.RentedCar.Year.ToString() + " " +
                                (string.IsNullOrWhiteSpace(x.RejectionReason) ? "N/A" : x.RejectionReason))
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(data))
                {
                    selectedItemTextBox.Text = data;
                }
            }
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            orderListView.Items.Clear();

            var orders = dataManager.Entities
                .OrderBy(x => x.RentedCar.Model)
                .ThenByDescending(x => x.RentedCar.Year)
                .Skip(currentPage * PAGE_LIMIT)
                .Take(PAGE_LIMIT);

            foreach (var order in orders)
            {
                var item = new ListViewItem(orderListView.Items.Count + 1 + "");
                item.SubItems.Add(order.RentedCar.Model);
                item.SubItems.Add(order.RentedCar.Year.ToString());
                item.SubItems.Add(order.PassportDetails);
                item.SubItems.Add(order.RentalDays.ToString());
                item.SubItems.Add(order.StatusOrder);
                item.SubItems.Add(string.IsNullOrWhiteSpace(order.RejectionReason) ? "N/A" : order.RejectionReason);
                item.SubItems.Add(order.Id.ToString());

                orderListView.Items.Add(item);
            }
        }
        private void LoadOrdersToListView()
        {
            try
            {
                orderListView.Items.Clear();

                var orders = FileManager.GetEntities<Order>("orders.txt");

                var rented = orders
                    .OrderBy(x => x.RentedCar.Model)
                    .ThenByDescending(x => x.RentedCar.Year);
                rented.ToList().ForEach(e  => dataManager.Add(e));

                orders = rented.Paginate(currentPage, PAGE_LIMIT);

                foreach (var order in orders)
                {
                    var item = new ListViewItem((orderListView.Items.Count + 1).ToString());
                    item.SubItems.Add(order.RentedCar.Model);
                    item.SubItems.Add(order.RentedCar.Year.ToString());
                    item.SubItems.Add(order.PassportDetails);
                    item.SubItems.Add(order.RentalDays.ToString());
                    item.SubItems.Add(order.StatusOrder);
                    item.SubItems.Add(string.IsNullOrEmpty(order.RejectionReason) ? "N/A" : order.RejectionReason);
                    item.SubItems.Add(order.Id.ToString());

                    orderListView.Items.Add(item);
                }

                CalculateStatistics();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Error loading orders: " + ex.Message);
            }
        }
        private void loadSourceBtn_Click(object sender, EventArgs e)
        {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                orderListView.Items.Clear();
                dataManager.Clear();

                var anotherOrders = FileManager.GetEntities<Order>(fileDialog.FileName);
                var currentOrderIds = dataManager.Entities.Select(e => e.Id);

                var uniqueAnotherOrders = anotherOrders.Where(order => !currentOrderIds.Contains(order.Id));

                var allOrders = dataManager.Entities
                    .Concat(uniqueAnotherOrders)
                    .OrderBy(x => x.RentedCar.Model)
                    .ThenByDescending(x => x.RentedCar.Year)
                    .ToList();

                allOrders.ForEach(e => dataManager.Add(e));

                allOrders = allOrders.Paginate(0, PAGE_LIMIT).ToList();

                allOrders.ForEach(e =>
                {
                    var item = new ListViewItem(orderListView.Items.Count + 1 + "");
                    item.SubItems.Add(e.RentedCar.Model);
                    item.SubItems.Add(e.RentedCar.Year.ToString());
                    item.SubItems.Add(e.PassportDetails);
                    item.SubItems.Add(e.RentalDays.ToString());
                    item.SubItems.Add(e.StatusOrder);
                    item.SubItems.Add(string.IsNullOrWhiteSpace(e.RejectionReason) ? "N/A" : e.RejectionReason);
                    item.SubItems.Add(e.Id.ToString());

                    orderListView.Items.Add(item);
                });

                CalculateStatistics();
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

                var cars = FileManager.GetEntities<Car>("cars.txt");

                foreach (var car in cars)
                {
                    var item = new MaterialSkin.MaterialListBoxItem
                    {
                        Text = $"{car.Model} | {car.Year} | Status: {car.CarStatus}"
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
        private void Paginate()
        {
            orderListView.Items.Clear();

            var data = dataManager.Entities
                .OrderBy(x => x.RentedCar.Model)
                .ThenByDescending(x => x.RentedCar.Year)
                .Paginate(currentPage, PAGE_LIMIT)
                .ToList();

            data.ForEach(e =>
            {
                var item = new ListViewItem(orderListView.Items.Count + 1 + "");
                item.SubItems.Add(e.RentedCar.Model);
                item.SubItems.Add(e.RentedCar.Year.ToString());
                item.SubItems.Add(e.PassportDetails);
                item.SubItems.Add(e.RentalDays.ToString());
                item.SubItems.Add(e.StatusOrder);
                item.SubItems.Add(string.IsNullOrWhiteSpace(e.RejectionReason) ? "N/A" : e.RejectionReason);
                item.SubItems.Add(e.Id.ToString());

                orderListView.Items.Add(item);
            });

            this.pageNumTextBox.Text = (currentPage + 1).ToString();
        }
        private void CalculateStatistics()
        {
            var totalOrders = dataManager.Entities.Count(e => e is Order);
            countTextBox.Text = totalOrders.ToString();

            var maxRentalDays = dataManager.Entities
                .Where(e => e is Order)
                .Max(e => ((Order)e).RentalDays);
            maxDaysTextBox.Text = maxRentalDays.ToString();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0 && dataManager.Entities.Any())
            {
                currentPage--;
                Paginate();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < dataManager.Entities.Count() / PAGE_LIMIT && dataManager.Entities.Any())
            {
                currentPage++;
                Paginate();
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
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
    }
}
