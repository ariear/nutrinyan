using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace NutriNyan.Views.Dashboard
{
    public partial class DashboardMainForm : Form
    {
        private IconButton? currentActiveButton;

        public DashboardMainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            SetActiveButton((IconButton)dashboardButton);
            LoadDashboard();
        }

        private void DashboardMainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        // Load control method
        private void LoadDashboard()
        {
            LoadUserControl(new DashboardControl());
        }

        private void LoadTrackingGizi()
        {
            LoadUserControl(new TrackingGiziControl());
        }

        // Change bg color when btn active
        private void SetActiveButton(IconButton clickedButton)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.Transparent;
                currentActiveButton.ForeColor = Color.FromArgb(183, 201, 200);
                currentActiveButton.IconColor = Color.FromArgb(183, 201, 200);
            }

            currentActiveButton = clickedButton;
            currentActiveButton.BackColor = Color.FromArgb(0, 221, 220);
            currentActiveButton.ForeColor = Color.FromArgb(1, 54, 63);
            currentActiveButton.IconColor = Color.FromArgb(1, 54, 63);
        }


        // Button method
        private void TrackingGiziButton_Click(object sender, EventArgs e)
        {
            SetActiveButton((IconButton)sender);
            LoadTrackingGizi();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            SetActiveButton((IconButton)sender);
            LoadDashboard();
        }

        // Expose panelcontent
        public Panel PanelContent
        {
            get { return panelContent; }
        }
    }
}
