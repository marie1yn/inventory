using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace inventory
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private SidebarManager sidebarManager;

        public Form1()
        {
            InitializeComponent();
            sidebarManager = new SidebarManager(sidebarPanel, tabControl1, dashboard);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
            sidebarManager.ApplyTagColors();
            sidebarManager.UpdateSidebarUI();
            sidebarManager.SetActiveButton(dashboard);
            dashboard.PerformClick();
            logout.FillColor = Color.Maroon;
            logout.ForeColor = Color.White;
            SetInitialComboBoxValues(this);
        }

        private void BtnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BtnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnToggle_Click(object sender, EventArgs e) => sidebarManager.ToggleSidebar();
        private void SetInitialComboBoxValues(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Guna2ComboBox comboBox && comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (control.HasChildren)
                {
                    SetInitialComboBoxValues(control);
                }
            }
        }
        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button && button.Tag is string tabName)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    if (tab.Text == tabName)
                    {
                        tabControl1.SelectedTab = tab;
                        sidebarManager.SetActiveButton(button);
                        return;
                    }
                }
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox searchBox && (searchBox.Text == "Search Product" || searchBox.Text == "Search..." || searchBox.Text == "Search Order"))
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e) => ResetSearchBox();

        private void ResetSearchBox()
        {
            foreach (var searchBox in new[] { searchStocks, searchRoles, searchOrder })
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    searchBox.Text = searchBox == searchStocks ? "Search Product" : searchBox == searchOrder ? "Search Order" : "Search...";
                    searchBox.ForeColor = Color.Gray;
                }
            }
        }

        private void dashboard_Click(object sender, EventArgs e) => label1.Text = "Dashboard";
        private void stocks_Click(object sender, EventArgs e) => label1.Text = "Stock Management";
        private void orders_Click(object sender, EventArgs e) => label1.Text = "Orders and Reservations";
        private void statistics_Click(object sender, EventArgs e) => label1.Text = "Statistics";
        private void roles_Click(object sender, EventArgs e) => label1.Text = "Role Manager";

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    }
}
