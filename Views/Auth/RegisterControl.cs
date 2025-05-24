using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models;
using NutriNyan.Models.Enums;

namespace NutriNyan.Views.Auth
{
    public partial class RegisterControl : UserControl
    {
        AuthMainForm pMainAuth;
        public RegisterControl(AuthMainForm pMainAuth)
        {
            InitializeComponent();
            this.pMainAuth = pMainAuth;
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthMainForm authMainForm = (AuthMainForm)Application.OpenForms["AuthMainForm"];
            authMainForm.PanelAuth.Controls.Clear();
            LoginControl login = new LoginControl(pMainAuth);
            login.Dock = DockStyle.Fill;
            authMainForm.PanelAuth.Controls.Add(login);
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (Logic.IsValidPwd(Pwd_TextBox.Text) &&
                Nama_TextBox.Text != "" &&
                Database.GetUserIfExist(Nama_TextBox.Text) == null && // Avoiding duplicate username
                TB_TextBox.Text != "" &&
                Logic.IsNotTodayFuture(dateTimePicker1.Value)
                )
            {
                // Add here
                Database.UserLogged user = new Database.UserLogged(
                    username: Nama_TextBox.Text,
                    pwd: Pwd_TextBox.Text,
                    genderId: (int)jkBox.SelectedValue,
                    genderIndex: (int)jkBox.SelectedIndex,
                    dateBirth: dateTimePicker1.Value,
                    tb: Single.Parse(TB_TextBox.Text),
                    bb: Single.Parse(BB_TextBox.Text),
                    tingkatAktivitas: (ActivityLevel)aktivitasBox.SelectedValue,
                    purposeId: (int)targetBox.SelectedValue
                );
                MessageBox.Show("Success", "Information", MessageBoxButtons.OK);
                Database.SetUserLogged(new Database.UserLogged(Database.GetUserIfExist(Nama_TextBox.Text)!));
                Database.SetUnits();
                Dashboard.DashboardMainForm dashboard = new Dashboard.DashboardMainForm();
                pMainAuth.Hide();
                dashboard.ShowDialog();// need adjustment
                pMainAuth.Dispose();
            }
            else
            {
                MessageBox.Show("Hadehhhh", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            aktivitasBox.DataSource = Enum.GetValues(typeof(ActivityLevel));
            var _optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(_optionsBuilder.Options))
            {

                jkBox.DataSource = dbContext.Genders.Select(b => new { b.Type, b.Id }).ToList(); // Get only Type column of Genders table
                jkBox.DisplayMember = "Type";
                jkBox.ValueMember = "Id";

                var purposes = dbContext.Purposes.Select(b => new { b.Title, b.Id }).ToList(); // Get only Title column of Purposes table

                targetBox.DataSource = purposes;
                targetBox.DisplayMember = "Title";
                targetBox.ValueMember = "Id";
            }
        }
        /// <summary>
        /// This method won't allow TextBox to have alpha, means text must be alphabet and only allow one dot (assuming float number)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextMustNum(object sender, EventArgs e)
        {
            TextBox Compt = sender as TextBox;
            if (!Logic.IsDigits(Compt.Text))
            {
                string Sub = Compt.Text.Substring(0, Compt.Text.Length - 1); // Store the substring
                Compt.Text = ""; // Reset the text value
                Compt.AppendText(Sub); // Append/restore text value but throw unaccepted character
            }
        }
    }
}
