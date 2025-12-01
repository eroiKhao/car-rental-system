namespace CarRentalSystem.Views
{
    partial class PaymentForm
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
            payBtn = new MaterialSkin.Controls.MaterialButton();
            moneyTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ordersListView = new MaterialSkin.Controls.MaterialListView();
            id = new ColumnHeader();
            clientName = new ColumnHeader();
            carModel = new ColumnHeader();
            rentalDays = new ColumnHeader();
            totalPrice = new ColumnHeader();
            clientBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // payBtn
            // 
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            payBtn.Depth = 0;
            payBtn.HighEmphasis = true;
            payBtn.Icon = null;
            payBtn.Location = new Point(294, 369);
            payBtn.Margin = new Padding(4, 6, 4, 6);
            payBtn.MouseState = MaterialSkin.MouseState.HOVER;
            payBtn.Name = "payBtn";
            payBtn.NoAccentTextColor = Color.Empty;
            payBtn.Size = new Size(121, 36);
            payBtn.TabIndex = 1;
            payBtn.Text = "Pay for rent";
            payBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            payBtn.UseAccentColor = false;
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // moneyTextBox
            // 
            moneyTextBox.AnimateReadOnly = false;
            moneyTextBox.BorderStyle = BorderStyle.None;
            moneyTextBox.Depth = 0;
            moneyTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            moneyTextBox.Hint = "Total price";
            moneyTextBox.LeadingIcon = null;
            moneyTextBox.Location = new Point(107, 355);
            moneyTextBox.MaxLength = 50;
            moneyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            moneyTextBox.Multiline = false;
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(154, 50);
            moneyTextBox.TabIndex = 2;
            moneyTextBox.Text = "";
            moneyTextBox.TrailingIcon = null;
            // 
            // ordersListView
            // 
            ordersListView.AutoSizeTable = false;
            ordersListView.BackColor = Color.FromArgb(255, 255, 255);
            ordersListView.BorderStyle = BorderStyle.None;
            ordersListView.Columns.AddRange(new ColumnHeader[] { id, clientName, carModel, rentalDays, totalPrice });
            ordersListView.Depth = 0;
            ordersListView.FullRowSelect = true;
            ordersListView.Location = new Point(107, 79);
            ordersListView.MinimumSize = new Size(200, 100);
            ordersListView.MouseLocation = new Point(-1, -1);
            ordersListView.MouseState = MaterialSkin.MouseState.OUT;
            ordersListView.Name = "ordersListView";
            ordersListView.OwnerDraw = true;
            ordersListView.Size = new Size(589, 267);
            ordersListView.TabIndex = 3;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "#";
            id.Width = 40;
            // 
            // clientName
            // 
            clientName.Text = "Client Name";
            clientName.Width = 120;
            // 
            // carModel
            // 
            carModel.Text = "Car Model";
            carModel.Width = 150;
            // 
            // rentalDays
            // 
            rentalDays.Text = "Rental Days";
            rentalDays.Width = 120;
            // 
            // totalPrice
            // 
            totalPrice.Text = "totalPrice";
            totalPrice.Width = 100;
            // 
            // clientBtn
            // 
            clientBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clientBtn.Depth = 0;
            clientBtn.HighEmphasis = true;
            clientBtn.Icon = Main.Properties.Resources.home;
            clientBtn.Location = new Point(7, 79);
            clientBtn.Margin = new Padding(4, 6, 4, 6);
            clientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clientBtn.Name = "clientBtn";
            clientBtn.NoAccentTextColor = Color.Empty;
            clientBtn.Size = new Size(64, 36);
            clientBtn.TabIndex = 4;
            clientBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clientBtn.UseAccentColor = false;
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 465);
            Controls.Add(clientBtn);
            Controls.Add(ordersListView);
            Controls.Add(moneyTextBox);
            Controls.Add(payBtn);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            FormClosed += PaymentForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton payBtn;
        private MaterialSkin.Controls.MaterialTextBox moneyTextBox;
        private MaterialSkin.Controls.MaterialListView ordersListView;
        private ColumnHeader id;
        private ColumnHeader clientName;
        private ColumnHeader carModel;
        private ColumnHeader rentalDays;
        private ColumnHeader totalPrice;
        private MaterialSkin.Controls.MaterialButton clientBtn;
    }
}