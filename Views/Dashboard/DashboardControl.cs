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
    public partial class DashboardControl : UserControl
    {
        string Username;
        public DashboardControl(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            label1.Text = $"Halo {Username}\nSemoga Harimu Menyenangkan";
        }
    }
}
