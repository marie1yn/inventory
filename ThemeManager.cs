using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace inventory
{
    public static class ThemeManager
    {
        public static Color PrimaryColor { get; set; } = Color.FromArgb(120, 20, 20); // Lighter Red 207, 102, 121
        public static Color SecondaryColor { get; set; } = Color.FromArgb(200, 50, 50); // Lighter Red
        public static Color BackgroundColor { get; set; } = Color.FromArgb(30, 30, 30);  // Almost Black
        public static Color ForegroundColor { get; set; } = Color.FromArgb(230, 230, 230); // Light Gray

        public static void ApplyTheme(Form form)
        {
            form.BackColor = BackgroundColor;

            foreach (Control control in form.Controls)
            {
                if (control is Guna2Panel panel)
                {
                    panel.FillColor = PrimaryColor;
                }
                else if (control is Guna2Button button)
                {
                    button.FillColor = PrimaryColor;
                    button.HoverState.FillColor = SecondaryColor;
                    button.ForeColor = ForegroundColor;
                    button.BorderRadius = 8;
                }
                else if (control is Guna2TextBox textBox)
                {
                    textBox.FillColor = BackgroundColor;
                    textBox.ForeColor = ForegroundColor;
                    textBox.BorderColor = SecondaryColor;
                }
                else if (control is Guna2ControlBox controlBox)
                {
                    controlBox.FillColor = PrimaryColor;
                    controlBox.HoverState.FillColor = SecondaryColor;
                }
                else if (control is Label label)
                {
                    label.ForeColor = ForegroundColor;
                }
            }
        }
    }
}
