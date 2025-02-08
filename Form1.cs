using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using MaterialSkin;
using MaterialSkin.Controls;
using SkiaSharp;
using System;
using System.Windows.Forms;
using Axis = LiveChartsCore.SkiaSharpView.Axis;

namespace inventory
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red600, Primary.Yellow700, Accent.Red400, TextShade.WHITE);

            cartesianChart1.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values = new double[] { 2, 5, 4, 2, 4, 3, 5 }
                },
                new LineSeries<int>
                {
                    Values = new int[] { 4, 6, 5, 3, 3, 1, 2 }
                }
            };
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "X Axis",
                    NamePaint = new SolidColorPaint(SKColors.White),

                    LabelsPaint = new SolidColorPaint(SKColors.White),
                    TextSize = 15,

                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 }
                }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Y Axis",
                    NamePaint = new SolidColorPaint(SKColors.White),
                    LabelsRotation = 45,
                    LabelsPaint = new SolidColorPaint(SKColors.White),
                    TextSize = 15,

                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                    {
                        StrokeThickness = 2,
                        PathEffect = new DashEffect(new float[] { 3, 3 })
                    }
                }
            };
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void cartesianChart1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
