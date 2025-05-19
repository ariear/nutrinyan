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
            AuthMainForm authMainForm= (AuthMainForm)Application.OpenForms["AuthMainForm"];
            authMainForm.PanelAuth.Controls.Clear();
            RegisterControl register = new RegisterControl(pMainAuth);
            register.Dock = DockStyle.Fill;
            authMainForm.PanelAuth.Controls.Add(register);
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
        }
        private void Button1_Clicked(object sender, EventArgs e){
            if (Logic.AuthCheck(username: textBox1.Text, pwd: textBox2.Text)){
                Database.SetUserId(userId: Database.GetUserIfExist(textBox1.Text)!.Id);
                Dashboard.DashboardMainForm dashboard = new Dashboard.DashboardMainForm();
                pMainAuth.Hide();
                dashboard.ShowDialog();// need adjustment
                pMainAuth.Dispose();   // need adjustment
            }else{
                textBox1.Text = ""; textBox2.Text = "";
                WrongLogin.Show();
            };
        }
    }
}
