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

namespace NutriNyan.Views.Auth
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthMainForm authMainForm= (AuthMainForm)Application.OpenForms["AuthMainForm"];
            authMainForm.PanelAuth.Controls.Clear();
            RegisterControl register = new RegisterControl();
            register.Dock = DockStyle.Fill;
            authMainForm.PanelAuth.Controls.Add(register);
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
