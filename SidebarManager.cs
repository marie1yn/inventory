using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Timer = System.Windows.Forms.Timer;

namespace inventory
{
    public class SidebarManager
    {
        private Guna2Panel sidebarPanel; 
        private TabControl tabControl;
        private Form mainForm;
        private Timer animationTimer;
        private bool isSidebarExpanded = true;
        private const int expandedWidth = 200;
        private const int collapsedWidth = 50;
        private int animationSpeed = 10;  
        private int animationStep;
        private Dictionary<Guna2Button, Image> originalImages = new Dictionary<Guna2Button, Image>();

        public SidebarManager(Guna2Panel panel, TabControl tabControl)
        {
            sidebarPanel = panel ?? throw new ArgumentNullException(nameof(panel));
            this.tabControl = tabControl ?? throw new ArgumentNullException(nameof(tabControl)); 

            animationTimer = new Timer { Interval =10};
            animationTimer.Interval = animationSpeed;
            animationTimer.Tick += AnimateSidebar;

            AddButtonClickEvents();
            AddHoverEffects();
            ApplyTagColors();
            UpdateSidebarUI();
        }

        public void ApplyTagColors()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.ForeColor = Color.White;

                    if (!originalImages.ContainsKey(button) && button.Image != null)
                        originalImages[button] = new Bitmap(button.Image);

                    if (button.Image != null && originalImages.ContainsKey(button))
                        button.Image = ChangeImageColor(originalImages[button], Color.White);
                }
            }
        }

        private void AddButtonClickEvents()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                    button.MouseDown += SidebarButton_MouseDown;

            }
        }
        private void SidebarButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is Guna2Button button)
            {
                string tabName = button.Tag?.ToString();
                if (!string.IsNullOrEmpty(tabName))
                {
                    foreach (TabPage tab in tabControl.TabPages)
                    {
                        if (tab.Text == tabName)
                        {
                            tabControl.SelectedTab = tab;

                            // Close the sidebar after selecting a tab
                            if (isSidebarExpanded)
                            {
                                ToggleSidebar();
                            }

                            break;
                        }
                    }
                }
            }
        }


        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button && button.Tag != null)
            {
                string tabName = button.Tag.ToString();

                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Text == tabName)
                    {
                        tabControl.SelectedTab = tab; 
                        ToggleSidebar();
                        return;
                    }
                }
            }
            
        }


        public void ToggleSidebar()
        {
            if (!animationTimer.Enabled)
            {
                isSidebarExpanded = !isSidebarExpanded;
                sidebarPanel.BringToFront();
                animationStep = Math.Max(5, Math.Abs(expandedWidth - collapsedWidth) / 10);
                animationTimer.Start();
            }
        }

        private void AnimateSidebar(object sender, EventArgs e)
        {
            int targetWidth = isSidebarExpanded ? expandedWidth : collapsedWidth;
            int currentWidth = sidebarPanel.Width;

            sidebarPanel.Width = isSidebarExpanded
                ? Math.Min(currentWidth + animationStep, expandedWidth)
                : Math.Max(currentWidth - animationStep, collapsedWidth);

            if (sidebarPanel.Width == targetWidth)
            {
                animationTimer.Stop();
                UpdateSidebarUI();
            }
        }

        public void UpdateSidebarUI()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.ImageAlign = HorizontalAlignment.Left;
                    button.TextAlign = isSidebarExpanded ? HorizontalAlignment.Left : HorizontalAlignment.Center;
                    button.ImageSize = new Size(30, 30);
                    button.Text = isSidebarExpanded ? (button.Tag?.ToString() ?? "") : "";
                }
            }
        }

        private void AddHoverEffects()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.MouseEnter += (sender, e) =>
                    {
                        button.ForeColor = Color.DarkGray;
                        if (button.Image != null && originalImages.ContainsKey(button))
                            button.Image = ChangeImageColor(originalImages[button], Color.DarkGray);
                    };

                    button.MouseLeave += (sender, e) =>
                    {
                        button.ForeColor = Color.White;
                        if (button.Image != null && originalImages.ContainsKey(button))
                            button.Image = ChangeImageColor(originalImages[button], Color.White);
                    };
                }
            }
        }

        private Image ChangeImageColor(Image image, Color targetColor)
        {
            if (image == null) return null;

            Bitmap newBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] { 1, 0, 0, 0, 0 },
                    new float[] { 0, 1, 0, 0, 0 },
                    new float[] { 0, 0, 1, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { targetColor.R / 255f, targetColor.G / 255f, targetColor.B / 255f, 0, 1 }
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(image, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
                                0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;

        }
    }
}
