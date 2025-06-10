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
using NutriNyan.Models;

namespace NutriNyan.Views.Dashboard
{
    public partial class EditMakanan : UserControl
    {
        private List<Unit> unitsList = Database.units.GetDefaultUnits().Select(u => u).ToList();
        private MealItem mealItem { get; set; }
        private Food food { get; set; }
        private DateTime dateTimeEdit { get; set; }
        public EditMakanan(MealItem mealItem, DateTime date)
        {
            InitializeComponent();
            this.mealItem = mealItem;
            this.dateTimeEdit = date;
        }
        public void EditMakanan_Load(object sender, EventArgs e)
        {
            periode.Text += dateTimeEdit.ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
            this.food = Database.GetFoodIfExist(mealItem.FoodId);
            FoodNameValLabel.Text = food.Name;
            Unit? unit = Database.units.GetUnitIfExist("1 Porsi "+food.Name);
            if (unit != null && !unitsList.Contains(unit))
            {
                unitsList.Add(unit);
            }
            else
            {
            }
            unitSizeComboBox.DataSource = unitsList;
            unitSizeComboBox.ValueMember = "Weight";
            unitSizeComboBox.DisplayMember = "UnitType";
            NutritionFill();
        }
        private void UnitChanged(object sender, EventArgs e)
        {
            UnitValueBox.Text = "1";
            RefreshFillData();
        }
        private void UnitValueChanged(object sender, EventArgs e)
        {
            RefreshFillData();
        }
        public void NutritionFill()
        {
            unitSizeComboBox.DataSource = null;
            unitSizeComboBox.Items.Clear();
            // MessageBox.Show($"Passed\nUnitId: {unit.Id}\nvalue: {Database.units}", "Information", MessageBoxButtons.OK);
            unitSizeComboBox.DataSource = unitsList;
            unitSizeComboBox.ValueMember = "Weight";
            unitSizeComboBox.DisplayMember = "UnitType";
            for (int i = 0; i < unitsList.Count; i++)
            {
                if (unitsList[i].Id == mealItem.UnitId)
                {
                    unitSizeComboBox.SelectedIndex = i;
                }
            }
            UnitValueBox.Text = mealItem.Qty.ToString();
            RefreshFillData();
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
                }
                else if (textBox.Text[0] == '0' && textBox.Text[1] != ',')
                {
                    string text = textBox.Text.Substring(1);
                    textBox.Text = text;
                    textBox.SelectionStart = text.Length;
                }
            }
        }
        private void RefreshFillData()
        {
            float totalWeight = (float)unitSizeComboBox.SelectedValue * Single.Parse(UnitValueBox.Text);
            float multiply = totalWeight / 100;
            TWPanelLabel.Text = $"{totalWeight} gram";
            LemakTextBox.Text = $"{food.Lemak * multiply}";
            ProtTextBox.Text = $"{food.Protein * multiply}";
            KarbTextBox.Text = $"{food.Karbohidrat * multiply}";
            SeratTextBox.Text = $"{food.Serat * multiply}";
            GulaTextBox.Text = $"{food.Gula * multiply}";
            kaloriValLab.Text = Calculation.Calori.CaloriCal(
                protein: food.Protein * multiply,
                karbo: food.Karbohidrat * multiply,
                lemak: food.Lemak * multiply,
                gula: food.Gula * multiply,
                serat: food.Serat * multiply
            ).ToString() + " kkal";
        }
        private void SaveFoodButton_Clicked(object sender, EventArgs e)
        {
            mealItem.Gula = Single.Parse(GulaTextBox.Text);
            mealItem.Karbohidrat = Single.Parse(KarbTextBox.Text);
            mealItem.Lemak = Single.Parse(LemakTextBox.Text);
            mealItem.Protein = Single.Parse(ProtTextBox.Text);
            mealItem.Serat = Single.Parse(SeratTextBox.Text);
            mealItem.Qty = Single.Parse(UnitValueBox.Text);
            mealItem.UnitId = unitsList[unitSizeComboBox.SelectedIndex].Id;
            Database.NutritionLogOfDay.UpdateMealItem(mealItem);
            // Back to tracking Gizi
            DashboardMainForm dashboardMainForm = (DashboardMainForm)Application.OpenForms["DashboardMainForm"];
            dashboardMainForm.PanelContent.Controls.Clear();
            TrackingGiziControl trackingGizi = new TrackingGiziControl(dateTime: dateTimeEdit);//error here
            trackingGizi.Dock = DockStyle.Fill;
            dashboardMainForm.PanelContent.Controls.Add(trackingGizi);
            this.Hide();
            this.Dispose();
        }
    }
}
