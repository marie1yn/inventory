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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges142 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges143 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges138 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges139 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges140 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges141 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges156 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges157 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges144 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges145 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges146 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges147 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges148 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges149 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges150 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges151 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges152 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges153 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges154 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges155 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges158 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges159 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges161 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges162 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges160 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges167 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges168 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges163 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges164 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges165 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges166 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges183 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges184 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges169 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges170 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges172 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges173 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges171 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges175 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges176 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges174 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges178 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges179 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges177 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges181 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges182 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges180 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges185 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges186 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges208 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges209 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges194 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges195 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges187 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges188 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges189 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges190 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges191 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges192 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges193 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges206 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges207 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges196 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges197 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges198 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges199 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges204 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges205 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges200 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges201 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges202 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges203 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges212 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges213 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges210 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges211 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges214 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges215 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges216 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges217 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges218 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges219 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges220 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges221 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges222 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges223 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges224 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges225 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges226 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges227 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges228 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges229 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges230 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges231 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges232 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges233 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges234 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges235 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges236 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges237 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges238 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges239 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges240 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges241 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges242 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges243 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges244 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges245 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges246 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges247 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges248 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges249 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges250 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges263 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges264 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges253 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges254 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges251 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges252 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges255 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges256 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges257 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges258 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges259 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges260 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges261 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges262 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges265 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges273 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges274 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges266 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges267 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges268 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges269 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges270 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges271 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges272 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            Guna.Charts.WinForms.LPoint lPoint13 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint14 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint15 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint16 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint17 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint18 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint19 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint20 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint21 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint22 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint23 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint24 = new Guna.Charts.WinForms.LPoint();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            taskbar = new Guna2Panel();
            btnClose = new Guna2ControlBox();
            btnMinimize = new Guna2ControlBox();
            sidebarPanel = new Guna2Panel();
            logout = new Guna2Button();
            rolesbtn = new Guna2Button();
            statisticsbtn = new Guna2Button();
            ordersbtn = new Guna2Button();
            stocksbtn = new Guna2Button();
            dashboardbtn = new Guna2Button();
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
            panelStock = new Guna2Panel();
            stockPanel = new FlowLayoutPanel();
            stockScrollbar = new Guna2VScrollBar();
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
            panelOrder = new Guna2Panel();
            orderPanel = new FlowLayoutPanel();
            guna2Panel22 = new Guna2Panel();
            guna2Panel23 = new Guna2Panel();
            guna2Panel24 = new Guna2Panel();
            guna2Panel25 = new Guna2Panel();
            guna2Panel26 = new Guna2Panel();
            guna2Panel27 = new Guna2Panel();
            guna2Panel28 = new Guna2Panel();
            guna2Panel29 = new Guna2Panel();
            guna2Panel30 = new Guna2Panel();
            guna2Panel31 = new Guna2Panel();
            guna2Panel32 = new Guna2Panel();
            guna2Panel33 = new Guna2Panel();
            guna2Panel34 = new Guna2Panel();
            guna2Panel35 = new Guna2Panel();
            guna2Panel36 = new Guna2Panel();
            orderScrollbar = new Guna2VScrollBar();
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
            panelStock.SuspendLayout();
            guna2Panel15.SuspendLayout();
            guna2Panel16.SuspendLayout();
            ((ISupportInitialize)guna2PictureBox1).BeginInit();
            lblorder.SuspendLayout();
            guna2Panel14.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView5).BeginInit();
            panelOrder.SuspendLayout();
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
            taskbar.CustomizableEdges = customizableEdges142;
            tileBtn.SetDecoration(taskbar, Guna.UI2.AnimatorNS.DecorationType.None);
            taskbar.Dock = DockStyle.Top;
            taskbar.FillColor = Color.FromArgb(120, 20, 20);
            taskbar.Location = new Point(0, 0);
            taskbar.Margin = new Padding(3, 4, 3, 4);
            taskbar.Name = "taskbar";
            taskbar.ShadowDecoration.CustomizableEdges = customizableEdges143;
            taskbar.Size = new Size(1366, 47);
            taskbar.TabIndex = 0;
            taskbar.MouseDown += taskbar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.CustomizableEdges = customizableEdges138;
            tileBtn.SetDecoration(btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            btnClose.FillColor = Color.FromArgb(120, 20, 20);
            btnClose.HoverState.FillColor = Color.White;
            btnClose.HoverState.IconColor = Color.Black;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(1316, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges139;
            btnClose.Size = new Size(51, 47);
            btnClose.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.CustomizableEdges = customizableEdges140;
            tileBtn.SetDecoration(btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            btnMinimize.FillColor = Color.FromArgb(120, 20, 20);
            btnMinimize.HoverState.FillColor = Color.White;
            btnMinimize.HoverState.IconColor = Color.Black;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(1263, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges141;
            btnMinimize.Size = new Size(51, 47);
            btnMinimize.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Transparent;
            sidebarPanel.BorderColor = Color.DimGray;
            sidebarPanel.Controls.Add(logout);
            sidebarPanel.Controls.Add(rolesbtn);
            sidebarPanel.Controls.Add(statisticsbtn);
            sidebarPanel.Controls.Add(ordersbtn);
            sidebarPanel.Controls.Add(stocksbtn);
            sidebarPanel.Controls.Add(dashboardbtn);
            sidebarPanel.CustomBorderColor = Color.DimGray;
            sidebarPanel.CustomizableEdges = customizableEdges156;
            tileBtn.SetDecoration(sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.ForeColor = SystemColors.WindowFrame;
            sidebarPanel.Location = new Point(0, 116);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges157;
            sidebarPanel.Size = new Size(50, 652);
            sidebarPanel.TabIndex = 1;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.BackColor = Color.FromArgb(30, 30, 30);
            logout.Cursor = Cursors.Hand;
            logout.CustomizableEdges = customizableEdges144;
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
            logout.Location = new Point(0, 568);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.ShadowDecoration.CustomizableEdges = customizableEdges145;
            logout.Size = new Size(225, 60);
            logout.TabIndex = 6;
            logout.Tag = "LOGOUT";
            logout.Text = "LOGOUT";
            // 
            // rolesbtn
            // 
            rolesbtn.BackColor = Color.FromArgb(30, 30, 30);
            rolesbtn.Cursor = Cursors.Hand;
            rolesbtn.CustomizableEdges = customizableEdges146;
            tileBtn.SetDecoration(rolesbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            rolesbtn.DisabledState.BorderColor = Color.DarkGray;
            rolesbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            rolesbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rolesbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rolesbtn.FillColor = Color.FromArgb(30, 30, 30);
            rolesbtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            rolesbtn.ForeColor = Color.White;
            rolesbtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            rolesbtn.HoverState.ForeColor = Color.DarkGray;
            rolesbtn.Image = Properties.Resources.parcel;
            rolesbtn.ImageAlign = HorizontalAlignment.Left;
            rolesbtn.ImageSize = new Size(30, 30);
            rolesbtn.Location = new Point(0, 379);
            rolesbtn.Margin = new Padding(3, 4, 3, 4);
            rolesbtn.Name = "rolesbtn";
            rolesbtn.RightToLeft = RightToLeft.No;
            rolesbtn.ShadowDecoration.CustomizableEdges = customizableEdges147;
            rolesbtn.Size = new Size(225, 60);
            rolesbtn.TabIndex = 5;
            rolesbtn.Tag = "Roles";
            rolesbtn.Text = "Roles";
            rolesbtn.TextAlign = HorizontalAlignment.Left;
            rolesbtn.Click += roles_Click;
            // 
            // statisticsbtn
            // 
            statisticsbtn.BackColor = Color.FromArgb(30, 30, 30);
            statisticsbtn.Cursor = Cursors.Hand;
            statisticsbtn.CustomizableEdges = customizableEdges148;
            tileBtn.SetDecoration(statisticsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            statisticsbtn.DisabledState.BorderColor = Color.DarkGray;
            statisticsbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            statisticsbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            statisticsbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            statisticsbtn.FillColor = Color.FromArgb(30, 30, 30);
            statisticsbtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            statisticsbtn.ForeColor = Color.White;
            statisticsbtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            statisticsbtn.HoverState.ForeColor = Color.DarkGray;
            statisticsbtn.Image = Properties.Resources.data_usage;
            statisticsbtn.ImageAlign = HorizontalAlignment.Left;
            statisticsbtn.ImageSize = new Size(30, 30);
            statisticsbtn.Location = new Point(0, 293);
            statisticsbtn.Margin = new Padding(3, 4, 3, 4);
            statisticsbtn.Name = "statisticsbtn";
            statisticsbtn.RightToLeft = RightToLeft.No;
            statisticsbtn.ShadowDecoration.CustomizableEdges = customizableEdges149;
            statisticsbtn.Size = new Size(225, 60);
            statisticsbtn.TabIndex = 4;
            statisticsbtn.Tag = "Statistics";
            statisticsbtn.Text = "Statistics";
            statisticsbtn.TextAlign = HorizontalAlignment.Left;
            statisticsbtn.Click += statistics_Click;
            // 
            // ordersbtn
            // 
            ordersbtn.BackColor = Color.FromArgb(30, 30, 30);
            ordersbtn.Cursor = Cursors.Hand;
            ordersbtn.CustomizableEdges = customizableEdges150;
            tileBtn.SetDecoration(ordersbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            ordersbtn.DisabledState.BorderColor = Color.DarkGray;
            ordersbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ordersbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ordersbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ordersbtn.FillColor = Color.FromArgb(30, 30, 30);
            ordersbtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            ordersbtn.ForeColor = Color.White;
            ordersbtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            ordersbtn.HoverState.ForeColor = Color.DarkGray;
            ordersbtn.Image = Properties.Resources.shopping_cart;
            ordersbtn.ImageAlign = HorizontalAlignment.Left;
            ordersbtn.ImageSize = new Size(30, 30);
            ordersbtn.Location = new Point(0, 209);
            ordersbtn.Margin = new Padding(3, 4, 3, 4);
            ordersbtn.Name = "ordersbtn";
            ordersbtn.RightToLeft = RightToLeft.No;
            ordersbtn.ShadowDecoration.CustomizableEdges = customizableEdges151;
            ordersbtn.Size = new Size(225, 60);
            ordersbtn.TabIndex = 3;
            ordersbtn.Tag = "Orders";
            ordersbtn.Text = "Orders";
            ordersbtn.TextAlign = HorizontalAlignment.Left;
            ordersbtn.Click += orders_Click;
            // 
            // stocksbtn
            // 
            stocksbtn.BackColor = Color.FromArgb(30, 30, 30);
            stocksbtn.Cursor = Cursors.Hand;
            stocksbtn.CustomizableEdges = customizableEdges152;
            tileBtn.SetDecoration(stocksbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            stocksbtn.DisabledState.BorderColor = Color.DarkGray;
            stocksbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            stocksbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stocksbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stocksbtn.FillColor = Color.FromArgb(30, 30, 30);
            stocksbtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            stocksbtn.ForeColor = Color.White;
            stocksbtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            stocksbtn.HoverState.ForeColor = Color.DarkGray;
            stocksbtn.Image = Properties.Resources.money_graph_with_up_arrow;
            stocksbtn.ImageAlign = HorizontalAlignment.Left;
            stocksbtn.ImageSize = new Size(30, 30);
            stocksbtn.Location = new Point(0, 124);
            stocksbtn.Margin = new Padding(3, 4, 3, 4);
            stocksbtn.Name = "stocksbtn";
            stocksbtn.RightToLeft = RightToLeft.No;
            stocksbtn.ShadowDecoration.CustomizableEdges = customizableEdges153;
            stocksbtn.Size = new Size(225, 60);
            stocksbtn.TabIndex = 2;
            stocksbtn.Tag = "Stocks";
            stocksbtn.Text = "Stocks";
            stocksbtn.TextAlign = HorizontalAlignment.Left;
            stocksbtn.Click += stocks_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.FromArgb(30, 30, 30);
            dashboardbtn.Cursor = Cursors.Hand;
            dashboardbtn.CustomizableEdges = customizableEdges154;
            tileBtn.SetDecoration(dashboardbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            dashboardbtn.DisabledState.BorderColor = Color.DarkGray;
            dashboardbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboardbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboardbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboardbtn.FillColor = Color.FromArgb(30, 30, 30);
            dashboardbtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            dashboardbtn.ForeColor = Color.White;
            dashboardbtn.HoverState.FillColor = Color.FromArgb(128, 150, 100, 20);
            dashboardbtn.HoverState.ForeColor = Color.DarkGray;
            dashboardbtn.Image = Properties.Resources.dashboard__1_;
            dashboardbtn.ImageAlign = HorizontalAlignment.Left;
            dashboardbtn.ImageSize = new Size(30, 30);
            dashboardbtn.Location = new Point(0, 37);
            dashboardbtn.Margin = new Padding(3, 4, 3, 4);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.RightToLeft = RightToLeft.No;
            dashboardbtn.ShadowDecoration.CustomizableEdges = customizableEdges155;
            dashboardbtn.Size = new Size(225, 60);
            dashboardbtn.TabIndex = 1;
            dashboardbtn.Tag = "Dashboard";
            dashboardbtn.Text = "Dashboard";
            dashboardbtn.TextAlign = HorizontalAlignment.Left;
            dashboardbtn.Click += dashboard_Click;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.CustomizableEdges = customizableEdges158;
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
            btnToggle.ShadowDecoration.CustomizableEdges = customizableEdges159;
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
            guna2Panel1.CustomizableEdges = customizableEdges161;
            tileBtn.SetDecoration(guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(120, 20, 20);
            guna2Panel1.Location = new Point(0, 47);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges162;
            guna2Panel1.Size = new Size(1366, 69);
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
            guna2ImageButton4.Location = new Point(1251, 0);
            guna2ImageButton4.Name = "guna2ImageButton4";
            guna2ImageButton4.PressedState.ImageSize = new Size(45, 45);
            guna2ImageButton4.ShadowDecoration.CustomizableEdges = customizableEdges160;
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
            tabControl1.Location = new Point(0, 47);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1366, 721);
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
            lbldashboard.Size = new Size(1358, 688);
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
            guna2Panel12.CustomizableEdges = customizableEdges167;
            tileBtn.SetDecoration(guna2Panel12, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel12.Dock = DockStyle.Right;
            guna2Panel12.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel12.Location = new Point(870, 4);
            guna2Panel12.Name = "guna2Panel12";
            guna2Panel12.ShadowDecoration.CustomizableEdges = customizableEdges168;
            guna2Panel12.Size = new Size(485, 680);
            guna2Panel12.TabIndex = 0;
            // 
            // btnsales_dashboard
            // 
            btnsales_dashboard.BorderColor = Color.Maroon;
            btnsales_dashboard.BorderRadius = 15;
            btnsales_dashboard.CustomizableEdges = customizableEdges163;
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
            btnsales_dashboard.ShadowDecoration.CustomizableEdges = customizableEdges164;
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
            guna2ComboBox2.CustomizableEdges = customizableEdges165;
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
            guna2ComboBox2.ShadowDecoration.CustomizableEdges = customizableEdges166;
            guna2ComboBox2.Size = new Size(142, 36);
            guna2ComboBox2.TabIndex = 5;
            guna2ComboBox2.Tag = "Category";
            // 
            // guna2DataGridView4
            // 
            dataGridViewCellStyle22.BackColor = Color.White;
            guna2DataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            guna2DataGridView4.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            guna2DataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            guna2DataGridView4.ColumnHeadersHeight = 4;
            guna2DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView4, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.White;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = Color.DimGray;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle24.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            guna2DataGridView4.DefaultCellStyle = dataGridViewCellStyle24;
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
            guna2Panel7.CustomizableEdges = customizableEdges183;
            tileBtn.SetDecoration(guna2Panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel7.Location = new Point(0, 0);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges184;
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
            guna2Panel21.CustomizableEdges = customizableEdges169;
            tileBtn.SetDecoration(guna2Panel21, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel21.Location = new Point(69, 539);
            guna2Panel21.Name = "guna2Panel21";
            guna2Panel21.ShadowDecoration.CustomizableEdges = customizableEdges170;
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
            guna2Panel10.CustomizableEdges = customizableEdges172;
            tileBtn.SetDecoration(guna2Panel10, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel10.Location = new Point(69, 299);
            guna2Panel10.Name = "guna2Panel10";
            guna2Panel10.ShadowDecoration.CustomizableEdges = customizableEdges173;
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
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges171;
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
            guna2Panel11.CustomizableEdges = customizableEdges175;
            tileBtn.SetDecoration(guna2Panel11, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel11.Location = new Point(469, 299);
            guna2Panel11.Name = "guna2Panel11";
            guna2Panel11.ShadowDecoration.CustomizableEdges = customizableEdges176;
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
            guna2CirclePictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges174;
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
            guna2Panel9.CustomizableEdges = customizableEdges178;
            tileBtn.SetDecoration(guna2Panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel9.Location = new Point(469, 64);
            guna2Panel9.Name = "guna2Panel9";
            guna2Panel9.ShadowDecoration.CustomizableEdges = customizableEdges179;
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
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges177;
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
            guna2Panel8.CustomizableEdges = customizableEdges181;
            tileBtn.SetDecoration(guna2Panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel8.Location = new Point(69, 64);
            guna2Panel8.Name = "guna2Panel8";
            guna2Panel8.ShadowDecoration.CustomizableEdges = customizableEdges182;
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
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges180;
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
            guna2Panel6.CustomizableEdges = customizableEdges185;
            tileBtn.SetDecoration(guna2Panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel6.Dock = DockStyle.Fill;
            guna2Panel6.Location = new Point(3, 4);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges186;
            guna2Panel6.Size = new Size(1352, 680);
            guna2Panel6.TabIndex = 8;
            // 
            // lblstocks
            // 
            lblstocks.Controls.Add(guna2Panel5);
            tileBtn.SetDecoration(lblstocks, Guna.UI2.AnimatorNS.DecorationType.None);
            lblstocks.Location = new Point(4, 29);
            lblstocks.Name = "lblstocks";
            lblstocks.Size = new Size(1358, 688);
            lblstocks.TabIndex = 2;
            lblstocks.Text = "Stocks";
            lblstocks.UseVisualStyleBackColor = true;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Controls.Add(guna2Panel13);
            guna2Panel5.Controls.Add(guna2Panel15);
            guna2Panel5.CustomizableEdges = customizableEdges208;
            tileBtn.SetDecoration(guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel5.Dock = DockStyle.Fill;
            guna2Panel5.ForeColor = Color.DimGray;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges209;
            guna2Panel5.Size = new Size(1358, 688);
            guna2Panel5.TabIndex = 6;
            // 
            // guna2Panel13
            // 
            guna2Panel13.BorderColor = Color.Maroon;
            guna2Panel13.BorderThickness = 2;
            guna2Panel13.Controls.Add(searchStocks);
            guna2Panel13.Controls.Add(guna2ImageButton1);
            guna2Panel13.Controls.Add(panelStock);
            guna2Panel13.Controls.Add(categoryComboBox);
            guna2Panel13.CustomizableEdges = customizableEdges194;
            tileBtn.SetDecoration(guna2Panel13, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel13.Location = new Point(-7, 30);
            guna2Panel13.Name = "guna2Panel13";
            guna2Panel13.ShadowDecoration.CustomizableEdges = customizableEdges195;
            guna2Panel13.Size = new Size(1101, 662);
            guna2Panel13.TabIndex = 6;
            // 
            // searchStocks
            // 
            searchStocks.BorderColor = Color.Maroon;
            searchStocks.BorderRadius = 16;
            searchStocks.BorderThickness = 2;
            searchStocks.CustomizableEdges = customizableEdges187;
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
            searchStocks.ShadowDecoration.CustomizableEdges = customizableEdges188;
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
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges189;
            guna2ImageButton1.Size = new Size(40, 40);
            guna2ImageButton1.TabIndex = 1;
            // 
            // panelStock
            // 
            panelStock.BackColor = Color.FromArgb(235, 192, 192);
            panelStock.Controls.Add(stockPanel);
            panelStock.Controls.Add(stockScrollbar);
            panelStock.CustomizableEdges = customizableEdges190;
            tileBtn.SetDecoration(panelStock, Guna.UI2.AnimatorNS.DecorationType.None);
            panelStock.Location = new Point(70, 77);
            panelStock.Name = "panelStock";
            panelStock.ShadowDecoration.CustomizableEdges = customizableEdges191;
            panelStock.Size = new Size(1020, 581);
            panelStock.TabIndex = 5;
            // 
            // stockPanel
            // 
            tileBtn.SetDecoration(stockPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            stockPanel.Dock = DockStyle.Fill;
            stockPanel.Location = new Point(0, 0);
            stockPanel.Margin = new Padding(5);
            stockPanel.Name = "stockPanel";
            stockPanel.Padding = new Padding(10, 10, 5, 10);
            stockPanel.Size = new Size(1005, 581);
            stockPanel.TabIndex = 1;
            stockPanel.Scroll += stockScrollbar_Scroll;
            // 
            // stockScrollbar
            // 
            stockScrollbar.BorderRadius = 7;
            tileBtn.SetDecoration(stockScrollbar, Guna.UI2.AnimatorNS.DecorationType.None);
            stockScrollbar.Dock = DockStyle.Right;
            stockScrollbar.FillColor = Color.Transparent;
            stockScrollbar.InUpdate = false;
            stockScrollbar.LargeChange = 10;
            stockScrollbar.Location = new Point(1005, 0);
            stockScrollbar.Name = "stockScrollbar";
            stockScrollbar.ScrollbarSize = 15;
            stockScrollbar.Size = new Size(15, 581);
            stockScrollbar.TabIndex = 0;
            stockScrollbar.ThumbColor = Color.Maroon;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.Transparent;
            categoryComboBox.BorderColor = Color.Maroon;
            categoryComboBox.BorderRadius = 16;
            categoryComboBox.BorderThickness = 2;
            categoryComboBox.CustomizableEdges = customizableEdges192;
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
            categoryComboBox.Location = new Point(890, 24);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges193;
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
            guna2Panel15.CustomizableEdges = customizableEdges206;
            tileBtn.SetDecoration(guna2Panel15, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel15.Dock = DockStyle.Right;
            guna2Panel15.Location = new Point(1091, 0);
            guna2Panel15.Name = "guna2Panel15";
            guna2Panel15.ShadowDecoration.CustomizableEdges = customizableEdges207;
            guna2Panel15.Size = new Size(267, 688);
            guna2Panel15.TabIndex = 1;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderRadius = 20;
            guna2Button4.Cursor = Cursors.Hand;
            guna2Button4.CustomizableEdges = customizableEdges196;
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
            guna2Button4.Location = new Point(12, 565);
            guna2Button4.Margin = new Padding(3, 4, 3, 4);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges197;
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
            guna2Button3.CustomizableEdges = customizableEdges198;
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
            guna2Button3.Location = new Point(12, 626);
            guna2Button3.Margin = new Padding(3, 4, 3, 4);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges199;
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
            label4.Location = new Point(28, 54);
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
            guna2Panel16.CustomizableEdges = customizableEdges204;
            tileBtn.SetDecoration(guna2Panel16, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel16.Location = new Point(9, 110);
            guna2Panel16.Name = "guna2Panel16";
            guna2Panel16.ShadowDecoration.CustomizableEdges = customizableEdges205;
            guna2Panel16.Size = new Size(250, 430);
            guna2Panel16.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges200;
            tileBtn.SetDecoration(guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2PictureBox1.Image = Properties.Resources._51a01bde_2cc6_4016_8417_6a29e78dbe07;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 57);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges201;
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
            manageBtn.CustomizableEdges = customizableEdges202;
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
            manageBtn.ShadowDecoration.CustomizableEdges = customizableEdges203;
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
            lblorder.Controls.Add(panelOrder);
            lblorder.Controls.Add(guna2ImageButton2);
            lblorder.Controls.Add(searchOrder);
            lblorder.Controls.Add(guna2ComboBox1);
            tileBtn.SetDecoration(lblorder, Guna.UI2.AnimatorNS.DecorationType.None);
            lblorder.Location = new Point(4, 29);
            lblorder.Name = "lblorder";
            lblorder.Size = new Size(1358, 688);
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
            guna2Panel14.CustomizableEdges = customizableEdges212;
            tileBtn.SetDecoration(guna2Panel14, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel14.Dock = DockStyle.Left;
            guna2Panel14.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel14.Location = new Point(0, 0);
            guna2Panel14.Name = "guna2Panel14";
            guna2Panel14.ShadowDecoration.CustomizableEdges = customizableEdges213;
            guna2Panel14.Size = new Size(502, 688);
            guna2Panel14.TabIndex = 9;
            // 
            // guna2Button5
            // 
            guna2Button5.BorderColor = Color.Maroon;
            guna2Button5.BorderRadius = 15;
            guna2Button5.CustomizableEdges = customizableEdges210;
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
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges211;
            guna2Button5.Size = new Size(166, 36);
            guna2Button5.TabIndex = 6;
            guna2Button5.Text = "ADD ORDER";
            // 
            // guna2DataGridView5
            // 
            dataGridViewCellStyle25.BackColor = Color.White;
            guna2DataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            guna2DataGridView5.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            guna2DataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            guna2DataGridView5.ColumnHeadersHeight = 4;
            guna2DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView5, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.White;
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle27.ForeColor = Color.DimGray;
            dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle27.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            guna2DataGridView5.DefaultCellStyle = dataGridViewCellStyle27;
            guna2DataGridView5.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView5.Location = new Point(61, 102);
            guna2DataGridView5.Name = "guna2DataGridView5";
            guna2DataGridView5.RowHeadersVisible = false;
            guna2DataGridView5.RowHeadersWidth = 51;
            guna2DataGridView5.Size = new Size(416, 562);
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
            // panelOrder
            // 
            panelOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelOrder.AutoScroll = true;
            panelOrder.Controls.Add(orderPanel);
            panelOrder.Controls.Add(orderScrollbar);
            panelOrder.CustomizableEdges = customizableEdges214;
            tileBtn.SetDecoration(panelOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            panelOrder.Location = new Point(539, 115);
            panelOrder.Name = "panelOrder";
            panelOrder.ShadowDecoration.CustomizableEdges = customizableEdges215;
            panelOrder.Size = new Size(818, 577);
            panelOrder.TabIndex = 8;
            // 
            // orderPanel
            // 
            orderPanel.Controls.Add(guna2Panel22);
            orderPanel.Controls.Add(guna2Panel23);
            orderPanel.Controls.Add(guna2Panel24);
            orderPanel.Controls.Add(guna2Panel25);
            orderPanel.Controls.Add(guna2Panel26);
            orderPanel.Controls.Add(guna2Panel27);
            orderPanel.Controls.Add(guna2Panel28);
            orderPanel.Controls.Add(guna2Panel29);
            orderPanel.Controls.Add(guna2Panel30);
            orderPanel.Controls.Add(guna2Panel31);
            orderPanel.Controls.Add(guna2Panel32);
            orderPanel.Controls.Add(guna2Panel33);
            orderPanel.Controls.Add(guna2Panel34);
            orderPanel.Controls.Add(guna2Panel35);
            orderPanel.Controls.Add(guna2Panel36);
            tileBtn.SetDecoration(orderPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            orderPanel.Dock = DockStyle.Fill;
            orderPanel.Location = new Point(0, 0);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(803, 577);
            orderPanel.TabIndex = 11;
            // 
            // guna2Panel22
            // 
            guna2Panel22.BorderRadius = 20;
            guna2Panel22.CustomizableEdges = customizableEdges216;
            tileBtn.SetDecoration(guna2Panel22, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel22.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel22.Location = new Point(3, 3);
            guna2Panel22.Name = "guna2Panel22";
            guna2Panel22.Padding = new Padding(10);
            guna2Panel22.ShadowDecoration.CustomizableEdges = customizableEdges217;
            guna2Panel22.Size = new Size(259, 163);
            guna2Panel22.TabIndex = 10;
            // 
            // guna2Panel23
            // 
            guna2Panel23.BorderRadius = 20;
            guna2Panel23.CustomizableEdges = customizableEdges218;
            tileBtn.SetDecoration(guna2Panel23, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel23.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel23.Location = new Point(268, 3);
            guna2Panel23.Name = "guna2Panel23";
            guna2Panel23.Padding = new Padding(10);
            guna2Panel23.ShadowDecoration.CustomizableEdges = customizableEdges219;
            guna2Panel23.Size = new Size(259, 163);
            guna2Panel23.TabIndex = 11;
            // 
            // guna2Panel24
            // 
            guna2Panel24.BorderRadius = 20;
            guna2Panel24.CustomizableEdges = customizableEdges220;
            tileBtn.SetDecoration(guna2Panel24, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel24.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel24.Location = new Point(533, 3);
            guna2Panel24.Name = "guna2Panel24";
            guna2Panel24.Padding = new Padding(10);
            guna2Panel24.ShadowDecoration.CustomizableEdges = customizableEdges221;
            guna2Panel24.Size = new Size(259, 163);
            guna2Panel24.TabIndex = 12;
            // 
            // guna2Panel25
            // 
            guna2Panel25.BorderRadius = 20;
            guna2Panel25.CustomizableEdges = customizableEdges222;
            tileBtn.SetDecoration(guna2Panel25, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel25.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel25.Location = new Point(3, 172);
            guna2Panel25.Name = "guna2Panel25";
            guna2Panel25.Padding = new Padding(10);
            guna2Panel25.ShadowDecoration.CustomizableEdges = customizableEdges223;
            guna2Panel25.Size = new Size(259, 163);
            guna2Panel25.TabIndex = 13;
            // 
            // guna2Panel26
            // 
            guna2Panel26.BorderRadius = 20;
            guna2Panel26.CustomizableEdges = customizableEdges224;
            tileBtn.SetDecoration(guna2Panel26, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel26.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel26.Location = new Point(268, 172);
            guna2Panel26.Name = "guna2Panel26";
            guna2Panel26.Padding = new Padding(10);
            guna2Panel26.ShadowDecoration.CustomizableEdges = customizableEdges225;
            guna2Panel26.Size = new Size(259, 163);
            guna2Panel26.TabIndex = 14;
            // 
            // guna2Panel27
            // 
            guna2Panel27.BorderRadius = 20;
            guna2Panel27.CustomizableEdges = customizableEdges226;
            tileBtn.SetDecoration(guna2Panel27, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel27.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel27.Location = new Point(533, 172);
            guna2Panel27.Name = "guna2Panel27";
            guna2Panel27.Padding = new Padding(10);
            guna2Panel27.ShadowDecoration.CustomizableEdges = customizableEdges227;
            guna2Panel27.Size = new Size(259, 163);
            guna2Panel27.TabIndex = 15;
            // 
            // guna2Panel28
            // 
            guna2Panel28.BorderRadius = 20;
            guna2Panel28.CustomizableEdges = customizableEdges228;
            tileBtn.SetDecoration(guna2Panel28, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel28.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel28.Location = new Point(3, 341);
            guna2Panel28.Name = "guna2Panel28";
            guna2Panel28.Padding = new Padding(10);
            guna2Panel28.ShadowDecoration.CustomizableEdges = customizableEdges229;
            guna2Panel28.Size = new Size(259, 163);
            guna2Panel28.TabIndex = 16;
            // 
            // guna2Panel29
            // 
            guna2Panel29.BorderRadius = 20;
            guna2Panel29.CustomizableEdges = customizableEdges230;
            tileBtn.SetDecoration(guna2Panel29, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel29.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel29.Location = new Point(268, 341);
            guna2Panel29.Name = "guna2Panel29";
            guna2Panel29.Padding = new Padding(10);
            guna2Panel29.ShadowDecoration.CustomizableEdges = customizableEdges231;
            guna2Panel29.Size = new Size(259, 163);
            guna2Panel29.TabIndex = 17;
            // 
            // guna2Panel30
            // 
            guna2Panel30.BorderRadius = 20;
            guna2Panel30.CustomizableEdges = customizableEdges232;
            tileBtn.SetDecoration(guna2Panel30, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel30.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel30.Location = new Point(533, 341);
            guna2Panel30.Name = "guna2Panel30";
            guna2Panel30.Padding = new Padding(10);
            guna2Panel30.ShadowDecoration.CustomizableEdges = customizableEdges233;
            guna2Panel30.Size = new Size(259, 163);
            guna2Panel30.TabIndex = 18;
            // 
            // guna2Panel31
            // 
            guna2Panel31.BorderRadius = 20;
            guna2Panel31.CustomizableEdges = customizableEdges234;
            tileBtn.SetDecoration(guna2Panel31, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel31.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel31.Location = new Point(3, 510);
            guna2Panel31.Name = "guna2Panel31";
            guna2Panel31.Padding = new Padding(10);
            guna2Panel31.ShadowDecoration.CustomizableEdges = customizableEdges235;
            guna2Panel31.Size = new Size(259, 163);
            guna2Panel31.TabIndex = 19;
            // 
            // guna2Panel32
            // 
            guna2Panel32.BorderRadius = 20;
            guna2Panel32.CustomizableEdges = customizableEdges236;
            tileBtn.SetDecoration(guna2Panel32, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel32.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel32.Location = new Point(268, 510);
            guna2Panel32.Name = "guna2Panel32";
            guna2Panel32.Padding = new Padding(10);
            guna2Panel32.ShadowDecoration.CustomizableEdges = customizableEdges237;
            guna2Panel32.Size = new Size(259, 163);
            guna2Panel32.TabIndex = 20;
            // 
            // guna2Panel33
            // 
            guna2Panel33.BorderRadius = 20;
            guna2Panel33.CustomizableEdges = customizableEdges238;
            tileBtn.SetDecoration(guna2Panel33, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel33.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel33.Location = new Point(533, 510);
            guna2Panel33.Name = "guna2Panel33";
            guna2Panel33.Padding = new Padding(10);
            guna2Panel33.ShadowDecoration.CustomizableEdges = customizableEdges239;
            guna2Panel33.Size = new Size(259, 163);
            guna2Panel33.TabIndex = 21;
            // 
            // guna2Panel34
            // 
            guna2Panel34.BorderRadius = 20;
            guna2Panel34.CustomizableEdges = customizableEdges240;
            tileBtn.SetDecoration(guna2Panel34, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel34.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel34.Location = new Point(3, 679);
            guna2Panel34.Name = "guna2Panel34";
            guna2Panel34.Padding = new Padding(10);
            guna2Panel34.ShadowDecoration.CustomizableEdges = customizableEdges241;
            guna2Panel34.Size = new Size(259, 163);
            guna2Panel34.TabIndex = 22;
            // 
            // guna2Panel35
            // 
            guna2Panel35.BorderRadius = 20;
            guna2Panel35.CustomizableEdges = customizableEdges242;
            tileBtn.SetDecoration(guna2Panel35, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel35.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel35.Location = new Point(268, 679);
            guna2Panel35.Name = "guna2Panel35";
            guna2Panel35.Padding = new Padding(10);
            guna2Panel35.ShadowDecoration.CustomizableEdges = customizableEdges243;
            guna2Panel35.Size = new Size(259, 163);
            guna2Panel35.TabIndex = 23;
            // 
            // guna2Panel36
            // 
            guna2Panel36.BorderRadius = 20;
            guna2Panel36.CustomizableEdges = customizableEdges244;
            tileBtn.SetDecoration(guna2Panel36, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel36.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel36.Location = new Point(533, 679);
            guna2Panel36.Name = "guna2Panel36";
            guna2Panel36.Padding = new Padding(10);
            guna2Panel36.ShadowDecoration.CustomizableEdges = customizableEdges245;
            guna2Panel36.Size = new Size(259, 163);
            guna2Panel36.TabIndex = 24;
            // 
            // orderScrollbar
            // 
            orderScrollbar.BorderRadius = 7;
            tileBtn.SetDecoration(orderScrollbar, Guna.UI2.AnimatorNS.DecorationType.None);
            orderScrollbar.Dock = DockStyle.Right;
            orderScrollbar.FillColor = Color.Transparent;
            orderScrollbar.InUpdate = false;
            orderScrollbar.LargeChange = 10;
            orderScrollbar.Location = new Point(803, 0);
            orderScrollbar.Name = "orderScrollbar";
            orderScrollbar.ScrollbarSize = 15;
            orderScrollbar.Size = new Size(15, 577);
            orderScrollbar.TabIndex = 9;
            orderScrollbar.ThumbColor = Color.Maroon;
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
            guna2ImageButton2.Location = new Point(1054, 57);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(32, 32);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges246;
            guna2ImageButton2.Size = new Size(35, 35);
            guna2ImageButton2.TabIndex = 6;
            // 
            // searchOrder
            // 
            searchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchOrder.BorderColor = Color.Maroon;
            searchOrder.BorderRadius = 16;
            searchOrder.BorderThickness = 2;
            searchOrder.CustomizableEdges = customizableEdges247;
            tileBtn.SetDecoration(searchOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            searchOrder.DefaultText = "Search Order";
            searchOrder.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchOrder.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchOrder.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchOrder.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchOrder.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchOrder.Font = new Font("Segoe UI", 9F);
            searchOrder.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            searchOrder.Location = new Point(539, 57);
            searchOrder.Margin = new Padding(3, 4, 3, 4);
            searchOrder.Name = "searchOrder";
            searchOrder.PlaceholderText = "";
            searchOrder.SelectedText = "";
            searchOrder.ShadowDecoration.CustomizableEdges = customizableEdges248;
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
            guna2ComboBox1.CustomizableEdges = customizableEdges249;
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
            guna2ComboBox1.Location = new Point(1133, 57);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges250;
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
            lblstatistics.Size = new Size(1358, 688);
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
            guna2Panel3.CustomizableEdges = customizableEdges263;
            tileBtn.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges264;
            guna2Panel3.Size = new Size(1358, 688);
            guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel20
            // 
            guna2Panel20.Controls.Add(guna2DataGridView6);
            guna2Panel20.Controls.Add(guna2ComboBox3);
            guna2Panel20.CustomizableEdges = customizableEdges253;
            tileBtn.SetDecoration(guna2Panel20, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel20.Dock = DockStyle.Right;
            guna2Panel20.FillColor = Color.FromArgb(235, 192, 192);
            guna2Panel20.Location = new Point(1108, 0);
            guna2Panel20.Name = "guna2Panel20";
            guna2Panel20.ShadowDecoration.CustomizableEdges = customizableEdges254;
            guna2Panel20.Size = new Size(250, 688);
            guna2Panel20.TabIndex = 10;
            // 
            // guna2DataGridView6
            // 
            dataGridViewCellStyle28.BackColor = Color.White;
            guna2DataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            guna2DataGridView6.BackgroundColor = Color.FromArgb(235, 192, 192);
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle29.ForeColor = Color.White;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            guna2DataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            guna2DataGridView6.ColumnHeadersHeight = 4;
            guna2DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView6, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle30.ForeColor = Color.DimGray;
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle30.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
            guna2DataGridView6.DefaultCellStyle = dataGridViewCellStyle30;
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
            guna2ComboBox3.CustomizableEdges = customizableEdges251;
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
            guna2ComboBox3.ShadowDecoration.CustomizableEdges = customizableEdges252;
            guna2ComboBox3.Size = new Size(221, 36);
            guna2ComboBox3.TabIndex = 8;
            guna2ComboBox3.Tag = "";
            // 
            // guna2Chart1
            // 
            tileBtn.SetDecoration(guna2Chart1, Guna.UI2.AnimatorNS.DecorationType.None);
            chartFont9.FontName = "Arial";
            guna2Chart1.Legend.LabelFont = chartFont9;
            guna2Chart1.Location = new Point(81, 189);
            guna2Chart1.Name = "guna2Chart1";
            guna2Chart1.Size = new Size(1019, 491);
            guna2Chart1.TabIndex = 9;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            guna2Chart1.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            guna2Chart1.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            guna2Chart1.Tooltips.TitleFont = chartFont12;
            guna2Chart1.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            guna2Chart1.XAxes.Ticks = tick4;
            guna2Chart1.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            guna2Chart1.YAxes.Ticks = tick5;
            guna2Chart1.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            guna2Chart1.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            guna2Chart1.ZAxes.Ticks = tick6;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BorderColor = Color.Maroon;
            guna2Panel4.BorderRadius = 20;
            guna2Panel4.BorderThickness = 1;
            guna2Panel4.Controls.Add(label17);
            guna2Panel4.Controls.Add(label18);
            guna2Panel4.CustomizableEdges = customizableEdges255;
            tileBtn.SetDecoration(guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel4.Location = new Point(340, 59);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges256;
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
            guna2Panel17.CustomizableEdges = customizableEdges257;
            tileBtn.SetDecoration(guna2Panel17, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel17.Location = new Point(858, 59);
            guna2Panel17.Name = "guna2Panel17";
            guna2Panel17.ShadowDecoration.CustomizableEdges = customizableEdges258;
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
            guna2Panel18.CustomizableEdges = customizableEdges259;
            tileBtn.SetDecoration(guna2Panel18, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel18.Location = new Point(599, 59);
            guna2Panel18.Name = "guna2Panel18";
            guna2Panel18.ShadowDecoration.CustomizableEdges = customizableEdges260;
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
            guna2Panel19.CustomizableEdges = customizableEdges261;
            tileBtn.SetDecoration(guna2Panel19, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel19.Location = new Point(81, 59);
            guna2Panel19.Name = "guna2Panel19";
            guna2Panel19.ShadowDecoration.CustomizableEdges = customizableEdges262;
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
            lblroles.Size = new Size(1358, 688);
            lblroles.TabIndex = 5;
            lblroles.Text = "Roles";
            lblroles.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView2
            // 
            guna2DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = Color.White;
            dataGridViewCellStyle31.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle31.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle31.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle32.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle32.ForeColor = Color.White;
            dataGridViewCellStyle32.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            guna2DataGridView2.ColumnHeadersHeight = 4;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView2, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = Color.White;
            dataGridViewCellStyle33.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle33.ForeColor = Color.DimGray;
            dataGridViewCellStyle33.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle33.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle33;
            guna2DataGridView2.Dock = DockStyle.Fill;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(72, 125);
            guna2DataGridView2.Margin = new Padding(5);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = Color.White;
            dataGridViewCellStyle34.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle34.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = Color.White;
            dataGridViewCellStyle34.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.Size = new Size(1286, 563);
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
            dataGridViewCellStyle35.BackColor = Color.White;
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle35.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle35.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle36.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle36.ForeColor = Color.White;
            dataGridViewCellStyle36.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView1, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = Color.White;
            dataGridViewCellStyle37.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle37.ForeColor = Color.DimGray;
            dataGridViewCellStyle37.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle37.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle37;
            guna2DataGridView1.Dock = DockStyle.Left;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 125);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = Color.White;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle38.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = Color.White;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
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
            panel1.Size = new Size(1358, 125);
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
            guna2CirclePictureBox5.ShadowDecoration.CustomizableEdges = customizableEdges265;
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
            guna2GradientPanel1.CustomizableEdges = customizableEdges273;
            tileBtn.SetDecoration(guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2GradientPanel1.Location = new Point(499, 54);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges274;
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
            guna2Button1.CustomizableEdges = customizableEdges266;
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
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges267;
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
            guna2Button2.CustomizableEdges = customizableEdges268;
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
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges269;
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
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges270;
            guna2ImageButton3.Size = new Size(35, 35);
            guna2ImageButton3.TabIndex = 8;
            // 
            // searchRoles
            // 
            searchRoles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchRoles.BorderColor = Color.Maroon;
            searchRoles.BorderRadius = 16;
            searchRoles.BorderThickness = 2;
            searchRoles.CustomizableEdges = customizableEdges271;
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
            searchRoles.ShadowDecoration.CustomizableEdges = customizableEdges272;
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
            dataGridViewCellStyle39.BackColor = Color.White;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle39.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle39.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle39;
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle40.ForeColor = Color.White;
            dataGridViewCellStyle40.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            guna2DataGridView3.ColumnHeadersHeight = 4;
            guna2DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tileBtn.SetDecoration(guna2DataGridView3, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = Color.White;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle41.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle41.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle41.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.False;
            guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle41;
            guna2DataGridView3.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView3.Location = new Point(17, 120);
            guna2DataGridView3.Name = "guna2DataGridView3";
            guna2DataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = Color.White;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle42.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = Color.White;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            guna2DataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
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
            lPoint13.Label = "January";
            lPoint13.Y = 12D;
            lPoint14.Label = "February";
            lPoint14.Y = 10D;
            lPoint15.Label = "March";
            lPoint15.Y = 17D;
            lPoint16.Label = "April";
            lPoint16.Y = 20D;
            lPoint17.Label = "May";
            lPoint17.Y = 24D;
            lPoint18.Label = "June";
            lPoint18.Y = 7D;
            lPoint19.Label = "July";
            lPoint19.Y = 16D;
            lPoint20.Label = "August";
            lPoint20.Y = 21D;
            lPoint21.Label = "September";
            lPoint21.Y = 27D;
            lPoint22.Label = "October";
            lPoint22.Y = 30D;
            lPoint23.Label = "November";
            lPoint23.Y = 5D;
            lPoint24.Label = "December";
            lPoint24.Y = 16D;
            gunaHorizontalBarDataset1.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] { lPoint13, lPoint14, lPoint15, lPoint16, lPoint17, lPoint18, lPoint19, lPoint20, lPoint21, lPoint22, lPoint23, lPoint24 });
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            tileBtn.DefaultAnimation = animation2;
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
            Controls.Add(sidebarPanel);
            Controls.Add(guna2Panel1);
            Controls.Add(tabControl1);
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
            panelStock.ResumeLayout(false);
            guna2Panel15.ResumeLayout(false);
            guna2Panel15.PerformLayout();
            guna2Panel16.ResumeLayout(false);
            guna2Panel16.PerformLayout();
            ((ISupportInitialize)guna2PictureBox1).EndInit();
            lblorder.ResumeLayout(false);
            guna2Panel14.ResumeLayout(false);
            guna2Panel14.PerformLayout();
            ((ISupportInitialize)guna2DataGridView5).EndInit();
            panelOrder.ResumeLayout(false);
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
        protected Guna2Button dashboardbtn;
        protected Guna2Button rolesbtn;
        protected Guna2Button statisticsbtn;
        protected Guna2Button ordersbtn;
        protected Guna2Button stocksbtn;
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
        private Guna2Panel panelStock;
        private Guna2VScrollBar stockScrollbar;
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
        private Guna2Panel panelOrder;
        private Guna2VScrollBar orderScrollbar;
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
        private FlowLayoutPanel stockPanel;
        private Label label27;
        private Guna2CirclePictureBox guna2CirclePictureBox5;
        private Guna2Panel guna2Panel22;
        private FlowLayoutPanel orderPanel;
        private Guna2Panel guna2Panel23;
        private Guna2Panel guna2Panel24;
        private Guna2Panel guna2Panel25;
        private Guna2Panel guna2Panel26;
        private Guna2Panel guna2Panel27;
        private Guna2Panel guna2Panel28;
        private Guna2Panel guna2Panel29;
        private Guna2Panel guna2Panel30;
        private Guna2Panel guna2Panel31;
        private Guna2Panel guna2Panel32;
        private Guna2Panel guna2Panel33;
        private Guna2Panel guna2Panel34;
        private Guna2Panel guna2Panel35;
        private Guna2Panel guna2Panel36;
        private Guna2Button manageBtn;
    }
}
