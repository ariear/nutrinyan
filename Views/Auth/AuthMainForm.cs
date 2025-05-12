using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NutriNyan.Views.Dashboard;
using Calculation;

namespace NutriNyan.Views.Auth
{
    public partial class AuthMainForm : Form
    {
        public AuthMainForm()
        {
            InitializeComponent();

            LoginControl login = new LoginControl(this);
            panelAuth.Controls.Clear();
            login.Dock = DockStyle.Fill;
            panelAuth.Controls.Add(login);

            this.Resize += new EventHandler(AuthMainForm_Resize);
        }

        private void AuthMainForm_Load(object sender, EventArgs e)
        {
            ResizePanel();
        }

        private void AuthMainForm_Resize(object sender, EventArgs e)
        {
            ResizePanel();
        }

        private void ResizePanel()
        {
            panelHiasan.Width = this.ClientSize.Width / 2;
            panelHiasan.Height = this.ClientSize.Height;
        }

        public Panel PanelAuth
        {
            get { return panelAuth; }
        }
        
    }
}
