﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriNyan.Models;

namespace NutriNyan.Views.Dashboard
{
    public partial class SearchFoodForm : Form
    {
        private Dictionary<string, string> sumDict = new Dictionary<string, string>();
        private FlowLayoutPanel SearchflowLayoutPanel;
        private Dictionary<string, float> pselectedFood;
        private string[] pfoodNameNSum;
        public SearchFoodForm(Dictionary<string, float> selectedFood, string[] foodName)
        {
            InitializeComponent();
            this.pselectedFood = selectedFood;
            this.pfoodNameNSum = foodName;
        }

        private void SearchFoodForm_Load(object sender, EventArgs e)
        {
            LoadDataCariMakan();
        }
        private void LoadDataCariMakan()
        {
            // 4 aja, soalnya ku setting 4 juga
            List<Food>? foods = Database.MyFoods.GetLatestAddedFoods() ?? [];

            FlowLayoutPanel cardContainer = new FlowLayoutPanel();
            cardContainer.Dock = DockStyle.Fill;
            cardContainer.FlowDirection = FlowDirection.TopDown;
            cardContainer.WrapContents = false;
            cardContainer.AutoScroll = true;
            cardContainer.Padding = new Padding(10, 120, 0, 0);
            cariMakanTabPage.Controls.Add(cardContainer);

            for (int i = 0; i < 4; i++)
            {
                Panel card = new Panel();
                card.Size = new Size(750, 120);
                card.Margin = new Padding(10);
                card.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                card.BackColor = Color.FromArgb(1, 54, 63);

                Label title = new Label();
                title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                title.Location = new Point(10, 10);
                title.AutoSize = true;
                title.ForeColor = Color.White;
                card.Controls.Add(title);

                Label desc = new Label();
                desc.Font = new Font("Segoe UI", 9);
                desc.Location = new Point(10, 35);
                desc.MaximumSize = new Size(700, 0);
                desc.AutoSize = true;
                desc.ForeColor = Color.White;
                card.Controls.Add(desc);

                Button btn = new Button();
                btn.Text = "Pilih";
                btn.Size = new Size(80, 25);
                btn.Location = new Point(10, 80);
                btn.BackColor = Color.FromArgb(0, 221, 220);
                btn.ForeColor = Color.FromArgb(1, 54, 63);
                btn.Font = new Font("Segoe UI", 9);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                // btn.Name = item; Dont forget to change button name
                btn.Click += foodButtonClicked;
                card.Controls.Add(btn);

                cardContainer.Controls.Add(card);
            }
            this.sumDict.Clear();
            for (int i = 0; i < foods.Count; i++)
            {
                ((Label)cardContainer.Controls[i].Controls[0]).Text = foods[i].Name;
                ((Label)cardContainer.Controls[i].Controls[1]).Text = foods[i].Summary;
                this.sumDict.Add(foods[i].Name, foods[i].Summary);
                ((Button)cardContainer.Controls[i].Controls[2]).Name = Logic.GetFoodName(foods[i].Name); // Change button name
                cardContainer.Controls[i].Show();
            }
            for (int i = foods.Count; i < 4; i++)
            {
                ((Panel)cardContainer.Controls[i]).Hide();
            }
            this.SearchflowLayoutPanel = cardContainer;
        }
        private async void foodButtonClicked(object sender, EventArgs e)
        {
            string foodName = Logic.FoodNameTitleCase(((Button)sender).Name);
            Food? food = Database.MyFoods.GetFoodIfExist(foodName);
            if (food == null) {
                Dictionary<string, float>? result = await Api.GetReq(http_string: Api.fatsecretLinkFormat + ((Button)sender).Name);
                if (result != null && result.Count != 0)
                {
                    this.pselectedFood.Clear();
                    foreach (var kv in result)
                    {
                        pselectedFood.Add(kv.Key, kv.Value);
                    }
                    this.pfoodNameNSum[0] = Logic.FoodNameTitleCase(((Button)sender).Name);
                    this.pfoodNameNSum[1] = sumDict[((Button)sender).Name];
                    bool resultAddFood = Database.MyFoods.AddFood(
                        userId: Database.userLogged.Get().Id,
                        foodName: this.pfoodNameNSum[0],
                        karbohidrat: pselectedFood["Karbohidrat"],
                        protein: pselectedFood["Protein"],
                        lemak: pselectedFood["Lemak"],
                        serat: pselectedFood["Serat"],
                        gula: pselectedFood["Gula"],
                        summary: this.pfoodNameNSum[1]
                    );
                    if (resultAddFood)
                    {
                        this.Hide();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show($"Terjadi kesalahan saat Saving ke Database", "Information", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show($"Terjadi kesalahan\nSaat mencoba mengambil data makanan yang dipilih", "Information", MessageBoxButtons.OK);
                }
            } else {
                Unit? unit = Database.units.GetUnitIfExist("1 Porsi" + " " + food.Name);
                this.pselectedFood.Clear();
                if (unit != null) {
                    pselectedFood.Add("1 Porsi", unit.Weight);
                    
                } else {
                }
                pselectedFood.Add("Lemak", food.Lemak);
                pselectedFood.Add("Protein", food.Protein);
                pselectedFood.Add("Karbohidrat", food.Karbohidrat);
                pselectedFood.Add("Serat", food.Serat);
                pselectedFood.Add("Gula", food.Gula);
                this.pfoodNameNSum[0] = food.Name;
                this.pfoodNameNSum[1] = food.Summary;
                this.Hide();
                this.Dispose();
            }
        }
        private async void searchButtonClicked(object sender, EventArgs e)
        {
            string foodName = Logic.GetFoodName(searchTextBox.Text); // mmie-aya
            if (foodName != null)
            {
                Task<List<List<string>>?> getReq = Api.GetRecomendation(foodName);
                await Api.WaitingWindow(getReq);
                List<List<string>>? result = getReq.Result;
                if (result != null)
                {
                }
                else
                {
                    List<Food>? someFood = Database.MyFoods.GetSomeFood(searchTextBox.Text);
                    if (someFood != null)
                    {
                        result = new List<List<string>>();
                        foreach (Food food in someFood)
                        {
                            result.Add([food.Name, food.Summary]);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Terjadi kesalahan", "Information", MessageBoxButtons.OK);
                        return;
                    }
                }
                int count = 0;
                this.sumDict.Clear();
                for (int i = 0; i < result.Count; i++)
                {
                    ((Label)((Panel)this.SearchflowLayoutPanel.Controls[i]).Controls[0]).Text = Logic.FoodNameTitleCase(result[i][0]);
                    ((Label)((Panel)this.SearchflowLayoutPanel.Controls[i]).Controls[1]).Text = result[i][1];
                    this.sumDict.Add(result[i][0], result[i][1]);
                    ((Button)((Panel)this.SearchflowLayoutPanel.Controls[i]).Controls[2]).Name = result[i][0];
                    ((Panel)this.SearchflowLayoutPanel.Controls[i]).Show();
                    count++;
                }
                for (int i = count; i < 4; i++)
                {
                    ((Panel)this.SearchflowLayoutPanel.Controls[i]).Hide();
                }
            }
        }
    }
}
