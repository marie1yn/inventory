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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2Taskbar = new Guna2Panel();
            btnClose = new Guna2ControlBox();
            btnMinimize = new Guna2ControlBox();
            sidebarPanel = new Guna2Panel();
            btnToggle = new Guna2Button();
            guna2Button1 = new Guna2Button();
            guna2Button2 = new Guna2Button();
            guna2Button3 = new Guna2Button();
            guna2Button4 = new Guna2Button();
            guna2Button5 = new Guna2Button();
            guna2Button6 = new Guna2Button();
            guna2Taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
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
            guna2Taskbar.CustomizableEdges = customizableEdges21;
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.Maroon;
            guna2Taskbar.Location = new Point(0, 0);
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Taskbar.Size = new Size(1366, 35);
            guna2Taskbar.TabIndex = 0;
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;
            guna2Taskbar.MouseMove += Guna2Taskbar_MouseMove;
            guna2Taskbar.MouseUp += Guna2Taskbar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges17;
            btnClose.FillColor = Color.Maroon;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1321, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnClose.Size = new Size(45, 35);
            btnClose.TabIndex = 0;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges19;
            btnMinimize.FillColor = Color.Maroon;
            btnMinimize.HoverState.FillColor = Color.DarkRed;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1276, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnMinimize.Size = new Size(45, 35);
            btnMinimize.TabIndex = 1;
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(guna2Button6);
            sidebarPanel.Controls.Add(guna2Button5);
            sidebarPanel.Controls.Add(guna2Button4);
            sidebarPanel.Controls.Add(guna2Button3);
            sidebarPanel.Controls.Add(guna2Button2);
            sidebarPanel.Controls.Add(guna2Button1);
            sidebarPanel.Controls.Add(btnToggle);
            sidebarPanel.CustomizableEdges = customizableEdges15;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.White;
            sidebarPanel.Location = new Point(0, 35);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            sidebarPanel.Size = new Size(250, 733);
            sidebarPanel.TabIndex = 1;
            // 
            // btnToggle
            // 
            btnToggle.CustomizableEdges = customizableEdges13;
            btnToggle.DisabledState.BorderColor = Color.DarkGray;
            btnToggle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggle.ForeColor = Color.White;
            btnToggle.Location = new Point(5, 10);
            btnToggle.Name = "btnToggle";
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnToggle.Size = new Size(50, 50);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += guna2Button1_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(0, 81);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new Size(250, 45);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Dashboard";
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges9;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(0, 146);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button2.Size = new Size(250, 45);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "Stock";
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(0, 210);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(250, 45);
            guna2Button3.TabIndex = 3;
            guna2Button3.Text = "Orders";
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges5;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(0, 273);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button4.Size = new Size(250, 45);
            guna2Button4.TabIndex = 4;
            guna2Button4.Text = "Statistics";
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges3;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.Font = new Font("Segoe UI", 9F);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Location = new Point(0, 337);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button5.Size = new Size(250, 45);
            guna2Button5.TabIndex = 5;
            guna2Button5.Text = "Roles";
            // 
            // guna2Button6
            // 
            guna2Button6.CustomizableEdges = customizableEdges1;
            guna2Button6.DisabledState.BorderColor = Color.DarkGray;
            guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button6.Font = new Font("Segoe UI", 9F);
            guna2Button6.ForeColor = Color.White;
            guna2Button6.Location = new Point(0, 664);
            guna2Button6.Name = "guna2Button6";
            guna2Button6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button6.Size = new Size(250, 45);
            guna2Button6.TabIndex = 6;
            guna2Button6.Text = "LOGOUT";
            guna2Button6.Click += guna2Button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1366, 768);
            Controls.Add(sidebarPanel);
            Controls.Add(guna2Taskbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            guna2Taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna2Panel sidebarPanel;
        private Guna2Button btnToggle;
        private Guna2Button guna2Button1;
        private Guna2Button guna2Button6;
        private Guna2Button guna2Button5;
        private Guna2Button guna2Button4;
        private Guna2Button guna2Button3;
        private Guna2Button guna2Button2;
    }
}
