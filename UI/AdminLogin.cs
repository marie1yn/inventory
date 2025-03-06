using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            frontLogin.Visible = true;
            clickedLogin.Visible = false;
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            if (username == "admin" && password == "admin123")
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clickedLogin.Visible = false;
            guna2PanelPhoto.Visible = false;
        }

        private void guna2ButtonAdminLogin_Click(object sender, EventArgs e)
        {
            clickedLogin.Visible = true;
            guna2PanelPhoto.Visible = true;
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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


