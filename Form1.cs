using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;
using System.Data;

namespace inventory
{
    public partial class Form1 : Form
    {
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
            Example(guna2Chart1);
        }
        private void SetInitialComboBoxValues(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Guna2ComboBox comboBox && comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                if (control.HasChildren)
                {
                    SetInitialComboBoxValues(control);
                }
            }
        }
        private void taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
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
            if (sender is Guna2TextBox searchBox &&
                (searchBox.Text == "Search Product" || searchBox.Text == "Search..." || searchBox.Text == "Search Order"))
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
                    searchBox.Text = searchBox == searchStocks ? "Search Product" :
                                     searchBox == searchOrder ? "Search Order" : "Search...";
                    searchBox.ForeColor = Color.Gray;
                }
            }
        }
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (sidebarManager != null)
            {
                sidebarManager.ToggleSidebar();
            }
        }
        private void manageBtn_Click(object sender, EventArgs e)
        {
            new ManageStock().Show();
        }
        private void btnsales_dashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = lblstatistics;
            sidebarManager.SetActiveButton(statistics);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = lblstatistics;
            sidebarManager.SetActiveButton(statistics);
        }
        public static void Example(GunaChart guna2Chart1)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" };

            // 🛠️ Chart Configuration
            guna2Chart1.YAxes.GridLines.Display = false;
            guna2Chart1.Legend.Position = LegendPosition.Right; // Move legend to the right

            var random = new Random();

            // 🟠 Stacked Bar Dataset 1 (Product A Sales)
            var stackedBar1 = new GunaStackedBarDataset
            {
                Label = "Product A",
                FillColors = new ColorCollection
                {
                    Color.FromArgb(245, 245, 220), // Beige 🤍
                    Color.FromArgb(247, 231, 206), // Champagne ✨
                }
            };

            // 🔵 Stacked Bar Dataset 2 (Product B Sales)
            var stackedBar2 = new GunaStackedBarDataset
            {
                Label = "Product B",
                FillColors = new ColorCollection
                {
                    Color.FromArgb(85, 107, 47)  // Dark Olive Green 🌿
                }
            };

            var stackedBar3 = new GunaStackedBarDataset
            {
                Label = "Product C",
                FillColors = new ColorCollection
                {
                    Color.FromArgb(128, 0, 0) // Maroon ❤️
                }
            };

            // 🔴 Line Dataset (Total Revenue)
            var lineDataset = new GunaLineDataset
            {
                Label = "Total Revenue",
                BorderWidth = 2,
                BorderColor = Color.FromArgb(50, 50, 50),
                //BorderColor = Color.FromArgb(184, 134, 11),  // Deep Gold 🌟
                FillColor = Color.FromArgb(50, 50, 50),  // Dark Gray ⚫
                PointRadius = 6,
                PointFillColors = new ColorCollection()
                {
                    Color.Maroon,
                    Color.DarkGray,
                    Color.Black,
                    Color.FromArgb(184, 134, 11),
                    Color.FromArgb(85, 107, 47),
                },
                PointBorderColors = new ColorCollection()
                {
                    Color.White,
                }
            };


            // 📊 Add Data
            for (int i = 0; i < months.Length; i++)
            {
                int productA = random.Next(10, 100);
                int productB = random.Next(10, 100);
                int productC = random.Next(10, 100);
                int totalRevenue = productA + productB + productC;

                stackedBar1.DataPoints.Add(months[i], productA);
                stackedBar2.DataPoints.Add(months[i], productB);
                stackedBar3.DataPoints.Add(months[i], productB);
                lineDataset.DataPoints.Add(months[i], totalRevenue);
            }

            // 📝 Add datasets to chart
            guna2Chart1.Datasets.Add(stackedBar1);
            guna2Chart1.Datasets.Add(stackedBar2);
            guna2Chart1.Datasets.Add(stackedBar3);
            guna2Chart1.Datasets.Add(lineDataset);

            // 🔄 Update the chart
            guna2Chart1.Update();
        }
        private void dashboard_Click(object sender, EventArgs e) => label1.Text = "Dashboard";
        private void stocks_Click(object sender, EventArgs e) => label1.Text = "Stocks";
        private void orders_Click(object sender, EventArgs e) => label1.Text = "Orders";
        private void statistics_Click(object sender, EventArgs e) => label1.Text = "Statistics";
        private void roles_Click(object sender, EventArgs e) => label1.Text = "Roles";

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    }
}
