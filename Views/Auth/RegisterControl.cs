using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            optionsBuilder.UseNpgsql(AppDbContextFactory.ConnectionString.connectionString);
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hadehhhh", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            jkBox.DataSource = Enum.GetValues(typeof(Gender));
            aktivitasBox.DataSource = Enum.GetValues(typeof(ActivityLevel));

            var purposes = _context.Purposes.ToList();

            targetBox.DataSource = purposes;
            targetBox.DisplayMember = "Title";
            targetBox.ValueMember = "Id";
        }
    }
}
