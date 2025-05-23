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

namespace NutriNyan.Views
{
    public partial class ChangeTargetWaterForm : Form
    {
        private DateTime trackingWaterTimePicker;
        private Water? dataWater;
        private int progressBarValue;
        public ChangeTargetWaterForm(DateTime trackingWaterTimePicker, Water? dataWater, int progressBarValue)
        {
            InitializeComponent();
            this.trackingWaterTimePicker = trackingWaterTimePicker;
            this.dataWater = dataWater;
            this.progressBarValue = progressBarValue;
            title.Text = $"Ubah Target Air pada {this.trackingWaterTimePicker.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
            watertextBox.Text = dataWater.Target.ToString();
        }

        private void ChangeTargetWaterForm_Load(object sender, EventArgs e)
        {

        }

        private void ubahButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(watertextBox.Text) >= progressBarValue)
            {
                Database.updateTargetWater(dataWater.Id, Convert.ToInt32(watertextBox.Text));
                this.Close();
            } else
            {
                MessageBox.Show("Target air kurang besar!!", "Informasi");
            }
        }
    }
}
