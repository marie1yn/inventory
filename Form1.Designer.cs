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
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2Taskbar = new Guna2Panel();
            btnMinimize = new Guna2ControlBox();
            btnClose = new Guna2ControlBox();

            SuspendLayout();

            // guna2BorderlessForm1
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            guna2BorderlessForm1.ResizeForm = true;
            guna2BorderlessForm1.DockForm = false;
            guna2BorderlessForm1.DragForm = false;

            // guna2Taskbar (Custom Title Bar)
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.Maroon;
            guna2Taskbar.Size = new Size(1366, 35);
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;

            // Minimize Button
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FillColor = Color.Maroon;
            btnMinimize.HoverState.FillColor = Color.DarkRed;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1276, 0);
            btnMinimize.Size = new Size(45, 35);
            btnMinimize.Click += BtnMinimize_Click;

            // Close Button
            btnClose.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.CloseBox;
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FillColor = Color.Maroon;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1321, 0);
            btnClose.Size = new Size(45, 35);
            btnClose.Click += BtnClose_Click;

            // Add buttons to taskbar (No Maximize Button)
            guna2Taskbar.Controls.Add(btnClose);
            guna2Taskbar.Controls.Add(btnMinimize);

            // Add taskbar to form
            Controls.Add(guna2Taskbar);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1366, 768);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";

            ResumeLayout(false);
        }
    }
}
