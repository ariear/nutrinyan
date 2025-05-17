using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriNyan.Views.Dashboard
{
    public partial class SearchFoodForm : Form
    {
        public SearchFoodForm()
        {
            InitializeComponent();
        }

        private void SearchFoodForm_Load(object sender, EventArgs e)
        {
            LoadDataRekomendasiMakanan();
            LoadDataCariMakan();
        }

        // contoh ajah
        private void LoadDataRekomendasiMakanan()
        {
            string[] items = { "Mie ayam", "Bakso Mercon", "Seblak", "Donat spesial lobang", "Roti O Lempuyungan" }; 

            FlowLayoutPanel cardContainer = new FlowLayoutPanel();
            cardContainer.Dock = DockStyle.Fill;
            cardContainer.AutoScroll = true;
            cardContainer.Padding = new Padding(10, 40, 0, 0);
            rekomenFoodTabPage.Controls.Add(cardContainer);

            foreach (var item in items)
            {
                Panel card = new Panel();
                card.Size = new Size(240, 120);
                card.Margin = new Padding(10);
                card.BackColor = Color.FromArgb(1, 54, 63);

                Label title = new Label();
                title.Text = item;
                title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                title.Location = new Point(10, 10);
                title.AutoSize = true;
                title.ForeColor = Color.White;
                card.Controls.Add(title);

                Label desc = new Label();
                desc.Text = "1 Bungkus | Kalori : 137 kkal | Lemak : 2,06g | Karb : 25,01g | Prot : 4,52g";
                desc.Font = new Font("Segoe UI", 9);
                desc.Location = new Point(10, 35);
                desc.MaximumSize = new Size(200, 0);
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
                card.Controls.Add(btn);

                cardContainer.Controls.Add(card);
            }
        }

        // contoh ajah
        private void LoadDataCariMakan()
        {
            string[] items = { "Mie ayam", "Bakso Mercon", "Seblak", "Donat spesial lobang", "Roti O Lempuyungan" }; // contoh ajah

            FlowLayoutPanel cardContainer = new FlowLayoutPanel();
            cardContainer.Dock = DockStyle.Fill;
            cardContainer.FlowDirection = FlowDirection.TopDown;
            cardContainer.WrapContents = false;
            cardContainer.AutoScroll = true;
            cardContainer.Padding = new Padding(10, 120, 0, 0);
            cariMakanTabPage.Controls.Add(cardContainer);

            foreach (var item in items)
            {
                Panel card = new Panel();
                card.Size = new Size(750, 120);
                card.Margin = new Padding(10);
                card.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                card.BackColor = Color.FromArgb(1, 54, 63);

                Label title = new Label();
                title.Text = item;
                title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                title.Location = new Point(10, 10);
                title.AutoSize = true;
                title.ForeColor = Color.White;
                card.Controls.Add(title);

                Label desc = new Label();
                desc.Text = "1 Bungkus | Kalori : 137 kkal | Lemak : 2,06g | Karb : 25,01g | Prot : 4,52g";
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
                card.Controls.Add(btn);

                cardContainer.Controls.Add(card);
            }
        }
    }
}
