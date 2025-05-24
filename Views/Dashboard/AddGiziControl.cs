using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using NutriNyan.Models;

namespace NutriNyan.Views.Dashboard
{
    public partial class AddGiziControl : UserControl
    {
        private string tipeMakan = "";
        private DateTime trackingDateTime;
        private Dictionary<string, float> selectedFood = new Dictionary<string, float>();
        private string[] foodNameNSum = ["", ""]; // [foodName, Summary]
        public AddGiziControl(string tipeMakan, DateTime trackingDateTime)
        {
            InitializeComponent();

            this.tipeMakan = tipeMakan;
            this.trackingDateTime = trackingDateTime;
        }

        private void searchFoodButton_Click(object sender, EventArgs e)
        {
            SearchFoodForm searchFoodForm = new SearchFoodForm(selectedFood, foodNameNSum);
            searchFoodForm.ShowDialog();
            FillNutriData();
        }
        private void FillNutriData()
        {
            if (this.selectedFood.Count != 0)
            {
                Unit unit = Database.units.GetUnitIfExist("1 Porsi " + this.foodNameNSum[0]);
                if (unit == null)
                {
                    if (selectedFood["1 Porsi"] != 0)
                    {
                        Database.units.AddUnit(
                            unitType: "1 Porsi" + " " + this.foodNameNSum[0],
                            weight: selectedFood["1 Porsi"]
                        );
                    }
                }
                try
                {
                    float multiply = 1;
                    foodNameBox.Text = this.foodNameNSum[0];
                    if (selectedFood["1 Porsi"] != 0)
                    {
                        unitSizeComboBox.DataSource = (List<string>)["1 Porsi"];
                        multiply = selectedFood["1 Porsi"] / 100; // Here
                    }
                    UnitValueBox.Text = $"{selectedFood["1 Porsi"] * multiply}";
                    LemakTextBox.Text = $"{selectedFood["Lemak"] * multiply}";
                    ProtTextBox.Text = $"{selectedFood["Protein"] * multiply}";
                    KarbTextBox.Text = $"{selectedFood["Karbohidrat"] * multiply}";
                    SeratTextBox.Text = $"{selectedFood["Serat"] * multiply}";
                    GulaTextBox.Text = $"{selectedFood["Gula"] * multiply}";
                    KaloriTextBox.Text = Nutrition.CaloriCal(
                        protein: selectedFood["Protein"] * multiply,
                        karbo: selectedFood["Karbohidrat"] * multiply,
                        lemak: selectedFood["Lemak"] * multiply,
                        gula: selectedFood["Gula"] * multiply,
                        serat: selectedFood["Serat"] * multiply
                    ).ToString();
                }
                catch
                {
                    MessageBox.Show("Terjadi kesalahan on Adding", "Information", MessageBoxButtons.OK);
                }
            }
        }

        private void AddGiziControl_Load(object sender, EventArgs e)
        {
            title.Text = $"Tambah Makanan yang Dikonsumsi pada {trackingDateTime.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
            periode.Text = $"Periode Makan : {tipeMakan}";
        }
        private void SaveFoodButtonClicked(object sender, EventArgs e)
        {
            Unit? unit = Database.units.GetUnitIfExist("1 Porsi" + " " + this.foodNameNSum[0]);
            Meal? meal = Database.GetMealIfExist(tipeMakan, trackingDateTime);
            Food? food = Database.MyFoods.GetFoodIfExist(this.foodNameNSum[0]);
            if (unit != null && meal != null && food != null)
            {
                MessageBox.Show("Waiting", "Information", MessageBoxButtons.OK);
                bool resultAddMealItem = Database.AddMealItem(
                    mealId: meal.Id,
                    foodId: food.Id,
                    qty: Single.Parse(UnitValueBox.Text), // Need adjustment
                    karbohidrat: Single.Parse(KarbTextBox.Text),
                    protein: Single.Parse(ProtTextBox.Text),
                    lemak: Single.Parse(LemakTextBox.Text),
                    serat: Single.Parse(SeratTextBox.Text),
                    gula: Single.Parse(GulaTextBox.Text),
                    unitId: unit.Id
                );
                if (resultAddMealItem)
                {
                    MessageBox.Show("Success saving", "Information", MessageBoxButtons.OK);
                    DashboardMainForm dashboardMainForm = (DashboardMainForm)Application.OpenForms["DashboardMainForm"];
                    dashboardMainForm.PanelContent.Controls.Clear();
                    TrackingGiziControl trackingGizi = new TrackingGiziControl(dateTime: trackingDateTime);
                    trackingGizi.Dock = DockStyle.Fill;
                    dashboardMainForm.PanelContent.Controls.Add(trackingGizi);
                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to Save", "Information", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show($"Terjadi kesalahan pada saving food\nUnit: {unit}\tmeal: {meal}\tfood: {food}", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
