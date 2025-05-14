namespace Car_Rental_System.Views
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
            orderListView = new MaterialSkin.Controls.MaterialListView();
            searchBtn = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            prevBtn = new MaterialSkin.Controls.MaterialButton();
            nextBtn = new MaterialSkin.Controls.MaterialButton();
            modifyBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // clientBtn
            // 
            clientBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clientBtn.Depth = 0;
            clientBtn.HighEmphasis = true;
            clientBtn.Icon = null;
            clientBtn.Location = new Point(7, 492);
            clientBtn.Margin = new Padding(4, 6, 4, 6);
            clientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clientBtn.Name = "clientBtn";
            clientBtn.NoAccentTextColor = Color.Empty;
            clientBtn.Size = new Size(135, 36);
            clientBtn.TabIndex = 0;
            clientBtn.Text = "Back to Client";
            clientBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clientBtn.UseAccentColor = false;
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // orderListView
            // 
            orderListView.AutoSizeTable = false;
            orderListView.BackColor = Color.FromArgb(255, 255, 255);
            orderListView.BorderStyle = BorderStyle.None;
            orderListView.Depth = 0;
            orderListView.FullRowSelect = true;
            orderListView.Location = new Point(196, 123);
            orderListView.MinimumSize = new Size(200, 100);
            orderListView.MouseLocation = new Point(-1, -1);
            orderListView.MouseState = MaterialSkin.MouseState.OUT;
            orderListView.Name = "orderListView";
            orderListView.OwnerDraw = true;
            orderListView.Size = new Size(782, 360);
            orderListView.TabIndex = 1;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Details;
            // 
            // searchBtn
            // 
            searchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchBtn.Depth = 0;
            searchBtn.HighEmphasis = true;
            searchBtn.Icon = Properties.Resources.search;
            searchBtn.Location = new Point(897, 70);
            searchBtn.Margin = new Padding(4, 6, 4, 6);
            searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            searchBtn.Name = "searchBtn";
            searchBtn.NoAccentTextColor = Color.Empty;
            searchBtn.Size = new Size(64, 36);
            searchBtn.TabIndex = 2;
            searchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchBtn.UseAccentColor = false;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(736, 67);
            searchTextBox.MaxLength = 50;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 50);
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
            prevBtn.Icon = null;
            prevBtn.Location = new Point(267, 492);
            prevBtn.Margin = new Padding(4, 6, 4, 6);
            prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            prevBtn.Name = "prevBtn";
            prevBtn.NoAccentTextColor = Color.Empty;
            prevBtn.Size = new Size(64, 36);
            prevBtn.TabIndex = 5;
            prevBtn.Text = "prev";
            prevBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevBtn.UseAccentColor = false;
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextBtn.Depth = 0;
            nextBtn.HighEmphasis = true;
            nextBtn.Icon = null;
            nextBtn.Location = new Point(370, 492);
            nextBtn.Margin = new Padding(4, 6, 4, 6);
            nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            nextBtn.Name = "nextBtn";
            nextBtn.NoAccentTextColor = Color.Empty;
            nextBtn.Size = new Size(64, 36);
            nextBtn.TabIndex = 6;
            nextBtn.Text = "next";
            nextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextBtn.UseAccentColor = false;
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // modifyBtn
            // 
            modifyBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modifyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            modifyBtn.Depth = 0;
            modifyBtn.HighEmphasis = true;
            modifyBtn.Icon = null;
            modifyBtn.Location = new Point(1019, 489);
            modifyBtn.Margin = new Padding(4, 6, 4, 6);
            modifyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            modifyBtn.Name = "modifyBtn";
            modifyBtn.NoAccentTextColor = Color.Empty;
            modifyBtn.Size = new Size(116, 36);
            modifyBtn.TabIndex = 7;
            modifyBtn.Text = "modify cars";
            modifyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            modifyBtn.UseAccentColor = false;
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 564);
            Controls.Add(modifyBtn);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(searchTextBox);
            Controls.Add(searchBtn);
            Controls.Add(orderListView);
            Controls.Add(clientBtn);
            Name = "AdminForm";
            Text = "Admin Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton clientBtn;
        private MaterialSkin.Controls.MaterialListView orderListView;
        private MaterialSkin.Controls.MaterialButton searchBtn;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private MaterialSkin.Controls.MaterialButton prevBtn;
        private MaterialSkin.Controls.MaterialButton nextBtn;
        private MaterialSkin.Controls.MaterialButton modifyBtn;
    }
}