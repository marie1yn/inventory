﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void BtnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BtnClose_Click(object sender, EventArgs e) => this.Close();

        private void taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    }
}
