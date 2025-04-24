using System.Windows.Forms;

namespace Car_Rental_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClient = new MaterialSkin.Controls.MaterialButton();
            this.btnAdmin = new MaterialSkin.Controls.MaterialButton();
            this.panelClient = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.carslabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnPayment = new MaterialSkin.Controls.MaterialButton();
            this.listBoxApprovedOrders = new MaterialSkin.Controls.MaterialListBox();
            this.txtPassportDetails = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBackClient = new MaterialSkin.Controls.MaterialButton();
            this.btnRent = new MaterialSkin.Controls.MaterialButton();
            this.txtRentalDays = new MaterialSkin.Controls.MaterialTextBox();
            this.listBoxCars = new MaterialSkin.Controls.MaterialListBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.selectedItemTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearToTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.yearFromTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.labelCars = new MaterialSkin.Controls.MaterialLabel();
            this.orderListView = new MaterialSkin.Controls.MaterialListView();
            this.numberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rejectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxAdminCars = new MaterialSkin.Controls.MaterialListBox();
            this.txtRejectionReason = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDamaged = new MaterialSkin.Controls.MaterialButton();
            this.btnReject = new MaterialSkin.Controls.MaterialButton();
            this.btnApprove = new MaterialSkin.Controls.MaterialButton();
            this.btnBackAdmin = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.sortBtn = new MaterialSkin.Controls.MaterialButton();
            this.prevBtn = new MaterialSkin.Controls.MaterialButton();
            this.nextBtn = new MaterialSkin.Controls.MaterialButton();
            this.pageNumTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.maxDaysTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.loadSourceBtn = new MaterialSkin.Controls.MaterialButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelClient.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClient.Depth = 0;
            this.btnClient.HighEmphasis = true;
            this.btnClient.Icon = null;
            this.btnClient.Location = new System.Drawing.Point(491, 343);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClient.Name = "btnClient";
            this.btnClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClient.Size = new System.Drawing.Size(71, 36);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClient.UseAccentColor = false;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.HighEmphasis = true;
            this.btnAdmin.Icon = null;
            this.btnAdmin.Location = new System.Drawing.Point(670, 343);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdmin.Size = new System.Drawing.Size(68, 36);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdmin.UseAccentColor = false;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.materialLabel2);
            this.panelClient.Controls.Add(this.carslabel);
            this.panelClient.Controls.Add(this.btnPayment);
            this.panelClient.Controls.Add(this.listBoxApprovedOrders);
            this.panelClient.Controls.Add(this.txtPassportDetails);
            this.panelClient.Controls.Add(this.btnBackClient);
            this.panelClient.Controls.Add(this.btnRent);
            this.panelClient.Controls.Add(this.txtRentalDays);
            this.panelClient.Controls.Add(this.listBoxCars);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(3, 64);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1357, 538);
            this.panelClient.TabIndex = 2;
            this.panelClient.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(959, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Payment";
            // 
            // carslabel
            // 
            this.carslabel.AutoSize = true;
            this.carslabel.Depth = 0;
            this.carslabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carslabel.Location = new System.Drawing.Point(462, 30);
            this.carslabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.carslabel.Name = "carslabel";
            this.carslabel.Size = new System.Drawing.Size(33, 19);
            this.carslabel.TabIndex = 7;
            this.carslabel.Text = "Cars";
            // 
            // btnPayment
            // 
            this.btnPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayment.Depth = 0;
            this.btnPayment.HighEmphasis = true;
            this.btnPayment.Icon = null;
            this.btnPayment.Location = new System.Drawing.Point(936, 419);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPayment.Size = new System.Drawing.Size(134, 36);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayment.UseAccentColor = false;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // listBoxApprovedOrders
            // 
            this.listBoxApprovedOrders.BackColor = System.Drawing.Color.White;
            this.listBoxApprovedOrders.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxApprovedOrders.Depth = 0;
            this.listBoxApprovedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxApprovedOrders.Location = new System.Drawing.Point(732, 69);
            this.listBoxApprovedOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxApprovedOrders.Name = "listBoxApprovedOrders";
            this.listBoxApprovedOrders.SelectedIndex = -1;
            this.listBoxApprovedOrders.SelectedItem = null;
            this.listBoxApprovedOrders.Size = new System.Drawing.Size(487, 330);
            this.listBoxApprovedOrders.TabIndex = 5;
            // 
            // txtPassportDetails
            // 
            this.txtPassportDetails.AnimateReadOnly = false;
            this.txtPassportDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassportDetails.Depth = 0;
            this.txtPassportDetails.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassportDetails.Hint = "Passport details";
            this.txtPassportDetails.LeadingIcon = null;
            this.txtPassportDetails.Location = new System.Drawing.Point(20, 109);
            this.txtPassportDetails.MaxLength = 50;
            this.txtPassportDetails.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassportDetails.Multiline = false;
            this.txtPassportDetails.Name = "txtPassportDetails";
            this.txtPassportDetails.Size = new System.Drawing.Size(198, 50);
            this.txtPassportDetails.TabIndex = 4;
            this.txtPassportDetails.Text = "";
            this.txtPassportDetails.TrailingIcon = null;
            // 
            // btnBackClient
            // 
            this.btnBackClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackClient.Depth = 0;
            this.btnBackClient.HighEmphasis = true;
            this.btnBackClient.Icon = null;
            this.btnBackClient.Location = new System.Drawing.Point(57, 399);
            this.btnBackClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackClient.Name = "btnBackClient";
            this.btnBackClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackClient.Size = new System.Drawing.Size(64, 36);
            this.btnBackClient.TabIndex = 3;
            this.btnBackClient.Text = "Back";
            this.btnBackClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackClient.UseAccentColor = false;
            this.btnBackClient.UseVisualStyleBackColor = true;
            this.btnBackClient.Click += new System.EventHandler(this.btnBackClient_Click);
            // 
            // btnRent
            // 
            this.btnRent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRent.Depth = 0;
            this.btnRent.HighEmphasis = true;
            this.btnRent.Icon = null;
            this.btnRent.Location = new System.Drawing.Point(120, 252);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRent.Name = "btnRent";
            this.btnRent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRent.Size = new System.Drawing.Size(64, 36);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Rent";
            this.btnRent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRent.UseAccentColor = false;
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.AnimateReadOnly = false;
            this.txtRentalDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRentalDays.Depth = 0;
            this.txtRentalDays.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRentalDays.Hint = "Rental period";
            this.txtRentalDays.LeadingIcon = null;
            this.txtRentalDays.Location = new System.Drawing.Point(20, 178);
            this.txtRentalDays.MaxLength = 50;
            this.txtRentalDays.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRentalDays.Multiline = false;
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(198, 50);
            this.txtRentalDays.TabIndex = 1;
            this.txtRentalDays.Text = "";
            this.txtRentalDays.TrailingIcon = null;
            // 
            // listBoxCars
            // 
            this.listBoxCars.BackColor = System.Drawing.Color.White;
            this.listBoxCars.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxCars.Depth = 0;
            this.listBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxCars.Location = new System.Drawing.Point(224, 52);
            this.listBoxCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.SelectedIndex = -1;
            this.listBoxCars.SelectedItem = null;
            this.listBoxCars.Size = new System.Drawing.Size(492, 403);
            this.listBoxCars.TabIndex = 0;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmin.Controls.Add(this.loadSourceBtn);
            this.panelAdmin.Controls.Add(this.materialLabel4);
            this.panelAdmin.Controls.Add(this.materialLabel1);
            this.panelAdmin.Controls.Add(this.maxDaysTextBox);
            this.panelAdmin.Controls.Add(this.countTextBox);
            this.panelAdmin.Controls.Add(this.pageNumTextBox);
            this.panelAdmin.Controls.Add(this.nextBtn);
            this.panelAdmin.Controls.Add(this.prevBtn);
            this.panelAdmin.Controls.Add(this.sortBtn);
            this.panelAdmin.Controls.Add(this.selectedItemTextBox);
            this.panelAdmin.Controls.Add(this.label4);
            this.panelAdmin.Controls.Add(this.label3);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(this.label2);
            this.panelAdmin.Controls.Add(this.yearToTextBox);
            this.panelAdmin.Controls.Add(this.yearFromTextBox);
            this.panelAdmin.Controls.Add(this.searchButton);
            this.panelAdmin.Controls.Add(this.searchTextBox);
            this.panelAdmin.Controls.Add(this.labelCars);
            this.panelAdmin.Controls.Add(this.orderListView);
            this.panelAdmin.Controls.Add(this.listBoxAdminCars);
            this.panelAdmin.Controls.Add(this.txtRejectionReason);
            this.panelAdmin.Controls.Add(this.btnDamaged);
            this.panelAdmin.Controls.Add(this.btnReject);
            this.panelAdmin.Controls.Add(this.btnApprove);
            this.panelAdmin.Controls.Add(this.btnBackAdmin);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(3, 64);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1357, 538);
            this.panelAdmin.TabIndex = 9;
            this.panelAdmin.Visible = false;
            // 
            // selectedItemTextBox
            // 
            this.selectedItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedItemTextBox.Enabled = false;
            this.selectedItemTextBox.Location = new System.Drawing.Point(-5, 433);
            this.selectedItemTextBox.Name = "selectedItemTextBox";
            this.selectedItemTextBox.Size = new System.Drawing.Size(696, 22);
            this.selectedItemTextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "-";
            // 
            // yearToTextBox
            // 
            this.yearToTextBox.AnimateReadOnly = false;
            this.yearToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearToTextBox.Depth = 0;
            this.yearToTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yearToTextBox.LeadingIcon = null;
            this.yearToTextBox.Location = new System.Drawing.Point(531, 26);
            this.yearToTextBox.MaxLength = 50;
            this.yearToTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.yearToTextBox.Multiline = false;
            this.yearToTextBox.Name = "yearToTextBox";
            this.yearToTextBox.Size = new System.Drawing.Size(111, 50);
            this.yearToTextBox.TabIndex = 12;
            this.yearToTextBox.Text = "";
            this.yearToTextBox.TrailingIcon = null;
            // 
            // yearFromTextBox
            // 
            this.yearFromTextBox.AnimateReadOnly = false;
            this.yearFromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearFromTextBox.Depth = 0;
            this.yearFromTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yearFromTextBox.LeadingIcon = null;
            this.yearFromTextBox.Location = new System.Drawing.Point(341, 22);
            this.yearFromTextBox.MaxLength = 50;
            this.yearFromTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.yearFromTextBox.Multiline = false;
            this.yearFromTextBox.Name = "yearFromTextBox";
            this.yearFromTextBox.Size = new System.Drawing.Size(128, 50);
            this.yearFromTextBox.TabIndex = 11;
            this.yearFromTextBox.Text = "";
            this.yearFromTextBox.TrailingIcon = null;
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = global::Car_Rental_System.Properties.Resources.icons8_search_501;
            this.searchButton.Location = new System.Drawing.Point(693, 30);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(64, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AnimateReadOnly = false;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Depth = 0;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.Hint = "Seacrh for order";
            this.searchTextBox.LeadingIcon = null;
            this.searchTextBox.Location = new System.Drawing.Point(20, 17);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(287, 50);
            this.searchTextBox.TabIndex = 9;
            this.searchTextBox.Text = "";
            this.searchTextBox.TrailingIcon = null;
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Depth = 0;
            this.labelCars.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCars.Location = new System.Drawing.Point(1297, 12);
            this.labelCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(33, 19);
            this.labelCars.TabIndex = 8;
            this.labelCars.Text = "Cars";
            // 
            // orderListView
            // 
            this.orderListView.AutoSizeTable = false;
            this.orderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberColumn,
            this.modelColumn,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.rejectionColumn,
            this.idColumn});
            this.orderListView.Depth = 0;
            this.orderListView.FullRowSelect = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(3, 149);
            this.orderListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.orderListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.orderListView.MouseState = MaterialSkin.MouseState.OUT;
            this.orderListView.Name = "orderListView";
            this.orderListView.OwnerDraw = true;
            this.orderListView.Size = new System.Drawing.Size(902, 268);
            this.orderListView.TabIndex = 7;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.SelectedIndexChanged += new System.EventHandler(this.orderListView_SelectedIndexChanged);
            // 
            // numberColumn
            // 
            this.numberColumn.Text = "#";
            // 
            // modelColumn
            // 
            this.modelColumn.Text = "Model";
            this.modelColumn.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Passport Details";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rental days";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // rejectionColumn
            // 
            this.rejectionColumn.Text = "Rejection Reason";
            this.rejectionColumn.Width = 132;
            // 
            // idColumn
            // 
            this.idColumn.Width = 0;
            // 
            // listBoxAdminCars
            // 
            this.listBoxAdminCars.BackColor = System.Drawing.Color.White;
            this.listBoxAdminCars.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxAdminCars.Depth = 0;
            this.listBoxAdminCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxAdminCars.Location = new System.Drawing.Point(1269, 33);
            this.listBoxAdminCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxAdminCars.Name = "listBoxAdminCars";
            this.listBoxAdminCars.SelectedIndex = -1;
            this.listBoxAdminCars.SelectedItem = null;
            this.listBoxAdminCars.Size = new System.Drawing.Size(549, 287);
            this.listBoxAdminCars.TabIndex = 6;
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.AnimateReadOnly = false;
            this.txtRejectionReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRejectionReason.Depth = 0;
            this.txtRejectionReason.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRejectionReason.Hint = "Rejection reason";
            this.txtRejectionReason.LeadingIcon = null;
            this.txtRejectionReason.Location = new System.Drawing.Point(303, 475);
            this.txtRejectionReason.MaxLength = 50;
            this.txtRejectionReason.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRejectionReason.Multiline = false;
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(287, 50);
            this.txtRejectionReason.TabIndex = 5;
            this.txtRejectionReason.Text = "";
            this.txtRejectionReason.TrailingIcon = null;
            // 
            // btnDamaged
            // 
            this.btnDamaged.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDamaged.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDamaged.Depth = 0;
            this.btnDamaged.HighEmphasis = true;
            this.btnDamaged.Icon = null;
            this.btnDamaged.Location = new System.Drawing.Point(1226, 329);
            this.btnDamaged.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDamaged.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDamaged.Name = "btnDamaged";
            this.btnDamaged.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDamaged.Size = new System.Drawing.Size(158, 36);
            this.btnDamaged.TabIndex = 4;
            this.btnDamaged.Text = "Mark as Damaged";
            this.btnDamaged.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDamaged.UseAccentColor = false;
            this.btnDamaged.UseVisualStyleBackColor = true;
            this.btnDamaged.Click += new System.EventHandler(this.btnDamaged_Click);
            // 
            // btnReject
            // 
            this.btnReject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReject.Depth = 0;
            this.btnReject.HighEmphasis = true;
            this.btnReject.Icon = null;
            this.btnReject.Location = new System.Drawing.Point(617, 475);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReject.Name = "btnReject";
            this.btnReject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReject.Size = new System.Drawing.Size(74, 36);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReject.UseAccentColor = false;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApprove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApprove.Depth = 0;
            this.btnApprove.HighEmphasis = true;
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(172, 475);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApprove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApprove.Size = new System.Drawing.Size(87, 36);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApprove.UseAccentColor = false;
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackAdmin.Depth = 0;
            this.btnBackAdmin.HighEmphasis = true;
            this.btnBackAdmin.Icon = null;
            this.btnBackAdmin.Location = new System.Drawing.Point(20, 475);
            this.btnBackAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackAdmin.Size = new System.Drawing.Size(64, 36);
            this.btnBackAdmin.TabIndex = 1;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackAdmin.UseAccentColor = false;
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(545, 191);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Choose your role:";
            // 
            // sortBtn
            // 
            this.sortBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sortBtn.Depth = 0;
            this.sortBtn.HighEmphasis = true;
            this.sortBtn.Icon = null;
            this.sortBtn.Location = new System.Drawing.Point(786, 31);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sortBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sortBtn.Size = new System.Drawing.Size(64, 36);
            this.sortBtn.TabIndex = 20;
            this.sortBtn.Text = "sort";
            this.sortBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sortBtn.UseAccentColor = false;
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.prevBtn.Depth = 0;
            this.prevBtn.HighEmphasis = true;
            this.prevBtn.Icon = null;
            this.prevBtn.Location = new System.Drawing.Point(57, 101);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.prevBtn.Size = new System.Drawing.Size(64, 36);
            this.prevBtn.TabIndex = 21;
            this.prevBtn.Text = "prev";
            this.prevBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.prevBtn.UseAccentColor = false;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextBtn.Depth = 0;
            this.nextBtn.HighEmphasis = true;
            this.nextBtn.Icon = null;
            this.nextBtn.Location = new System.Drawing.Point(183, 101);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextBtn.Size = new System.Drawing.Size(64, 36);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "next";
            this.nextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextBtn.UseAccentColor = false;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageNumTextBox
            // 
            this.pageNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageNumTextBox.Enabled = false;
            this.pageNumTextBox.Location = new System.Drawing.Point(142, 109);
            this.pageNumTextBox.Name = "pageNumTextBox";
            this.pageNumTextBox.ReadOnly = true;
            this.pageNumTextBox.Size = new System.Drawing.Size(24, 22);
            this.pageNumTextBox.TabIndex = 23;
            this.pageNumTextBox.Text = "1";
            // 
            // countTextBox
            // 
            this.countTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countTextBox.Enabled = false;
            this.countTextBox.Location = new System.Drawing.Point(709, 450);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(100, 22);
            this.countTextBox.TabIndex = 24;
            // 
            // maxDaysTextBox
            // 
            this.maxDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDaysTextBox.Enabled = false;
            this.maxDaysTextBox.Location = new System.Drawing.Point(829, 450);
            this.maxDaysTextBox.Name = "maxDaysTextBox";
            this.maxDaysTextBox.ReadOnly = true;
            this.maxDaysTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxDaysTextBox.TabIndex = 25;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(728, 428);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Count:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(841, 428);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(74, 19);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "Max days:";
            // 
            // loadSourceBtn
            // 
            this.loadSourceBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadSourceBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadSourceBtn.Depth = 0;
            this.loadSourceBtn.HighEmphasis = true;
            this.loadSourceBtn.Icon = null;
            this.loadSourceBtn.Location = new System.Drawing.Point(693, 101);
            this.loadSourceBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadSourceBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadSourceBtn.Name = "loadSourceBtn";
            this.loadSourceBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadSourceBtn.Size = new System.Drawing.Size(190, 36);
            this.loadSourceBtn.TabIndex = 28;
            this.loadSourceBtn.Text = "Load another source";
            this.loadSourceBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadSourceBtn.UseAccentColor = false;
            this.loadSourceBtn.UseVisualStyleBackColor = true;
            this.loadSourceBtn.Click += new System.EventHandler(this.loadSourceBtn_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 605);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.materialLabel3);
            this.Name = "MainForm";
            this.Text = "Car Rental System";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClient;
        private MaterialSkin.Controls.MaterialButton btnAdmin;
        private System.Windows.Forms.Panel panelClient;
        private MaterialSkin.Controls.MaterialListBox listBoxCars;
        private MaterialSkin.Controls.MaterialButton btnBackClient;
        private MaterialSkin.Controls.MaterialButton btnRent;
        private MaterialSkin.Controls.MaterialTextBox txtRentalDays;
        private MaterialSkin.Controls.MaterialTextBox txtPassportDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel carslabel;
        private MaterialSkin.Controls.MaterialButton btnPayment;
        private MaterialSkin.Controls.MaterialListBox listBoxApprovedOrders;
        private System.Windows.Forms.Panel panelAdmin;
        private MaterialSkin.Controls.MaterialButton btnDamaged;
        private MaterialSkin.Controls.MaterialButton btnReject;
        private MaterialSkin.Controls.MaterialButton btnApprove;
        private MaterialSkin.Controls.MaterialButton btnBackAdmin;
        private MaterialSkin.Controls.MaterialTextBox txtRejectionReason;
        private MaterialSkin.Controls.MaterialListBox listBoxAdminCars;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialListView orderListView;
        private MaterialSkin.Controls.MaterialLabel labelCars;
        private System.Windows.Forms.ColumnHeader numberColumn;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private System.Windows.Forms.ColumnHeader modelColumn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader rejectionColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox yearToTextBox;
        private MaterialSkin.Controls.MaterialTextBox yearFromTextBox;
        private System.Windows.Forms.TextBox selectedItemTextBox;
        private System.Windows.Forms.ColumnHeader idColumn;
        private MaterialSkin.Controls.MaterialButton sortBtn;
        private TextBox pageNumTextBox;
        private MaterialSkin.Controls.MaterialButton nextBtn;
        private MaterialSkin.Controls.MaterialButton prevBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TextBox maxDaysTextBox;
        private TextBox countTextBox;
        private MaterialSkin.Controls.MaterialButton loadSourceBtn;
        private OpenFileDialog fileDialog;
    }
}

