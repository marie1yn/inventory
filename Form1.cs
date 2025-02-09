using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace inventory
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;

        public Form1()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                this.Opacity = 0.7;
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void Guna2Taskbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            this.Opacity = 1.0;
        }

        private void Guna2Taskbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button != MouseButtons.Left)
            {
                isDragging = false;
                this.Opacity = 1.0;
            }
        }

        private void ApplyTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.White;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna2Panel panel)
                {
                    panel.FillColor = System.Drawing.Color.Maroon;
                }
                else if (ctrl is Guna2Button button)
                {
                    button.FillColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    button.ForeColor = System.Drawing.Color.White;
                }
                else if (ctrl is Label label)
                {
                    label.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
