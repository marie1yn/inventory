namespace inventory
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel38 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            pictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            lblCategory = new Label();
            lblWarning = new Label();
            lblProductName = new Label();
            guna2Panel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel38
            // 
            guna2Panel38.BackColor = Color.Transparent;
            guna2Panel38.BorderColor = Color.Black;
            guna2Panel38.BorderRadius = 20;
            guna2Panel38.BorderThickness = 2;
            guna2Panel38.Controls.Add(guna2Button8);
            guna2Panel38.Controls.Add(pictureBoxProduct);
            guna2Panel38.Controls.Add(lblCategory);
            guna2Panel38.Controls.Add(lblWarning);
            guna2Panel38.Controls.Add(lblProductName);
            guna2Panel38.CustomizableEdges = customizableEdges5;
            guna2Panel38.FillColor = Color.White;
            guna2Panel38.Location = new Point(0, 0);
            guna2Panel38.Margin = new Padding(1, 1, 1, 5);
            guna2Panel38.Name = "guna2Panel38";
            guna2Panel38.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel38.Size = new Size(241, 380);
            guna2Panel38.TabIndex = 14;
            // 
            // guna2Button8
            // 
            guna2Button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button8.BackColor = Color.FromArgb(30, 30, 30);
            guna2Button8.Cursor = Cursors.Hand;
            guna2Button8.CustomizableEdges = customizableEdges1;
            guna2Button8.DisabledState.BorderColor = Color.DarkGray;
            guna2Button8.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button8.FillColor = Color.FromArgb(120, 20, 20);
            guna2Button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            guna2Button8.ForeColor = Color.White;
            guna2Button8.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            guna2Button8.HoverState.ForeColor = Color.DarkGray;
            guna2Button8.ImageAlign = HorizontalAlignment.Left;
            guna2Button8.ImageSize = new Size(30, 30);
            guna2Button8.Location = new Point(3, 306);
            guna2Button8.Margin = new Padding(3, 4, 3, 4);
            guna2Button8.Name = "guna2Button8";
            guna2Button8.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button8.Size = new Size(235, 42);
            guna2Button8.TabIndex = 13;
            guna2Button8.Tag = "";
            guna2Button8.Text = "Manage";
            guna2Button8.Click += guna2Button8_Click;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.CustomizableEdges = customizableEdges3;
            pictureBoxProduct.Image = Properties.Resources._51a01bde_2cc6_4016_8417_6a29e78dbe07;
            pictureBoxProduct.ImageRotate = 0F;
            pictureBoxProduct.Location = new Point(3, 40);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pictureBoxProduct.Size = new Size(235, 235);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 11;
            pictureBoxProduct.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(60, 355);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(123, 17);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category: Rice Bowl";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Maroon;
            lblWarning.Location = new Point(50, 279);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(147, 23);
            lblWarning.TabIndex = 9;
            lblWarning.Text = "# about to expire!";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(51, 11);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(148, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            lblProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel38);
            Name = "ProductCard";
            Size = new Size(241, 380);
            guna2Panel38.ResumeLayout(false);
            guna2Panel38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel38;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxProduct;
        private Label lblCategory;
        private Label lblWarning;
        private Label lblProductName;
    }
}
