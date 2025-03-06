using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;
using System.Data;
using inventory.Utils;

namespace inventory
{
    public partial class Form1 : Form
    {
        private SidebarManager sidebarManager;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true; // Reduce UI flickering
            sidebarManager = new SidebarManager(sidebarPanel, tabControl1, dashboardbtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SuspendLayout(); // Suspend layout updates for performance
            sidebarManager.ToggleSidebar();
            sidebarManager.ApplyTagColors();
            sidebarManager.UpdateSidebarUI();
            sidebarManager.SetActiveButton(dashboardbtn);
            dashboardbtn.PerformClick();

            logout.FillColor = Color.Maroon;
            logout.ForeColor = Color.White;

            SetInitialComboBoxValues(this);
            Example(guna2Chart1);
            stockScrollbar.BindingContainer = stockPanel;
            orderScrollbar.BindingContainer = orderPanel;

            for (int i = 0; i < 20; i++)
            {
                var stockCard = new ProductCard();
                stockCard.SuspendLayout(); // Reduce layout recalculations
                stockPanel.Controls.Add(stockCard);
                stockCard.ResumeLayout();

                var orderCard = new OrderCard();
                orderCard.SuspendLayout();
                orderPanel.Controls.Add(orderCard);
                orderCard.ResumeLayout();
            }
            ResumeLayout(); // Resume layout updates
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            sidebarManager?.ToggleSidebar();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            loginForm.Show();
            this.Hide();
            loginForm.FormClosed += (s, args) => System.Windows.Forms.Application.Exit();
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

        private void manageBtn_Click(object sender, EventArgs e)
        {
            new ManageStock().Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new AddNewProduct().Show();
        }

        private void btnsales_dashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = lblstatistics;
            sidebarManager.SetActiveButton(statisticsbtn);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new AddOrder().Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = lblstatistics;
            sidebarManager.SetActiveButton(statisticsbtn);
        }

        public static void Example(GunaChart guna2Chart1)
        {
            guna2Chart1.SuspendLayout(); // Optimize UI updates
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" };

            guna2Chart1.YAxes.GridLines.Display = false;
            guna2Chart1.Legend.Position = LegendPosition.Right;

            var random = new Random();

            var stackedBar1 = new GunaStackedBarDataset { Label = "Product A", FillColors = new ColorCollection { Color.FromArgb(245, 245, 220) } };
            var stackedBar2 = new GunaStackedBarDataset { Label = "Product B", FillColors = new ColorCollection { Color.FromArgb(85, 107, 47) } };
            var stackedBar3 = new GunaStackedBarDataset { Label = "Product C", FillColors = new ColorCollection { Color.FromArgb(128, 0, 0) } };
            var lineDataset = new GunaLineDataset { Label = "Total Revenue", BorderWidth = 2, BorderColor = Color.FromArgb(50, 50, 50) };

            for (int i = 0; i < months.Length; i++)
            {
                int productA = random.Next(10, 100);
                int productB = random.Next(10, 100);
                int productC = random.Next(10, 100);
                int totalRevenue = productA + productB + productC;

                stackedBar1.DataPoints.Add(months[i], productA);
                stackedBar2.DataPoints.Add(months[i], productB);
                stackedBar3.DataPoints.Add(months[i], productC);
                lineDataset.DataPoints.Add(months[i], totalRevenue);
            }

            guna2Chart1.Datasets.Add(stackedBar1);
            guna2Chart1.Datasets.Add(stackedBar2);
            guna2Chart1.Datasets.Add(stackedBar3);
            guna2Chart1.Datasets.Add(lineDataset);
            guna2Chart1.Update();
            guna2Chart1.ResumeLayout();
        }

        private void dashboard_Click(object sender, EventArgs e) => labelTab.Text = "Dashboard";
        private void stocks_Click(object sender, EventArgs e) => labelTab.Text = "Stocks";
        private void orders_Click(object sender, EventArgs e) => labelTab.Text = "Orders";
        private void statistics_Click(object sender, EventArgs e) => labelTab.Text = "Statistics";
        private void roles_Click(object sender, EventArgs e) => labelTab.Text = "Roles";
    }
}
