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

namespace NutriNyan.Views.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        Dictionary<string, float> result;
        public DashboardControl()
        {
            InitializeComponent();
            label1.Text = $"Halo {Database.Username}. Semoga Harimu Menyenangkan";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Process and format foodName from user input for http request
            string? foodNameProc = Logic.GetFoodName(foodName.Text);
            if (foodNameProc != null) // null if there is no single character
            {
                Food food = Database.GetFoodIfExist(foodName: foodNameProc);
                if (food != null)
                {

                }
                else
                {
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    using (var dbContext = new AppDbContext(optionsBuilder.Options))
                    // await html of the http request
                    result = await Api.GetReq(Api.fatsecretLinkFormat + foodNameProc);
                    if (result != null) // Null if there is error when try to reach the website
                    {
                        if (result.Count != 0) // 0 if the page did exist
                        {
                            // print out the result of the http request
                            string resultText = "Hasil Pencarian untuk " + foodName.Text;
                            foreach (KeyValuePair<string, float> item in result)
                            {
                                resultText += $"\n{item.Key}: {item.Value}";
                            }
                            ResultLab.Text = resultText;
                            // Database.AddFood(
                            //     user: Database.GetUserIfExist(Username),
                            //     foodName: Logic.FoodNameTitleCase(foodNameProc),
                            //     karbohidrat: result["Karbohidrat"],
                            //     protein: result["Protein"],
                            //     lemak: result["Lemak"],
                            //     serat: result["Serat"],
                            //     gula: result["Gula"],
                            //     unitId: 
                            //     );
                        }
                        else
                        {
                            ResultLab.Text = $"Maaf, pencarian untuk {foodName.Text} tidak ada";
                        }
                    }
                    else
                    {
                        ResultLab.Text = "Terdapat kesalahan, silakan coba lagi nanti";
                    }
                }
            }else
            {
                ResultLab.Text = "Inputan tidak boleh kosong.";
            }
        }
    }
}
