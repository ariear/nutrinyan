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
using FontAwesome.Sharp;
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
                float tb;
                float bb;
                if (Single.Parse("1,001") < Single.Parse("1.001"))
                {
                    tb = Single.Parse(TB_TextBox.Text);
                    bb = Single.Parse(BB_TextBox.Text);
                }
                else
                {
                    tb = Single.Parse(TB_TextBox.Text.Replace(",", "."));
                    bb = Single.Parse(BB_TextBox.Text.Replace(",", "."));
                }
                Database.UserLogged user = new Database.UserLogged(
                    username: Nama_TextBox.Text,
                    pwd: Pwd_TextBox.Text,
                    genderId: (int)jkBox.SelectedValue,
                    genderIndex: (int)jkBox.SelectedIndex,
                    dateBirth: dateTimePicker1.Value,
                    tb: tb,
                    bb: bb,
                    tingkatAktivitas: (ActivityLevel)aktivitasBox.SelectedValue,
                    purposeId: (int)targetBox.SelectedValue
                );
                MessageBox.Show("Registrasi akun berhasil!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.SetUserLogged(new Database.UserLogged(Database.GetUserIfExist(Nama_TextBox.Text)!));
                Database.SetUnits();
                Dashboard.DashboardMainForm dashboard = new Dashboard.DashboardMainForm();
                pMainAuth.Hide();
                dashboard.ShowDialog();// need adjustment
                pMainAuth.Dispose();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Nama_TextBox.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Database.GetUserIfExist(Nama_TextBox.Text) != null)
                {
                    MessageBox.Show("Username sudah digunakan, silakan pilih username lain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Logic.IsValidPwd(Pwd_TextBox.Text))
                {
                    if (Pwd_TextBox.Text.Length < 6)
                    {
                        MessageBox.Show("Password harus minimal 6 karakter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password harus mengandung angka, huruf, dan simbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (!Logic.IsNotTodayFuture(dateTimePicker1.Value))
                {
                    if (dateTimePicker1.Value.ToString("MM-dd-yyyy") == DateTime.Now.ToString("MM-dd-yyyy"))
                    {
                        MessageBox.Show("Tanggal lahir tidak boleh hari ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (DateTime.Now < dateTimePicker1.Value)
                    {
                        MessageBox.Show("Tanggal lahir tidak boleh di masa depan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (string.IsNullOrWhiteSpace(TB_TextBox.Text) || !float.TryParse(TB_TextBox.Text, out _))
                {
                    MessageBox.Show("Tinggi badan harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(BB_TextBox.Text) || !float.TryParse(BB_TextBox.Text, out _))
                {
                    MessageBox.Show("Berat badan harus diisi!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            aktivitasBox.DataSource = Enum.GetValues(typeof(ActivityLevel));
            jkBox.DataSource = Database.genders; // Get only Type column of Genders table
            jkBox.DisplayMember = "GenderName";
            jkBox.ValueMember = "DbGenderId";

            targetBox.DataSource = Database.purposes;
            targetBox.DisplayMember = "purposeName";
            targetBox.ValueMember = "purposeId";

            // var _optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // using (var dbContext = new AppDbContext(_optionsBuilder.Options))
            // {
            //     try
            //     {
            //         jkBox.DataSource = Database.genders; // Get only Type column of Genders table
            //         jkBox.DisplayMember = "GenderName";
            //         jkBox.ValueMember = "DbGenderId";
            //     }
            //     catch (Exception E)
            //     {
            //         MessageBox.Show($"{E}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     }
            //     var purposes = dbContext.Purposes.Select(b => new { b.Title, b.Id }).ToList(); // Get only Title column of Purposes table

            //     targetBox.DataSource = purposes;
            //     targetBox.DisplayMember = "Title";
            //     targetBox.ValueMember = "Id";
            // }
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

        private void togglePwButton_Click(object sender, EventArgs e)
        {
            if (Pwd_TextBox.PasswordChar == '*')
            {
                Pwd_TextBox.PasswordChar = '\0';
                togglePwButton.IconChar = IconChar.EyeSlash;
            }
            else
            {
                Pwd_TextBox.PasswordChar = '*';
                togglePwButton.IconChar = IconChar.Eye;
            }
        }
        private void purposeChanged(object sender, EventArgs e)
        {
            purposeDeskriptionLab.Text = Database.purposes[targetBox.SelectedIndex].deskripsi;
        }
    }
}
