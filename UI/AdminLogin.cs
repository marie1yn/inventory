using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //guna2PanelFrontPage.Dock = DockStyle.Fill;
            guna2PanelFrontPage.BringToFront();
            guna2PanelFrontPage.Visible = true;
            guna2PanelFrontPage2.Visible = true;
            guna2PanelFrontPage2.BringToFront();

            guna2PanelAdminLogin.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            string password = guna2TextBoxPassword.Text;

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
            guna2PanelAdminLogin.Visible = false;
            guna2PanelPhoto.Visible = false;
        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonAdminLogin_Click(object sender, EventArgs e)
        {
            guna2PanelFrontPage.Visible = false;
            guna2PanelAdminLogin.Visible = true;

            guna2PanelAdminLogin.BringToFront();
            guna2PanelPhoto.BringToFront();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


