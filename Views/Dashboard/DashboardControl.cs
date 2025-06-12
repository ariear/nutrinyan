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
using static Database;

namespace NutriNyan.Views.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            label1.Text = $"Halo {userLogged.Get().Username}, Selamat Datang!";

            var dailyCalories = Database.GetWeeklyCalories();
            chart2.Series["Kalori"].Points.Clear();

            double maxCalories = dailyCalories.Max(d => d.Value);
            double yAxisMax = Math.Ceiling(maxCalories / 100.0) * 100;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = yAxisMax;

            foreach (var day in dailyCalories)
            {
                var dataPoint = new DataPoint();
                dataPoint.AxisLabel = day.Key;
                dataPoint.YValues = new double[] { day.Value };
                dataPoint.IsValueShownAsLabel = true;
                dataPoint.LabelBackColor = Color.GreenYellow;
                dataPoint.Label = $"{day.Value:N0} kcal";

                chart2.Series["Kalori"].Points.Add(dataPoint);
            }
        }

    }
}
