using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace inventory
{
    partial class Form1
    {
        private IContainer components = null;
        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2Panel guna2Taskbar;
        private Guna2ControlBox btnMinimize;
        private Guna2ControlBox btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2Taskbar = new Guna2Panel();
            btnClose = new Guna2ControlBox();
            btnMinimize = new Guna2ControlBox();
            sidebarPanel = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            logout = new Guna2Button();
            roles = new Guna2Button();
            stats = new Guna2Button();
            orders = new Guna2Button();
            stocks = new Guna2Button();
            dashboard = new Guna2Button();
            btnToggle = new Guna2Button();
            guna2Panel1 = new Guna2Panel();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            guna2TextBox2 = new Guna2TextBox();
            guna2TextBox1 = new Guna2TextBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtTopProduct = new Guna2TextBox();
            btnNotif = new Guna2ImageButton();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            guna2Taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockForm = false;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Taskbar
            // 
            guna2Taskbar.Controls.Add(btnClose);
            guna2Taskbar.Controls.Add(btnMinimize);
            guna2Taskbar.CustomizableEdges = customizableEdges32;
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.FromArgb(120, 20, 20);
            guna2Taskbar.Location = new Point(0, 0);
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.ShadowDecoration.CustomizableEdges = customizableEdges33;
            guna2Taskbar.Size = new Size(1366, 35);
            guna2Taskbar.TabIndex = 0;
            guna2Taskbar.Paint += guna2Taskbar_Paint;
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;
            guna2Taskbar.MouseMove += Guna2Taskbar_MouseMove;
            guna2Taskbar.MouseUp += Guna2Taskbar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges28;
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1322, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges29;
            btnClose.Size = new Size(45, 35);
            btnClose.TabIndex = 0;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges30;
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1276, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges31;
            btnMinimize.Size = new Size(45, 35);
            btnMinimize.TabIndex = 1;
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Transparent;
            sidebarPanel.BorderColor = Color.DimGray;
            sidebarPanel.Controls.Add(guna2Panel2);
            sidebarPanel.Controls.Add(logout);
            sidebarPanel.Controls.Add(roles);
            sidebarPanel.Controls.Add(stats);
            sidebarPanel.Controls.Add(orders);
            sidebarPanel.Controls.Add(stocks);
            sidebarPanel.Controls.Add(dashboard);
            sidebarPanel.CustomBorderColor = Color.DimGray;
            sidebarPanel.CustomizableEdges = customizableEdges26;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 35);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges27;
            sidebarPanel.Size = new Size(200, 733);
            sidebarPanel.TabIndex = 1;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 64);
            guna2Panel2.CustomizableEdges = customizableEdges12;
            guna2Panel2.Dock = DockStyle.Right;
            guna2Panel2.Location = new Point(197, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2Panel2.Size = new Size(3, 733);
            guna2Panel2.TabIndex = 7;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges14;
            logout.DisabledState.BorderColor = Color.DarkGray;
            logout.DisabledState.CustomBorderColor = Color.DarkGray;
            logout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logout.FillColor = Color.FromArgb(120, 20, 20);
            logout.Font = new Font("Arial", 12F, FontStyle.Bold);
            logout.ForeColor = Color.FromArgb(120, 20, 20);
            logout.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            logout.HoverState.ForeColor = Color.DarkGray;
            logout.Image = Properties.Resources.logout__1_;
            logout.ImageAlign = HorizontalAlignment.Left;
            logout.ImageSize = new Size(30, 30);
            logout.Location = new Point(0, 692);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges15;
            logout.Size = new Size(197, 45);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            logout.Click += guna2Button6_Click;
            // 
            // roles
            // 
            roles.BackColor = Color.FromArgb(30, 30, 30);
            roles.Cursor = Cursors.Hand;
            roles.CustomizableEdges = customizableEdges16;
            roles.DisabledState.BorderColor = Color.DarkGray;
            roles.DisabledState.CustomBorderColor = Color.DarkGray;
            roles.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            roles.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            roles.FillColor = Color.FromArgb(30, 30, 30);
            roles.Font = new Font("Arial", 12F, FontStyle.Bold);
            roles.ForeColor = Color.FromArgb(30, 30, 30);
            roles.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            roles.HoverState.ForeColor = Color.DarkGray;
            roles.Image = Properties.Resources.parcel;
            roles.ImageAlign = HorizontalAlignment.Left;
            roles.ImageSize = new Size(30, 30);
            roles.Location = new Point(0, 284);
            roles.Name = "roles";
            roles.RightToLeft = RightToLeft.No;
            roles.ShadowDecoration.CustomizableEdges = customizableEdges17;
            roles.Size = new Size(197, 45);
            roles.TabIndex = 5;
            roles.Tag = "Roles";
            roles.TextAlign = HorizontalAlignment.Left;
            // 
            // stats
            // 
            stats.BackColor = Color.FromArgb(30, 30, 30);
            stats.Cursor = Cursors.Hand;
            stats.CustomizableEdges = customizableEdges18;
            stats.DisabledState.BorderColor = Color.DarkGray;
            stats.DisabledState.CustomBorderColor = Color.DarkGray;
            stats.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stats.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stats.FillColor = Color.FromArgb(30, 30, 30);
            stats.Font = new Font("Arial", 12F, FontStyle.Bold);
            stats.ForeColor = Color.FromArgb(30, 30, 30);
            stats.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            stats.HoverState.ForeColor = Color.DarkGray;
            stats.Image = Properties.Resources.data_usage;
            stats.ImageAlign = HorizontalAlignment.Left;
            stats.ImageSize = new Size(30, 30);
            stats.Location = new Point(0, 220);
            stats.Name = "stats";
            stats.RightToLeft = RightToLeft.No;
            stats.ShadowDecoration.CustomizableEdges = customizableEdges19;
            stats.Size = new Size(197, 45);
            stats.TabIndex = 4;
            stats.Tag = "Statistics";
            stats.TextAlign = HorizontalAlignment.Left;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(30, 30, 30);
            orders.Cursor = Cursors.Hand;
            orders.CustomizableEdges = customizableEdges20;
            orders.DisabledState.BorderColor = Color.DarkGray;
            orders.DisabledState.CustomBorderColor = Color.DarkGray;
            orders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            orders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            orders.FillColor = Color.FromArgb(30, 30, 30);
            orders.Font = new Font("Arial", 12F, FontStyle.Bold);
            orders.ForeColor = Color.FromArgb(30, 30, 30);
            orders.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            orders.HoverState.ForeColor = Color.DarkGray;
            orders.Image = Properties.Resources.shopping_cart;
            orders.ImageAlign = HorizontalAlignment.Left;
            orders.ImageSize = new Size(30, 30);
            orders.Location = new Point(0, 157);
            orders.Name = "orders";
            orders.RightToLeft = RightToLeft.No;
            orders.ShadowDecoration.CustomizableEdges = customizableEdges21;
            orders.Size = new Size(197, 45);
            orders.TabIndex = 3;
            orders.Tag = "Orders";
            orders.TextAlign = HorizontalAlignment.Left;
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(30, 30, 30);
            stocks.Cursor = Cursors.Hand;
            stocks.CustomizableEdges = customizableEdges22;
            stocks.DisabledState.BorderColor = Color.DarkGray;
            stocks.DisabledState.CustomBorderColor = Color.DarkGray;
            stocks.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stocks.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stocks.FillColor = Color.FromArgb(30, 30, 30);
            stocks.Font = new Font("Arial", 12F, FontStyle.Bold);
            stocks.ForeColor = Color.FromArgb(30, 30, 30);
            stocks.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            stocks.HoverState.ForeColor = Color.DarkGray;
            stocks.Image = Properties.Resources.money_graph_with_up_arrow;
            stocks.ImageAlign = HorizontalAlignment.Left;
            stocks.ImageSize = new Size(30, 30);
            stocks.Location = new Point(0, 93);
            stocks.Name = "stocks";
            stocks.RightToLeft = RightToLeft.No;
            stocks.ShadowDecoration.CustomizableEdges = customizableEdges23;
            stocks.Size = new Size(197, 45);
            stocks.TabIndex = 2;
            stocks.Tag = "Stock";
            stocks.TextAlign = HorizontalAlignment.Left;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.FromArgb(30, 30, 30);
            dashboard.Cursor = Cursors.Hand;
            dashboard.CustomizableEdges = customizableEdges24;
            dashboard.DisabledState.BorderColor = Color.DarkGray;
            dashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboard.FillColor = Color.FromArgb(30, 30, 30);
            dashboard.Font = new Font("Arial", 12F, FontStyle.Bold);
            dashboard.ForeColor = Color.FromArgb(30, 30, 30);
            dashboard.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            dashboard.HoverState.ForeColor = Color.DarkGray;
            dashboard.Image = Properties.Resources.dashboard__1_;
            dashboard.ImageAlign = HorizontalAlignment.Left;
            dashboard.ImageSize = new Size(30, 30);
            dashboard.Location = new Point(0, 28);
            dashboard.Name = "dashboard";
            dashboard.RightToLeft = RightToLeft.No;
            dashboard.ShadowDecoration.CustomizableEdges = customizableEdges25;
            dashboard.Size = new Size(197, 45);
            dashboard.TabIndex = 1;
            dashboard.Tag = "Dashboard";
            dashboard.TextAlign = HorizontalAlignment.Left;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges8;
            btnToggle.DisabledState.BorderColor = Color.DarkGray;
            btnToggle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggle.FillColor = Color.FromArgb(120, 20, 20);
            btnToggle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnToggle.ForeColor = Color.White;
            btnToggle.Location = new Point(0, 0);
            btnToggle.Name = "btnToggle";
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnToggle.Size = new Size(44, 50);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += btnToggle_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnToggle);
            guna2Panel1.CustomizableEdges = customizableEdges10;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(200, 35);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Panel1.Size = new Size(1166, 52);
            guna2Panel1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dashboard (1).png");
            imageList1.Images.SetKeyName(1, "data-usage.png");
            imageList1.Images.SetKeyName(2, "logo.jpeg");
            imageList1.Images.SetKeyName(3, "logout (1).png");
            imageList1.Images.SetKeyName(4, "money-graph-with-up-arrow.png");
            imageList1.Images.SetKeyName(5, "parcel.png");
            imageList1.Images.SetKeyName(6, "setting.png");
            imageList1.Images.SetKeyName(7, "shopping-cart.png");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(200, 87);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1166, 681);
            tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(guna2TextBox2);
            tabPage2.Controls.Add(guna2TextBox1);
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1158, 653);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dashboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.CustomizableEdges = customizableEdges1;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(742, 271);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox2.Size = new Size(413, 196);
            guna2TextBox2.TabIndex = 5;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(742, 47);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(413, 196);
            guna2TextBox1.TabIndex = 4;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtTopProduct);
            materialCard1.Controls.Add(btnNotif);
            materialCard1.Controls.Add(cartesianChart1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(63, 47);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(671, 457);
            materialCard1.TabIndex = 3;
            // 
            // txtTopProduct
            // 
            txtTopProduct.CustomizableEdges = customizableEdges5;
            txtTopProduct.DefaultText = "";
            txtTopProduct.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTopProduct.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTopProduct.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Font = new Font("Segoe UI", 9F);
            txtTopProduct.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Location = new Point(15, 14);
            txtTopProduct.Name = "txtTopProduct";
            txtTopProduct.PasswordChar = '\0';
            txtTopProduct.PlaceholderText = "";
            txtTopProduct.SelectedText = "";
            txtTopProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTopProduct.Size = new Size(570, 55);
            txtTopProduct.TabIndex = 0;
            // 
            // btnNotif
            // 
            btnNotif.CheckedState.ImageSize = new Size(64, 64);
            btnNotif.HoverState.ImageSize = new Size(64, 64);
            btnNotif.Image = (Image)resources.GetObject("btnNotif.Image");
            btnNotif.ImageOffset = new Point(0, 0);
            btnNotif.ImageRotate = 0F;
            btnNotif.Location = new Point(591, 13);
            btnNotif.Margin = new Padding(3, 2, 3, 2);
            btnNotif.Name = "btnNotif";
            btnNotif.PressedState.ImageSize = new Size(64, 64);
            btnNotif.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnNotif.Size = new Size(67, 55);
            btnNotif.TabIndex = 1;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(13, 92);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(643, 356);
            cartesianChart1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1158, 653);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Stocks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1158, 653);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1158, 653);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Stats";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1158, 653);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Roles";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(tabControl1);
            Controls.Add(guna2Panel1);
            Controls.Add(sidebarPanel);
            Controls.Add(guna2Taskbar);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            guna2Taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna2Panel sidebarPanel;
        private Guna2Button btnToggle;
        private Guna2Button logout;
        private Guna2Panel guna2Panel1;
        private ImageList imageList1;
        protected Guna2Button dashboard;
        protected Guna2Button roles;
        protected Guna2Button stats;
        protected Guna2Button orders;
        protected Guna2Button stocks;
        private Guna2Panel guna2Panel2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Guna2ImageButton btnNotif;
        private Guna2TextBox txtTopProduct;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna2TextBox guna2TextBox2;
        private Guna2TextBox guna2TextBox1;
    }
}
