using System.Drawing;
using Guna.UI2.WinForms;

namespace inventory
{
    public static class ThemeManager
    {
        public static Color PrimaryColor { get; set; } = Color.Maroon;
        public static Color SecondaryColor { get; set; } = Color.Yellow;
        public static Color BackgroundColor { get; set; } = Color.White;
        public static Color ForegroundColor { get; set; } = Color.Black;

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
                }
                else if (control is Guna2TextBox textBox)
                {
                    textBox.FillColor = BackgroundColor;
                    textBox.ForeColor = ForegroundColor;
                }
                else if (control is Guna2ControlBox controlBox)
                {
                    controlBox.FillColor = PrimaryColor;
                    controlBox.HoverState.FillColor = SecondaryColor;
                }
            }
        }
    }
}
