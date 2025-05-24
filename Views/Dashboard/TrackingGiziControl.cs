using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriNyan.Models;
using NutriNyan.Views.Auth;

namespace NutriNyan.Views.Dashboard
{
    public partial class TrackingGiziControl : UserControl
    {
        public TrackingGiziControl(DateTime? dateTime = null)
        {
            InitializeComponent();
            trackingDateTimePicker.Value = dateTime ?? DateTime.Now;
        }

        private void TrackingGiziControl_Load(object sender, EventArgs e)
        {
            sarapanGridView.Columns.Add("makanan", "Makanan");
            sarapanGridView.Columns.Add("satuan", "Satuan");
            sarapanGridView.Columns.Add("lemak", "Lemak");
            sarapanGridView.Columns.Add("karbo", "Karbo");
            sarapanGridView.Columns.Add("protein", "Protein");
            sarapanGridView.Columns.Add("serat", "Serat");
            sarapanGridView.Columns.Add("gula", "Gula");
            sarapanGridView.Columns.Add("kalori", "Kalori");
            sarapanGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            });
            sarapanGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Hapus",
                UseColumnTextForButtonValue = true,
                Text = "Hapus"
            });
            List<MealItem> mealsPagi = Database.GetRowOfMealItems(date: trackingDateTimePicker.Value.ToUniversalTime(), mealType: Database.MealTypes[0]);
            if (mealsPagi != null)
            {
                foreach (MealItem mealItem in mealsPagi)
                {
                    Food? food = Database.GetFoodIfExist(mealItem.FoodId);
                    Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
                    if (food != null && unit != null)
                    {
                        // Lemak, karbo, protein, serat, gula, kalori
                        sarapanGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
                                                mealItem.Protein, mealItem.Serat, mealItem.Gula,
                                                Calculation.Nutrition.CaloriCal(
                                                    protein: mealItem.Protein,
                                                    karbo: mealItem.Karbohidrat,
                                                    lemak: mealItem.Lemak,
                                                    gula: mealItem.Gula,
                                                    serat: mealItem.Serat
                                                ));
                    }
                }
            }
            // sarapanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // sarapanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");

            makanSiangGridView.Columns.Add("makanan", "Makanan");
            makanSiangGridView.Columns.Add("satuan", "Satuan");
            makanSiangGridView.Columns.Add("lemak", "Lemak");
            makanSiangGridView.Columns.Add("karbo", "Karbo");
            makanSiangGridView.Columns.Add("protein", "Protein");
            makanSiangGridView.Columns.Add("serat", "Serat");
            makanSiangGridView.Columns.Add("gula", "Gula");
            makanSiangGridView.Columns.Add("kalori", "Kalori");
            makanSiangGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            });
            makanSiangGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Hapus",
                UseColumnTextForButtonValue = true,
                Text = "Hapus"
            });
            // makanSiangGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            List<MealItem> mealsSiang = Database.GetRowOfMealItems(date: trackingDateTimePicker.Value.ToUniversalTime(), mealType: Database.MealTypes[1]);
            if (mealsSiang != null)
            {
                foreach (MealItem mealItem in mealsSiang)
                {
                    Food? food = Database.GetFoodIfExist(mealItem.FoodId);
                    Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
                    if (food != null && unit != null)
                    {
                        // Lemak, karbo, protein, serat, gula, kalori
                        makanSiangGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
                                                mealItem.Protein, mealItem.Serat, mealItem.Gula,
                                                Calculation.Nutrition.CaloriCal(
                                                    protein: mealItem.Protein,
                                                    karbo: mealItem.Karbohidrat,
                                                    lemak: mealItem.Lemak,
                                                    gula: mealItem.Gula,
                                                    serat: mealItem.Serat
                                                ));
                    }
                }
            }

            makanMalamGridView.Columns.Add("makanan", "Makanan");
            makanMalamGridView.Columns.Add("satuan", "Satuan");
            makanMalamGridView.Columns.Add("lemak", "Lemak");
            makanMalamGridView.Columns.Add("karbo", "Karbo");
            makanMalamGridView.Columns.Add("protein", "Protein");
            makanMalamGridView.Columns.Add("serat", "Serat");
            makanMalamGridView.Columns.Add("gula", "Gula");
            makanMalamGridView.Columns.Add("kalori", "Kalori");
            makanMalamGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            });
            makanMalamGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Hapus",
                UseColumnTextForButtonValue = true,
                Text = "Hapus"
            });
            // makanMalamGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            List<MealItem> mealsMalam = Database.GetRowOfMealItems(date: trackingDateTimePicker.Value.ToUniversalTime(), mealType: Database.MealTypes[2]);
            if (mealsMalam != null)
            {
                foreach (MealItem mealItem in mealsMalam)
                {
                    Food? food = Database.GetFoodIfExist(mealItem.FoodId);
                    Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
                    if (food != null && unit != null)
                    {
                        // Lemak, karbo, protein, serat, gula, kalori
                        makanMalamGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
                                                mealItem.Protein, mealItem.Serat, mealItem.Gula,
                                                Calculation.Nutrition.CaloriCal(
                                                    protein: mealItem.Protein,
                                                    karbo: mealItem.Karbohidrat,
                                                    lemak: mealItem.Lemak,
                                                    gula: mealItem.Gula,
                                                    serat: mealItem.Serat
                                                ));
                    }
                }
            }

            jajanGridView.Columns.Add("makanan", "Makanan");
            jajanGridView.Columns.Add("satuan", "Satuan");
            jajanGridView.Columns.Add("lemak", "Lemak");
            jajanGridView.Columns.Add("karbo", "Karbo");
            jajanGridView.Columns.Add("protein", "Protein");
            jajanGridView.Columns.Add("serat", "Serat");
            jajanGridView.Columns.Add("gula", "Gula");
            jajanGridView.Columns.Add("kalori", "Kalori");
            jajanGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            });
            jajanGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Hapus",
                UseColumnTextForButtonValue = true,
                Text = "Hapus"
            });
            // jajanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            List<MealItem> mealsJajan = Database.GetRowOfMealItems(date: trackingDateTimePicker.Value.ToUniversalTime(), mealType: Database.MealTypes[3]);
            if (mealsJajan != null)
            {
                foreach (MealItem mealItem in mealsJajan)
                {
                    Food? food = Database.GetFoodIfExist(mealItem.FoodId);
                    Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
                    if (food != null && unit != null)
                    {
                        // Lemak, karbo, protein, serat, gula, kalori
                        jajanGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
                                                mealItem.Protein, mealItem.Serat, mealItem.Gula,
                                                Calculation.Nutrition.CaloriCal(
                                                    protein: mealItem.Protein,
                                                    karbo: mealItem.Karbohidrat,
                                                    lemak: mealItem.Lemak,
                                                    gula: mealItem.Gula,
                                                    serat: mealItem.Serat
                                                ));
                    }
                }
            }
            Database.EnsureNutritionLog(DateTime.UtcNow, "Unknown");
        }

        private void makanButton_Click(object sender, EventArgs e)
        {
            Button tombolClick = sender as Button;
            string tipeMakan = tombolClick.Tag.ToString();
            MessageBox.Show($"Tag Tipe Makan: {tipeMakan}", "Information", MessageBoxButtons.OK);
            DashboardMainForm dashboardMainForm = (DashboardMainForm)Application.OpenForms["DashboardMainForm"];
            dashboardMainForm.PanelContent.Controls.Clear();
            AddGiziControl addGizi = new AddGiziControl(tipeMakan, trackingDateTimePicker.Value.ToUniversalTime());
            addGizi.Dock = DockStyle.Fill;
            dashboardMainForm.PanelContent.Controls.Add(addGizi);
        }

        private void sarapanGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowNumber,
                                  this.Font,
                                  SystemBrushes.ControlText,
                                  headerBounds,
                                  centerFormat);
        }

        private void makanSiangGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowNumber,
                                  this.Font,
                                  SystemBrushes.ControlText,
                                  headerBounds,
                                  centerFormat);
        }

        private void makanMalamGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowNumber,
                                  this.Font,
                                  SystemBrushes.ControlText,
                                  headerBounds,
                                  centerFormat);
        }

        private void jajanGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowNumber,
                                  this.Font,
                                  SystemBrushes.ControlText,
                                  headerBounds,
                                  centerFormat);
        }
        private void trackDatePickChanged(object sender, EventArgs e)
        {
            DateTimePicker senderDate = sender as DateTimePicker;
            Database.EnsureNutritionLog(senderDate.Value.ToUniversalTime(), "ChangedValue");
        }
    }
}
