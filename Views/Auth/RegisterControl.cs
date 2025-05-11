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
        private AppDbContext _context;

        public RegisterControl()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            _context = new AppDbContext(optionsBuilder.Options);
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthMainForm authMainForm = (AuthMainForm)Application.OpenForms["AuthMainForm"];
            authMainForm.PanelAuth.Controls.Clear();
            LoginControl login = new LoginControl();
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
                !Logic.IsUsernameExist(Nama_TextBox.Text, _context) &&
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

            jkBox.DataSource = _context.Genders.Select(b => new { b.Type, b.Id }).ToList(); // Get only Type column of Genders table
            jkBox.DisplayMember = "Type";
            jkBox.ValueMember = "Id";

            var purposes = _context.Purposes.Select(b => new { b.Title, b.Id }).ToList(); // Get only Title column of Purposes table

            targetBox.DataSource = purposes;
            targetBox.DisplayMember = "Title";
            targetBox.ValueMember = "Id";
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
                _context.Add(new User
                {
                    Username = Nama_TextBox.Text,
                    Password = Logic.Get_PWDHash(Pwd_TextBox.Text),
                    GenderId = (int)jkBox.SelectedValue,
                    DateBirth = dateTimePicker1.Value.ToUniversalTime(),
                    Tb = Single.Parse(TB_TextBox.Text),
                    Bb = Single.Parse(BB_TextBox.Text),
                    DefaultTargetWater = (int)AKG.CalAKG(Logic.GetAge(dateTimePicker1.Value)).Last(),
                    TingkatAktivitas = Logic.GetTAktifitasValue((ActivityLevel)aktivitasBox.SelectedValue),
                    PurposeId = (int)targetBox.SelectedValue,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                _context.SaveChanges();
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
            }else {
                MessageBox.Show("Failed to saving", "Information", MessageBoxButtons.OK);
            };
        }
    }
}
