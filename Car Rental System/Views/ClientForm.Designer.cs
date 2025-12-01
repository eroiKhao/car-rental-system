namespace CarRentalSystem
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passportTextBox = new MaterialSkin.Controls.MaterialTextBox();
            rentalDaysTextBox = new MaterialSkin.Controls.MaterialTextBox();
            adminBtn = new MaterialSkin.Controls.MaterialButton();
            rentBtn = new MaterialSkin.Controls.MaterialButton();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            carsListView = new MaterialSkin.Controls.MaterialListView();
            id = new ColumnHeader();
            model = new ColumnHeader();
            status = new ColumnHeader();
            priceperday = new ColumnHeader();
            selectedTextBox = new MaterialSkin.Controls.MaterialTextBox();
            nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            emailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            payBtn = new MaterialSkin.Controls.MaterialButton();
            searchCarBtn = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            cancelSearchBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // passportTextBox
            // 
            passportTextBox.AnimateReadOnly = false;
            passportTextBox.BorderStyle = BorderStyle.None;
            passportTextBox.Depth = 0;
            passportTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passportTextBox.Hint = "Passport details";
            passportTextBox.LeadingIcon = null;
            passportTextBox.Location = new Point(6, 250);
            passportTextBox.MaxLength = 50;
            passportTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passportTextBox.Multiline = false;
            passportTextBox.Name = "passportTextBox";
            passportTextBox.Size = new Size(244, 50);
            passportTextBox.TabIndex = 1;
            passportTextBox.Text = "";
            passportTextBox.TrailingIcon = null;
            // 
            // rentalDaysTextBox
            // 
            rentalDaysTextBox.AnimateReadOnly = false;
            rentalDaysTextBox.BorderStyle = BorderStyle.None;
            rentalDaysTextBox.Depth = 0;
            rentalDaysTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentalDaysTextBox.Hint = "Rental days";
            rentalDaysTextBox.LeadingIcon = null;
            rentalDaysTextBox.Location = new Point(6, 194);
            rentalDaysTextBox.MaxLength = 50;
            rentalDaysTextBox.MouseState = MaterialSkin.MouseState.OUT;
            rentalDaysTextBox.Multiline = false;
            rentalDaysTextBox.Name = "rentalDaysTextBox";
            rentalDaysTextBox.Size = new Size(244, 50);
            rentalDaysTextBox.TabIndex = 2;
            rentalDaysTextBox.Text = "";
            rentalDaysTextBox.TrailingIcon = null;
            // 
            // adminBtn
            // 
            adminBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            adminBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            adminBtn.Depth = 0;
            adminBtn.HighEmphasis = true;
            adminBtn.Icon = Main.Properties.Resources.admin;
            adminBtn.Location = new Point(736, 366);
            adminBtn.Margin = new Padding(4, 6, 4, 6);
            adminBtn.MouseState = MaterialSkin.MouseState.HOVER;
            adminBtn.Name = "adminBtn";
            adminBtn.NoAccentTextColor = Color.Empty;
            adminBtn.Size = new Size(146, 36);
            adminBtn.TabIndex = 3;
            adminBtn.Text = "Admin panel";
            adminBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            adminBtn.UseAccentColor = false;
            adminBtn.UseVisualStyleBackColor = true;
            adminBtn.Click += adminBtn_Click;
            // 
            // rentBtn
            // 
            rentBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rentBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            rentBtn.Depth = 0;
            rentBtn.HighEmphasis = true;
            rentBtn.Icon = null;
            rentBtn.Location = new Point(7, 309);
            rentBtn.Margin = new Padding(4, 6, 4, 6);
            rentBtn.MouseState = MaterialSkin.MouseState.HOVER;
            rentBtn.Name = "rentBtn";
            rentBtn.NoAccentTextColor = Color.Empty;
            rentBtn.Size = new Size(64, 36);
            rentBtn.TabIndex = 4;
            rentBtn.Text = "Rent";
            rentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            rentBtn.UseAccentColor = false;
            rentBtn.UseVisualStyleBackColor = true;
            rentBtn.Click += rentBtn_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // carsListView
            // 
            carsListView.AutoSizeTable = false;
            carsListView.BackColor = Color.FromArgb(255, 255, 255);
            carsListView.BorderStyle = BorderStyle.None;
            carsListView.Columns.AddRange(new ColumnHeader[] { id, model, status, priceperday });
            carsListView.Depth = 0;
            carsListView.FullRowSelect = true;
            carsListView.Location = new Point(271, 82);
            carsListView.MinimumSize = new Size(200, 100);
            carsListView.MouseLocation = new Point(-1, -1);
            carsListView.MouseState = MaterialSkin.MouseState.OUT;
            carsListView.Name = "carsListView";
            carsListView.OwnerDraw = true;
            carsListView.Size = new Size(446, 236);
            carsListView.TabIndex = 5;
            carsListView.UseCompatibleStateImageBehavior = false;
            carsListView.View = View.Details;
            carsListView.SelectedIndexChanged += carsListView_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "#";
            id.Width = 40;
            // 
            // model
            // 
            model.Text = "Model";
            model.Width = 150;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 100;
            // 
            // priceperday
            // 
            priceperday.Text = "PricePerDay";
            priceperday.Width = 150;
            // 
            // selectedTextBox
            // 
            selectedTextBox.AnimateReadOnly = false;
            selectedTextBox.BorderStyle = BorderStyle.None;
            selectedTextBox.Depth = 0;
            selectedTextBox.Enabled = false;
            selectedTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            selectedTextBox.LeadingIcon = null;
            selectedTextBox.Location = new Point(271, 324);
            selectedTextBox.MaxLength = 50;
            selectedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            selectedTextBox.Multiline = false;
            selectedTextBox.Name = "selectedTextBox";
            selectedTextBox.ReadOnly = true;
            selectedTextBox.Size = new Size(446, 50);
            selectedTextBox.TabIndex = 6;
            selectedTextBox.Text = "";
            selectedTextBox.TrailingIcon = null;
            // 
            // nameTextBox
            // 
            nameTextBox.AnimateReadOnly = false;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Depth = 0;
            nameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTextBox.Hint = "Name";
            nameTextBox.LeadingIcon = null;
            nameTextBox.Location = new Point(6, 82);
            nameTextBox.MaxLength = 50;
            nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nameTextBox.Multiline = false;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(244, 50);
            nameTextBox.TabIndex = 7;
            nameTextBox.Text = "";
            nameTextBox.TrailingIcon = null;
            // 
            // emailTextBox
            // 
            emailTextBox.AnimateReadOnly = false;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Depth = 0;
            emailTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextBox.Hint = "Email";
            emailTextBox.LeadingIcon = null;
            emailTextBox.Location = new Point(6, 138);
            emailTextBox.MaxLength = 50;
            emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(244, 50);
            emailTextBox.TabIndex = 8;
            emailTextBox.Text = "";
            emailTextBox.TrailingIcon = null;
            // 
            // payBtn
            // 
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            payBtn.Depth = 0;
            payBtn.HighEmphasis = true;
            payBtn.Icon = null;
            payBtn.Location = new Point(186, 309);
            payBtn.Margin = new Padding(4, 6, 4, 6);
            payBtn.MouseState = MaterialSkin.MouseState.HOVER;
            payBtn.Name = "payBtn";
            payBtn.NoAccentTextColor = Color.Empty;
            payBtn.Size = new Size(64, 36);
            payBtn.TabIndex = 9;
            payBtn.Text = "Pay";
            payBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            payBtn.UseAccentColor = false;
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // searchCarBtn
            // 
            searchCarBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchCarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchCarBtn.Depth = 0;
            searchCarBtn.HighEmphasis = true;
            searchCarBtn.Icon = null;
            searchCarBtn.Location = new Point(768, 159);
            searchCarBtn.Margin = new Padding(4, 6, 4, 6);
            searchCarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            searchCarBtn.Name = "searchCarBtn";
            searchCarBtn.NoAccentTextColor = Color.Empty;
            searchCarBtn.Size = new Size(78, 36);
            searchCarBtn.TabIndex = 10;
            searchCarBtn.Text = "Search";
            searchCarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchCarBtn.UseAccentColor = false;
            searchCarBtn.UseVisualStyleBackColor = true;
            searchCarBtn.Click += searchCarBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.Hint = "Search for car";
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(736, 100);
            searchTextBox.MaxLength = 50;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(146, 50);
            searchTextBox.TabIndex = 11;
            searchTextBox.Text = "";
            searchTextBox.TrailingIcon = null;
            // 
            // cancelSearchBtn
            // 
            cancelSearchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelSearchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelSearchBtn.Depth = 0;
            cancelSearchBtn.HighEmphasis = true;
            cancelSearchBtn.Icon = null;
            cancelSearchBtn.Location = new Point(768, 207);
            cancelSearchBtn.Margin = new Padding(4, 6, 4, 6);
            cancelSearchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            cancelSearchBtn.Name = "cancelSearchBtn";
            cancelSearchBtn.NoAccentTextColor = Color.Empty;
            cancelSearchBtn.Size = new Size(77, 36);
            cancelSearchBtn.TabIndex = 12;
            cancelSearchBtn.Text = "Cancel";
            cancelSearchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelSearchBtn.UseAccentColor = false;
            cancelSearchBtn.UseVisualStyleBackColor = true;
            cancelSearchBtn.Click += cancelSearchBtn_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 419);
            Controls.Add(cancelSearchBtn);
            Controls.Add(searchTextBox);
            Controls.Add(searchCarBtn);
            Controls.Add(payBtn);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(selectedTextBox);
            Controls.Add(carsListView);
            Controls.Add(rentBtn);
            Controls.Add(adminBtn);
            Controls.Add(rentalDaysTextBox);
            Controls.Add(passportTextBox);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox passportTextBox;
        private MaterialSkin.Controls.MaterialTextBox rentalDaysTextBox;
        private MaterialSkin.Controls.MaterialButton adminBtn;
        private MaterialSkin.Controls.MaterialButton rentBtn;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private MaterialSkin.Controls.MaterialListView carsListView;
        private ColumnHeader id;
        private ColumnHeader model;
        private ColumnHeader status;
        private ColumnHeader priceperday;
        private MaterialSkin.Controls.MaterialTextBox selectedTextBox;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialTextBox emailTextBox;
        private MaterialSkin.Controls.MaterialButton payBtn;
        private MaterialSkin.Controls.MaterialButton searchCarBtn;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private MaterialSkin.Controls.MaterialButton cancelSearchBtn;
    }
}
