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
    public partial class TrackingAirControl : UserControl
    {
        private Water? dataWater;
        public TrackingAirControl()
        {
            InitializeComponent();
        }

        private void TrackingAirControl_Load(object sender, EventArgs e)
        {
            waterGridView.Columns.Add("satuan", "Satuan (ml)");
            waterGridView.Columns.Add("jam", "Jam");
            var idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "entryId";
            idColumn.HeaderText = "ID";
            idColumn.Visible = false;
            waterGridView.Columns.Add(idColumn);
            waterGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit"
            });
            waterGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Hapus",
                UseColumnTextForButtonValue = true,
                Text = "Hapus"
            });

            UpdateWaterDataDisplay(DateTime.Now);

            trackingWaterTimePicker.MaxDate = DateTime.Today;
            trackingWaterTimePicker.Value = DateTime.Today;
            daftarAirLabel.Text = $"Daftar air yang diminum pada hari {trackingWaterTimePicker.Value.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
        }

        private void waterGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void changeTargetWaterButton_Click(object sender, EventArgs e)
        {
            ChangeTargetWaterForm changeTargetWater = new ChangeTargetWaterForm(trackingWaterTimePicker.Value, dataWater, progressBar.Value);
            changeTargetWater.ShowDialog();

            UpdateWaterDataDisplay(trackingWaterTimePicker.Value);
        }

        private void trackingWaterTimePicker_CloseUp(object sender, EventArgs e)
        {
            daftarAirLabel.Text = $"Daftar air yang diminum pada hari {trackingWaterTimePicker.Value.ToString("dd MMMM yyyy", new CultureInfo("id-ID"))}";
            Water? getDataWater = Database.getWaterDay(trackingWaterTimePicker.Value);
            if (getDataWater == null)
            {
                Database.createWaterDay(trackingWaterTimePicker.Value);
                getDataWater = Database.getWaterDay(trackingWaterTimePicker.Value);
            }

            dataWater = getDataWater;
            maxWaterValue.Text = $"{dataWater.Target} ml";
            progressBar.Maximum = dataWater.Target;

            progressBar.Value = 0;
            waterGridView.Rows.Clear();
            foreach (var entry in dataWater.Entries.ToList())
            {
                string satuan = entry.Value.ToString();
                string jam = entry.CreatedAt.ToLocalTime().ToString("HH : mm");
                waterGridView.Rows.Add(satuan, jam, entry.Id);

                progressBar.Value += Convert.ToInt32(entry.Value);
            }

            totalAirLabel.Text = $"Total air diminum : {progressBar.Value} ml";
            if (progressBar.Value >= dataWater.Target)
            {
                targetTercapailabel.Text = "Horee, kamu sudah memenuhi target minum air!!";
            }
            else
            {
                targetTercapailabel.Text = "";
            }
        }

        private void UpdateWaterDataDisplay(DateTime date)
        {
            progressBar.Value = 0;
            waterGridView.Rows.Clear();

            dataWater = Database.getWaterDay(date);

            maxWaterValue.Text = $"{dataWater.Target} ml";
            progressBar.Maximum = dataWater.Target;

            foreach (var entry in dataWater.Entries.ToList())
            {
                string satuan = entry.Value.ToString();
                string jam = entry.CreatedAt.ToLocalTime().ToString("HH : mm");
                waterGridView.Rows.Add(satuan, jam, entry.Id);

                progressBar.Value += Convert.ToInt32(entry.Value);
            }

            totalAirLabel.Text = $"Total air diminum : {progressBar.Value} ml";
            if (progressBar.Value >= dataWater.Target)
            {
                targetTercapailabel.Text = "Horee, kamu sudah memenuhi target minum air!!";
            }
            else
            {
                targetTercapailabel.Text = "";
            }
        }

        private void inputWaterButton_Click(object sender, EventArgs e)
        {
            if ((progressBar.Value + Convert.ToInt32(inputWaterBox.Text)) <= dataWater.Target)
            {
                Database.addWaterEntry(dataWater.Id, Convert.ToInt32(inputWaterBox.Text));
                UpdateWaterDataDisplay(trackingWaterTimePicker.Value);

                MessageBox.Show("Berhasil memasukkan air", "Informasi");
                inputWaterBox.Text = "";
            }
            else
            {
                MessageBox.Show("Air melebihi target harian!!", "Informasi");
                inputWaterBox.Text = "";
            }
        }

        private void waterGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == waterGridView.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                var idValue = waterGridView.Rows[e.RowIndex].Cells["entryId"].Value;
                if (idValue != null && int.TryParse(idValue.ToString(), out int entryId))
                {
                    DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus Air", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool deleted = Database.DeleteWaterEntryById(entryId);
                        if (deleted)
                        {
                            MessageBox.Show("Data berhasil dihapus!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateWaterDataDisplay(trackingWaterTimePicker.Value);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data!!");
                        }
                    }
                }
            }

            if (e.ColumnIndex == waterGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                var idValue = waterGridView.Rows[e.RowIndex].Cells["entryId"].Value;
                if (idValue != null && int.TryParse(idValue.ToString(), out int entryId))
                {
                    WaterEntry getWaterEntry = Database.GetWaterEntryById(entryId);
                    EditWaterEntryForm editWaterEntry = new EditWaterEntryForm(getWaterEntry, progressBar.Value, dataWater.Target);
                    editWaterEntry.ShowDialog();

                    UpdateWaterDataDisplay(trackingWaterTimePicker.Value);
                }
            }
        }
    }
}
