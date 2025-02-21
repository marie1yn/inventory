using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace inventory
{
    partial class Form1
    {
        private IContainer components = null;
        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2Panel guna2Taskbar;
        private Guna2ControlBox btnMinimize;
        private Guna2ControlBox btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges57 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges58 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges53 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges54 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges55 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges56 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges51 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges52 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.LPoint lPoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint3 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint4 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint5 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint6 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint7 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint8 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint9 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint10 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint11 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint12 = new Guna.Charts.WinForms.LPoint();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont17 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont18 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont19 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont20 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid7 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick7 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont21 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid8 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick8 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont22 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid9 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel3 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont23 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick9 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont24 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont25 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont26 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont27 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont28 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid10 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick10 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont29 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid11 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick11 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont30 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid12 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel4 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont31 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick12 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont32 = new Guna.Charts.WinForms.ChartFont();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2Taskbar = new Guna2Panel();
            btnClose = new Guna2ControlBox();
            btnMinimize = new Guna2ControlBox();
            sidebarPanel = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            logout = new Guna2Button();
            roles = new Guna2Button();
            statistics = new Guna2Button();
            orders = new Guna2Button();
            stocks = new Guna2Button();
            dashboard = new Guna2Button();
            btnToggle = new Guna2Button();
            guna2Panel1 = new Guna2Panel();
            label1 = new Label();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            lbldashboard = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            gunaHorizontalBarDataset1 = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            txtTopProduct = new Guna2TextBox();
            notificationIcon = new Guna2ImageButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            label2 = new Label();
            guna2TextBox1 = new Guna2TextBox();
            guna2TextBox2 = new Guna2TextBox();
            guna2Panel6 = new Guna2Panel();
            lblstocks = new TabPage();
            guna2Panel5 = new Guna2Panel();
            guna2ImageButton1 = new Guna2ImageButton();
            search = new Guna2TextBox();
            categoryComboBox = new Guna2ComboBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label4 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            guna2Panel4 = new Guna2Panel();
            guna2VScrollBar1 = new Guna2VScrollBar();
            lblorder = new TabPage();
            guna2ImageButton2 = new Guna2ImageButton();
            guna2TextBox3 = new Guna2TextBox();
            guna2ComboBox1 = new Guna2ComboBox();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            llblstatistics = new TabPage();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            gunaChart4 = new Guna.Charts.WinForms.GunaChart();
            gunaChart3 = new Guna.Charts.WinForms.GunaChart();
            gunaChart2 = new Guna.Charts.WinForms.GunaChart();
            lblroles = new TabPage();
            guna2DataGridView2 = new Guna2DataGridView();
            guna2DataGridView1 = new Guna2DataGridView();
            panel1 = new Panel();
            guna2TextBox4 = new Guna2TextBox();
            guna2ImageButton3 = new Guna2ImageButton();
            guna2GradientPanel1 = new Guna2GradientPanel();
            guna2Button1 = new Guna2Button();
            guna2Button2 = new Guna2Button();
            guna2Taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            lbldashboard.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            lblstocks.SuspendLayout();
            guna2Panel5.SuspendLayout();
            materialCard3.SuspendLayout();
            guna2Panel4.SuspendLayout();
            lblorder.SuspendLayout();
            llblstatistics.SuspendLayout();
            lblroles.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView2).BeginInit();
            ((ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockForm = false;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Taskbar
            // 
            guna2Taskbar.Controls.Add(btnClose);
            guna2Taskbar.Controls.Add(btnMinimize);
            guna2Taskbar.CustomizableEdges = customizableEdges57;
            guna2Taskbar.Dock = DockStyle.Top;
            guna2Taskbar.FillColor = Color.FromArgb(120, 20, 20);
            guna2Taskbar.Location = new Point(0, 0);
            guna2Taskbar.Margin = new Padding(3, 4, 3, 4);
            guna2Taskbar.Name = "guna2Taskbar";
            guna2Taskbar.ShadowDecoration.CustomizableEdges = customizableEdges58;
            guna2Taskbar.Size = new Size(1366, 47);
            guna2Taskbar.TabIndex = 0;
            guna2Taskbar.MouseDown += Guna2Taskbar_MouseDown;
            guna2Taskbar.MouseMove += Guna2Taskbar_MouseMove;
            guna2Taskbar.MouseUp += Guna2Taskbar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges53;
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1316, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges54;
            btnClose.Size = new Size(51, 47);
            btnClose.TabIndex = 0;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges55;
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1263, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges56;
            btnMinimize.Size = new Size(51, 47);
            btnMinimize.TabIndex = 1;
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Transparent;
            sidebarPanel.BorderColor = Color.DimGray;
            sidebarPanel.Controls.Add(guna2Panel2);
            sidebarPanel.Controls.Add(logout);
            sidebarPanel.Controls.Add(roles);
            sidebarPanel.Controls.Add(statistics);
            sidebarPanel.Controls.Add(orders);
            sidebarPanel.Controls.Add(stocks);
            sidebarPanel.Controls.Add(dashboard);
            sidebarPanel.CustomBorderColor = Color.DimGray;
            sidebarPanel.CustomizableEdges = customizableEdges51;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 47);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges52;
            sidebarPanel.Size = new Size(229, 721);
            sidebarPanel.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 64);
            guna2Panel2.CustomizableEdges = customizableEdges37;
            guna2Panel2.Dock = DockStyle.Right;
            guna2Panel2.Location = new Point(226, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges38;
            guna2Panel2.Size = new Size(3, 721);
            guna2Panel2.TabIndex = 7;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges39;
            logout.DisabledState.BorderColor = Color.DarkGray;
            logout.DisabledState.CustomBorderColor = Color.DarkGray;
            logout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logout.FillColor = Color.FromArgb(120, 20, 20);
            logout.Font = new Font("Arial", 12F, FontStyle.Bold);
            logout.ForeColor = Color.FromArgb(120, 20, 20);
            logout.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            logout.HoverState.ForeColor = Color.DarkGray;
            logout.Image = Properties.Resources.logout__1_;
            logout.ImageAlign = HorizontalAlignment.Left;
            logout.ImageSize = new Size(30, 30);
            logout.Location = new Point(0, 637);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges40;
            logout.Size = new Size(225, 60);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            // 
            // roles
            // 
            roles.BackColor = Color.FromArgb(30, 30, 30);
            roles.Cursor = Cursors.Hand;
            roles.CustomizableEdges = customizableEdges41;
            roles.DisabledState.BorderColor = Color.DarkGray;
            roles.DisabledState.CustomBorderColor = Color.DarkGray;
            roles.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            roles.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            roles.FillColor = Color.FromArgb(30, 30, 30);
            roles.Font = new Font("Arial", 12F, FontStyle.Bold);
            roles.ForeColor = Color.FromArgb(30, 30, 30);
            roles.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            roles.HoverState.ForeColor = Color.DarkGray;
            roles.Image = Properties.Resources.parcel;
            roles.ImageAlign = HorizontalAlignment.Left;
            roles.ImageSize = new Size(30, 30);
            roles.Location = new Point(0, 379);
            roles.Margin = new Padding(3, 4, 3, 4);
            roles.Name = "roles";
            roles.RightToLeft = RightToLeft.No;
            roles.ShadowDecoration.CustomizableEdges = customizableEdges42;
            roles.Size = new Size(225, 60);
            roles.TabIndex = 5;
            roles.Tag = "Roles";
            roles.TextAlign = HorizontalAlignment.Left;
            roles.Click += roles_Click;
            // 
            // statistics
            // 
            statistics.BackColor = Color.FromArgb(30, 30, 30);
            statistics.Cursor = Cursors.Hand;
            statistics.CustomizableEdges = customizableEdges43;
            statistics.DisabledState.BorderColor = Color.DarkGray;
            statistics.DisabledState.CustomBorderColor = Color.DarkGray;
            statistics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            statistics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            statistics.FillColor = Color.FromArgb(30, 30, 30);
            statistics.Font = new Font("Arial", 12F, FontStyle.Bold);
            statistics.ForeColor = Color.FromArgb(30, 30, 30);
            statistics.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            statistics.HoverState.ForeColor = Color.DarkGray;
            statistics.Image = Properties.Resources.data_usage;
            statistics.ImageAlign = HorizontalAlignment.Left;
            statistics.ImageSize = new Size(30, 30);
            statistics.Location = new Point(0, 293);
            statistics.Margin = new Padding(3, 4, 3, 4);
            statistics.Name = "statistics";
            statistics.RightToLeft = RightToLeft.No;
            statistics.ShadowDecoration.CustomizableEdges = customizableEdges44;
            statistics.Size = new Size(225, 60);
            statistics.TabIndex = 4;
            statistics.Tag = "Statistics";
            statistics.TextAlign = HorizontalAlignment.Left;
            statistics.Click += statistics_Click;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(30, 30, 30);
            orders.Cursor = Cursors.Hand;
            orders.CustomizableEdges = customizableEdges45;
            orders.DisabledState.BorderColor = Color.DarkGray;
            orders.DisabledState.CustomBorderColor = Color.DarkGray;
            orders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            orders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            orders.FillColor = Color.FromArgb(30, 30, 30);
            orders.Font = new Font("Arial", 12F, FontStyle.Bold);
            orders.ForeColor = Color.FromArgb(30, 30, 30);
            orders.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            orders.HoverState.ForeColor = Color.DarkGray;
            orders.Image = Properties.Resources.shopping_cart;
            orders.ImageAlign = HorizontalAlignment.Left;
            orders.ImageSize = new Size(30, 30);
            orders.Location = new Point(0, 209);
            orders.Margin = new Padding(3, 4, 3, 4);
            orders.Name = "orders";
            orders.RightToLeft = RightToLeft.No;
            orders.ShadowDecoration.CustomizableEdges = customizableEdges46;
            orders.Size = new Size(225, 60);
            orders.TabIndex = 3;
            orders.Tag = "Orders";
            orders.TextAlign = HorizontalAlignment.Left;
            orders.Click += orders_Click;
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(30, 30, 30);
            stocks.Cursor = Cursors.Hand;
            stocks.CustomizableEdges = customizableEdges47;
            stocks.DisabledState.BorderColor = Color.DarkGray;
            stocks.DisabledState.CustomBorderColor = Color.DarkGray;
            stocks.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stocks.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stocks.FillColor = Color.FromArgb(30, 30, 30);
            stocks.Font = new Font("Arial", 12F, FontStyle.Bold);
            stocks.ForeColor = Color.FromArgb(30, 30, 30);
            stocks.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            stocks.HoverState.ForeColor = Color.DarkGray;
            stocks.Image = Properties.Resources.money_graph_with_up_arrow;
            stocks.ImageAlign = HorizontalAlignment.Left;
            stocks.ImageSize = new Size(30, 30);
            stocks.Location = new Point(0, 124);
            stocks.Margin = new Padding(3, 4, 3, 4);
            stocks.Name = "stocks";
            stocks.RightToLeft = RightToLeft.No;
            stocks.ShadowDecoration.CustomizableEdges = customizableEdges48;
            stocks.Size = new Size(225, 60);
            stocks.TabIndex = 2;
            stocks.Tag = "Stocks";
            stocks.TextAlign = HorizontalAlignment.Left;
            stocks.Click += stocks_Click;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.FromArgb(30, 30, 30);
            dashboard.Cursor = Cursors.Hand;
            dashboard.CustomizableEdges = customizableEdges49;
            dashboard.DisabledState.BorderColor = Color.DarkGray;
            dashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboard.FillColor = Color.FromArgb(30, 30, 30);
            dashboard.Font = new Font("Arial", 12F, FontStyle.Bold);
            dashboard.ForeColor = Color.FromArgb(30, 30, 30);
            dashboard.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            dashboard.HoverState.ForeColor = Color.DarkGray;
            dashboard.Image = Properties.Resources.dashboard__1_;
            dashboard.ImageAlign = HorizontalAlignment.Left;
            dashboard.ImageSize = new Size(30, 30);
            dashboard.Location = new Point(0, 37);
            dashboard.Margin = new Padding(3, 4, 3, 4);
            dashboard.Name = "dashboard";
            dashboard.RightToLeft = RightToLeft.No;
            dashboard.ShadowDecoration.CustomizableEdges = customizableEdges50;
            dashboard.Size = new Size(225, 60);
            dashboard.TabIndex = 1;
            dashboard.Tag = "Dashboard";
            dashboard.TextAlign = HorizontalAlignment.Left;
            dashboard.Click += dashboard_Click;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges1;
            btnToggle.DisabledState.BorderColor = Color.DarkGray;
            btnToggle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggle.FillColor = Color.FromArgb(120, 20, 20);
            btnToggle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnToggle.ForeColor = Color.White;
            btnToggle.Location = new Point(0, 0);
            btnToggle.Margin = new Padding(3, 4, 3, 4);
            btnToggle.Name = "btnToggle";
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnToggle.Size = new Size(50, 67);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += btnToggle_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnToggle);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(229, 47);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1137, 69);
            guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 16);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dashboard (1).png");
            imageList1.Images.SetKeyName(1, "data-usage.png");
            imageList1.Images.SetKeyName(2, "logo.jpeg");
            imageList1.Images.SetKeyName(3, "logout (1).png");
            imageList1.Images.SetKeyName(4, "money-graph-with-up-arrow.png");
            imageList1.Images.SetKeyName(5, "parcel.png");
            imageList1.Images.SetKeyName(6, "setting.png");
            imageList1.Images.SetKeyName(7, "shopping-cart.png");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(lbldashboard);
            tabControl1.Controls.Add(lblstocks);
            tabControl1.Controls.Add(lblorder);
            tabControl1.Controls.Add(llblstatistics);
            tabControl1.Controls.Add(lblroles);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(229, 47);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1137, 721);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // lbldashboard
            // 
            lbldashboard.Controls.Add(materialCard1);
            lbldashboard.Controls.Add(materialCard2);
            lbldashboard.Controls.Add(guna2Panel6);
            lbldashboard.Location = new Point(4, 29);
            lbldashboard.Margin = new Padding(3, 4, 3, 4);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Padding = new Padding(3, 4, 3, 4);
            lbldashboard.Size = new Size(1129, 688);
            lbldashboard.TabIndex = 1;
            lbldashboard.Text = "Dashboard";
            lbldashboard.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(gunaChart1);
            materialCard1.Controls.Add(txtTopProduct);
            materialCard1.Controls.Add(notificationIcon);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(72, 63);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(767, 609);
            materialCard1.TabIndex = 3;
            // 
            // gunaChart1
            // 
            gunaChart1.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { gunaHorizontalBarDataset1 });
            chartFont1.FontName = "Arial";
            gunaChart1.Legend.LabelFont = chartFont1;
            gunaChart1.Location = new Point(17, 100);
            gunaChart1.Name = "gunaChart1";
            gunaChart1.Size = new Size(735, 493);
            gunaChart1.TabIndex = 2;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart1.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            gunaChart1.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart1.Tooltips.TitleFont = chartFont4;
            gunaChart1.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            gunaChart1.XAxes.Ticks = tick1;
            gunaChart1.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            gunaChart1.YAxes.Ticks = tick2;
            gunaChart1.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            gunaChart1.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            gunaChart1.ZAxes.Ticks = tick3;
            // 
            // gunaHorizontalBarDataset1
            // 
            lPoint1.Label = "January";
            lPoint1.Y = 12D;
            lPoint2.Label = "February";
            lPoint2.Y = 10D;
            lPoint3.Label = "March";
            lPoint3.Y = 17D;
            lPoint4.Label = "April";
            lPoint4.Y = 20D;
            lPoint5.Label = "May";
            lPoint5.Y = 24D;
            lPoint6.Label = "June";
            lPoint6.Y = 7D;
            lPoint7.Label = "July";
            lPoint7.Y = 16D;
            lPoint8.Label = "August";
            lPoint8.Y = 21D;
            lPoint9.Label = "September";
            lPoint9.Y = 27D;
            lPoint10.Label = "October";
            lPoint10.Y = 30D;
            lPoint11.Label = "November";
            lPoint11.Y = 5D;
            lPoint12.Label = "December";
            lPoint12.Y = 16D;
            gunaHorizontalBarDataset1.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] { lPoint1, lPoint2, lPoint3, lPoint4, lPoint5, lPoint6, lPoint7, lPoint8, lPoint9, lPoint10, lPoint11, lPoint12 });
            gunaHorizontalBarDataset1.FillColors.AddRange(new Color[] { Color.FromArgb(192, 0, 0), Color.FromArgb(255, 128, 128), Color.FromArgb(255, 192, 192), Color.FromArgb(192, 0, 0), Color.FromArgb(255, 128, 128), Color.FromArgb(255, 192, 192), Color.FromArgb(192, 0, 0), Color.FromArgb(255, 128, 128), Color.FromArgb(255, 192, 192), Color.FromArgb(192, 0, 0), Color.FromArgb(255, 128, 128), Color.FromArgb(192, 0, 0) });
            gunaHorizontalBarDataset1.Label = "Stock Levels";
            gunaHorizontalBarDataset1.TargetChart = gunaChart1;
            // 
            // txtTopProduct
            // 
            txtTopProduct.CustomizableEdges = customizableEdges5;
            txtTopProduct.DefaultText = "";
            txtTopProduct.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTopProduct.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTopProduct.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTopProduct.Enabled = false;
            txtTopProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Font = new Font("Segoe UI", 9F);
            txtTopProduct.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTopProduct.Location = new Point(17, 19);
            txtTopProduct.Margin = new Padding(3, 5, 3, 5);
            txtTopProduct.Name = "txtTopProduct";
            txtTopProduct.PasswordChar = '\0';
            txtTopProduct.PlaceholderText = "";
            txtTopProduct.ReadOnly = true;
            txtTopProduct.SelectedText = "";
            txtTopProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTopProduct.Size = new Size(651, 73);
            txtTopProduct.TabIndex = 0;
            // 
            // notificationIcon
            // 
            notificationIcon.CheckedState.ImageSize = new Size(64, 64);
            notificationIcon.HoverState.ImageSize = new Size(64, 64);
            notificationIcon.Image = Properties.Resources.notif;
            notificationIcon.ImageOffset = new Point(0, 0);
            notificationIcon.ImageRotate = 0F;
            notificationIcon.Location = new Point(675, 17);
            notificationIcon.Name = "notificationIcon";
            notificationIcon.PressedState.ImageSize = new Size(64, 64);
            notificationIcon.ShadowDecoration.CustomizableEdges = customizableEdges7;
            notificationIcon.Size = new Size(77, 73);
            notificationIcon.TabIndex = 1;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label3);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(guna2TextBox1);
            materialCard2.Controls.Add(guna2TextBox2);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Right;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(639, 4);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(487, 680);
            materialCard2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 308);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 7;
            label3.Text = "Summary of Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 6;
            label2.Text = "Top Products";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.CustomizableEdges = customizableEdges8;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.Enabled = false;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(17, 103);
            guna2TextBox1.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ReadOnly = true;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2TextBox1.Size = new Size(453, 171);
            guna2TextBox1.TabIndex = 4;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.CustomizableEdges = customizableEdges10;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.Enabled = false;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(17, 357);
            guna2TextBox2.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.ReadOnly = true;
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2TextBox2.Size = new Size(453, 311);
            guna2TextBox2.TabIndex = 5;
            // 
            // guna2Panel6
            // 
            guna2Panel6.CustomizableEdges = customizableEdges12;
            guna2Panel6.Dock = DockStyle.Fill;
            guna2Panel6.Location = new Point(3, 4);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2Panel6.Size = new Size(1123, 680);
            guna2Panel6.TabIndex = 8;
            // 
            // lblstocks
            // 
            lblstocks.Controls.Add(guna2Panel5);
            lblstocks.Location = new Point(4, 29);
            lblstocks.Name = "lblstocks";
            lblstocks.Size = new Size(1129, 688);
            lblstocks.TabIndex = 2;
            lblstocks.Text = "Stocks";
            lblstocks.UseVisualStyleBackColor = true;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Controls.Add(guna2ImageButton1);
            guna2Panel5.Controls.Add(search);
            guna2Panel5.Controls.Add(categoryComboBox);
            guna2Panel5.Controls.Add(materialCard3);
            guna2Panel5.Controls.Add(guna2Panel4);
            guna2Panel5.CustomizableEdges = customizableEdges21;
            guna2Panel5.Dock = DockStyle.Fill;
            guna2Panel5.ForeColor = Color.DimGray;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Panel5.Size = new Size(1129, 688);
            guna2Panel5.TabIndex = 6;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Cursor = Cursors.Hand;
            guna2ImageButton1.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton1.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(35, 35);
            guna2ImageButton1.Location = new Point(578, 54);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ImageButton1.Size = new Size(35, 35);
            guna2ImageButton1.TabIndex = 1;
            // 
            // search
            // 
            search.BorderColor = Color.Maroon;
            search.BorderRadius = 16;
            search.BorderThickness = 2;
            search.CustomizableEdges = customizableEdges15;
            search.DefaultText = "Search Product";
            search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Font = new Font("Segoe UI", 9F);
            search.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            search.Location = new Point(63, 54);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.PasswordChar = '\0';
            search.PlaceholderText = "";
            search.SelectedText = "";
            search.ShadowDecoration.CustomizableEdges = customizableEdges16;
            search.Size = new Size(509, 36);
            search.TabIndex = 0;
            search.Tag = "Search Product";
            search.Enter += search_Enter;
            search.Leave += search_Leave;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.Transparent;
            categoryComboBox.BorderColor = Color.Maroon;
            categoryComboBox.BorderRadius = 16;
            categoryComboBox.BorderThickness = 2;
            categoryComboBox.CustomizableEdges = customizableEdges17;
            categoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            categoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryComboBox.Font = new Font("Segoe UI", 10F);
            categoryComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            categoryComboBox.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            categoryComboBox.ItemHeight = 30;
            categoryComboBox.Items.AddRange(new object[] { "Rice Bowls", "Bento" });
            categoryComboBox.Location = new Point(657, 54);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges18;
            categoryComboBox.Size = new Size(200, 36);
            categoryComboBox.TabIndex = 4;
            categoryComboBox.Tag = "Category";
            categoryComboBox.TextAlign = HorizontalAlignment.Center;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label4);
            materialCard3.Controls.Add(materialCard4);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Right;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(858, 0);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(271, 688);
            materialCard3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 57);
            label4.Name = "label4";
            label4.Size = new Size(215, 40);
            label4.TabIndex = 1;
            label4.Text = "Top Product";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(17, 111);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(219, 335);
            materialCard4.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.LightCoral;
            guna2Panel4.Controls.Add(guna2VScrollBar1);
            guna2Panel4.CustomizableEdges = customizableEdges19;
            guna2Panel4.Location = new Point(63, 111);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel4.Size = new Size(1003, 581);
            guna2Panel4.TabIndex = 5;
            // 
            // guna2VScrollBar1
            // 
            guna2VScrollBar1.BorderRadius = 7;
            guna2VScrollBar1.Dock = DockStyle.Right;
            guna2VScrollBar1.FillColor = Color.Transparent;
            guna2VScrollBar1.InUpdate = false;
            guna2VScrollBar1.LargeChange = 10;
            guna2VScrollBar1.Location = new Point(988, 0);
            guna2VScrollBar1.Name = "guna2VScrollBar1";
            guna2VScrollBar1.ScrollbarSize = 15;
            guna2VScrollBar1.Size = new Size(15, 581);
            guna2VScrollBar1.TabIndex = 0;
            guna2VScrollBar1.ThumbColor = Color.Maroon;
            // 
            // lblorder
            // 
            lblorder.Controls.Add(guna2ImageButton2);
            lblorder.Controls.Add(guna2TextBox3);
            lblorder.Controls.Add(guna2ComboBox1);
            lblorder.Controls.Add(materialCard5);
            lblorder.Location = new Point(4, 29);
            lblorder.Name = "lblorder";
            lblorder.Size = new Size(1129, 688);
            lblorder.TabIndex = 3;
            lblorder.Text = "Orders";
            lblorder.UseVisualStyleBackColor = true;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.Cursor = Cursors.Hand;
            guna2ImageButton2.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton2.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.ImageSize = new Size(35, 35);
            guna2ImageButton2.Location = new Point(826, 57);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges23;
            guna2ImageButton2.Size = new Size(35, 35);
            guna2ImageButton2.TabIndex = 6;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox3.BorderColor = Color.Maroon;
            guna2TextBox3.BorderRadius = 16;
            guna2TextBox3.BorderThickness = 2;
            guna2TextBox3.CustomizableEdges = customizableEdges24;
            guna2TextBox3.DefaultText = "Search Product";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2TextBox3.Location = new Point(311, 57);
            guna2TextBox3.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PasswordChar = '\0';
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges25;
            guna2TextBox3.Size = new Size(509, 36);
            guna2TextBox3.TabIndex = 5;
            guna2TextBox3.Tag = "Search Product";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.Maroon;
            guna2ComboBox1.BorderRadius = 16;
            guna2ComboBox1.BorderThickness = 2;
            guna2ComboBox1.CustomizableEdges = customizableEdges26;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "Rice Bowls", "Bento" });
            guna2ComboBox1.Location = new Point(905, 57);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges27;
            guna2ComboBox1.Size = new Size(200, 36);
            guna2ComboBox1.TabIndex = 7;
            guna2ComboBox1.Tag = "Category";
            guna2ComboBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Depth = 0;
            materialCard5.Dock = DockStyle.Left;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(0, 0);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(403, 688);
            materialCard5.TabIndex = 0;
            // 
            // llblstatistics
            // 
            llblstatistics.Controls.Add(materialCard6);
            llblstatistics.Controls.Add(gunaChart4);
            llblstatistics.Controls.Add(gunaChart3);
            llblstatistics.Controls.Add(gunaChart2);
            llblstatistics.Location = new Point(4, 29);
            llblstatistics.Name = "llblstatistics";
            llblstatistics.Size = new Size(1129, 688);
            llblstatistics.TabIndex = 4;
            llblstatistics.Text = "Statistics";
            llblstatistics.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Depth = 0;
            materialCard6.Dock = DockStyle.Right;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(741, 0);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(388, 688);
            materialCard6.TabIndex = 3;
            // 
            // gunaChart4
            // 
            chartFont9.FontName = "Arial";
            gunaChart4.Legend.LabelFont = chartFont9;
            gunaChart4.Location = new Point(52, 308);
            gunaChart4.Name = "gunaChart4";
            gunaChart4.Size = new Size(672, 372);
            gunaChart4.TabIndex = 2;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart4.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            gunaChart4.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart4.Tooltips.TitleFont = chartFont12;
            gunaChart4.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            gunaChart4.XAxes.Ticks = tick4;
            gunaChart4.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            gunaChart4.YAxes.Ticks = tick5;
            gunaChart4.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            gunaChart4.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            gunaChart4.ZAxes.Ticks = tick6;
            // 
            // gunaChart3
            // 
            chartFont17.FontName = "Arial";
            gunaChart3.Legend.LabelFont = chartFont17;
            gunaChart3.Location = new Point(400, 64);
            gunaChart3.Name = "gunaChart3";
            gunaChart3.Size = new Size(324, 226);
            gunaChart3.TabIndex = 1;
            chartFont18.FontName = "Arial";
            chartFont18.Size = 12;
            chartFont18.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart3.Title.Font = chartFont18;
            chartFont19.FontName = "Arial";
            gunaChart3.Tooltips.BodyFont = chartFont19;
            chartFont20.FontName = "Arial";
            chartFont20.Size = 9;
            chartFont20.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart3.Tooltips.TitleFont = chartFont20;
            gunaChart3.XAxes.GridLines = grid7;
            chartFont21.FontName = "Arial";
            tick7.Font = chartFont21;
            gunaChart3.XAxes.Ticks = tick7;
            gunaChart3.YAxes.GridLines = grid8;
            chartFont22.FontName = "Arial";
            tick8.Font = chartFont22;
            gunaChart3.YAxes.Ticks = tick8;
            gunaChart3.ZAxes.GridLines = grid9;
            chartFont23.FontName = "Arial";
            pointLabel3.Font = chartFont23;
            gunaChart3.ZAxes.PointLabels = pointLabel3;
            chartFont24.FontName = "Arial";
            tick9.Font = chartFont24;
            gunaChart3.ZAxes.Ticks = tick9;
            // 
            // gunaChart2
            // 
            chartFont25.FontName = "Arial";
            gunaChart2.Legend.LabelFont = chartFont25;
            gunaChart2.Location = new Point(52, 64);
            gunaChart2.Name = "gunaChart2";
            gunaChart2.Size = new Size(324, 226);
            gunaChart2.TabIndex = 0;
            chartFont26.FontName = "Arial";
            chartFont26.Size = 12;
            chartFont26.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart2.Title.Font = chartFont26;
            chartFont27.FontName = "Arial";
            gunaChart2.Tooltips.BodyFont = chartFont27;
            chartFont28.FontName = "Arial";
            chartFont28.Size = 9;
            chartFont28.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart2.Tooltips.TitleFont = chartFont28;
            gunaChart2.XAxes.GridLines = grid10;
            chartFont29.FontName = "Arial";
            tick10.Font = chartFont29;
            gunaChart2.XAxes.Ticks = tick10;
            gunaChart2.YAxes.GridLines = grid11;
            chartFont30.FontName = "Arial";
            tick11.Font = chartFont30;
            gunaChart2.YAxes.Ticks = tick11;
            gunaChart2.ZAxes.GridLines = grid12;
            chartFont31.FontName = "Arial";
            pointLabel4.Font = chartFont31;
            gunaChart2.ZAxes.PointLabels = pointLabel4;
            chartFont32.FontName = "Arial";
            tick12.Font = chartFont32;
            gunaChart2.ZAxes.Ticks = tick12;
            // 
            // lblroles
            // 
            lblroles.Controls.Add(guna2DataGridView2);
            lblroles.Controls.Add(guna2DataGridView1);
            lblroles.Controls.Add(panel1);
            lblroles.Location = new Point(4, 29);
            lblroles.Name = "lblroles";
            lblroles.Size = new Size(1129, 688);
            lblroles.TabIndex = 5;
            lblroles.Text = "Roles";
            lblroles.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView2.ColumnHeadersHeight = 4;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView2.Dock = DockStyle.Fill;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(72, 125);
            guna2DataGridView2.Margin = new Padding(5);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.Size = new Size(1057, 563);
            guna2DataGridView2.TabIndex = 11;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView2.ThemeStyle.ReadOnly = false;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.Dock = DockStyle.Left;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 125);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(72, 563);
            guna2DataGridView1.TabIndex = 9;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2TextBox4);
            panel1.Controls.Add(guna2ImageButton3);
            panel1.Controls.Add(guna2GradientPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 125);
            panel1.TabIndex = 10;
            // 
            // guna2TextBox4
            // 
            guna2TextBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox4.BorderColor = Color.Maroon;
            guna2TextBox4.BorderRadius = 16;
            guna2TextBox4.BorderThickness = 2;
            guna2TextBox4.CustomizableEdges = customizableEdges28;
            guna2TextBox4.DefaultText = "Search Product";
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Segoe UI", 9F);
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2TextBox4.Location = new Point(293, 58);
            guna2TextBox4.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PasswordChar = '\0';
            guna2TextBox4.PlaceholderText = "";
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges29;
            guna2TextBox4.Size = new Size(509, 36);
            guna2TextBox4.TabIndex = 7;
            guna2TextBox4.Tag = "Search Product";
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Cursor = Cursors.Hand;
            guna2ImageButton3.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton3.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.ImageSize = new Size(35, 35);
            guna2ImageButton3.Location = new Point(808, 58);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges30;
            guna2ImageButton3.Size = new Size(35, 35);
            guna2ImageButton3.TabIndex = 8;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientPanel1.Controls.Add(guna2Button1);
            guna2GradientPanel1.Controls.Add(guna2Button2);
            guna2GradientPanel1.CustomizableEdges = customizableEdges35;
            guna2GradientPanel1.Location = new Point(271, 48);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges36;
            guna2GradientPanel1.Size = new Size(850, 60);
            guna2GradientPanel1.TabIndex = 10;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.BackColor = Color.FromArgb(30, 30, 30);
            guna2Button1.BorderColor = Color.White;
            guna2Button1.BorderThickness = 5;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges31;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.Maroon;
            guna2Button1.HoverState.ForeColor = Color.DarkGray;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(620, 0);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2Button1.Size = new Size(115, 60);
            guna2Button1.TabIndex = 8;
            guna2Button1.Tag = "";
            guna2Button1.Text = "ADD";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.FromArgb(30, 30, 30);
            guna2Button2.BorderColor = Color.White;
            guna2Button2.BorderThickness = 5;
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges33;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(120, 20, 20);
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.HoverState.FillColor = Color.Maroon;
            guna2Button2.HoverState.ForeColor = Color.DarkGray;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.ImageSize = new Size(30, 30);
            guna2Button2.Location = new Point(735, 0);
            guna2Button2.Margin = new Padding(3, 4, 3, 4);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges34;
            guna2Button2.Size = new Size(115, 60);
            guna2Button2.TabIndex = 9;
            guna2Button2.Tag = "";
            guna2Button2.Text = "DELETE";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(guna2Panel1);
            Controls.Add(tabControl1);
            Controls.Add(sidebarPanel);
            Controls.Add(guna2Taskbar);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load;
            guna2Taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            lbldashboard.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            lblstocks.ResumeLayout(false);
            guna2Panel5.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            guna2Panel4.ResumeLayout(false);
            lblorder.ResumeLayout(false);
            llblstatistics.ResumeLayout(false);
            lblroles.ResumeLayout(false);
            ((ISupportInitialize)guna2DataGridView2).EndInit();
            ((ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna2Panel sidebarPanel;
        private Guna2Button btnToggle;
        private Guna2Button logout;
        private Guna2Panel guna2Panel1;
        private ImageList imageList1;
        protected Guna2Button dashboard;
        protected Guna2Button roles;
        protected Guna2Button statistics;
        protected Guna2Button orders;
        protected Guna2Button stocks;
        private Guna2Panel guna2Panel2;
        private TabControl tabControl1;
        private TabPage lbldashboard;
        private TabPage lblstocks;
        private TabPage lblorder;
        private TabPage llblstatistics;
        private TabPage lblroles;
        private Guna2ImageButton notificationIcon;
        private Guna2TextBox txtTopProduct;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna2TextBox guna2TextBox2;
        private Guna2TextBox guna2TextBox1;
        private Label label1;
        private Guna2TextBox search;
        private Guna2ImageButton guna2ImageButton1;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaHorizontalBarDataset gunaHorizontalBarDataset1;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label3;
        private Guna2ComboBox categoryComboBox;
        private Guna2Panel guna2Panel4;
        private Guna2VScrollBar guna2VScrollBar1;
        private Guna2Panel guna2Panel6;
        private Guna2Panel guna2Panel5;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Guna2ImageButton guna2ImageButton2;
        private Guna2TextBox guna2TextBox3;
        private Guna2ComboBox guna2ComboBox1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private Guna.Charts.WinForms.GunaChart gunaChart4;
        private Guna.Charts.WinForms.GunaChart gunaChart3;
        private Guna.Charts.WinForms.GunaChart gunaChart2;
        private Guna2DataGridView guna2DataGridView1;
        private Guna2ImageButton guna2ImageButton3;
        private Guna2TextBox guna2TextBox4;
        private Panel panel1;
        private Guna2DataGridView guna2DataGridView2;
        private Guna2Button guna2Button1;
        private Guna2Button guna2Button2;
        private Guna2GradientPanel guna2GradientPanel1;
    }
}
