namespace inventory
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardTab = new TabPage();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            stocksTab = new TabPage();
            suppliesTab = new TabPage();
            ordersTab = new TabPage();
            usageTab = new TabPage();
            logout = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            dashboardTab.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(dashboardTab);
            materialTabControl1.Controls.Add(stocksTab);
            materialTabControl1.Controls.Add(suppliesTab);
            materialTabControl1.Controls.Add(ordersTab);
            materialTabControl1.Controls.Add(usageTab);
            materialTabControl1.Controls.Add(logout);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1344, 662);
            materialTabControl1.TabIndex = 2;
            // 
            // dashboardTab
            // 
            dashboardTab.AccessibleName = "";
            dashboardTab.Controls.Add(materialCard2);
            dashboardTab.Controls.Add(materialCard1);
            dashboardTab.ImageKey = "dashboard (1).png";
            dashboardTab.Location = new Point(4, 31);
            dashboardTab.Name = "dashboardTab";
            dashboardTab.Padding = new Padding(3);
            dashboardTab.Size = new Size(1336, 627);
            dashboardTab.TabIndex = 0;
            dashboardTab.Text = "Dashboard";
            dashboardTab.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(guna2CircleButton1);
            materialCard2.Controls.Add(materialListBox1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(865, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(454, 596);
            materialCard2.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.Location = new Point(387, 10);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(50, 50);
            guna2CircleButton1.TabIndex = 1;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(17, 66);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(420, 513);
            materialListBox1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(cartesianChart1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 222);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(835, 388);
            materialCard1.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(17, 17);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(801, 354);
            cartesianChart1.TabIndex = 0;
            // 
            // stocksTab
            // 
            stocksTab.ImageKey = "money-graph-with-up-arrow.png";
            stocksTab.Location = new Point(4, 31);
            stocksTab.Name = "stocksTab";
            stocksTab.Padding = new Padding(3);
            stocksTab.Size = new Size(1336, 627);
            stocksTab.TabIndex = 1;
            stocksTab.Text = "Stock Management";
            stocksTab.UseVisualStyleBackColor = true;
            // 
            // suppliesTab
            // 
            suppliesTab.ImageKey = "parcel.png";
            suppliesTab.Location = new Point(4, 31);
            suppliesTab.Name = "suppliesTab";
            suppliesTab.Size = new Size(1336, 627);
            suppliesTab.TabIndex = 2;
            suppliesTab.Text = "Suppliers ";
            suppliesTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            ordersTab.ImageKey = "shopping-cart.png";
            ordersTab.Location = new Point(4, 31);
            ordersTab.Name = "ordersTab";
            ordersTab.Size = new Size(1336, 627);
            ordersTab.TabIndex = 3;
            ordersTab.Text = "Orders & Restocking";
            ordersTab.UseVisualStyleBackColor = true;
            // 
            // usageTab
            // 
            usageTab.ImageKey = "data-usage.png";
            usageTab.Location = new Point(4, 31);
            usageTab.Name = "usageTab";
            usageTab.Size = new Size(1336, 627);
            usageTab.TabIndex = 4;
            usageTab.Text = "Usage Reports ";
            usageTab.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.ImageKey = "logout (1).png";
            logout.Location = new Point(4, 31);
            logout.Name = "logout";
            logout.Size = new Size(1336, 627);
            logout.TabIndex = 5;
            logout.Text = "LOGOUT";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dashboard (1).png");
            imageList1.Images.SetKeyName(1, "data-usage.png");
            imageList1.Images.SetKeyName(2, "logout (1).png");
            imageList1.Images.SetKeyName(3, "money-graph-with-up-arrow.png");
            imageList1.Images.SetKeyName(4, "parcel.png");
            imageList1.Images.SetKeyName(5, "setting.png");
            imageList1.Images.SetKeyName(6, "shopping-cart.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 729);
            Controls.Add(materialTabControl1);
            DrawerHighlightWithAccent = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerWidth = 300;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            materialTabControl1.ResumeLayout(false);
            dashboardTab.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage dashboardTab;
        private TabPage stocksTab;
        private TabPage suppliesTab;
        private TabPage ordersTab;
        private TabPage usageTab;
        private TabPage logout;
        private ImageList imageList1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
    }
}
