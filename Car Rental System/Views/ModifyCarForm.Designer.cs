namespace Car_Rental_System.Views
{
    partial class ModifyCarForm
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
            guid = new ColumnHeader();
            addBtn = new MaterialSkin.Controls.MaterialButton();
            modelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            priceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            carsListView = new MaterialSkin.Controls.MaterialListView();
            id = new ColumnHeader();
            model = new ColumnHeader();
            price = new ColumnHeader();
            status = new ColumnHeader();
            date = new ColumnHeader();
            addLabel = new MaterialSkin.Controls.MaterialLabel();
            markAsDamagedBtn = new MaterialSkin.Controls.MaterialButton();
            deleteBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // guid
            // 
            guid.Text = "";
            guid.Width = 0;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(91, 277);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(64, 36);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // modelTextBox
            // 
            modelTextBox.AnimateReadOnly = false;
            modelTextBox.BorderStyle = BorderStyle.None;
            modelTextBox.Depth = 0;
            modelTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            modelTextBox.Hint = "Enter a model...";
            modelTextBox.LeadingIcon = null;
            modelTextBox.Location = new Point(64, 151);
            modelTextBox.MaxLength = 50;
            modelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            modelTextBox.Multiline = false;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(125, 50);
            modelTextBox.TabIndex = 2;
            modelTextBox.Text = "";
            modelTextBox.TrailingIcon = null;
            // 
            // priceTextBox
            // 
            priceTextBox.AnimateReadOnly = false;
            priceTextBox.BorderStyle = BorderStyle.None;
            priceTextBox.Depth = 0;
            priceTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceTextBox.Hint = "Enter a price...";
            priceTextBox.LeadingIcon = null;
            priceTextBox.Location = new Point(64, 218);
            priceTextBox.MaxLength = 50;
            priceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            priceTextBox.Multiline = false;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(125, 50);
            priceTextBox.TabIndex = 3;
            priceTextBox.Text = "";
            priceTextBox.TrailingIcon = null;
            // 
            // carsListView
            // 
            carsListView.AutoSizeTable = false;
            carsListView.BackColor = Color.FromArgb(255, 255, 255);
            carsListView.BorderStyle = BorderStyle.None;
            carsListView.Columns.AddRange(new ColumnHeader[] { id, model, price, status, date, guid });
            carsListView.Depth = 0;
            carsListView.FullRowSelect = true;
            carsListView.Location = new Point(258, 83);
            carsListView.MinimumSize = new Size(200, 100);
            carsListView.MouseLocation = new Point(-1, -1);
            carsListView.MouseState = MaterialSkin.MouseState.OUT;
            carsListView.Name = "carsListView";
            carsListView.OwnerDraw = true;
            carsListView.Size = new Size(500, 358);
            carsListView.TabIndex = 4;
            carsListView.UseCompatibleStateImageBehavior = false;
            carsListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "#";
            id.Width = 50;
            // 
            // model
            // 
            model.Text = "Model";
            model.Width = 120;
            // 
            // price
            // 
            price.Text = "price/day";
            price.Width = 100;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 100;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 130;
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Depth = 0;
            addLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addLabel.Location = new Point(77, 115);
            addLabel.MouseState = MaterialSkin.MouseState.HOVER;
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(98, 19);
            addLabel.TabIndex = 5;
            addLabel.Text = "Add Car Form";
            // 
            // markAsDamagedBtn
            // 
            markAsDamagedBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            markAsDamagedBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            markAsDamagedBtn.Depth = 0;
            markAsDamagedBtn.HighEmphasis = true;
            markAsDamagedBtn.Icon = null;
            markAsDamagedBtn.Location = new Point(377, 450);
            markAsDamagedBtn.Margin = new Padding(4, 6, 4, 6);
            markAsDamagedBtn.MouseState = MaterialSkin.MouseState.HOVER;
            markAsDamagedBtn.Name = "markAsDamagedBtn";
            markAsDamagedBtn.NoAccentTextColor = Color.Empty;
            markAsDamagedBtn.Size = new Size(92, 36);
            markAsDamagedBtn.TabIndex = 6;
            markAsDamagedBtn.Text = "Damaged";
            markAsDamagedBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            markAsDamagedBtn.UseAccentColor = false;
            markAsDamagedBtn.UseVisualStyleBackColor = true;
            markAsDamagedBtn.Click += markAsDamagedBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteBtn.Depth = 0;
            deleteBtn.HighEmphasis = true;
            deleteBtn.Icon = null;
            deleteBtn.Location = new Point(270, 450);
            deleteBtn.Margin = new Padding(4, 6, 4, 6);
            deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.NoAccentTextColor = Color.Empty;
            deleteBtn.Size = new Size(73, 36);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteBtn.UseAccentColor = false;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ModifyCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 522);
            Controls.Add(deleteBtn);
            Controls.Add(markAsDamagedBtn);
            Controls.Add(addLabel);
            Controls.Add(carsListView);
            Controls.Add(priceTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(addBtn);
            Name = "ModifyCarForm";
            Text = "Modification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton addBtn;
        private MaterialSkin.Controls.MaterialTextBox modelTextBox;
        private MaterialSkin.Controls.MaterialTextBox priceTextBox;
        private MaterialSkin.Controls.MaterialListView carsListView;
        private ColumnHeader id;
        private ColumnHeader model;
        private ColumnHeader price;
        private ColumnHeader status;
        private ColumnHeader date;
        private MaterialSkin.Controls.MaterialLabel addLabel;
        private MaterialSkin.Controls.MaterialButton markAsDamagedBtn;
        private ColumnHeader guid;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
    }
}