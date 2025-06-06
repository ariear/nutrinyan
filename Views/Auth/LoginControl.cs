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
using static System.Windows.Forms.DataFormats;
using Calculation;
using System.Runtime.CompilerServices;
using FontAwesome.Sharp;

namespace NutriNyan.Views.Auth
{
    public partial class LoginControl : UserControl
    {
        AuthMainForm pMainAuth;
        public LoginControl(AuthMainForm pMainAuth)
        {
            InitializeComponent();
            WrongLogin.Hide();
            this.pMainAuth = pMainAuth;
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthMainForm authMainForm = (AuthMainForm)Application.OpenForms["AuthMainForm"];
            authMainForm.PanelAuth.Controls.Clear();
            RegisterControl register = new RegisterControl(pMainAuth);
            register.Dock = DockStyle.Fill;
            authMainForm.PanelAuth.Controls.Add(register);
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
        }
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            Dashboard.DashboardMainForm? result = Check();
            if (result != null)
            {
                pMainAuth.Hide();
                result.ShowDialog();// need adjustment
                pMainAuth.Dispose();// need adjustment
            }
            else
            {
                textBox1.Text = ""; textBox2.Text = "";
                WrongLogin.Show();
            }
        }
        private Dashboard.DashboardMainForm? Check()
        {
            if (Logic.AuthCheck(username: textBox1.Text, pwd: textBox2.Text))
            {
                Database.SetUserLogged(new Database.UserLogged(Database.GetUserIfExist(textBox1.Text)!));
                Database.SetUnits();
                return new Dashboard.DashboardMainForm();
            }
            else
            {
                return null;
            }
        }

        private void togglePwButton_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                togglePwButton.IconChar = IconChar.EyeSlash;
            } else
            {
                textBox2.PasswordChar = '*';
                togglePwButton.IconChar = IconChar.Eye;
            }
        }
    }
}
