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
        DbContextOptionsBuilder<AppDbContext> _optionsBuilder; 
        AuthMainForm pMainAuth;
        public RegisterControl(AuthMainForm pMainAuth)
        {
            InitializeComponent();
            _optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
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
            if (backgroundWorker1.IsBusy){
                MessageBox.Show("Thread Busy", "Information", MessageBoxButtons.OK);
            }
            if (Logic.IsValidPwd(Pwd_TextBox.Text) &&
                Nama_TextBox.Text != "" &&
                !Logic.IsUsernameExist(Nama_TextBox.Text, _optionsBuilder) &&
                TB_TextBox.Text != "" &&
                BB_TextBox.Text != "" &&
                !backgroundWorker1.IsBusy &&
                Logic.IsNotTodayFuture(dateTimePicker1.Value)
                )
            {
                // Add here
                backgroundWorker1.RunWorkerAsync(); // change this
                MessageBox.Show("Success", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hadehhhh", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            aktivitasBox.DataSource = Enum.GetValues(typeof(ActivityLevel));
            using (var dbContext = new AppDbContext(_optionsBuilder.Options)){

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
        /// <summary>
        /// Adding a User into the database and save the changes. Return true if success and false if there is an error.
        /// </summary>
        /// <returns>bool</returns>
        private bool AddUser()
        {
            try
            {
                int TargetWater = (int)AKG.CalAKG(Logic.GetAge(dateTimePicker1.Value), (int)jkBox.SelectedIndex).Last();
                string activLevel = Logic.GetTAktifitasValue((ActivityLevel)aktivitasBox.SelectedValue);
                string pwdHashed = Logic.Get_PWDHash(Pwd_TextBox.Text);
                using (var dbContext = new AppDbContext(_optionsBuilder.Options)){
                dbContext.Add(new User
                {
                    Username = Nama_TextBox.Text,
                    Password = pwdHashed,
                    GenderId = (int)jkBox.SelectedValue,
                    DateBirth = dateTimePicker1.Value.ToUniversalTime(),
                    Tb = Single.Parse(TB_TextBox.Text),
                    Bb = Single.Parse(BB_TextBox.Text),
                    DefaultTargetWater = TargetWater,
                    TingkatAktivitas = activLevel,
                    PurposeId = (int)targetBox.SelectedValue,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                dbContext.SaveChanges();
                }
                MessageBox.Show("Success saving", "Information", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (AddUser()){
                MessageBox.Show("Success saving to the database", "Information", MessageBoxButtons.OK);
                Dashboard.DashboardMainForm dashboard = new Dashboard.DashboardMainForm(Nama_TextBox.Text);
                pMainAuth.Hide();
                dashboard.ShowDialog();// need adjustment
                pMainAuth.Dispose();   // need adjustment
            }else {
                MessageBox.Show("Failed to saving", "Information", MessageBoxButtons.OK);
            };
        }
    }
}
