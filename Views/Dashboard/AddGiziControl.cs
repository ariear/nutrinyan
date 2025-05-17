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

namespace NutriNyan.Views.Dashboard
{
    public partial class AddGiziControl : UserControl
    {
        private string tipeMakan = "";
        private DateTime trackingDateTime;

        public AddGiziControl(string tipeMakan, DateTime trackingDateTime)
        {
            InitializeComponent();

            this.tipeMakan = tipeMakan;
            this.trackingDateTime = trackingDateTime;
        }

        private void searchFoodButton_Click(object sender, EventArgs e)
        {
            SearchFoodForm searchFoodForm = new SearchFoodForm();
            searchFoodForm.ShowDialog();
        }

        private void AddGiziControl_Load(object sender, EventArgs e)
        {
            title.Text = $"Tambah Makanan yang Dikonsumsi pada {trackingDateTime.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
            periode.Text = $"Periode Makan : {tipeMakan}";
        }
    }
}
