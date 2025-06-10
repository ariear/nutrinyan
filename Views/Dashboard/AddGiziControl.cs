using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private Database.NutritionLogOfDay MealOfADay { get; set; }
        private List<Unit> unitsList = Database.units.GetDefaultUnits() ?? []; 
        private DateTime trackingDateTime { get; set; }
        private Dictionary<string, float> selectedFood = new Dictionary<string, float>();
        private string[] foodNameNSum = ["", ""]; // [foodName, Summary]
        public AddGiziControl(Database.NutritionLogOfDay MealOfADay, DateTime trackingDateTime)
        {
            InitializeComponent();
            this.MealOfADay = MealOfADay;
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
                    if (selectedFood.ContainsKey("1 Porsi"))
                    {
                        Database.units.AddUnit(
                            unitType: "1 Porsi" + " " + this.foodNameNSum[0],
                            weight: selectedFood["1 Porsi"]
                        );
                    }
                }
                try
                {
                    foodNameBox.Text = this.foodNameNSum[0];
                    if (selectedFood.ContainsKey("1 Porsi"))
                    {
                        List<Unit> DataSourceStore = (List<Unit>)(unitSizeComboBox.DataSource ?? new List<Unit>());
                        if (DataSourceStore.Count < 4)
                        {
                            Unit? unitLocal = Database.units.GetUnitIfExist("1 Porsi" + " " + this.foodNameNSum[0]);
                            if (unitLocal != null)
                            {
                                DataSourceStore.Add(Database.units.GetUnitIfExist("1 Porsi" + " " + this.foodNameNSum[0])!);
                            }
                        }
                        else
                        {
                            DataSourceStore.RemoveAt(DataSourceStore.Count - 1);
                            DataSourceStore.Add(Database.units.GetUnitIfExist("1 Porsi" + " " + this.foodNameNSum[0])!);
                        }
                        unitSizeComboBox.DataSource = null;
                        unitSizeComboBox.Items.Clear();
                        unitSizeComboBox.DataSource = DataSourceStore;
                        unitSizeComboBox.ValueMember = "Weight";
                        unitSizeComboBox.DisplayMember = "UnitType";
                        unitSizeComboBox.SelectedIndex = DataSourceStore.Count - 1;
                        UnitValueBox.Text = "1";
                    }
                    else
                    {
                        unitSizeComboBox.SelectedIndex = 2;
                        UnitValueBox.Text = "1";
                    }
                    // Add some selectedFood["1 Porsi"]
                    RefreshFillData((float)unitSizeComboBox.SelectedValue);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Terjadi kesalahan on Adding\n{e}", "Information", MessageBoxButtons.OK);
                }
            }
        }
        private void RefreshFillData(float totalUnit)
        {
            if (selectedFood.Count != 0)
            {
                float totalWeight = totalUnit * Single.Parse(UnitValueBox.Text);
                float multiply =  totalWeight / 100;
                TWPanelLabel.Text = $"{totalWeight} gram";
                LemakTextBox.Text = $"{selectedFood["Lemak"] * multiply}";
                ProtTextBox.Text = $"{selectedFood["Protein"] * multiply}";
                KarbTextBox.Text = $"{selectedFood["Karbohidrat"] * multiply}";
                SeratTextBox.Text = $"{selectedFood["Serat"] * multiply}";
                GulaTextBox.Text = $"{selectedFood["Gula"] * multiply}";
                kaloriValLab.Text = Calori.CaloriCal(
                    protein: selectedFood["Protein"] * multiply,
                    karbo: selectedFood["Karbohidrat"] * multiply,
                    lemak: selectedFood["Lemak"] * multiply,
                    gula: selectedFood["Gula"] * multiply,
                    serat: selectedFood["Serat"] * multiply
                ).ToString() + " kkal";
            }
        }
        private void UnitChanged(object sender, EventArgs e)
        {
            UnitValueBox.Text = "1";
            RefreshFillData((float)unitSizeComboBox.SelectedValue);
        }
        private void UnitValueChanged(object sender, EventArgs e)
        {
            RefreshFillData((float)unitSizeComboBox.SelectedValue);
        }
        private void FloatTextBoxhanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.AppendText("0");
            }
            else if (textBox.Text.Length > 1)
            {
                bool result = Logic.IsDigits(textBox.Text);
                if (!result)
                {
                    string text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    textBox.Text = text;
                    textBox.SelectionStart = text.Length;
                }else if (textBox.Text[0] == '0' && textBox.Text[1] != ',')
                {
                    string text = textBox.Text.Substring(1);
                    textBox.Text = text;
                    textBox.SelectionStart = text.Length;
                }
            }
        }

        private void AddGiziControl_Load(object sender, EventArgs e)
        {
            title.Text = $"Tambah Makanan yang Dikonsumsi pada {trackingDateTime.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
            periode.Text = $"Periode Makan : {MealOfADay.mealType}";
            unitSizeComboBox.DataSource = this.unitsList;
            unitSizeComboBox.ValueMember = "Weight";
            unitSizeComboBox.DisplayMember = "UnitType";
        }
        private void SaveFoodButtonClicked(object sender, EventArgs e)
        {
            Unit? unit;
            if (unitSizeComboBox.SelectedIndex == 3)
            {
                unit = Database.units.GetUnitIfExist("1 Porsi" + " " + this.foodNameNSum[0]);
            }
            else
            {
                unit = Database.units.GetDefaultUnits()[unitSizeComboBox.SelectedIndex];
            }
            Food? food = Database.MyFoods.GetFoodIfExist(this.foodNameNSum[0]);
            if (unit != null && food != null)
            {
                bool resultAddMealItem = MealOfADay.AddMealItem(
                    dateOfDay: trackingDateTime,
                    foodId: food.Id,
                    qty: Single.Parse(UnitValueBox.Text, CultureInfo.InvariantCulture), // Need adjustment
                    karbohidrat: Single.Parse(KarbTextBox.Text, CultureInfo.InvariantCulture),
                    protein: Single.Parse(ProtTextBox.Text, CultureInfo.InvariantCulture),
                    lemak: Single.Parse(LemakTextBox.Text, CultureInfo.InvariantCulture),
                    serat: Single.Parse(SeratTextBox.Text, CultureInfo.InvariantCulture),
                    gula: Single.Parse(GulaTextBox.Text, CultureInfo.InvariantCulture),
                    unitId: unit.Id
                );
                if (resultAddMealItem)
                {
                    DashboardMainForm dashboardMainForm = (DashboardMainForm)Application.OpenForms["DashboardMainForm"];
                    dashboardMainForm.PanelContent.Controls.Clear();
                    TrackingGiziControl trackingGizi = new TrackingGiziControl(dateTime: trackingDateTime);//error here
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
                MessageBox.Show($"Terjadi kesalahan pada saving food\nUnit: {unit}\tmeal: {MealOfADay.mealType}\tfood: {food}", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
