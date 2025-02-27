namespace inventory
{
    partial class OrderCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            SuspendLayout();
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.BorderRadius = 20;
            guna2TileButton1.Cursor = Cursors.Hand;
            guna2TileButton1.CustomizableEdges = customizableEdges1;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.FromArgb(235, 192, 192);
            guna2TileButton1.Font = new Font("Segoe UI", 9F);
            guna2TileButton1.ForeColor = Color.White;
            guna2TileButton1.Location = new Point(3, 3);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.PressedColor = Color.Gray;
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TileButton1.Size = new Size(400, 200);
            guna2TileButton1.TabIndex = 0;
            guna2TileButton1.Text = "Customer Name";
            guna2TileButton1.TextAlign = HorizontalAlignment.Left;
            guna2TileButton1.Click += guna2TileButton1_Click;
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TileButton1);
            Margin = new Padding(1, 1, 1, 5);
            Name = "OrderCard";
            Size = new Size(407, 207);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}
