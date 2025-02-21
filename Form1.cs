using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using Timer = System.Windows.Forms.Timer;
using Guna.Charts.WinForms;

namespace inventory
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private SidebarManager sidebarManager;
        private int notificationCount = 0;
        private Guna2CircleButton notificationBadge;
        private Timer notificationTimer;
        private GunaChart gunaChart;

        public Form1()
        {
            InitializeComponent();
            InitializeGunaChart();
            sidebarManager = new SidebarManager(sidebarPanel, tabControl1, dashboard);
            InitializeNotificationBadge();
            InitializeNotificationTimer();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
            sidebarManager.ApplyTagColors();
            sidebarManager.UpdateSidebarUI();
            sidebarManager.SetActiveButton(dashboard);
            dashboard.PerformClick();
            guna2VScrollBar1.BindingContainer = guna2Panel4;
            logout.FillColor = Color.Maroon;
            logout.ForeColor = Color.White;

            if (!sidebarManager.originalImages.ContainsKey(logout) && logout.Image != null)
                sidebarManager.originalImages[logout] = new Bitmap(logout.Image);

            if (logout.Image != null && sidebarManager.originalImages.ContainsKey(logout))
                logout.Image = sidebarManager.ChangeImageColor(sidebarManager.originalImages[logout], Color.White);

        }

        private void InitializeGunaChart()
        {
            gunaChart = new GunaChart();
            gunaChart.Dock = DockStyle.Fill;
            Controls.Add(gunaChart);

            gunaChart.Datasets.Add(gunaHorizontalBarDataset1);

        }
        private void InitializeNotificationBadge()
        {
            notificationBadge = new Guna2CircleButton
            {
                Size = new Size(20, 20),
                FillColor = Color.Red,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Text = "0",
                Visible = false,
                Parent = sidebarPanel,
            };
            notificationBadge.Click += NotificationBadge_Click;
            PositionNotificationBadge();
        }

        private void InitializeNotificationTimer()
        {
            notificationTimer = new Timer { Interval = 5000 }; // Simulates new notification every 5s
            notificationTimer.Tick += (s, e) => AddNotification();
            notificationTimer.Start();
        }

        private void PositionNotificationBadge()
        {
            notificationBadge.Location = new Point(notificationIcon.Right - 10, notificationIcon.Top - 5);
        }

        private void AddNotification()
        {
            notificationCount++;
            notificationBadge.Text = notificationCount.ToString();
            notificationBadge.Visible = true;
        }

        private void NotificationBadge_Click(object sender, EventArgs e)
        {
            notificationCount = 0;
            notificationBadge.Text = "0";
            notificationBadge.Visible = false;
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void btnToggle_Click(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button && button.Tag != null)
            {
                string tabName = button.Tag.ToString();

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
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ResetSearchBox();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Product")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            ResetSearchBox();
        }

        private void ResetSearchBox()
        {
            if (string.IsNullOrWhiteSpace(search.Text)) // If empty, reset text
            {
                search.Text = "Search Product";
                search.ForeColor = Color.Gray;
            }
        }
        private void dashboard_Click(object sender, EventArgs e)
        {
            label1.Text = "Dashboard";
        }

        private void stocks_Click(object sender, EventArgs e)
        {
            label1.Text = "Stock Management";
        }

        private void orders_Click(object sender, EventArgs e)
        {
            label1.Text = "Orders and Reservations";
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            label1.Text = "Statistics";
        }

        private void roles_Click(object sender, EventArgs e)
        {
            label1.Text = "Role Manager";
        }
    }
}

