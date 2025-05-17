using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriNyan.Views.Auth;

namespace NutriNyan.Views.Dashboard
{
    public partial class TrackingGiziControl : UserControl
    {
        public TrackingGiziControl()
        {
            InitializeComponent();
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
            sarapanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");

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
            makanSiangGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");

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
            makanMalamGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");

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
            jajanGridView.Rows.Add("Mie Ayam", "1 Mangkok", "100", "60", "20", "4", "20", "400");
        }

        private void makanButton_Click(object sender, EventArgs e)
        {
            DashboardMainForm dashboardMainForm = (DashboardMainForm)Application.OpenForms["DashboardMainForm"];
            dashboardMainForm.PanelContent.Controls.Clear();
            AddGiziControl addGizi= new AddGiziControl();
            addGizi.Dock = DockStyle.Fill;
            dashboardMainForm.PanelContent.Controls.Add(addGizi);
        }
    }
}
