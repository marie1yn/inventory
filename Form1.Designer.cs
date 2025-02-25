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
        private Guna2Panel taskbar;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges108 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges109 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges104 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges105 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges106 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges107 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges102 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges103 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges88 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges89 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges90 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges91 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges92 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges93 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges94 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges95 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges96 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges97 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges98 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges99 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges100 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges101 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges51 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges52 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges55 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges56 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges53 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges54 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges57 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges58 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges59 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges60 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges61 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges62 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges63 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges76 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges77 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges66 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges67 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges64 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges65 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges68 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges69 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges70 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges71 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges72 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges73 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges74 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges75 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges78 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges86 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges87 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges79 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges80 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges81 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges82 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges83 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges84 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges85 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            taskbar = new Guna2Panel();
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
            guna2ImageButton4 = new Guna2ImageButton();
            label1 = new Label();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            lbldashboard = new TabPage();
            guna2Panel12 = new Guna2Panel();
            btnsales_dashboard = new Guna2Button();
            guna2ComboBox2 = new Guna2ComboBox();
            guna2DataGridView4 = new Guna2DataGridView();
            label12 = new Label();
            guna2Panel7 = new Guna2Panel();
            guna2Panel21 = new Guna2Panel();
            label25 = new Label();
            label26 = new Label();
            guna2Panel10 = new Guna2Panel();
            guna2CirclePictureBox3 = new Guna2CirclePictureBox();
            label8 = new Label();
            label9 = new Label();
            guna2Panel11 = new Guna2Panel();
            guna2CirclePictureBox4 = new Guna2CirclePictureBox();
            label10 = new Label();
            label11 = new Label();
            guna2Panel9 = new Guna2Panel();
            guna2CirclePictureBox2 = new Guna2CirclePictureBox();
            label6 = new Label();
            label7 = new Label();
            guna2Panel8 = new Guna2Panel();
            guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            label3 = new Label();
            label2 = new Label();
            guna2Panel6 = new Guna2Panel();
            lblstocks = new TabPage();
            guna2Panel5 = new Guna2Panel();
            guna2Panel13 = new Guna2Panel();
            searchStocks = new Guna2TextBox();
            guna2ImageButton1 = new Guna2ImageButton();
            stockPanel = new Guna2Panel();
            stockPanel1 = new FlowLayoutPanel();
            stockPanel_scroll = new Guna2VScrollBar();
            categoryComboBox = new Guna2ComboBox();
            guna2Panel15 = new Guna2Panel();
            guna2Button4 = new Guna2Button();
            guna2Button3 = new Guna2Button();
            label4 = new Label();
            guna2Panel16 = new Guna2Panel();
            guna2PictureBox1 = new Guna2PictureBox();
            label15 = new Label();
            label14 = new Label();
            manageBtn = new Guna2Button();
            label13 = new Label();
            lblorder = new TabPage();
            guna2Panel14 = new Guna2Panel();
            guna2Button5 = new Guna2Button();
            guna2DataGridView5 = new Guna2DataGridView();
            label16 = new Label();
            orderPanel = new Guna2Panel();
            orderPanel_scroll = new Guna2VScrollBar();
            guna2ImageButton2 = new Guna2ImageButton();
            searchOrder = new Guna2TextBox();
            guna2ComboBox1 = new Guna2ComboBox();
            lblstatistics = new TabPage();
            guna2Panel3 = new Guna2Panel();
            guna2Panel20 = new Guna2Panel();
            guna2DataGridView6 = new Guna2DataGridView();
            guna2ComboBox3 = new Guna2ComboBox();
            guna2Chart1 = new Guna.Charts.WinForms.GunaChart();
            guna2Panel4 = new Guna2Panel();
            label17 = new Label();
            label18 = new Label();
            guna2Panel17 = new Guna2Panel();
            label19 = new Label();
            label20 = new Label();
            guna2Panel18 = new Guna2Panel();
            label21 = new Label();
            label22 = new Label();
            guna2Panel19 = new Guna2Panel();
            label23 = new Label();
            label24 = new Label();
            lblroles = new TabPage();
            guna2DataGridView2 = new Guna2DataGridView();
            guna2DataGridView1 = new Guna2DataGridView();
            panel1 = new Panel();
            label27 = new Label();
            guna2CirclePictureBox5 = new Guna2CirclePictureBox();
            guna2GradientPanel1 = new Guna2GradientPanel();
            guna2Button1 = new Guna2Button();
            guna2Button2 = new Guna2Button();
            guna2ImageButton3 = new Guna2ImageButton();
            searchRoles = new Guna2TextBox();
            label5 = new Label();
            guna2DataGridView3 = new Guna2DataGridView();
            gunaStackedBarDataset1 = new Guna.Charts.WinForms.GunaStackedBarDataset();
            gunaHorizontalBarDataset1 = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            gunaSteppedLineDataset1 = new Guna.Charts.WinForms.GunaSteppedLineDataset();
            tileBtn = new Guna2Transition();
            gunaLineDataset1 = new Guna.Charts.WinForms.GunaLineDataset();
            gunaStackedBarDataset2 = new Guna.Charts.WinForms.GunaStackedBarDataset();
            taskbar.SuspendLayout();
            sidebarPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            lbldashboard.SuspendLayout();
            guna2Panel12.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView4).BeginInit();
            guna2Panel7.SuspendLayout();
            guna2Panel21.SuspendLayout();
            guna2Panel10.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox3).BeginInit();
            guna2Panel11.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox4).BeginInit();
            guna2Panel9.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox2).BeginInit();
            guna2Panel8.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            lblstocks.SuspendLayout();
            guna2Panel5.SuspendLayout();
            guna2Panel13.SuspendLayout();
            stockPanel.SuspendLayout();
            guna2Panel15.SuspendLayout();
            guna2Panel16.SuspendLayout();
            ((ISupportInitialize)guna2PictureBox1).BeginInit();
            lblorder.SuspendLayout();
            guna2Panel14.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView5).BeginInit();
            orderPanel.SuspendLayout();
            lblstatistics.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel20.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView6).BeginInit();
            guna2Panel4.SuspendLayout();
            guna2Panel17.SuspendLayout();
            guna2Panel18.SuspendLayout();
            guna2Panel19.SuspendLayout();
            lblroles.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView2).BeginInit();
            ((ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox5).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView3).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockForm = false;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // taskbar
            // 
            taskbar.Controls.Add(btnClose);
            taskbar.Controls.Add(btnMinimize);
            taskbar.CustomizableEdges = customizableEdges108;
            tileBtn.SetDecoration(taskbar, Guna.UI2.AnimatorNS.DecorationType.None);
            taskbar.Dock = DockStyle.Top;
            taskbar.FillColor = Color.FromArgb(120, 20, 20);
            taskbar.Location = new Point(0, 0);
            taskbar.Margin = new Padding(3, 4, 3, 4);
            taskbar.Name = "taskbar";
            taskbar.ShadowDecoration.CustomizableEdges = customizableEdges109;
            taskbar.Size = new Size(1366, 47);
            taskbar.TabIndex = 0;
            taskbar.MouseDown += taskbar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.CustomizableEdges = customizableEdges104;
            tileBtn.SetDecoration(btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1316, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges105;
            btnClose.Size = new Size(51, 47);
            btnClose.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.CustomizableEdges = customizableEdges106;
            tileBtn.SetDecoration(btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1263, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges107;
            btnMinimize.Size = new Size(51, 47);
            btnMinimize.TabIndex = 1;
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
            sidebarPanel.CustomizableEdges = customizableEdges102;
            tileBtn.SetDecoration(sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 47);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges103;
            sidebarPanel.Size = new Size(229, 721);
            sidebarPanel.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 64);
            guna2Panel2.CustomizableEdges = customizableEdges88;
            tileBtn.SetDecoration(guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel2.Dock = DockStyle.Right;
            guna2Panel2.Location = new Point(226, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges89;
            guna2Panel2.Size = new Size(3, 721);
            guna2Panel2.TabIndex = 7;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges90;
            tileBtn.SetDecoration(logout, Guna.UI2.AnimatorNS.DecorationType.None);
            logout.DisabledState.BorderColor = Color.DarkGray;
            logout.DisabledState.CustomBorderColor = Color.DarkGray;
            logout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logout.FillColor = Color.FromArgb(120, 20, 20);
            logout.Font = new Font("Arial", 12F, FontStyle.Bold);
            logout.ForeColor = Color.White;
            logout.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            logout.HoverState.ForeColor = Color.DarkGray;
            logout.Image = Properties.Resources.logout__1_;
            logout.ImageAlign = HorizontalAlignment.Left;
            logout.ImageSize = new Size(30, 30);
            logout.Location = new Point(0, 637);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges91;
            logout.Size = new Size(225, 60);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            logout.Text = "LOGOUT";
            // 
            // roles
            // 
            roles.BackColor = Color.FromArgb(30, 30, 30);
            roles.Cursor = Cursors.Hand;
            roles.CustomizableEdges = customizableEdges92;
            tileBtn.SetDecoration(roles, Guna.UI2.AnimatorNS.DecorationType.None);
            roles.DisabledState.BorderColor = Color.DarkGray;
            roles.DisabledState.CustomBorderColor = Color.DarkGray;
            roles.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            roles.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            roles.FillColor = Color.FromArgb(30, 30, 30);
            roles.Font = new Font("Arial", 12F, FontStyle.Bold);
            roles.ForeColor = Color.White;
            roles.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            roles.HoverState.ForeColor = Color.DarkGray;
            roles.Image = Properties.Resources.parcel;
            roles.ImageAlign = HorizontalAlignment.Left;
            roles.ImageSize = new Size(30, 30);
            roles.Location = new Point(0, 379);
            roles.Margin = new Padding(3, 4, 3, 4);
            roles.Name = "roles";
            roles.RightToLeft = RightToLeft.No;
            roles.ShadowDecoration.CustomizableEdges = customizableEdges93;
            roles.Size = new Size(225, 60);
            roles.TabIndex = 5;
            roles.Tag = "Roles";
            roles.Text = "Roles";
            roles.TextAlign = HorizontalAlignment.Left;
            roles.Click += roles_Click;
            // 
            // statistics
            // 
            statistics.BackColor = Color.FromArgb(30, 30, 30);
            statistics.Cursor = Cursors.Hand;
            statistics.CustomizableEdges = customizableEdges94;
            tileBtn.SetDecoration(statistics, Guna.UI2.AnimatorNS.DecorationType.None);
            statistics.DisabledState.BorderColor = Color.DarkGray;
            statistics.DisabledState.CustomBorderColor = Color.DarkGray;
            statistics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            statistics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            statistics.FillColor = Color.FromArgb(30, 30, 30);
            statistics.Font = new Font("Arial", 12F, FontStyle.Bold);
            statistics.ForeColor = Color.White;
            statistics.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            statistics.HoverState.ForeColor = Color.DarkGray;
            statistics.Image = Properties.Resources.data_usage;
            statistics.ImageAlign = HorizontalAlignment.Left;
            statistics.ImageSize = new Size(30, 30);
            statistics.Location = new Point(0, 293);
            statistics.Margin = new Padding(3, 4, 3, 4);
            statistics.Name = "statistics";
            statistics.RightToLeft = RightToLeft.No;
            statistics.ShadowDecoration.CustomizableEdges = customizableEdges95;
            statistics.Size = new Size(225, 60);
            statistics.TabIndex = 4;
            statistics.Tag = "Statistics";
            statistics.Text = "Statistics";
            statistics.TextAlign = HorizontalAlignment.Left;
            statistics.Click += statistics_Click;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(30, 30, 30);
            orders.Cursor = Cursors.Hand;
            orders.CustomizableEdges = customizableEdges96;
            tileBtn.SetDecoration(orders, Guna.UI2.AnimatorNS.DecorationType.None);
            orders.DisabledState.BorderColor = Color.DarkGray;
            orders.DisabledState.CustomBorderColor = Color.DarkGray;
            orders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            orders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            orders.FillColor = Color.FromArgb(30, 30, 30);
            orders.Font = new Font("Arial", 12F, FontStyle.Bold);
            orders.ForeColor = Color.White;
            orders.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            orders.HoverState.ForeColor = Color.DarkGray;
            orders.Image = Properties.Resources.shopping_cart;
            orders.ImageAlign = HorizontalAlignment.Left;
            orders.ImageSize = new Size(30, 30);
            orders.Location = new Point(0, 209);
            orders.Margin = new Padding(3, 4, 3, 4);
            orders.Name = "orders";
            orders.RightToLeft = RightToLeft.No;
            orders.ShadowDecoration.CustomizableEdges = customizableEdges97;
            orders.Size = new Size(225, 60);
            orders.TabIndex = 3;
            orders.Tag = "Orders";
            orders.Text = "Orders";
            orders.TextAlign = HorizontalAlignment.Left;
            orders.Click += orders_Click;
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(30, 30, 30);
            stocks.Cursor = Cursors.Hand;
            stocks.CustomizableEdges = customizableEdges98;
            tileBtn.SetDecoration(stocks, Guna.UI2.AnimatorNS.DecorationType.None);
            stocks.DisabledState.BorderColor = Color.DarkGray;
            stocks.DisabledState.CustomBorderColor = Color.DarkGray;
            stocks.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stocks.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stocks.FillColor = Color.FromArgb(30, 30, 30);
            stocks.Font = new Font("Arial", 12F, FontStyle.Bold);
            stocks.ForeColor = Color.White;
            stocks.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            stocks.HoverState.ForeColor = Color.DarkGray;
            stocks.Image = Properties.Resources.money_graph_with_up_arrow;
            stocks.ImageAlign = HorizontalAlignment.Left;
            stocks.ImageSize = new Size(30, 30);
            stocks.Location = new Point(0, 124);
            stocks.Margin = new Padding(3, 4, 3, 4);
            stocks.Name = "stocks";
            stocks.RightToLeft = RightToLeft.No;
            stocks.ShadowDecoration.CustomizableEdges = customizableEdges99;
            stocks.Size = new Size(225, 60);
            stocks.TabIndex = 2;
            stocks.Tag = "Stocks";
            stocks.Text = "Stocks";
            stocks.TextAlign = HorizontalAlignment.Left;
            stocks.Click += stocks_Click;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.FromArgb(30, 30, 30);
            dashboard.Cursor = Cursors.Hand;
            dashboard.CustomizableEdges = customizableEdges100;
            tileBtn.SetDecoration(dashboard, Guna.UI2.AnimatorNS.DecorationType.None);
            dashboard.DisabledState.BorderColor = Color.DarkGray;
            dashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboard.FillColor = Color.FromArgb(30, 30, 30);
            dashboard.Font = new Font("Arial", 12F, FontStyle.Bold);
            dashboard.ForeColor = Color.White;
            dashboard.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            dashboard.HoverState.ForeColor = Color.DarkGray;
            dashboard.Image = Properties.Resources.dashboard__1_;
            dashboard.ImageAlign = HorizontalAlignment.Left;
            dashboard.ImageSize = new Size(30, 30);
            dashboard.Location = new Point(0, 37);
            dashboard.Margin = new Padding(3, 4, 3, 4);
            dashboard.Name = "dashboard";
            dashboard.RightToLeft = RightToLeft.No;
            dashboard.ShadowDecoration.CustomizableEdges = customizableEdges101;
            dashboard.Size = new Size(225, 60);
            dashboard.TabIndex = 1;
            dashboard.Tag = "Dashboard";
            dashboard.Text = "Dashboard";
            dashboard.TextAlign = HorizontalAlignment.Left;
            dashboard.Click += dashboard_Click;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges2;
            tileBtn.SetDecoration(btnToggle, Guna.UI2.AnimatorNS.DecorationType.None);
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
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnToggle.Size = new Size(50, 67);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "☰";
            btnToggle.Click += btnToggle_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2ImageButton4);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnToggle);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            tileBtn.SetDecoration(guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(229, 47);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1137, 69);
            guna2Panel1.TabIndex = 2;
            // 
            // guna2ImageButton4
            // 
            guna2ImageButton4.BackColor = Color.Transparent;
            guna2ImageButton4.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton4.Cursor = Cursors.Hand;
            tileBtn.SetDecoration(guna2ImageButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ImageButton4.Dock = DockStyle.Right;
            guna2ImageButton4.HoverState.ImageSize = new Size(50, 50);
            guna2ImageButton4.Image = Properties.Resources.notif;
            guna2ImageButton4.ImageOffset = new Point(0, 0);
            guna2ImageButton4.ImageRotate = 0F;
            guna2ImageButton4.ImageSize = new Size(45, 45);
            guna2ImageButton4.Location = new Point(1022, 0);
            guna2ImageButton4.Name = "guna2ImageButton4";
            guna2ImageButton4.PressedState.ImageSize = new Size(45, 45);
            guna2ImageButton4.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton4.Size = new Size(115, 69);
            guna2ImageButton4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            tileBtn.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            imageList1.Images.SetKeyName(8, "peso-sign.png");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(lbldashboard);
            tabControl1.Controls.Add(lblstocks);
            tabControl1.Controls.Add(lblorder);
            tabControl1.Controls.Add(lblstatistics);
            tabControl1.Controls.Add(lblroles);
            tileBtn.SetDecoration(tabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            lbldashboard.Controls.Add(guna2Panel12);
            lbldashboard.Controls.Add(guna2Panel7);
            lbldashboard.Controls.Add(guna2Panel6);
            tileBtn.SetDecoration(lbldashboard, Guna.UI2.AnimatorNS.DecorationType.None);
            lbldashboard.Location = new Point(4, 29);
            lbldashboard.Margin = new Padding(3, 4, 3, 4);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Padding = new Padding(3, 4, 3, 4);
            lbldashboard.Size = new Size(1129, 688);
            lbldashboard.TabIndex = 1;
            lbldashboard.Text = "Dashboard";
            lbldashboard.UseVisualStyleBackColor = true;
            // 
            // guna2Panel12
            // 
            guna2Panel12.Controls.Add(btnsales_dashboard);
            guna2Panel12.Controls.Add(guna2ComboBox2);
            guna2Panel12.Controls.Add(guna2DataGridView4);
            guna2Panel12.Controls.Add(label12);
            guna2Panel12.CustomizableEdges = customizableEdges10;
            tileBtn.SetDecoration(guna2Panel12, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel12.Dock = DockStyle.Right;
            guna2Panel12.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel12.Location = new Point(641, 4);
            guna2Panel12.Name = "guna2Panel12";
            guna2Panel12.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Panel12.Size = new Size(485, 680);
            guna2Panel12.TabIndex = 0;
            // 
            // btnsales_dashboard
            // 
            btnsales_dashboard.BorderColor = Color.Maroon;
            btnsales_dashboard.BorderRadius = 15;
            btnsales_dashboard.CustomizableEdges = customizableEdges6;
            tileBtn.SetDecoration(btnsales_dashboard, Guna.UI2.AnimatorNS.DecorationType.None);
            btnsales_dashboard.DisabledState.BorderColor = Color.DarkGray;
            btnsales_dashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsales_dashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsales_dashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsales_dashboard.FillColor = Color.Maroon;
            btnsales_dashboard.Font = new Font("Segoe UI", 9F);
            btnsales_dashboard.ForeColor = Color.White;
            btnsales_dashboard.Location = new Point(384, 60);
            btnsales_dashboard.Name = "btnsales_dashboard";
            btnsales_dashboard.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnsales_dashboard.Size = new Size(75, 36);
            btnsales_dashboard.TabIndex = 6;
            btnsales_dashboard.Text = "See All";
            btnsales_dashboard.Click += btnsales_dashboard_Click;
            // 
            // guna2ComboBox2
            // 
            guna2ComboBox2.BackColor = Color.Transparent;
            guna2ComboBox2.BorderColor = Color.Maroon;
            guna2ComboBox2.BorderRadius = 16;
            guna2ComboBox2.BorderThickness = 2;
            guna2ComboBox2.CustomizableEdges = customizableEdges8;
            tileBtn.SetDecoration(guna2ComboBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox2.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox2.Font = new Font("Segoe UI", 10F);
            guna2ComboBox2.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox2.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2ComboBox2.ItemHeight = 30;
            guna2ComboBox2.Items.AddRange(new object[] { "Today" });
            guna2ComboBox2.Location = new Point(236, 60);
            guna2ComboBox2.Name = "guna2ComboBox2";
            guna2ComboBox2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ComboBox2.Size = new Size(142, 36);
            guna2ComboBox2.TabIndex = 5;
            guna2ComboBox2.Tag = "Category";
            // 
            // guna2DataGridView4
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView4.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView4.ColumnHeadersHeight = 4;
            guna2DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView4, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView4.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView4.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView4.Location = new Point(25, 102);
            guna2DataGridView4.Name = "guna2DataGridView4";
            guna2DataGridView4.RowHeadersVisible = false;
            guna2DataGridView4.RowHeadersWidth = 51;
            guna2DataGridView4.Size = new Size(435, 562);
            guna2DataGridView4.TabIndex = 3;
            guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView4.ThemeStyle.BackColor = Color.FromArgb(235, 192, 192);
            guna2DataGridView4.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView4.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView4.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView4.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView4.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView4.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView4.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView4.ThemeStyle.ReadOnly = false;
            guna2DataGridView4.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView4.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView4.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView4.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            guna2DataGridView4.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView4.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView4.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label12
            // 
            label12.AutoSize = true;
            tileBtn.SetDecoration(label12, Guna.UI2.AnimatorNS.DecorationType.None);
            label12.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(25, 68);
            label12.Name = "label12";
            label12.Size = new Size(85, 25);
            label12.TabIndex = 2;
            label12.Text = "Upsales";
            // 
            // guna2Panel7
            // 
            guna2Panel7.Controls.Add(guna2Panel21);
            guna2Panel7.Controls.Add(guna2Panel10);
            guna2Panel7.Controls.Add(guna2Panel11);
            guna2Panel7.Controls.Add(guna2Panel9);
            guna2Panel7.Controls.Add(guna2Panel8);
            guna2Panel7.CustomizableEdges = customizableEdges26;
            tileBtn.SetDecoration(guna2Panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel7.Location = new Point(0, 0);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges27;
            guna2Panel7.Size = new Size(871, 692);
            guna2Panel7.TabIndex = 0;
            // 
            // guna2Panel21
            // 
            guna2Panel21.BorderColor = Color.Maroon;
            guna2Panel21.BorderRadius = 20;
            guna2Panel21.BorderThickness = 1;
            guna2Panel21.Controls.Add(label25);
            guna2Panel21.Controls.Add(label26);
            guna2Panel21.CustomizableEdges = customizableEdges12;
            tileBtn.SetDecoration(guna2Panel21, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel21.Location = new Point(69, 539);
            guna2Panel21.Name = "guna2Panel21";
            guna2Panel21.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2Panel21.Size = new Size(776, 129);
            guna2Panel21.TabIndex = 4;
            // 
            // label25
            // 
            label25.AutoSize = true;
            tileBtn.SetDecoration(label25, Guna.UI2.AnimatorNS.DecorationType.None);
            label25.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(21, 69);
            label25.Name = "label25";
            label25.Size = new Size(368, 39);
            label25.TabIndex = 1;
            label25.Text = "Chicken Cordon Bleu";
            // 
            // label26
            // 
            label26.AutoSize = true;
            tileBtn.SetDecoration(label26, Guna.UI2.AnimatorNS.DecorationType.None);
            label26.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(21, 33);
            label26.Name = "label26";
            label26.Size = new Size(86, 17);
            label26.TabIndex = 0;
            label26.Text = "Top Product";
            // 
            // guna2Panel10
            // 
            guna2Panel10.BorderColor = Color.Maroon;
            guna2Panel10.BorderRadius = 20;
            guna2Panel10.BorderThickness = 1;
            guna2Panel10.Controls.Add(guna2CirclePictureBox3);
            guna2Panel10.Controls.Add(label8);
            guna2Panel10.Controls.Add(label9);
            guna2Panel10.CustomizableEdges = customizableEdges15;
            tileBtn.SetDecoration(guna2Panel10, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel10.Location = new Point(69, 299);
            guna2Panel10.Name = "guna2Panel10";
            guna2Panel10.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel10.Size = new Size(376, 220);
            guna2Panel10.TabIndex = 3;
            // 
            // guna2CirclePictureBox3
            // 
            tileBtn.SetDecoration(guna2CirclePictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CirclePictureBox3.FillColor = Color.FromArgb(235, 192, 192);
            guna2CirclePictureBox3.Image = Properties.Resources.users_avatar;
            guna2CirclePictureBox3.ImageRotate = 0F;
            guna2CirclePictureBox3.Location = new Point(18, 18);
            guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            guna2CirclePictureBox3.Padding = new Padding(10);
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox3.Size = new Size(60, 60);
            guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox3.TabIndex = 3;
            guna2CirclePictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            tileBtn.SetDecoration(label8, Guna.UI2.AnimatorNS.DecorationType.None);
            label8.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(18, 156);
            label8.Name = "label8";
            label8.Size = new Size(75, 41);
            label8.TabIndex = 1;
            label8.Text = "120";
            // 
            // label9
            // 
            label9.AutoSize = true;
            tileBtn.SetDecoration(label9, Guna.UI2.AnimatorNS.DecorationType.None);
            label9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 116);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 0;
            label9.Text = "Total Client";
            // 
            // guna2Panel11
            // 
            guna2Panel11.BorderColor = Color.Maroon;
            guna2Panel11.BorderRadius = 20;
            guna2Panel11.BorderThickness = 1;
            guna2Panel11.Controls.Add(guna2CirclePictureBox4);
            guna2Panel11.Controls.Add(label10);
            guna2Panel11.Controls.Add(label11);
            guna2Panel11.CustomizableEdges = customizableEdges18;
            tileBtn.SetDecoration(guna2Panel11, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel11.Location = new Point(469, 299);
            guna2Panel11.Name = "guna2Panel11";
            guna2Panel11.ShadowDecoration.CustomizableEdges = customizableEdges19;
            guna2Panel11.Size = new Size(376, 220);
            guna2Panel11.TabIndex = 4;
            // 
            // guna2CirclePictureBox4
            // 
            tileBtn.SetDecoration(guna2CirclePictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CirclePictureBox4.FillColor = Color.FromArgb(235, 192, 192);
            guna2CirclePictureBox4.Image = Properties.Resources.dish;
            guna2CirclePictureBox4.ImageRotate = 0F;
            guna2CirclePictureBox4.Location = new Point(18, 18);
            guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            guna2CirclePictureBox4.Padding = new Padding(10);
            guna2CirclePictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges17;
            guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox4.Size = new Size(60, 60);
            guna2CirclePictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox4.TabIndex = 4;
            guna2CirclePictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            tileBtn.SetDecoration(label10, Guna.UI2.AnimatorNS.DecorationType.None);
            label10.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(18, 156);
            label10.Name = "label10";
            label10.Size = new Size(75, 41);
            label10.TabIndex = 1;
            label10.Text = "101";
            // 
            // label11
            // 
            label11.AutoSize = true;
            tileBtn.SetDecoration(label11, Guna.UI2.AnimatorNS.DecorationType.None);
            label11.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 116);
            label11.Name = "label11";
            label11.Size = new Size(85, 17);
            label11.TabIndex = 0;
            label11.Text = "Total Menus";
            // 
            // guna2Panel9
            // 
            guna2Panel9.BorderColor = Color.Maroon;
            guna2Panel9.BorderRadius = 20;
            guna2Panel9.BorderThickness = 1;
            guna2Panel9.Controls.Add(guna2CirclePictureBox2);
            guna2Panel9.Controls.Add(label6);
            guna2Panel9.Controls.Add(label7);
            guna2Panel9.CustomizableEdges = customizableEdges21;
            tileBtn.SetDecoration(guna2Panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel9.Location = new Point(469, 64);
            guna2Panel9.Name = "guna2Panel9";
            guna2Panel9.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Panel9.Size = new Size(376, 220);
            guna2Panel9.TabIndex = 2;
            // 
            // guna2CirclePictureBox2
            // 
            tileBtn.SetDecoration(guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CirclePictureBox2.FillColor = Color.FromArgb(235, 192, 192);
            guna2CirclePictureBox2.Image = Properties.Resources.order;
            guna2CirclePictureBox2.ImageRotate = 0F;
            guna2CirclePictureBox2.Location = new Point(18, 18);
            guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            guna2CirclePictureBox2.Padding = new Padding(10);
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox2.Size = new Size(60, 60);
            guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox2.TabIndex = 3;
            guna2CirclePictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tileBtn.SetDecoration(label6, Guna.UI2.AnimatorNS.DecorationType.None);
            label6.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 156);
            label6.Name = "label6";
            label6.Size = new Size(75, 41);
            label6.TabIndex = 1;
            label6.Text = "125";
            // 
            // label7
            // 
            label7.AutoSize = true;
            tileBtn.SetDecoration(label7, Guna.UI2.AnimatorNS.DecorationType.None);
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 116);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 0;
            label7.Text = "Total Orders";
            // 
            // guna2Panel8
            // 
            guna2Panel8.BorderColor = Color.Maroon;
            guna2Panel8.BorderRadius = 20;
            guna2Panel8.BorderThickness = 1;
            guna2Panel8.Controls.Add(guna2CirclePictureBox1);
            guna2Panel8.Controls.Add(label3);
            guna2Panel8.Controls.Add(label2);
            guna2Panel8.CustomizableEdges = customizableEdges24;
            tileBtn.SetDecoration(guna2Panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel8.Location = new Point(69, 64);
            guna2Panel8.Name = "guna2Panel8";
            guna2Panel8.ShadowDecoration.CustomizableEdges = customizableEdges25;
            guna2Panel8.Size = new Size(376, 220);
            guna2Panel8.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            tileBtn.SetDecoration(guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CirclePictureBox1.FillColor = Color.FromArgb(235, 192, 192);
            guna2CirclePictureBox1.Image = Properties.Resources.peso_sign;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(18, 18);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.Padding = new Padding(10);
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges23;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(60, 60);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tileBtn.SetDecoration(label3, Guna.UI2.AnimatorNS.DecorationType.None);
            label3.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 156);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 1;
            label3.Text = "Php 0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            tileBtn.SetDecoration(label2, Guna.UI2.AnimatorNS.DecorationType.None);
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 0;
            label2.Text = "Total Revenue";
            // 
            // guna2Panel6
            // 
            guna2Panel6.CustomizableEdges = customizableEdges28;
            tileBtn.SetDecoration(guna2Panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel6.Dock = DockStyle.Fill;
            guna2Panel6.Location = new Point(3, 4);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges29;
            guna2Panel6.Size = new Size(1123, 680);
            guna2Panel6.TabIndex = 8;
            // 
            // lblstocks
            // 
            lblstocks.Controls.Add(guna2Panel5);
            tileBtn.SetDecoration(lblstocks, Guna.UI2.AnimatorNS.DecorationType.None);
            lblstocks.Location = new Point(4, 29);
            lblstocks.Name = "lblstocks";
            lblstocks.Size = new Size(1129, 688);
            lblstocks.TabIndex = 2;
            lblstocks.Text = "Stocks";
            lblstocks.UseVisualStyleBackColor = true;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Controls.Add(guna2Panel13);
            guna2Panel5.Controls.Add(guna2Panel15);
            guna2Panel5.CustomizableEdges = customizableEdges51;
            tileBtn.SetDecoration(guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel5.Dock = DockStyle.Fill;
            guna2Panel5.ForeColor = Color.DimGray;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges52;
            guna2Panel5.Size = new Size(1129, 688);
            guna2Panel5.TabIndex = 6;
            // 
            // guna2Panel13
            // 
            guna2Panel13.BorderColor = Color.Maroon;
            guna2Panel13.BorderThickness = 2;
            guna2Panel13.Controls.Add(searchStocks);
            guna2Panel13.Controls.Add(guna2ImageButton1);
            guna2Panel13.Controls.Add(stockPanel);
            guna2Panel13.Controls.Add(categoryComboBox);
            guna2Panel13.CustomizableEdges = customizableEdges37;
            tileBtn.SetDecoration(guna2Panel13, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel13.Location = new Point(-7, 30);
            guna2Panel13.Name = "guna2Panel13";
            guna2Panel13.ShadowDecoration.CustomizableEdges = customizableEdges38;
            guna2Panel13.Size = new Size(1077, 662);
            guna2Panel13.TabIndex = 6;
            // 
            // searchStocks
            // 
            searchStocks.BorderColor = Color.Maroon;
            searchStocks.BorderRadius = 16;
            searchStocks.BorderThickness = 2;
            searchStocks.CustomizableEdges = customizableEdges30;
            tileBtn.SetDecoration(searchStocks, Guna.UI2.AnimatorNS.DecorationType.None);
            searchStocks.DefaultText = "Search Product";
            searchStocks.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchStocks.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchStocks.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchStocks.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchStocks.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchStocks.Font = new Font("Segoe UI", 9F);
            searchStocks.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            searchStocks.Location = new Point(70, 24);
            searchStocks.Margin = new Padding(3, 4, 3, 4);
            searchStocks.Name = "searchStocks";
            searchStocks.PlaceholderText = "";
            searchStocks.SelectedText = "";
            searchStocks.ShadowDecoration.CustomizableEdges = customizableEdges31;
            searchStocks.Size = new Size(696, 36);
            searchStocks.TabIndex = 0;
            searchStocks.Tag = "Search Product";
            searchStocks.Enter += search_Enter;
            searchStocks.Leave += search_Leave;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Cursor = Cursors.Hand;
            tileBtn.SetDecoration(guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ImageButton1.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton1.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(30, 30);
            guna2ImageButton1.Location = new Point(772, 22);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(30, 30);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2ImageButton1.Size = new Size(40, 40);
            guna2ImageButton1.TabIndex = 1;
            // 
            // stockPanel
            // 
            stockPanel.BackColor = Color.FromArgb(235, 192, 192);
            stockPanel.Controls.Add(stockPanel1);
            stockPanel.Controls.Add(stockPanel_scroll);
            stockPanel.CustomizableEdges = customizableEdges33;
            tileBtn.SetDecoration(stockPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            stockPanel.Location = new Point(70, 77);
            stockPanel.Name = "stockPanel";
            stockPanel.ShadowDecoration.CustomizableEdges = customizableEdges34;
            stockPanel.Size = new Size(995, 581);
            stockPanel.TabIndex = 5;
            // 
            // stockPanel1
            // 
            tileBtn.SetDecoration(stockPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            stockPanel1.Dock = DockStyle.Fill;
            stockPanel1.FlowDirection = FlowDirection.TopDown;
            stockPanel1.Location = new Point(0, 0);
            stockPanel1.Name = "stockPanel1";
            stockPanel1.Padding = new Padding(10);
            stockPanel1.Size = new Size(980, 581);
            stockPanel1.TabIndex = 1;
            stockPanel1.WrapContents = false;
            // 
            // stockPanel_scroll
            // 
            stockPanel_scroll.BorderRadius = 7;
            tileBtn.SetDecoration(stockPanel_scroll, Guna.UI2.AnimatorNS.DecorationType.None);
            stockPanel_scroll.Dock = DockStyle.Right;
            stockPanel_scroll.FillColor = Color.Transparent;
            stockPanel_scroll.InUpdate = false;
            stockPanel_scroll.LargeChange = 10;
            stockPanel_scroll.Location = new Point(980, 0);
            stockPanel_scroll.Name = "stockPanel_scroll";
            stockPanel_scroll.ScrollbarSize = 15;
            stockPanel_scroll.Size = new Size(15, 581);
            stockPanel_scroll.TabIndex = 0;
            stockPanel_scroll.ThumbColor = Color.Maroon;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.Transparent;
            categoryComboBox.BorderColor = Color.Maroon;
            categoryComboBox.BorderRadius = 16;
            categoryComboBox.BorderThickness = 2;
            categoryComboBox.CustomizableEdges = customizableEdges35;
            tileBtn.SetDecoration(categoryComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            categoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            categoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryComboBox.Font = new Font("Segoe UI", 10F);
            categoryComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            categoryComboBox.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            categoryComboBox.ItemHeight = 30;
            categoryComboBox.Items.AddRange(new object[] { "Rice Bowls", "Bento" });
            categoryComboBox.Location = new Point(865, 24);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges36;
            categoryComboBox.Size = new Size(200, 36);
            categoryComboBox.TabIndex = 4;
            categoryComboBox.Tag = "Category";
            // 
            // guna2Panel15
            // 
            guna2Panel15.Controls.Add(guna2Button4);
            guna2Panel15.Controls.Add(guna2Button3);
            guna2Panel15.Controls.Add(label4);
            guna2Panel15.Controls.Add(guna2Panel16);
            guna2Panel15.CustomizableEdges = customizableEdges49;
            tileBtn.SetDecoration(guna2Panel15, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel15.Dock = DockStyle.Right;
            guna2Panel15.Location = new Point(837, 0);
            guna2Panel15.Name = "guna2Panel15";
            guna2Panel15.ShadowDecoration.CustomizableEdges = customizableEdges50;
            guna2Panel15.Size = new Size(292, 688);
            guna2Panel15.TabIndex = 1;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderRadius = 20;
            guna2Button4.Cursor = Cursors.Hand;
            guna2Button4.CustomizableEdges = customizableEdges39;
            tileBtn.SetDecoration(guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.FromArgb(120, 20, 20);
            guna2Button4.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            guna2Button4.HoverState.ForeColor = Color.DarkGray;
            guna2Button4.ImageAlign = HorizontalAlignment.Left;
            guna2Button4.ImageSize = new Size(30, 30);
            guna2Button4.Location = new Point(25, 565);
            guna2Button4.Margin = new Padding(3, 4, 3, 4);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges40;
            guna2Button4.Size = new Size(247, 53);
            guna2Button4.TabIndex = 13;
            guna2Button4.Tag = "";
            guna2Button4.Text = "Add New Product";
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderRadius = 20;
            guna2Button3.Cursor = Cursors.Hand;
            guna2Button3.CustomizableEdges = customizableEdges41;
            tileBtn.SetDecoration(guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.DimGray;
            guna2Button3.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            guna2Button3.HoverState.ForeColor = Color.White;
            guna2Button3.ImageAlign = HorizontalAlignment.Left;
            guna2Button3.ImageSize = new Size(30, 30);
            guna2Button3.Location = new Point(25, 626);
            guna2Button3.Margin = new Padding(3, 4, 3, 4);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges42;
            guna2Button3.Size = new Size(247, 53);
            guna2Button3.TabIndex = 12;
            guna2Button3.Tag = "";
            guna2Button3.Text = "See All Sales";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tileBtn.SetDecoration(label4, Guna.UI2.AnimatorNS.DecorationType.None);
            label4.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 54);
            label4.Name = "label4";
            label4.Size = new Size(212, 41);
            label4.TabIndex = 1;
            label4.Text = "Top Product";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel16
            // 
            guna2Panel16.BorderColor = Color.Black;
            guna2Panel16.BorderRadius = 20;
            guna2Panel16.BorderThickness = 2;
            guna2Panel16.Controls.Add(guna2PictureBox1);
            guna2Panel16.Controls.Add(label15);
            guna2Panel16.Controls.Add(label14);
            guna2Panel16.Controls.Add(manageBtn);
            guna2Panel16.Controls.Add(label13);
            guna2Panel16.CustomizableEdges = customizableEdges47;
            tileBtn.SetDecoration(guna2Panel16, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel16.Location = new Point(22, 110);
            guna2Panel16.Name = "guna2Panel16";
            guna2Panel16.ShadowDecoration.CustomizableEdges = customizableEdges48;
            guna2Panel16.Size = new Size(250, 430);
            guna2Panel16.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges43;
            tileBtn.SetDecoration(guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2PictureBox1.Image = Properties.Resources._51a01bde_2cc6_4016_8417_6a29e78dbe07;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 57);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges44;
            guna2PictureBox1.Size = new Size(244, 250);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 11;
            guna2PictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            tileBtn.SetDecoration(label15, Guna.UI2.AnimatorNS.DecorationType.None);
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(66, 405);
            label15.Name = "label15";
            label15.Size = new Size(123, 17);
            label15.TabIndex = 10;
            label15.Text = "Category: Rice Bowl";
            // 
            // label14
            // 
            label14.AutoSize = true;
            tileBtn.SetDecoration(label14, Guna.UI2.AnimatorNS.DecorationType.None);
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(53, 322);
            label14.Name = "label14";
            label14.Size = new Size(147, 23);
            label14.TabIndex = 9;
            label14.Text = "# about to expire!";
            // 
            // manageBtn
            // 
            manageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            manageBtn.BackColor = Color.FromArgb(30, 30, 30);
            manageBtn.Cursor = Cursors.Hand;
            manageBtn.CustomizableEdges = customizableEdges45;
            tileBtn.SetDecoration(manageBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            manageBtn.DisabledState.BorderColor = Color.DarkGray;
            manageBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            manageBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            manageBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            manageBtn.FillColor = Color.FromArgb(120, 20, 20);
            manageBtn.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            manageBtn.ForeColor = Color.White;
            manageBtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            manageBtn.HoverState.ForeColor = Color.DarkGray;
            manageBtn.ImageAlign = HorizontalAlignment.Left;
            manageBtn.ImageSize = new Size(30, 30);
            manageBtn.Location = new Point(3, 360);
            manageBtn.Margin = new Padding(3, 4, 3, 4);
            manageBtn.Name = "manageBtn";
            manageBtn.ShadowDecoration.CustomizableEdges = customizableEdges46;
            manageBtn.Size = new Size(244, 42);
            manageBtn.TabIndex = 8;
            manageBtn.Tag = "";
            manageBtn.Text = "Manage";
            manageBtn.Click += manageBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            tileBtn.SetDecoration(label13, Guna.UI2.AnimatorNS.DecorationType.None);
            label13.Font = new Font("Arial Nova", 12F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(53, 21);
            label13.Name = "label13";
            label13.Size = new Size(146, 25);
            label13.TabIndex = 0;
            label13.Text = "Product Name";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblorder
            // 
            lblorder.Controls.Add(guna2Panel14);
            lblorder.Controls.Add(orderPanel);
            lblorder.Controls.Add(guna2ImageButton2);
            lblorder.Controls.Add(searchOrder);
            lblorder.Controls.Add(guna2ComboBox1);
            tileBtn.SetDecoration(lblorder, Guna.UI2.AnimatorNS.DecorationType.None);
            lblorder.Location = new Point(4, 29);
            lblorder.Name = "lblorder";
            lblorder.Size = new Size(1129, 688);
            lblorder.TabIndex = 3;
            lblorder.Text = "Orders";
            lblorder.UseVisualStyleBackColor = true;
            // 
            // guna2Panel14
            // 
            guna2Panel14.BorderColor = Color.Maroon;
            guna2Panel14.BorderThickness = 2;
            guna2Panel14.Controls.Add(guna2Button5);
            guna2Panel14.Controls.Add(guna2DataGridView5);
            guna2Panel14.Controls.Add(label16);
            guna2Panel14.CustomBorderThickness = new Padding(0, 0, 2, 0);
            guna2Panel14.CustomizableEdges = customizableEdges55;
            tileBtn.SetDecoration(guna2Panel14, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel14.Dock = DockStyle.Left;
            guna2Panel14.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel14.Location = new Point(0, 0);
            guna2Panel14.Name = "guna2Panel14";
            guna2Panel14.ShadowDecoration.CustomizableEdges = customizableEdges56;
            guna2Panel14.Size = new Size(502, 688);
            guna2Panel14.TabIndex = 9;
            // 
            // guna2Button5
            // 
            guna2Button5.BorderColor = Color.Maroon;
            guna2Button5.BorderRadius = 15;
            guna2Button5.CustomizableEdges = customizableEdges53;
            tileBtn.SetDecoration(guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.Maroon;
            guna2Button5.Font = new Font("Segoe UI", 9F);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Location = new Point(311, 57);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges54;
            guna2Button5.Size = new Size(166, 36);
            guna2Button5.TabIndex = 6;
            guna2Button5.Text = "ADD ORDER";
            // 
            // guna2DataGridView5
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView5.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView5.ColumnHeadersHeight = 4;
            guna2DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView5, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView5.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView5.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView5.Location = new Point(25, 102);
            guna2DataGridView5.Name = "guna2DataGridView5";
            guna2DataGridView5.RowHeadersVisible = false;
            guna2DataGridView5.RowHeadersWidth = 51;
            guna2DataGridView5.Size = new Size(452, 562);
            guna2DataGridView5.TabIndex = 3;
            guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView5.ThemeStyle.BackColor = Color.FromArgb(235, 192, 192);
            guna2DataGridView5.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView5.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView5.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView5.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView5.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView5.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView5.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView5.ThemeStyle.ReadOnly = false;
            guna2DataGridView5.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView5.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView5.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView5.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            guna2DataGridView5.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView5.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView5.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label16
            // 
            label16.AutoSize = true;
            tileBtn.SetDecoration(label16, Guna.UI2.AnimatorNS.DecorationType.None);
            label16.Font = new Font("Arial Nova", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(61, 57);
            label16.Name = "label16";
            label16.Size = new Size(198, 33);
            label16.TabIndex = 2;
            label16.Text = "Order History";
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderPanel.AutoScroll = true;
            orderPanel.Controls.Add(orderPanel_scroll);
            orderPanel.CustomizableEdges = customizableEdges57;
            tileBtn.SetDecoration(orderPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            orderPanel.Location = new Point(310, 115);
            orderPanel.Name = "orderPanel";
            orderPanel.ShadowDecoration.CustomizableEdges = customizableEdges58;
            orderPanel.Size = new Size(818, 577);
            orderPanel.TabIndex = 8;
            // 
            // orderPanel_scroll
            // 
            orderPanel_scroll.BorderRadius = 7;
            tileBtn.SetDecoration(orderPanel_scroll, Guna.UI2.AnimatorNS.DecorationType.None);
            orderPanel_scroll.Dock = DockStyle.Right;
            orderPanel_scroll.FillColor = Color.Transparent;
            orderPanel_scroll.InUpdate = false;
            orderPanel_scroll.LargeChange = 10;
            orderPanel_scroll.Location = new Point(803, 0);
            orderPanel_scroll.Name = "orderPanel_scroll";
            orderPanel_scroll.ScrollbarSize = 15;
            orderPanel_scroll.Size = new Size(15, 577);
            orderPanel_scroll.TabIndex = 9;
            orderPanel_scroll.ThumbColor = Color.Maroon;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.Cursor = Cursors.Hand;
            tileBtn.SetDecoration(guna2ImageButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ImageButton2.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton2.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.ImageSize = new Size(30, 30);
            guna2ImageButton2.Location = new Point(825, 57);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges59;
            guna2ImageButton2.Size = new Size(35, 35);
            guna2ImageButton2.TabIndex = 6;
            // 
            // searchOrder
            // 
            searchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchOrder.BorderColor = Color.Maroon;
            searchOrder.BorderRadius = 16;
            searchOrder.BorderThickness = 2;
            searchOrder.CustomizableEdges = customizableEdges60;
            tileBtn.SetDecoration(searchOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            searchOrder.DefaultText = "Search Order";
            searchOrder.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchOrder.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchOrder.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchOrder.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchOrder.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchOrder.Font = new Font("Segoe UI", 9F);
            searchOrder.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            searchOrder.Location = new Point(310, 57);
            searchOrder.Margin = new Padding(3, 4, 3, 4);
            searchOrder.Name = "searchOrder";
            searchOrder.PlaceholderText = "";
            searchOrder.SelectedText = "";
            searchOrder.ShadowDecoration.CustomizableEdges = customizableEdges61;
            searchOrder.Size = new Size(509, 36);
            searchOrder.TabIndex = 5;
            searchOrder.Tag = "Search Order";
            searchOrder.Enter += search_Enter;
            searchOrder.Leave += search_Leave;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.Maroon;
            guna2ComboBox1.BorderRadius = 16;
            guna2ComboBox1.BorderThickness = 2;
            guna2ComboBox1.CustomizableEdges = customizableEdges62;
            tileBtn.SetDecoration(guna2ComboBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "Rice Bowls", "Bento" });
            guna2ComboBox1.Location = new Point(904, 57);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges63;
            guna2ComboBox1.Size = new Size(200, 36);
            guna2ComboBox1.TabIndex = 7;
            guna2ComboBox1.Tag = "Category";
            // 
            // lblstatistics
            // 
            lblstatistics.Controls.Add(guna2Panel3);
            tileBtn.SetDecoration(lblstatistics, Guna.UI2.AnimatorNS.DecorationType.None);
            lblstatistics.Location = new Point(4, 29);
            lblstatistics.Name = "lblstatistics";
            lblstatistics.Size = new Size(1129, 688);
            lblstatistics.TabIndex = 4;
            lblstatistics.Text = "Statistics";
            lblstatistics.UseVisualStyleBackColor = true;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(guna2Panel20);
            guna2Panel3.Controls.Add(guna2Chart1);
            guna2Panel3.Controls.Add(guna2Panel4);
            guna2Panel3.Controls.Add(guna2Panel17);
            guna2Panel3.Controls.Add(guna2Panel18);
            guna2Panel3.Controls.Add(guna2Panel19);
            guna2Panel3.CustomizableEdges = customizableEdges76;
            tileBtn.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges77;
            guna2Panel3.Size = new Size(1129, 688);
            guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel20
            // 
            guna2Panel20.Controls.Add(guna2DataGridView6);
            guna2Panel20.Controls.Add(guna2ComboBox3);
            guna2Panel20.CustomizableEdges = customizableEdges66;
            tileBtn.SetDecoration(guna2Panel20, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel20.Dock = DockStyle.Right;
            guna2Panel20.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel20.Location = new Point(879, 0);
            guna2Panel20.Name = "guna2Panel20";
            guna2Panel20.ShadowDecoration.CustomizableEdges = customizableEdges67;
            guna2Panel20.Size = new Size(250, 688);
            guna2Panel20.TabIndex = 10;
            // 
            // guna2DataGridView6
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView6.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView6.ColumnHeadersHeight = 4;
            guna2DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView6, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView6.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView6.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView6.Location = new Point(14, 116);
            guna2DataGridView6.Name = "guna2DataGridView6";
            guna2DataGridView6.RowHeadersVisible = false;
            guna2DataGridView6.RowHeadersWidth = 51;
            guna2DataGridView6.Size = new Size(221, 564);
            guna2DataGridView6.TabIndex = 9;
            guna2DataGridView6.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView6.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView6.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView6.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView6.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView6.ThemeStyle.BackColor = Color.FromArgb(235, 192, 192);
            guna2DataGridView6.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView6.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView6.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView6.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView6.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView6.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView6.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView6.ThemeStyle.ReadOnly = false;
            guna2DataGridView6.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView6.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView6.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView6.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            guna2DataGridView6.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView6.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView6.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2ComboBox3
            // 
            guna2ComboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox3.BackColor = Color.Transparent;
            guna2ComboBox3.BorderColor = Color.Maroon;
            guna2ComboBox3.BorderRadius = 16;
            guna2ComboBox3.BorderThickness = 2;
            guna2ComboBox3.CustomizableEdges = customizableEdges64;
            tileBtn.SetDecoration(guna2ComboBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ComboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox3.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox3.Font = new Font("Segoe UI", 10F);
            guna2ComboBox3.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox3.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            guna2ComboBox3.ItemHeight = 30;
            guna2ComboBox3.Items.AddRange(new object[] { "Monthly", "This Week", "Today" });
            guna2ComboBox3.Location = new Point(14, 57);
            guna2ComboBox3.Name = "guna2ComboBox3";
            guna2ComboBox3.ShadowDecoration.CustomizableEdges = customizableEdges65;
            guna2ComboBox3.Size = new Size(221, 36);
            guna2ComboBox3.TabIndex = 8;
            guna2ComboBox3.Tag = "";
            // 
            // guna2Chart1
            // 
            tileBtn.SetDecoration(guna2Chart1, Guna.UI2.AnimatorNS.DecorationType.None);
            chartFont1.FontName = "Arial";
            guna2Chart1.Legend.LabelFont = chartFont1;
            guna2Chart1.Location = new Point(81, 189);
            guna2Chart1.Name = "guna2Chart1";
            guna2Chart1.Size = new Size(1019, 491);
            guna2Chart1.TabIndex = 9;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            guna2Chart1.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            guna2Chart1.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            guna2Chart1.Tooltips.TitleFont = chartFont4;
            guna2Chart1.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            guna2Chart1.XAxes.Ticks = tick1;
            guna2Chart1.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            guna2Chart1.YAxes.Ticks = tick2;
            guna2Chart1.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            guna2Chart1.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            guna2Chart1.ZAxes.Ticks = tick3;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BorderColor = Color.Maroon;
            guna2Panel4.BorderRadius = 20;
            guna2Panel4.BorderThickness = 1;
            guna2Panel4.Controls.Add(label17);
            guna2Panel4.Controls.Add(label18);
            guna2Panel4.CustomizableEdges = customizableEdges68;
            tileBtn.SetDecoration(guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel4.Location = new Point(340, 59);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges69;
            guna2Panel4.Size = new Size(242, 108);
            guna2Panel4.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            tileBtn.SetDecoration(label17, Guna.UI2.AnimatorNS.DecorationType.None);
            label17.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(19, 57);
            label17.Name = "label17";
            label17.Size = new Size(75, 41);
            label17.TabIndex = 1;
            label17.Text = "120";
            // 
            // label18
            // 
            label18.AutoSize = true;
            tileBtn.SetDecoration(label18, Guna.UI2.AnimatorNS.DecorationType.None);
            label18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(19, 17);
            label18.Name = "label18";
            label18.Size = new Size(79, 17);
            label18.TabIndex = 0;
            label18.Text = "Total Client";
            // 
            // guna2Panel17
            // 
            guna2Panel17.BorderColor = Color.Maroon;
            guna2Panel17.BorderRadius = 20;
            guna2Panel17.BorderThickness = 1;
            guna2Panel17.Controls.Add(label19);
            guna2Panel17.Controls.Add(label20);
            guna2Panel17.CustomizableEdges = customizableEdges70;
            tileBtn.SetDecoration(guna2Panel17, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel17.Location = new Point(858, 59);
            guna2Panel17.Name = "guna2Panel17";
            guna2Panel17.ShadowDecoration.CustomizableEdges = customizableEdges71;
            guna2Panel17.Size = new Size(242, 108);
            guna2Panel17.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            tileBtn.SetDecoration(label19, Guna.UI2.AnimatorNS.DecorationType.None);
            label19.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(18, 57);
            label19.Name = "label19";
            label19.Size = new Size(75, 41);
            label19.TabIndex = 1;
            label19.Text = "101";
            // 
            // label20
            // 
            label20.AutoSize = true;
            tileBtn.SetDecoration(label20, Guna.UI2.AnimatorNS.DecorationType.None);
            label20.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(18, 17);
            label20.Name = "label20";
            label20.Size = new Size(85, 17);
            label20.TabIndex = 0;
            label20.Text = "Total Menus";
            // 
            // guna2Panel18
            // 
            guna2Panel18.BorderColor = Color.Maroon;
            guna2Panel18.BorderRadius = 20;
            guna2Panel18.BorderThickness = 1;
            guna2Panel18.Controls.Add(label21);
            guna2Panel18.Controls.Add(label22);
            guna2Panel18.CustomizableEdges = customizableEdges72;
            tileBtn.SetDecoration(guna2Panel18, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel18.Location = new Point(599, 59);
            guna2Panel18.Name = "guna2Panel18";
            guna2Panel18.ShadowDecoration.CustomizableEdges = customizableEdges73;
            guna2Panel18.Size = new Size(242, 108);
            guna2Panel18.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            tileBtn.SetDecoration(label21, Guna.UI2.AnimatorNS.DecorationType.None);
            label21.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(19, 57);
            label21.Name = "label21";
            label21.Size = new Size(75, 41);
            label21.TabIndex = 1;
            label21.Text = "125";
            // 
            // label22
            // 
            label22.AutoSize = true;
            tileBtn.SetDecoration(label22, Guna.UI2.AnimatorNS.DecorationType.None);
            label22.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(19, 17);
            label22.Name = "label22";
            label22.Size = new Size(88, 17);
            label22.TabIndex = 0;
            label22.Text = "Total Orders";
            // 
            // guna2Panel19
            // 
            guna2Panel19.BorderColor = Color.Maroon;
            guna2Panel19.BorderRadius = 20;
            guna2Panel19.BorderThickness = 1;
            guna2Panel19.Controls.Add(label23);
            guna2Panel19.Controls.Add(label24);
            guna2Panel19.CustomizableEdges = customizableEdges74;
            tileBtn.SetDecoration(guna2Panel19, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel19.Location = new Point(81, 59);
            guna2Panel19.Name = "guna2Panel19";
            guna2Panel19.ShadowDecoration.CustomizableEdges = customizableEdges75;
            guna2Panel19.Size = new Size(242, 108);
            guna2Panel19.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            tileBtn.SetDecoration(label23, Guna.UI2.AnimatorNS.DecorationType.None);
            label23.Font = new Font("Arial Nova", 19.8000011F, FontStyle.Bold);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(17, 57);
            label23.Name = "label23";
            label23.Size = new Size(116, 41);
            label23.TabIndex = 1;
            label23.Text = "Php ...";
            // 
            // label24
            // 
            label24.AutoSize = true;
            tileBtn.SetDecoration(label24, Guna.UI2.AnimatorNS.DecorationType.None);
            label24.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(17, 17);
            label24.Name = "label24";
            label24.Size = new Size(100, 17);
            label24.TabIndex = 0;
            label24.Text = "Total Revenue";
            // 
            // lblroles
            // 
            lblroles.Controls.Add(guna2DataGridView2);
            lblroles.Controls.Add(guna2DataGridView1);
            lblroles.Controls.Add(panel1);
            tileBtn.SetDecoration(lblroles, Guna.UI2.AnimatorNS.DecorationType.None);
            lblroles.Location = new Point(4, 29);
            lblroles.Name = "lblroles";
            lblroles.Size = new Size(1129, 688);
            lblroles.TabIndex = 5;
            lblroles.Text = "Roles";
            lblroles.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView2
            // 
            guna2DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            guna2DataGridView2.ColumnHeadersHeight = 4;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView2, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            guna2DataGridView2.Dock = DockStyle.Fill;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(72, 125);
            guna2DataGridView2.Margin = new Padding(5);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView1, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = Color.DimGray;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            guna2DataGridView1.Dock = DockStyle.Left;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 125);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = Color.White;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
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
            panel1.Controls.Add(label27);
            panel1.Controls.Add(guna2CirclePictureBox5);
            panel1.Controls.Add(guna2GradientPanel1);
            tileBtn.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 125);
            panel1.TabIndex = 10;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            tileBtn.SetDecoration(label27, Guna.UI2.AnimatorNS.DecorationType.None);
            label27.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(139, 64);
            label27.Name = "label27";
            label27.Size = new Size(121, 40);
            label27.TabIndex = 3;
            label27.Text = "Admin";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2CirclePictureBox5
            // 
            tileBtn.SetDecoration(guna2CirclePictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CirclePictureBox5.Image = Properties.Resources.account;
            guna2CirclePictureBox5.ImageRotate = 0F;
            guna2CirclePictureBox5.Location = new Point(73, 54);
            guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            guna2CirclePictureBox5.ShadowDecoration.CustomizableEdges = customizableEdges78;
            guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox5.Size = new Size(60, 60);
            guna2CirclePictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox5.TabIndex = 11;
            guna2CirclePictureBox5.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientPanel1.Controls.Add(guna2Button1);
            guna2GradientPanel1.Controls.Add(guna2Button2);
            guna2GradientPanel1.Controls.Add(guna2ImageButton3);
            guna2GradientPanel1.Controls.Add(searchRoles);
            guna2GradientPanel1.CustomizableEdges = customizableEdges86;
            tileBtn.SetDecoration(guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2GradientPanel1.Location = new Point(270, 54);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges87;
            guna2GradientPanel1.Size = new Size(850, 60);
            guna2GradientPanel1.TabIndex = 10;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.White;
            guna2Button1.BorderRadius = 10;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges79;
            tileBtn.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Button1.Location = new Point(617, 10);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges80;
            guna2Button1.Size = new Size(100, 36);
            guna2Button1.TabIndex = 8;
            guna2Button1.Tag = "";
            guna2Button1.Text = "ADD";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.White;
            guna2Button2.BorderRadius = 10;
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges81;
            tileBtn.SetDecoration(guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Button2.Location = new Point(732, 10);
            guna2Button2.Margin = new Padding(3, 4, 3, 4);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges82;
            guna2Button2.Size = new Size(115, 36);
            guna2Button2.TabIndex = 9;
            guna2Button2.Tag = "";
            guna2Button2.Text = "DELETE";
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Cursor = Cursors.Hand;
            tileBtn.SetDecoration(guna2ImageButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ImageButton3.HoverState.ImageSize = new Size(35, 35);
            guna2ImageButton3.Image = Properties.Resources.magnifying_glass;
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.ImageSize = new Size(30, 30);
            guna2ImageButton3.Location = new Point(537, 11);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges83;
            guna2ImageButton3.Size = new Size(35, 35);
            guna2ImageButton3.TabIndex = 8;
            // 
            // searchRoles
            // 
            searchRoles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchRoles.BorderColor = Color.Maroon;
            searchRoles.BorderRadius = 16;
            searchRoles.BorderThickness = 2;
            searchRoles.CustomizableEdges = customizableEdges84;
            tileBtn.SetDecoration(searchRoles, Guna.UI2.AnimatorNS.DecorationType.None);
            searchRoles.DefaultText = "Search...";
            searchRoles.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchRoles.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchRoles.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchRoles.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchRoles.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchRoles.Font = new Font("Segoe UI", 9F);
            searchRoles.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            searchRoles.Location = new Point(22, 10);
            searchRoles.Margin = new Padding(3, 4, 3, 4);
            searchRoles.Name = "searchRoles";
            searchRoles.PlaceholderText = "";
            searchRoles.SelectedText = "";
            searchRoles.ShadowDecoration.CustomizableEdges = customizableEdges85;
            searchRoles.Size = new Size(509, 36);
            searchRoles.TabIndex = 7;
            searchRoles.Tag = "Search...";
            searchRoles.Enter += search_Enter;
            searchRoles.Leave += search_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tileBtn.SetDecoration(label5, Guna.UI2.AnimatorNS.DecorationType.None);
            label5.Location = new Point(17, 48);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // guna2DataGridView3
            // 
            guna2DataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            guna2DataGridView3.ColumnHeadersHeight = 4;
            guna2DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView3, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle20.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle20;
            guna2DataGridView3.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView3.Location = new Point(17, 120);
            guna2DataGridView3.Name = "guna2DataGridView3";
            guna2DataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.White;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = Color.White;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            guna2DataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            guna2DataGridView3.RowHeadersVisible = false;
            guna2DataGridView3.RowHeadersWidth = 51;
            guna2DataGridView3.Size = new Size(354, 548);
            guna2DataGridView3.TabIndex = 0;
            guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView3.ThemeStyle.BackColor = Color.White;
            guna2DataGridView3.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView3.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView3.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView3.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView3.ThemeStyle.ReadOnly = false;
            guna2DataGridView3.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView3.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView3.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView3.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            guna2DataGridView3.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // gunaStackedBarDataset1
            // 
            gunaStackedBarDataset1.Label = "Monthly Sales";
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
            // 
            // gunaSteppedLineDataset1
            // 
            gunaSteppedLineDataset1.BorderColor = Color.Empty;
            gunaSteppedLineDataset1.FillColor = Color.Empty;
            gunaSteppedLineDataset1.Label = "SteppedLine1";
            // 
            // tileBtn
            // 
            tileBtn.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            tileBtn.DefaultAnimation = animation1;
            // 
            // gunaLineDataset1
            // 
            gunaLineDataset1.BorderColor = Color.Empty;
            gunaLineDataset1.FillColor = Color.Empty;
            gunaLineDataset1.Label = "Line1";
            // 
            // gunaStackedBarDataset2
            // 
            gunaStackedBarDataset2.Label = "StackedBar2";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(guna2Panel1);
            Controls.Add(tabControl1);
            Controls.Add(sidebarPanel);
            Controls.Add(taskbar);
            tileBtn.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load;
            taskbar.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            lbldashboard.ResumeLayout(false);
            guna2Panel12.ResumeLayout(false);
            guna2Panel12.PerformLayout();
            ((ISupportInitialize)guna2DataGridView4).EndInit();
            guna2Panel7.ResumeLayout(false);
            guna2Panel21.ResumeLayout(false);
            guna2Panel21.PerformLayout();
            guna2Panel10.ResumeLayout(false);
            guna2Panel10.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox3).EndInit();
            guna2Panel11.ResumeLayout(false);
            guna2Panel11.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox4).EndInit();
            guna2Panel9.ResumeLayout(false);
            guna2Panel9.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox2).EndInit();
            guna2Panel8.ResumeLayout(false);
            guna2Panel8.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox1).EndInit();
            lblstocks.ResumeLayout(false);
            guna2Panel5.ResumeLayout(false);
            guna2Panel13.ResumeLayout(false);
            stockPanel.ResumeLayout(false);
            guna2Panel15.ResumeLayout(false);
            guna2Panel15.PerformLayout();
            guna2Panel16.ResumeLayout(false);
            guna2Panel16.PerformLayout();
            ((ISupportInitialize)guna2PictureBox1).EndInit();
            lblorder.ResumeLayout(false);
            guna2Panel14.ResumeLayout(false);
            guna2Panel14.PerformLayout();
            ((ISupportInitialize)guna2DataGridView5).EndInit();
            orderPanel.ResumeLayout(false);
            lblstatistics.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel20.ResumeLayout(false);
            ((ISupportInitialize)guna2DataGridView6).EndInit();
            guna2Panel4.ResumeLayout(false);
            guna2Panel4.PerformLayout();
            guna2Panel17.ResumeLayout(false);
            guna2Panel17.PerformLayout();
            guna2Panel18.ResumeLayout(false);
            guna2Panel18.PerformLayout();
            guna2Panel19.ResumeLayout(false);
            guna2Panel19.PerformLayout();
            lblroles.ResumeLayout(false);
            ((ISupportInitialize)guna2DataGridView2).EndInit();
            ((ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox5).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ((ISupportInitialize)guna2DataGridView3).EndInit();
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
        private TabPage lblstatistics;
        private TabPage lblroles;
        private Label label1;
        private Guna2TextBox searchStocks;
        private Guna2ImageButton guna2ImageButton1;
        private Guna.Charts.WinForms.GunaHorizontalBarDataset gunaHorizontalBarDataset1;
        private Guna2ComboBox categoryComboBox;
        private Guna2Panel stockPanel;
        private Guna2VScrollBar stockPanel_scroll;
        private Guna2Panel guna2Panel6;
        private Guna2ImageButton guna2ImageButton2;
        private Guna2TextBox searchOrder;
        private Guna2ComboBox guna2ComboBox1;
        private Guna2DataGridView guna2DataGridView1;
        private Guna2ImageButton guna2ImageButton3;
        private Guna2TextBox searchRoles;
        private Panel panel1;
        private Guna2DataGridView guna2DataGridView2;
        private Guna2Button guna2Button1;
        private Guna2Button guna2Button2;
        private Guna2GradientPanel guna2GradientPanel1;
        private Guna.Charts.WinForms.GunaStackedBarDataset gunaStackedBarDataset1;
        private Guna.Charts.WinForms.GunaSteppedLineDataset gunaSteppedLineDataset1;
        private Guna2Panel orderPanel;
        private Guna2VScrollBar orderPanel_scroll;
        private Label label5;
        private Guna2DataGridView guna2DataGridView3;
        private Guna2Panel guna2Panel7;
        private Guna2Transition tileBtn;
        private Guna2Panel guna2Panel8;
        private Guna2Panel guna2Panel12;
        private Guna2Panel guna2Panel9;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Guna2DataGridView guna2DataGridView4;
        private Label label12;
        private Guna2Panel guna2Panel10;
        private Label label8;
        private Label label9;
        private Guna2Panel guna2Panel11;
        private Label label10;
        private Label label11;
        private Guna2ComboBox guna2ComboBox2;
        private Guna2Button btnsales_dashboard;
        private Guna2Panel guna2Panel13;
        private Guna2Panel guna2Panel5;
        private Guna2Panel guna2Panel15;
        private Label productName;
        private Label label13;
        private Label label4;
        private Guna2Panel guna2Panel16;
        private Label label14;
        private Guna2Button manageBtn;
        private Guna2ImageButton guna2ImageButton4;
        private Label label15;
        private Guna2PictureBox guna2PictureBox1;
        private Guna2Button guna2Button3;
        private Guna2Button guna2Button4;
        private Guna2Panel guna2Panel14;
        private Guna2Button guna2Button5;
        private Guna2DataGridView guna2DataGridView5;
        private Label label16;
        private Guna2Panel guna2Panel3;
        private Guna2Panel guna2Panel4;
        private Label label17;
        private Label label18;
        private Guna2Panel guna2Panel17;
        private Label label19;
        private Label label20;
        private Guna2Panel guna2Panel18;
        private Label label21;
        private Label label22;
        private Guna2Panel guna2Panel19;
        private Label label23;
        private Label label24;
        private Guna.Charts.WinForms.GunaChart guna2Chart1;
        private Guna.Charts.WinForms.GunaLineDataset gunaLineDataset1;
        private Guna.Charts.WinForms.GunaStackedBarDataset gunaStackedBarDataset2;
        private Guna2Panel guna2Panel20;
        private Guna2DataGridView guna2DataGridView6;
        private Guna2ComboBox guna2ComboBox3;
        private Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna2Panel guna2Panel21;
        private Label label25;
        private Label label26;
        private FlowLayoutPanel stockPanel1;
        private Label label27;
        private Guna2CirclePictureBox guna2CirclePictureBox5;
    }
}
