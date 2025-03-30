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
            this.listBoxAdminCars = new MaterialSkin.Controls.MaterialListBox();
            this.txtRejectionReason = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDamaged = new MaterialSkin.Controls.MaterialButton();
            this.btnReject = new MaterialSkin.Controls.MaterialButton();
            this.btnApprove = new MaterialSkin.Controls.MaterialButton();
            this.btnBackAdmin = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.orderListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCars = new MaterialSkin.Controls.MaterialLabel();
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
            this.panelClient.Size = new System.Drawing.Size(1333, 495);
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
            this.panelAdmin.Size = new System.Drawing.Size(1333, 495);
            this.panelAdmin.TabIndex = 9;
            this.panelAdmin.Visible = false;
            // 
            // listBoxAdminCars
            // 
            this.listBoxAdminCars.BackColor = System.Drawing.Color.White;
            this.listBoxAdminCars.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxAdminCars.Depth = 0;
            this.listBoxAdminCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxAdminCars.Location = new System.Drawing.Point(770, 36);
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
            this.txtRejectionReason.Location = new System.Drawing.Point(311, 371);
            this.txtRejectionReason.MaxLength = 50;
            this.txtRejectionReason.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRejectionReason.Multiline = false;
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(287, 50);
            this.txtRejectionReason.TabIndex = 5;
            this.txtRejectionReason.Text = "";
            this.txtRejectionReason.TrailingIcon = null;
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackAdmin.Depth = 0;
            this.btnBackAdmin.HighEmphasis = true;
            this.btnBackAdmin.Icon = null;
            this.btnBackAdmin.Location = new System.Drawing.Point(37, 411);
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
            // orderListView
            // 
            this.orderListView.AutoSizeTable = false;
            this.orderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.orderListView.Depth = 0;
            this.orderListView.FullRowSelect = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(37, 14);
            this.orderListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.orderListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.orderListView.MouseState = MaterialSkin.MouseState.OUT;
            this.orderListView.Name = "orderListView";
            this.orderListView.OwnerDraw = true;
            this.orderListView.Size = new System.Drawing.Size(712, 351);
            this.orderListView.TabIndex = 7;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "]";
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Car";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Days";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Passport details";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rejection reason";
            this.columnHeader6.Width = 154;
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Depth = 0;
            this.labelCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCars.Location = new System.Drawing.Point(1048, 14);
            this.labelCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(33, 19);
            this.labelCars.TabIndex = 8;
            this.labelCars.Text = "Cars";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 562);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel labelCars;
    }
}

