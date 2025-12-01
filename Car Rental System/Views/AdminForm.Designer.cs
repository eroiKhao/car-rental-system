namespace CarRentalSystem.Views
{
    partial class AdminForm
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
            clientBtn = new MaterialSkin.Controls.MaterialButton();
            ordersListView = new MaterialSkin.Controls.MaterialListView();
            id = new ColumnHeader();
            clientName = new ColumnHeader();
            rentedCar = new ColumnHeader();
            rentalDays = new ColumnHeader();
            totalPrice = new ColumnHeader();
            status = new ColumnHeader();
            rejectionReason = new ColumnHeader();
            createdAt = new ColumnHeader();
            searchBtn = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            prevBtn = new MaterialSkin.Controls.MaterialButton();
            nextBtn = new MaterialSkin.Controls.MaterialButton();
            modifyBtn = new MaterialSkin.Controls.MaterialButton();
            deleteOrderBtn = new MaterialSkin.Controls.MaterialButton();
            approveOrderBtn = new MaterialSkin.Controls.MaterialButton();
            rejectOrderBtn = new MaterialSkin.Controls.MaterialButton();
            reasonTextBox = new MaterialSkin.Controls.MaterialTextBox();
            currentPageLbl = new MaterialSkin.Controls.MaterialLabel();
            totalOrdersLbl = new MaterialSkin.Controls.MaterialLabel();
            clearBtn = new MaterialSkin.Controls.MaterialButton();
            analyzeBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // clientBtn
            // 
            clientBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clientBtn.Depth = 0;
            clientBtn.HighEmphasis = true;
            clientBtn.Icon = Main.Properties.Resources.home;
            clientBtn.Location = new Point(20, 72);
            clientBtn.Margin = new Padding(4, 6, 4, 6);
            clientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clientBtn.Name = "clientBtn";
            clientBtn.NoAccentTextColor = Color.Empty;
            clientBtn.Size = new Size(64, 36);
            clientBtn.TabIndex = 0;
            clientBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clientBtn.UseAccentColor = false;
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // ordersListView
            // 
            ordersListView.AutoSizeTable = false;
            ordersListView.BackColor = Color.FromArgb(255, 255, 255);
            ordersListView.BorderStyle = BorderStyle.None;
            ordersListView.Columns.AddRange(new ColumnHeader[] { id, clientName, rentedCar, rentalDays, totalPrice, status, rejectionReason, createdAt });
            ordersListView.Depth = 0;
            ordersListView.FullRowSelect = true;
            ordersListView.Location = new Point(20, 138);
            ordersListView.MinimumSize = new Size(200, 100);
            ordersListView.MouseLocation = new Point(-1, -1);
            ordersListView.MouseState = MaterialSkin.MouseState.OUT;
            ordersListView.Name = "ordersListView";
            ordersListView.OwnerDraw = true;
            ordersListView.Size = new Size(1011, 250);
            ordersListView.TabIndex = 1;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "#";
            // 
            // clientName
            // 
            clientName.Text = "Client Name";
            clientName.Width = 120;
            // 
            // rentedCar
            // 
            rentedCar.Text = "Car Model";
            rentedCar.Width = 150;
            // 
            // rentalDays
            // 
            rentalDays.Text = "Rental Days";
            rentalDays.Width = 120;
            // 
            // totalPrice
            // 
            totalPrice.Text = "Total Price";
            totalPrice.Width = 120;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 100;
            // 
            // rejectionReason
            // 
            rejectionReason.Text = "Rejection Reason";
            rejectionReason.Width = 150;
            // 
            // createdAt
            // 
            createdAt.Text = "Created At";
            createdAt.Width = 150;
            // 
            // searchBtn
            // 
            searchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchBtn.Depth = 0;
            searchBtn.HighEmphasis = true;
            searchBtn.Icon = Main.Properties.Resources.search;
            searchBtn.Location = new Point(321, 93);
            searchBtn.Margin = new Padding(4, 6, 4, 6);
            searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            searchBtn.Name = "searchBtn";
            searchBtn.NoAccentTextColor = Color.Empty;
            searchBtn.Size = new Size(106, 36);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchBtn.UseAccentColor = false;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.Hint = "Search by model/Client name";
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(167, 81);
            searchTextBox.MaxLength = 50;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(147, 50);
            searchTextBox.TabIndex = 4;
            searchTextBox.Text = "";
            searchTextBox.TrailingIcon = null;
            // 
            // prevBtn
            // 
            prevBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prevBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prevBtn.Depth = 0;
            prevBtn.HighEmphasis = true;
            prevBtn.Icon = Main.Properties.Resources.back;
            prevBtn.Location = new Point(20, 400);
            prevBtn.Margin = new Padding(4, 6, 4, 6);
            prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            prevBtn.Name = "prevBtn";
            prevBtn.NoAccentTextColor = Color.Empty;
            prevBtn.Size = new Size(86, 36);
            prevBtn.TabIndex = 5;
            prevBtn.Text = "prev";
            prevBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevBtn.UseAccentColor = false;
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextBtn.Depth = 0;
            nextBtn.HighEmphasis = true;
            nextBtn.Icon = Main.Properties.Resources.forward;
            nextBtn.Location = new Point(941, 400);
            nextBtn.Margin = new Padding(4, 6, 4, 6);
            nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            nextBtn.Name = "nextBtn";
            nextBtn.NoAccentTextColor = Color.Empty;
            nextBtn.Size = new Size(86, 36);
            nextBtn.TabIndex = 6;
            nextBtn.Text = "next";
            nextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextBtn.UseAccentColor = false;
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modifyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            modifyBtn.Depth = 0;
            modifyBtn.HighEmphasis = true;
            modifyBtn.Icon = Main.Properties.Resources.car;
            modifyBtn.Location = new Point(900, 72);
            modifyBtn.Margin = new Padding(4, 6, 4, 6);
            modifyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            modifyBtn.Name = "modifyBtn";
            modifyBtn.NoAccentTextColor = Color.Empty;
            modifyBtn.Size = new Size(144, 36);
            modifyBtn.TabIndex = 7;
            modifyBtn.Text = "modify cars";
            modifyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            modifyBtn.UseAccentColor = false;
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // deleteOrderBtn
            // 
            deleteOrderBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteOrderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteOrderBtn.Depth = 0;
            deleteOrderBtn.HighEmphasis = true;
            deleteOrderBtn.Icon = null;
            deleteOrderBtn.Location = new Point(130, 450);
            deleteOrderBtn.Margin = new Padding(4, 6, 4, 6);
            deleteOrderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteOrderBtn.Name = "deleteOrderBtn";
            deleteOrderBtn.NoAccentTextColor = Color.Empty;
            deleteOrderBtn.Size = new Size(73, 36);
            deleteOrderBtn.TabIndex = 8;
            deleteOrderBtn.Text = "Delete";
            deleteOrderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteOrderBtn.UseAccentColor = false;
            deleteOrderBtn.UseVisualStyleBackColor = true;
            deleteOrderBtn.Click += deleteOrderBtn_Click;
            // 
            // approveOrderBtn
            // 
            approveOrderBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            approveOrderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            approveOrderBtn.Depth = 0;
            approveOrderBtn.HighEmphasis = true;
            approveOrderBtn.Icon = null;
            approveOrderBtn.Location = new Point(20, 450);
            approveOrderBtn.Margin = new Padding(4, 6, 4, 6);
            approveOrderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            approveOrderBtn.Name = "approveOrderBtn";
            approveOrderBtn.NoAccentTextColor = Color.Empty;
            approveOrderBtn.Size = new Size(87, 36);
            approveOrderBtn.TabIndex = 9;
            approveOrderBtn.Text = "Approve";
            approveOrderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            approveOrderBtn.UseAccentColor = false;
            approveOrderBtn.UseVisualStyleBackColor = true;
            approveOrderBtn.Click += approveOrderBtn_Click;
            // 
            // rejectOrderBtn
            // 
            rejectOrderBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rejectOrderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            rejectOrderBtn.Depth = 0;
            rejectOrderBtn.HighEmphasis = true;
            rejectOrderBtn.Icon = null;
            rejectOrderBtn.Location = new Point(843, 400);
            rejectOrderBtn.Margin = new Padding(4, 6, 4, 6);
            rejectOrderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            rejectOrderBtn.Name = "rejectOrderBtn";
            rejectOrderBtn.NoAccentTextColor = Color.Empty;
            rejectOrderBtn.Size = new Size(74, 36);
            rejectOrderBtn.TabIndex = 10;
            rejectOrderBtn.Text = "Reject";
            rejectOrderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            rejectOrderBtn.UseAccentColor = false;
            rejectOrderBtn.UseVisualStyleBackColor = true;
            rejectOrderBtn.Click += rejectOrderBtn_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.AnimateReadOnly = false;
            reasonTextBox.BorderStyle = BorderStyle.None;
            reasonTextBox.Depth = 0;
            reasonTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            reasonTextBox.Hint = "Reason for rejection";
            reasonTextBox.LeadingIcon = null;
            reasonTextBox.Location = new Point(636, 398);
            reasonTextBox.MaxLength = 50;
            reasonTextBox.MouseState = MaterialSkin.MouseState.OUT;
            reasonTextBox.Multiline = false;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(200, 50);
            reasonTextBox.TabIndex = 11;
            reasonTextBox.Text = "";
            reasonTextBox.TrailingIcon = null;
            // 
            // currentPageLbl
            // 
            currentPageLbl.AutoSize = true;
            currentPageLbl.Depth = 0;
            currentPageLbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            currentPageLbl.Location = new Point(400, 400);
            currentPageLbl.MouseState = MaterialSkin.MouseState.HOVER;
            currentPageLbl.Name = "currentPageLbl";
            currentPageLbl.Size = new Size(37, 19);
            currentPageLbl.TabIndex = 12;
            currentPageLbl.Text = "Page";
            // 
            // totalOrdersLbl
            // 
            totalOrdersLbl.AutoSize = true;
            totalOrdersLbl.Depth = 0;
            totalOrdersLbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalOrdersLbl.Location = new Point(500, 400);
            totalOrdersLbl.MouseState = MaterialSkin.MouseState.HOVER;
            totalOrdersLbl.Name = "totalOrdersLbl";
            totalOrdersLbl.Size = new Size(86, 19);
            totalOrdersLbl.TabIndex = 13;
            totalOrdersLbl.Text = "Total orders";
            // 
            // clearBtn
            // 
            clearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clearBtn.Depth = 0;
            clearBtn.HighEmphasis = true;
            clearBtn.Icon = null;
            clearBtn.Location = new Point(435, 95);
            clearBtn.Margin = new Padding(4, 6, 4, 6);
            clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clearBtn.Name = "clearBtn";
            clearBtn.NoAccentTextColor = Color.Empty;
            clearBtn.Size = new Size(66, 36);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Clear";
            clearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clearBtn.UseAccentColor = false;
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // analyzeBtn
            // 
            analyzeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            analyzeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            analyzeBtn.Depth = 0;
            analyzeBtn.HighEmphasis = true;
            analyzeBtn.Icon = null;
            analyzeBtn.Location = new Point(240, 450);
            analyzeBtn.Margin = new Padding(4, 6, 4, 6);
            analyzeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            analyzeBtn.Name = "analyzeBtn";
            analyzeBtn.NoAccentTextColor = Color.Empty;
            analyzeBtn.Size = new Size(86, 36);
            analyzeBtn.TabIndex = 15;
            analyzeBtn.Text = "Analyze";
            analyzeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            analyzeBtn.UseAccentColor = false;
            analyzeBtn.UseVisualStyleBackColor = true;
            analyzeBtn.Click += analyzeBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 497);
            Controls.Add(analyzeBtn);
            Controls.Add(clearBtn);
            Controls.Add(totalOrdersLbl);
            Controls.Add(currentPageLbl);
            Controls.Add(reasonTextBox);
            Controls.Add(rejectOrderBtn);
            Controls.Add(approveOrderBtn);
            Controls.Add(deleteOrderBtn);
            Controls.Add(modifyBtn);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(searchTextBox);
            Controls.Add(searchBtn);
            Controls.Add(ordersListView);
            Controls.Add(clientBtn);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            FormClosed += AdminForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton clientBtn;
        private MaterialSkin.Controls.MaterialListView ordersListView;
        private MaterialSkin.Controls.MaterialButton searchBtn;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private MaterialSkin.Controls.MaterialButton prevBtn;
        private MaterialSkin.Controls.MaterialButton nextBtn;
        private MaterialSkin.Controls.MaterialButton modifyBtn;
        private ColumnHeader id;
        private ColumnHeader clientName;
        private ColumnHeader rentedCar;
        private ColumnHeader rentalDays;
        private ColumnHeader totalPrice;
        private ColumnHeader status;
        private ColumnHeader createdAt;
        private MaterialSkin.Controls.MaterialButton deleteOrderBtn;
        private MaterialSkin.Controls.MaterialButton approveOrderBtn;
        private MaterialSkin.Controls.MaterialButton rejectOrderBtn;
        private MaterialSkin.Controls.MaterialTextBox reasonTextBox;
        private ColumnHeader rejectionReason;
        private MaterialSkin.Controls.MaterialLabel currentPageLbl;
        private MaterialSkin.Controls.MaterialLabel totalOrdersLbl;
        private MaterialSkin.Controls.MaterialButton clearBtn;
        private MaterialSkin.Controls.MaterialButton analyzeBtn;
    }
}