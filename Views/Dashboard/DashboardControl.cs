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
        User user = Database.userLogged.Get();
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
            CalNutritionOfTheDay();
        }
        private void CalNutritionOfTheDay()
        {
            List<float> nutritionOfTheDay = [0F, 0F, 0F, 0F, 0F, 0F];
            for (int i = 0; i < 4; i++)
            {
                List<MealItem> meals = Database.MealsOfADay[i].GetRowOfMealItems(DateTime.UtcNow);
                if (meals != null)
                {
                    foreach (MealItem mealItem in meals)
                    {
                        Food? food = Database.MyFoods.GetFoodIfExist(mealItem.FoodId);
                        Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
                        if (food != null && unit != null)
                        {
                            // Lemak, karbo, protein, serat, gula, kalori
                            float kalori = Calculation.Calori.CaloriCal(
                                                        protein: mealItem.Protein,
                                                        karbo: mealItem.Karbohidrat,
                                                        lemak: mealItem.Lemak,
                                                        gula: mealItem.Gula,
                                                        serat: mealItem.Serat
                                                    );
                            nutritionOfTheDay[0] += mealItem.Lemak;         // Lemak
                            nutritionOfTheDay[1] += mealItem.Serat;         // Serat
                            nutritionOfTheDay[2] += mealItem.Protein;       // Protein
                            nutritionOfTheDay[3] += mealItem.Karbohidrat;
                            nutritionOfTheDay[4] += kalori;            // Karbo
                            nutritionOfTheDay[5] += mealItem.Gula;          // Gula
                        }
                    }
                }
            }
            nutritionNeeded(nutritionOfTheDay);
        }
        private void nutritionNeeded(List<float> nutritionValADay)
        {
            int count = 0;
            List<float> nutriNeed = Database.userLogged.GetNutritionNeeded(DateTime.UtcNow);
            List<int> index = [5, 9, 4, 8, 3];
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (count == 5)
                {
                    break;
                }
                else
                {
                    Label label = ctrl as Label;
                    label.Text = MathF.Round(nutritionValADay[count], 2) + "/" + nutriNeed[index[count]].ToString(); //+ " gram";
                    count++;
                }
            }
            // groupBox1.Controls[4].Text = MathF.Round(nutritionValADay[4], 2) + "/" + nutriNeed[index[4]].ToString() + " kkal";//kebutuhan kalori
            groupBox1.Controls[5].Text = MathF.Round(nutritionValADay[5], 2) + "/" + "50"; // Kebutuhan gula
        }
    }
}
