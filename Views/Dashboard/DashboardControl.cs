using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms.DataVisualization.Charting;

namespace NutriNyan.Views.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        User user = Database.userLogged.user;
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series series = chart2.Series.Add("Kalori");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Auto;
            series.Color = Color.Yellow;
            series.IsValueShownAsLabel = true;
            series.LabelBackColor = Color.GreenYellow;
            series["PointWidth"] = "0.6";
            series.XValueType = ChartValueType.String;
            chart2.Series["Kalori"].IsXValueIndexed = true;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 3000;

            // Menambahan data ke tabel kotak
            series.Points.AddXY("senin", 99);
            series.Points.AddXY("selasa", 169);
            series.Points.AddXY("rabu", 187);
            series.Points.AddXY("kamis", 125);
            series.Points.AddXY("jumat", 156);
            series.Points.AddXY("sabtu", 225);
            series.Points.AddXY("minggu", 112);
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            label1.Text = $"Halo {user.Username}, Selamat Datang!";
        }
    }
}
