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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel16 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            lblCategory = new Label();
            lblWarning = new Label();
            manageBtn = new Guna.UI2.WinForms.Guna2Button();
            lblProductName = new Label();
            guna2Panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel16
            // 
            guna2Panel16.BorderColor = Color.Black;
            guna2Panel16.BorderRadius = 20;
            guna2Panel16.BorderThickness = 2;
            guna2Panel16.Controls.Add(guna2Button1);
            guna2Panel16.Controls.Add(pictureBoxProduct);
            guna2Panel16.Controls.Add(lblCategory);
            guna2Panel16.Controls.Add(lblWarning);
            guna2Panel16.Controls.Add(manageBtn);
            guna2Panel16.Controls.Add(lblProductName);
            guna2Panel16.CustomizableEdges = customizableEdges15;
            guna2Panel16.Location = new Point(90, 10);
            guna2Panel16.Name = "guna2Panel16";
            guna2Panel16.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel16.Size = new Size(250, 430);
            guna2Panel16.TabIndex = 8;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button1.BackColor = Color.FromArgb(30, 30, 30);
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Button1.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            guna2Button1.HoverState.ForeColor = Color.DarkGray;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(3, 359);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(244, 42);
            guna2Button1.TabIndex = 12;
            guna2Button1.Tag = "";
            guna2Button1.Text = "Manage";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.CustomizableEdges = customizableEdges11;
            pictureBoxProduct.Image = Properties.Resources._51a01bde_2cc6_4016_8417_6a29e78dbe07;
            pictureBoxProduct.ImageRotate = 0F;
            pictureBoxProduct.Location = new Point(3, 57);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pictureBoxProduct.Size = new Size(244, 250);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 11;
            pictureBoxProduct.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(66, 405);
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
            lblWarning.Location = new Point(53, 322);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(147, 23);
            lblWarning.TabIndex = 9;
            lblWarning.Text = "# about to expire!";
            // 
            // manageBtn
            // 
            manageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            manageBtn.BackColor = Color.FromArgb(30, 30, 30);
            manageBtn.Cursor = Cursors.Hand;
            manageBtn.CustomizableEdges = customizableEdges13;
            manageBtn.DisabledState.BorderColor = Color.DarkGray;
            manageBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            manageBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            manageBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            manageBtn.FillColor = Color.FromArgb(120, 20, 20);
            manageBtn.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            manageBtn.ForeColor = Color.White;
            manageBtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            manageBtn.HoverState.ForeColor = Color.DarkGray;
            manageBtn.ImageAlign = HorizontalAlignment.Left;
            manageBtn.ImageSize = new Size(30, 30);
            manageBtn.Location = new Point(3, 690);
            manageBtn.Margin = new Padding(3, 4, 3, 4);
            manageBtn.Name = "manageBtn";
            manageBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            manageBtn.Size = new Size(244, 42);
            manageBtn.TabIndex = 8;
            manageBtn.Tag = "";
            manageBtn.Text = "Manage";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(53, 21);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(146, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            lblProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel16);
            Name = "ProductCard";
            Size = new Size(431, 451);
            guna2Panel16.ResumeLayout(false);
            guna2Panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel16;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxProduct;
        private Label lblCategory;
        private Label lblWarning;
        private Guna.UI2.WinForms.Guna2Button manageBtn;
        private Label lblProductName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
