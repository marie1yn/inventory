using System;
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
        private Timer animationTimer;
        private bool isSidebarExpanded = true;
        private const int expandedWidth = 200;
        private const int collapsedWidth = 50;
        private int animationStep = 50; // Adjust speed (higher = faster)
        private Color defaultTextColor = Color.White; // Normal text color
        private Color hoverTextColor = Color.DarkGray; // Hover text color

        public SidebarManager(Guna2Panel panel)
        {
            sidebarPanel = panel ?? throw new ArgumentNullException(nameof(panel));

            // Initialize animation timer
            animationTimer = new Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimateSidebar;

            AddHoverEffects();
            UpdateSidebarUI();
        }

        public void ToggleSidebar()
        {
            if (!animationTimer.Enabled) // Prevent multiple clicks during animation
            {
                isSidebarExpanded = !isSidebarExpanded;
                animationTimer.Start();
            }
        }

        private void AnimateSidebar(object sender, EventArgs e)
        {
            int targetWidth = isSidebarExpanded ? expandedWidth : collapsedWidth;
            int currentWidth = sidebarPanel.Width;

            if (isSidebarExpanded && currentWidth < expandedWidth)
            {
                sidebarPanel.Width = Math.Min(currentWidth + animationStep, expandedWidth);
            }
            else if (!isSidebarExpanded && currentWidth > collapsedWidth)
            {
                sidebarPanel.Width = Math.Max(currentWidth - animationStep, collapsedWidth);
            }
            else
            {
                animationTimer.Stop();
                UpdateSidebarUI();
            }
        }

        private void UpdateSidebarUI()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    // Keep icons visible even when sidebar is collapsed
                    button.ImageAlign = HorizontalAlignment.Left;
                    button.TextAlign = isSidebarExpanded ? HorizontalAlignment.Left : HorizontalAlignment.Center;
                    button.ImageSize = new Size(30, 30);
                    button.ForeColor = defaultTextColor; // Reset text color
                    button.Text = isSidebarExpanded ? (button.Tag?.ToString() ?? "") : "";

                    // Set default icon color to match text color
                    if (button.Image != null)
                    {
                        button.Image = ChangeImageColor(button.Image, defaultTextColor);
                    }
                }
            }
        }

        private void AddHoverEffects()
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.ForeColor = defaultTextColor; // Default text color

                    button.MouseEnter += (sender, e) =>
                    {
                        button.ForeColor = hoverTextColor; // Change text color on hover
                        if (button.Image != null)
                        {
                            button.Image = ChangeImageColor(button.Image, hoverTextColor); // Match icon color to text
                        }
                    };

                    button.MouseLeave += (sender, e) =>
                    {
                        button.ForeColor = defaultTextColor; // Revert text color
                        if (button.Image != null)
                        {
                            button.Image = ChangeImageColor(button.Image, defaultTextColor); // Match icon color to text
                        }
                    };
                }
            }
        }

        private Image ChangeImageColor(Image image, Color targetColor)
        {
            Bitmap newBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                // Create a color matrix to apply the target color
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] { 0, 0, 0, 0, 0 },
                    new float[] { 0, 0, 0, 0, 0 },
                    new float[] { 0, 0, 0, 0, 0 },
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
