using System;
using System.Runtime.InteropServices;
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
            sidebarManager = new SidebarManager(sidebarPanel, tabControl1);
            this.Load += Form1_Load; // Attach the Load event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
            sidebarManager.ToggleSidebar();

            // 🔹 Ensure sidebar and toggle panel are fully visible
            sidebarPanel.Refresh();
            sidebarPanel.Invalidate();
            sidebarPanel.Update();

            guna2Panel1.Refresh();
            guna2Panel1.Invalidate();
            guna2Panel1.Update();

            // 🔹 Bring Sidebar & Toggle Panel to the front
            guna2Panel1.BringToFront();
            sidebarPanel.BringToFront();

            // ✅ Apply button colors & refresh UI
            sidebarManager.ApplyTagColors();
            sidebarManager.UpdateSidebarUI(); // Ensure all buttons update on startup
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

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
        }

        private void guna2Taskbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
