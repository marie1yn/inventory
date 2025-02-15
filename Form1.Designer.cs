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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges57 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges58 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges51 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges52 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges53 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges54 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges55 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges56 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges59 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges60 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges61 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges62 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges63 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges64 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges65 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges66 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges67 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges68 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges69 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges70 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges71 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges72 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2Taskbar = new Guna2Panel();
            btnClose = new Guna2ControlBox();
            btnMinimize = new Guna2ControlBox();
            sidebarPanel = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            logout = new Guna2Button();
            roles = new Guna2Button();
            statistics = new Guna2Button();
            orders = new Guna2Button();
            stocks = new Guna2Button();
            dashboard = new Guna2Button();
            btnToggle = new Guna2Button();
            guna2Panel1 = new Guna2Panel();
            label1 = new Label();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            guna2TextBox2 = new Guna2TextBox();
            guna2TextBox1 = new Guna2TextBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtTopProduct = new Guna2TextBox();
            notificationIcon = new Guna2ImageButton();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage1 = new TabPage();
            guna2ShadowPanel1 = new Guna2ShadowPanel();
            guna2ImageButton1 = new Guna2ImageButton();
            search = new Guna2TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            guna2Taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            guna2Taskbar.CustomizableEdges = customizableEdges41;
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.FromArgb(120, 20, 20);
            guna2Taskbar.Location = new Point(0, 0);
            guna2Taskbar.Margin = new Padding(3, 4, 3, 4);
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.ShadowDecoration.CustomizableEdges = customizableEdges42;
            guna2Taskbar.Size = new Size(1561, 47);
            guna2Taskbar.TabIndex = 0;
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;
            guna2Taskbar.MouseMove += Guna2Taskbar_MouseMove;
            guna2Taskbar.MouseUp += Guna2Taskbar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges37;
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1511, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges38;
            btnClose.Size = new Size(51, 47);
            btnClose.TabIndex = 0;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges39;
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1458, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges40;
            btnMinimize.Size = new Size(51, 47);
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
            sidebarPanel.Controls.Add(statistics);
            sidebarPanel.Controls.Add(orders);
            sidebarPanel.Controls.Add(stocks);
            sidebarPanel.Controls.Add(dashboard);
            sidebarPanel.CustomBorderColor = Color.DimGray;
            sidebarPanel.CustomizableEdges = customizableEdges57;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 47);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges58;
            sidebarPanel.Size = new Size(229, 977);
            sidebarPanel.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 64);
            guna2Panel2.CustomizableEdges = customizableEdges43;
            guna2Panel2.Dock = DockStyle.Right;
            guna2Panel2.Location = new Point(226, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges44;
            guna2Panel2.Size = new Size(3, 977);
            guna2Panel2.TabIndex = 7;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges45;
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
            logout.Location = new Point(0, 923);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges46;
            logout.Size = new Size(225, 60);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            // 
            // roles
            // 
            roles.BackColor = Color.FromArgb(30, 30, 30);
            roles.Cursor = Cursors.Hand;
            roles.CustomizableEdges = customizableEdges47;
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
            roles.Location = new Point(0, 379);
            roles.Margin = new Padding(3, 4, 3, 4);
            roles.Name = "roles";
            roles.RightToLeft = RightToLeft.No;
            roles.ShadowDecoration.CustomizableEdges = customizableEdges48;
            roles.Size = new Size(225, 60);
            roles.TabIndex = 5;
            roles.Tag = "Roles";
            roles.TextAlign = HorizontalAlignment.Left;
            // 
            // statistics
            // 
            statistics.BackColor = Color.FromArgb(30, 30, 30);
            statistics.Cursor = Cursors.Hand;
            statistics.CustomizableEdges = customizableEdges49;
            statistics.DisabledState.BorderColor = Color.DarkGray;
            statistics.DisabledState.CustomBorderColor = Color.DarkGray;
            statistics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            statistics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            statistics.FillColor = Color.FromArgb(30, 30, 30);
            statistics.Font = new Font("Arial", 12F, FontStyle.Bold);
            statistics.ForeColor = Color.FromArgb(30, 30, 30);
            statistics.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            statistics.HoverState.ForeColor = Color.DarkGray;
            statistics.Image = Properties.Resources.data_usage;
            statistics.ImageAlign = HorizontalAlignment.Left;
            statistics.ImageSize = new Size(30, 30);
            statistics.Location = new Point(0, 293);
            statistics.Margin = new Padding(3, 4, 3, 4);
            statistics.Name = "statistics";
            statistics.RightToLeft = RightToLeft.No;
            statistics.ShadowDecoration.CustomizableEdges = customizableEdges50;
            statistics.Size = new Size(225, 60);
            statistics.TabIndex = 4;
            statistics.Tag = "Statistics";
            statistics.TextAlign = HorizontalAlignment.Left;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(30, 30, 30);
            orders.Cursor = Cursors.Hand;
            orders.CustomizableEdges = customizableEdges51;
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
            orders.Location = new Point(0, 209);
            orders.Margin = new Padding(3, 4, 3, 4);
            orders.Name = "orders";
            orders.RightToLeft = RightToLeft.No;
            orders.ShadowDecoration.CustomizableEdges = customizableEdges52;
            orders.Size = new Size(225, 60);
            orders.TabIndex = 3;
            orders.Tag = "Orders";
            orders.TextAlign = HorizontalAlignment.Left;
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(30, 30, 30);
            stocks.Cursor = Cursors.Hand;
            stocks.CustomizableEdges = customizableEdges53;
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
            stocks.Location = new Point(0, 124);
            stocks.Margin = new Padding(3, 4, 3, 4);
            stocks.Name = "stocks";
            stocks.RightToLeft = RightToLeft.No;
            stocks.ShadowDecoration.CustomizableEdges = customizableEdges54;
            stocks.Size = new Size(225, 60);
            stocks.TabIndex = 2;
            stocks.Tag = "Stocks";
            stocks.TextAlign = HorizontalAlignment.Left;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.FromArgb(30, 30, 30);
            dashboard.Cursor = Cursors.Hand;
            dashboard.CustomizableEdges = customizableEdges55;
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
            dashboard.Location = new Point(0, 37);
            dashboard.Margin = new Padding(3, 4, 3, 4);
            dashboard.Name = "dashboard";
            dashboard.RightToLeft = RightToLeft.No;
            dashboard.ShadowDecoration.CustomizableEdges = customizableEdges56;
            dashboard.Size = new Size(225, 60);
            dashboard.TabIndex = 1;
            dashboard.Tag = "Dashboard";
            dashboard.TextAlign = HorizontalAlignment.Left;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges59;
            btnToggle.DisabledState.BorderColor = Color.DarkGray;
            btnToggle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggle.FillColor = Color.FromArgb(120, 20, 20);
            btnToggle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnToggle.ForeColor = Color.White;
            btnToggle.Location = new Point(0, 0);
            btnToggle.Margin = new Padding(3, 4, 3, 4);
            btnToggle.Name = "btnToggle";
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges60;
            btnToggle.Size = new Size(50, 67);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += btnToggle_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnToggle);
            guna2Panel1.CustomizableEdges = customizableEdges61;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(229, 47);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges62;
            guna2Panel1.Size = new Size(1332, 69);
            guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 16);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
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
            tabControl1.Location = new Point(229, 116);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1332, 908);
            tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(guna2TextBox2);
            tabPage2.Controls.Add(guna2TextBox1);
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1324, 875);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dashboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.CustomizableEdges = customizableEdges63;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(847, 361);
            guna2TextBox2.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges64;
            guna2TextBox2.Size = new Size(472, 261);
            guna2TextBox2.TabIndex = 5;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.CustomizableEdges = customizableEdges65;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(847, 63);
            guna2TextBox1.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges66;
            guna2TextBox1.Size = new Size(472, 261);
            guna2TextBox1.TabIndex = 4;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtTopProduct);
            materialCard1.Controls.Add(notificationIcon);
            materialCard1.Controls.Add(cartesianChart1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(72, 63);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(767, 609);
            materialCard1.TabIndex = 3;
            // 
            // txtTopProduct
            // 
            txtTopProduct.CustomizableEdges = customizableEdges67;
            txtTopProduct.DefaultText = "";
            txtTopProduct.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTopProduct.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTopProduct.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Font = new Font("Segoe UI", 9F);
            txtTopProduct.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Location = new Point(17, 19);
            txtTopProduct.Margin = new Padding(3, 5, 3, 5);
            txtTopProduct.Name = "txtTopProduct";
            txtTopProduct.PasswordChar = '\0';
            txtTopProduct.PlaceholderText = "";
            txtTopProduct.SelectedText = "";
            txtTopProduct.ShadowDecoration.CustomizableEdges = customizableEdges68;
            txtTopProduct.Size = new Size(651, 73);
            txtTopProduct.TabIndex = 0;
            // 
            // notificationIcon
            // 
            notificationIcon.CheckedState.ImageSize = new Size(64, 64);
            notificationIcon.HoverState.ImageSize = new Size(64, 64);
            notificationIcon.Image = (Image)resources.GetObject("notificationIcon.Image");
            notificationIcon.ImageOffset = new Point(0, 0);
            notificationIcon.ImageRotate = 0F;
            notificationIcon.Location = new Point(675, 17);
            notificationIcon.Name = "notificationIcon";
            notificationIcon.PressedState.ImageSize = new Size(64, 64);
            notificationIcon.ShadowDecoration.CustomizableEdges = customizableEdges69;
            notificationIcon.Size = new Size(77, 73);
            notificationIcon.TabIndex = 1;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(15, 123);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(735, 475);
            cartesianChart1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(guna2ShadowPanel1);
            tabPage1.Controls.Add(guna2ImageButton1);
            tabPage1.Controls.Add(search);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1324, 875);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Stocks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(723, 228);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(250, 125);
            guna2ShadowPanel1.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(559, 68);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges70;
            guna2ImageButton1.Size = new Size(42, 34);
            guna2ImageButton1.TabIndex = 1;
            // 
            // search
            // 
            search.BorderColor = Color.Maroon;
            search.CustomizableEdges = customizableEdges71;
            search.DefaultText = "";
            search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Font = new Font("Segoe UI", 9F);
            search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Location = new Point(63, 54);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.PasswordChar = '\0';
            search.PlaceholderText = "";
            search.SelectedText = "";
            search.ShadowDecoration.CustomizableEdges = customizableEdges72;
            search.Size = new Size(551, 60);
            search.TabIndex = 0;
            search.TextChanged += guna2TextBox3_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1324, 875);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1324, 875);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Statistics";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1324, 875);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Roles";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1561, 1024);
            Controls.Add(tabControl1);
            Controls.Add(guna2Panel1);
            Controls.Add(sidebarPanel);
            Controls.Add(guna2Taskbar);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load;
            guna2Taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna2Panel sidebarPanel;
        private Guna2Button btnToggle;
        private Guna2Button logout;
        private Guna2Panel guna2Panel1;
        private ImageList imageList1;
        protected Guna2Button dashboard;
        protected Guna2Button roles;
        protected Guna2Button statistics;
        protected Guna2Button orders;
        protected Guna2Button stocks;
        private Guna2Panel guna2Panel2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Guna2ImageButton notificationIcon;
        private Guna2TextBox txtTopProduct;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna2TextBox guna2TextBox2;
        private Guna2TextBox guna2TextBox1;
        private Label label1;
        private Guna2TextBox search;
        private Guna2ShadowPanel guna2ShadowPanel1;
        private Guna2ImageButton guna2ImageButton1;
    }
}
