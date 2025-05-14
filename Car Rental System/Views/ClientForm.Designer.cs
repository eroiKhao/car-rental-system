namespace Car_Rental_System
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
            carsListBox = new MaterialSkin.Controls.MaterialListBox();
            passTextBox = new MaterialSkin.Controls.MaterialTextBox();
            rentalDaysTextBox = new MaterialSkin.Controls.MaterialTextBox();
            adminBtn = new MaterialSkin.Controls.MaterialButton();
            rentBtn = new MaterialSkin.Controls.MaterialButton();
            approvedListBox = new MaterialSkin.Controls.MaterialListBox();
            payBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // carsListBox
            // 
            carsListBox.BackColor = Color.White;
            carsListBox.BorderColor = Color.LightGray;
            carsListBox.Depth = 0;
            carsListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            carsListBox.Location = new Point(182, 85);
            carsListBox.MouseState = MaterialSkin.MouseState.HOVER;
            carsListBox.Name = "carsListBox";
            carsListBox.SelectedIndex = -1;
            carsListBox.SelectedItem = null;
            carsListBox.Size = new Size(546, 384);
            carsListBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            passTextBox.AnimateReadOnly = false;
            passTextBox.BorderStyle = BorderStyle.None;
            passTextBox.Depth = 0;
            passTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passTextBox.LeadingIcon = null;
            passTextBox.Location = new Point(31, 171);
            passTextBox.MaxLength = 50;
            passTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passTextBox.Multiline = false;
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(125, 50);
            passTextBox.TabIndex = 1;
            passTextBox.Text = "";
            passTextBox.TrailingIcon = null;
            // 
            // rentalDaysTextBox
            // 
            rentalDaysTextBox.AnimateReadOnly = false;
            rentalDaysTextBox.BorderStyle = BorderStyle.None;
            rentalDaysTextBox.Depth = 0;
            rentalDaysTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentalDaysTextBox.LeadingIcon = null;
            rentalDaysTextBox.Location = new Point(31, 241);
            rentalDaysTextBox.MaxLength = 50;
            rentalDaysTextBox.MouseState = MaterialSkin.MouseState.OUT;
            rentalDaysTextBox.Multiline = false;
            rentalDaysTextBox.Name = "rentalDaysTextBox";
            rentalDaysTextBox.Size = new Size(125, 50);
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
            adminBtn.Icon = null;
            adminBtn.Location = new Point(1155, 489);
            adminBtn.Margin = new Padding(4, 6, 4, 6);
            adminBtn.MouseState = MaterialSkin.MouseState.HOVER;
            adminBtn.Name = "adminBtn";
            adminBtn.NoAccentTextColor = Color.Empty;
            adminBtn.Size = new Size(118, 36);
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
            rentBtn.Location = new Point(61, 300);
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
            // approvedListBox
            // 
            approvedListBox.BackColor = Color.White;
            approvedListBox.BorderColor = Color.LightGray;
            approvedListBox.Depth = 0;
            approvedListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            approvedListBox.Location = new Point(748, 97);
            approvedListBox.MouseState = MaterialSkin.MouseState.HOVER;
            approvedListBox.Name = "approvedListBox";
            approvedListBox.SelectedIndex = -1;
            approvedListBox.SelectedItem = null;
            approvedListBox.Size = new Size(487, 344);
            approvedListBox.TabIndex = 5;
            // 
            // payBtn
            // 
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            payBtn.Depth = 0;
            payBtn.HighEmphasis = true;
            payBtn.Icon = null;
            payBtn.Location = new Point(963, 450);
            payBtn.Margin = new Padding(4, 6, 4, 6);
            payBtn.MouseState = MaterialSkin.MouseState.HOVER;
            payBtn.Name = "payBtn";
            payBtn.NoAccentTextColor = Color.Empty;
            payBtn.Size = new Size(121, 36);
            payBtn.TabIndex = 6;
            payBtn.Text = "Pay for rent";
            payBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            payBtn.UseAccentColor = false;
            payBtn.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 552);
            Controls.Add(payBtn);
            Controls.Add(approvedListBox);
            Controls.Add(rentBtn);
            Controls.Add(adminBtn);
            Controls.Add(rentalDaysTextBox);
            Controls.Add(passTextBox);
            Controls.Add(carsListBox);
            Name = "ClientForm";
            Text = "Client Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox carsListBox;
        private MaterialSkin.Controls.MaterialTextBox passTextBox;
        private MaterialSkin.Controls.MaterialTextBox rentalDaysTextBox;
        private MaterialSkin.Controls.MaterialButton adminBtn;
        private MaterialSkin.Controls.MaterialButton rentBtn;
        private MaterialSkin.Controls.MaterialListBox approvedListBox;
        private MaterialSkin.Controls.MaterialButton payBtn;
    }
}
