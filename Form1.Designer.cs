﻿using System;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
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
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            guna2Taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Taskbar
            // 
            guna2Taskbar.Controls.Add(btnClose);
            guna2Taskbar.Controls.Add(btnMinimize);
            guna2Taskbar.CustomizableEdges = customizableEdges25;
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.FromArgb(120, 20, 20);
            guna2Taskbar.Location = new Point(0, 0);
            guna2Taskbar.Margin = new Padding(3, 4, 3, 4);
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Taskbar.Size = new Size(1561, 47);
            guna2Taskbar.TabIndex = 0;
            guna2Taskbar.Paint += guna2Taskbar_Paint;
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;
            guna2Taskbar.MouseMove += Guna2Taskbar_MouseMove;
            guna2Taskbar.MouseUp += Guna2Taskbar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges21;
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1510, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnClose.Size = new Size(51, 47);
            btnClose.TabIndex = 0;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges23;
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1458, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges24;
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
            sidebarPanel.Controls.Add(stats);
            sidebarPanel.Controls.Add(orders);
            sidebarPanel.Controls.Add(stocks);
            sidebarPanel.Controls.Add(dashboard);
            sidebarPanel.CustomBorderColor = Color.DimGray;
            sidebarPanel.CustomizableEdges = customizableEdges19;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 47);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges20;
            sidebarPanel.Size = new Size(229, 977);
            sidebarPanel.TabIndex = 1;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 64);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Dock = DockStyle.Right;
            guna2Panel2.Location = new Point(226, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(3, 977);
            guna2Panel2.TabIndex = 7;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges7;
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
            logout.Location = new Point(0, 815);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges8;
            logout.Size = new Size(225, 60);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            logout.Click += guna2Button6_Click;
            // 
            // roles
            // 
            roles.BackColor = Color.FromArgb(30, 30, 30);
            roles.Cursor = Cursors.Hand;
            roles.CustomizableEdges = customizableEdges9;
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
            roles.ShadowDecoration.CustomizableEdges = customizableEdges10;
            roles.Size = new Size(225, 60);
            roles.TabIndex = 5;
            roles.Tag = "Roles";
            roles.TextAlign = HorizontalAlignment.Left;
            // 
            // stats
            // 
            stats.BackColor = Color.FromArgb(30, 30, 30);
            stats.Cursor = Cursors.Hand;
            stats.CustomizableEdges = customizableEdges11;
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
            stats.Location = new Point(0, 293);
            stats.Margin = new Padding(3, 4, 3, 4);
            stats.Name = "stats";
            stats.RightToLeft = RightToLeft.No;
            stats.ShadowDecoration.CustomizableEdges = customizableEdges12;
            stats.Size = new Size(225, 60);
            stats.TabIndex = 4;
            stats.Tag = "Statistics";
            stats.TextAlign = HorizontalAlignment.Left;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(30, 30, 30);
            orders.Cursor = Cursors.Hand;
            orders.CustomizableEdges = customizableEdges13;
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
            orders.ShadowDecoration.CustomizableEdges = customizableEdges14;
            orders.Size = new Size(225, 60);
            orders.TabIndex = 3;
            orders.Tag = "Orders";
            orders.TextAlign = HorizontalAlignment.Left;
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(30, 30, 30);
            stocks.Cursor = Cursors.Hand;
            stocks.CustomizableEdges = customizableEdges15;
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
            stocks.ShadowDecoration.CustomizableEdges = customizableEdges16;
            stocks.Size = new Size(225, 60);
            stocks.TabIndex = 2;
            stocks.Tag = "Stock";
            stocks.TextAlign = HorizontalAlignment.Left;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.FromArgb(30, 30, 30);
            dashboard.Cursor = Cursors.Hand;
            dashboard.CustomizableEdges = customizableEdges17;
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
            dashboard.ShadowDecoration.CustomizableEdges = customizableEdges18;
            dashboard.Size = new Size(225, 60);
            dashboard.TabIndex = 1;
            dashboard.Tag = "Dashboard";
            dashboard.TextAlign = HorizontalAlignment.Left;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges1;
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
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnToggle.Size = new Size(50, 67);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += btnToggle_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnToggle);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(229, 47);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1332, 69);
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
            tabControl1.Location = new Point(229, 116);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1332, 908);
            tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1324, 875);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dashboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1324, 875);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Stocks";
            tabPage1.UseVisualStyleBackColor = true;
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
            tabPage4.Text = "Stats";
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
            guna2Taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
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
    }
}
