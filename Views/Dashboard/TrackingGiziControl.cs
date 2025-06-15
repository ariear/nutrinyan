using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using NutriNyan.Models;
using NutriNyan.Views.Auth;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace NutriNyan.Views.Dashboard
{
    public partial class TrackingGiziControl : UserControl
    {
        bool IsInitialize = false;
        public TrackingGiziControl(DateTime? dateTime = null)
        {
            InitializeComponent();
            trackingDateTimePicker.Value = dateTime ?? DateTime.Now;
            IsInitialize = true;
        }

        private void TrackingGiziControl_Load(object sender, EventArgs e)
        {
            sarapanGridView.Columns.Add("makanan", "Makanan");
            sarapanGridView.Columns.Add("berat", "Berat");
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
            makanSiangGridView.Columns.Add("makanan", "Makanan");
            makanSiangGridView.Columns.Add("berat", "Berat");
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
            makanMalamGridView.Columns.Add("makanan", "Makanan");
            makanMalamGridView.Columns.Add("berat", "Berat");
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
            jajanGridView.Columns.Add("makanan", "Makanan");
            jajanGridView.Columns.Add("berat", "Berat");
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
            GridViewFill();
        }
        private void GridViewFill()
        {
            Database.EnsureNutritionLog(trackingDateTimePicker.Value, "Unknown");
            List<DataGridView> dataGridObjects = [sarapanGridView, makanSiangGridView, makanMalamGridView, jajanGridView];
            List<Label> kaloriLabels = [totalKaloriPagi, totalKaloriSiang, totalKaloriMalam, totalKaloriJajan];
            float totalKaloriADay = 0;
            // Lemak i_0, Serat i_1, Protein i_2, Karbo i_3, Kalori i_4, Gula i_5
            List<float> nutritionOfTheDay = [0F, 0F, 0F, 0F, 0F, 0F];
            for (int i = 0; i < 4; i++)
            {
                List<MealItem> meals = Database.MealsOfADay[i].GetRowOfMealItems(trackingDateTimePicker.Value);
                if (meals != null)
                {
                    float totalKalori = 0;
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
                            totalKalori += kalori;
                            dataGridObjects[i].Rows.Add(food.Name, MathF.Round(mealItem.Qty * unit.Weight).ToString() + " gram", mealItem.Lemak,
                                                    mealItem.Karbohidrat, mealItem.Protein, mealItem.Serat, mealItem.Gula, kalori
                                                    );
                            nutritionOfTheDay[0] += mealItem.Lemak;         // Lemak
                            nutritionOfTheDay[1] += mealItem.Serat;         // Serat
                            nutritionOfTheDay[2] += mealItem.Protein;       // Protein
                            nutritionOfTheDay[3] += mealItem.Karbohidrat;   // Karbo
                            nutritionOfTheDay[5] += mealItem.Gula;          // Gula
                        }
                    }
                    nutritionOfTheDay[4] += totalKalori; // Kalori
                    kaloriLabels[i].Text = ((int)totalKalori).ToString();
                }
            }
            KaloriValLab.Text = ((int)totalKaloriADay).ToString() + "/" + KaloriValLab.Text.Split("/")[1];
            nutritionNeeded(nutritionOfTheDay);
            // int iconButCount = 4;
            // for (int i = 0; i < iconButCount; i++)
            // {
            //     Controls[i].Tag = i.ToString();
            // }
            // List<MealItem> mealsPagi =  Database.MealsOfADay[0].GetRowOfMealItems(trackingDateTimePicker.Value);
            // if (mealsPagi != null)
            // {
            //     float totalKalori = 0;
            //     foreach (MealItem mealItem in mealsPagi)
            //     {
            //         Food? food = Database.GetFoodIfExist(mealItem.FoodId);
            //         Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
            //         if (food != null && unit != null)
            //         {
            //             // Lemak, karbo, protein, serat, gula, kalori
            //             float kalori = Calculation.Calori.CaloriCal(
            //                                         protein: mealItem.Protein,
            //                                         karbo: mealItem.Karbohidrat,
            //                                         lemak: mealItem.Lemak,
            //                                         gula: mealItem.Gula,
            //                                         serat: mealItem.Serat
            //                                     );
            //             totalKalori += kalori;
            //             sarapanGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
            //                                     mealItem.Protein, mealItem.Serat, mealItem.Gula, kalori
            //                                     );
            //         }
            //     }
            // }
            // // sarapanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // // sarapanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // // makanSiangGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // List<MealItem> mealsSiang =  Database.MealsOfADay[1].GetRowOfMealItems(trackingDateTimePicker.Value);
            // if (mealsSiang != null)
            // {
            //     foreach (MealItem mealItem in mealsSiang)
            //     {
            //         Food? food = Database.GetFoodIfExist(mealItem.FoodId);
            //         Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
            //         if (food != null && unit != null)
            //         {
            //             // Lemak, karbo, protein, serat, gula, kalori
            //             makanSiangGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
            //                                     mealItem.Protein, mealItem.Serat, mealItem.Gula,
            //                                     Calculation.Calori.CaloriCal(
            //                                         protein: mealItem.Protein,
            //                                         karbo: mealItem.Karbohidrat,
            //                                         lemak: mealItem.Lemak,
            //                                         gula: mealItem.Gula,
            //                                         serat: mealItem.Serat
            //                                     ));
            //         }
            //     }
            // }
            // // makanMalamGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // List<MealItem> mealsMalam =  Database.MealsOfADay[2].GetRowOfMealItems(trackingDateTimePicker.Value);
            // if (mealsMalam != null)
            // {
            //     foreach (MealItem mealItem in mealsMalam)
            //     {
            //         Food? food = Database.GetFoodIfExist(mealItem.FoodId);
            //         Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
            //         if (food != null && unit != null)
            //         {
            //             // Lemak, karbo, protein, serat, gula, kalori
            //             makanMalamGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
            //                                     mealItem.Protein, mealItem.Serat, mealItem.Gula,
            //                                     Calculation.Calori.CaloriCal(
            //                                         protein: mealItem.Protein,
            //                                         karbo: mealItem.Karbohidrat,
            //                                         lemak: mealItem.Lemak,
            //                                         gula: mealItem.Gula,
            //                                         serat: mealItem.Serat
            //                                     ));
            //         }
            //     }
            // }
            // // jajanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
            // List<MealItem> mealsJajan = Database.MealsOfADay[3].GetRowOfMealItems(trackingDateTimePicker.Value);
            // if (mealsJajan != null)
            // {
            //     foreach (MealItem mealItem in mealsJajan)
            //     {
            //         Food? food = Database.GetFoodIfExist(mealItem.FoodId);
            //         Unit? unit = Database.units.GetUnitIfExist(mealItem.UnitId);
            //         if (food != null && unit != null)
            //         {
            //             // Lemak, karbo, protein, serat, gula, kalori
            //             jajanGridView.Rows.Add(food.Name, unit.UnitType, mealItem.Lemak, mealItem.Karbohidrat,
            //                                     mealItem.Protein, mealItem.Serat, mealItem.Gula,
            //                                     Calculation.Calori.CaloriCal(
            //                                         protein: mealItem.Protein,
            //                                         karbo: mealItem.Karbohidrat,
            //                                         lemak: mealItem.Lemak,
            //                                         gula: mealItem.Gula,
            //                                         serat: mealItem.Serat
            //                                     ));
            //         }
            //     }
            // }
        }

        private void DataGridContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = sender as DataGridView;
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                MealItem mealItem = Database.MealsOfADay[Int32.Parse((string)senderGrid.Tag)].GetRowOfMealItems(trackingDateTimePicker.Value)[e.RowIndex];
                DashboardMainForm dashboardMainForm = (DashboardMainForm)System.Windows.Forms.Application.OpenForms["DashboardMainForm"];
                dashboardMainForm.PanelContent.Controls.Clear();
                EditMakanan editMakanan = new EditMakanan(mealItem, trackingDateTimePicker.Value);
                editMakanan.Dock = DockStyle.Fill;
                dashboardMainForm.PanelContent.Controls.Add(editMakanan);
            }
            else if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                try
                {
                    var result = MessageBox.Show(
                        "apakah anda yakin menghapus daftar ini?",
                        "Konfirmasi Hapus",
                        (MessageBoxButton)MessageBoxButtons.YesNo,
                        (MessageBoxImage)MessageBoxIcon.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        Database.NutritionLogOfDay nutDay = Database.MealsOfADay[Int32.Parse((string)senderGrid.Tag)];
                        MealItem mealItem = nutDay.GetRowOfMealItems(trackingDateTimePicker.Value)[e.RowIndex];
                        Database.NutritionLogOfDay.RemoveMealItem(mealItem);
                        RefreshGridView();
                    }
                    if (result == MessageBoxResult.No)
                    {
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show($"Error\n{E}");
                }
            }
        }
        private void RefreshGridView()
        {
            if (sarapanGridView != null)
            {
                sarapanGridView.Rows.Clear();
                makanSiangGridView.Rows.Clear();
                makanMalamGridView.Rows.Clear();
                jajanGridView.Rows.Clear();
            }
            GridViewFill();
        }

        private void makanButton_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton tombolClick = sender as FontAwesome.Sharp.IconButton;
            Database.NutritionLogOfDay meal = Database.MealsOfADay[Int32.Parse((string)tombolClick.Tag)];
            DashboardMainForm dashboardMainForm = (DashboardMainForm)System.Windows.Forms.Application.OpenForms["DashboardMainForm"];
            dashboardMainForm.PanelContent.Controls.Clear();
            AddGiziControl addGizi = new AddGiziControl(meal, trackingDateTimePicker.Value);
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
            if (IsInitialize)
            {
                RefreshGridView();
            }
        }

        private void nutritionNeeded(List<float> nutritionValADay)
        {
            int count = 0;
            List<float> nutriNeed = Database.userLogged.GetNutritionNeeded(trackingDateTimePicker.Value.ToUniversalTime());
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
