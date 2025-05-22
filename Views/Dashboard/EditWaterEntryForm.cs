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

namespace NutriNyan.Views.Dashboard
{
    public partial class EditWaterEntryForm : Form
    {
        private WaterEntry waterEntry;
        private int progressBarValue;
        private int waterTarget;
        public EditWaterEntryForm(WaterEntry waterEntry, int progressBarValue, int waterTarget)
        {
            InitializeComponent();
            this.waterEntry = waterEntry;
            this.progressBarValue = progressBarValue;
            this.waterTarget = waterTarget;

            jamTimePicker.Value = this.waterEntry.CreatedAt.ToLocalTime();
            jamTimePicker.Format = DateTimePickerFormat.Custom;
            jamTimePicker.CustomFormat = "HH:mm";
            jamTimePicker.ShowUpDown = true;

            airMlTextBox.Text = Convert.ToString(waterEntry.Value);
        }

        private void EditWaterEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (((progressBarValue + Convert.ToInt32(airMlTextBox.Text)) - waterEntry.Value) <= waterTarget)
            {
                Database.updateWaterEntry(waterEntry.Id, Convert.ToInt32(airMlTextBox.Text), jamTimePicker.Value);
                MessageBox.Show("Data berhasil diedit!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Air melebihi target harian!!", "Informasi");
            }
        }
    }
}
