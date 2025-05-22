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
using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;

namespace NutriNyan.Views.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        Dictionary<string, float> result;
        public DashboardControl()
        {
            InitializeComponent();
        }
    }
}
