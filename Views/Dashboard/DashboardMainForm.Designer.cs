namespace NutriNyan.Views.Dashboard
{
    partial class DashboardMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarMenu = new Panel();
            settingButton = new FontAwesome.Sharp.IconButton();
            reminderButton = new FontAwesome.Sharp.IconButton();
            konsultasiButton = new FontAwesome.Sharp.IconButton();
            TrackingAirButton = new FontAwesome.Sharp.IconButton();
            TrackingGiziButton = new FontAwesome.Sharp.IconButton();
            dashboardButton = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            logoApp = new PictureBox();
            panelContent = new Panel();
            sidebarMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoApp).BeginInit();
            SuspendLayout();
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = Color.FromArgb(1, 54, 63);
            sidebarMenu.Controls.Add(settingButton);
            sidebarMenu.Controls.Add(reminderButton);
            sidebarMenu.Controls.Add(konsultasiButton);
            sidebarMenu.Controls.Add(TrackingAirButton);
            sidebarMenu.Controls.Add(TrackingGiziButton);
            sidebarMenu.Controls.Add(dashboardButton);
            sidebarMenu.Controls.Add(panelLogo);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.Margin = new Padding(4, 5, 4, 5);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(374, 1170);
            sidebarMenu.TabIndex = 0;
            // 
            // settingButton
            // 
            settingButton.Dock = DockStyle.Top;
            settingButton.FlatAppearance.BorderSize = 0;
            settingButton.FlatStyle = FlatStyle.Flat;
            settingButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingButton.ForeColor = Color.FromArgb(183, 201, 200);
            settingButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            settingButton.IconColor = Color.FromArgb(183, 201, 200);
            settingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingButton.IconSize = 36;
            settingButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingButton.Location = new Point(0, 733);
            settingButton.Margin = new Padding(4, 5, 4, 5);
            settingButton.Name = "settingButton";
            settingButton.Padding = new Padding(14, 0, 21, 0);
            settingButton.Size = new Size(374, 100);
            settingButton.TabIndex = 6;
            settingButton.Text = "Pengaturan";
            settingButton.TextAlign = ContentAlignment.MiddleLeft;
            settingButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
            // 
            // reminderButton
            // 
            reminderButton.Dock = DockStyle.Top;
            reminderButton.FlatAppearance.BorderSize = 0;
            reminderButton.FlatStyle = FlatStyle.Flat;
            reminderButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reminderButton.ForeColor = Color.FromArgb(183, 201, 200);
            reminderButton.IconChar = FontAwesome.Sharp.IconChar.Bell;
            reminderButton.IconColor = Color.FromArgb(183, 201, 200);
            reminderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            reminderButton.IconSize = 36;
            reminderButton.ImageAlign = ContentAlignment.MiddleLeft;
            reminderButton.Location = new Point(0, 633);
            reminderButton.Margin = new Padding(4, 5, 4, 5);
            reminderButton.Name = "reminderButton";
            reminderButton.Padding = new Padding(14, 0, 21, 0);
            reminderButton.Size = new Size(374, 100);
            reminderButton.TabIndex = 5;
            reminderButton.Text = "Pengingat Makan";
            reminderButton.TextAlign = ContentAlignment.MiddleLeft;
            reminderButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reminderButton.UseVisualStyleBackColor = true;
            // 
            // konsultasiButton
            // 
            konsultasiButton.Dock = DockStyle.Top;
            konsultasiButton.FlatAppearance.BorderSize = 0;
            konsultasiButton.FlatStyle = FlatStyle.Flat;
            konsultasiButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            konsultasiButton.ForeColor = Color.FromArgb(183, 201, 200);
            konsultasiButton.IconChar = FontAwesome.Sharp.IconChar.Comments;
            konsultasiButton.IconColor = Color.FromArgb(183, 201, 200);
            konsultasiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            konsultasiButton.IconSize = 36;
            konsultasiButton.ImageAlign = ContentAlignment.MiddleLeft;
            konsultasiButton.Location = new Point(0, 533);
            konsultasiButton.Margin = new Padding(4, 5, 4, 5);
            konsultasiButton.Name = "konsultasiButton";
            konsultasiButton.Padding = new Padding(14, 0, 21, 0);
            konsultasiButton.Size = new Size(374, 100);
            konsultasiButton.TabIndex = 4;
            konsultasiButton.Text = "Konsultasi Gizi";
            konsultasiButton.TextAlign = ContentAlignment.MiddleLeft;
            konsultasiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            konsultasiButton.UseVisualStyleBackColor = true;
            // 
            // TrackingAirButton
            // 
            TrackingAirButton.Dock = DockStyle.Top;
            TrackingAirButton.FlatAppearance.BorderSize = 0;
            TrackingAirButton.FlatStyle = FlatStyle.Flat;
            TrackingAirButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrackingAirButton.ForeColor = Color.FromArgb(183, 201, 200);
            TrackingAirButton.IconChar = FontAwesome.Sharp.IconChar.GlassWaterDroplet;
            TrackingAirButton.IconColor = Color.FromArgb(183, 201, 200);
            TrackingAirButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TrackingAirButton.IconSize = 36;
            TrackingAirButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrackingAirButton.Location = new Point(0, 433);
            TrackingAirButton.Margin = new Padding(4, 5, 4, 5);
            TrackingAirButton.Name = "TrackingAirButton";
            TrackingAirButton.Padding = new Padding(14, 0, 21, 0);
            TrackingAirButton.Size = new Size(374, 100);
            TrackingAirButton.TabIndex = 3;
            TrackingAirButton.Text = "Tracking Air";
            TrackingAirButton.TextAlign = ContentAlignment.MiddleLeft;
            TrackingAirButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TrackingAirButton.UseVisualStyleBackColor = true;
            TrackingAirButton.Click += TrackingAirButton_Click;
            // 
            // TrackingGiziButton
            // 
            TrackingGiziButton.Dock = DockStyle.Top;
            TrackingGiziButton.FlatAppearance.BorderSize = 0;
            TrackingGiziButton.FlatStyle = FlatStyle.Flat;
            TrackingGiziButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrackingGiziButton.ForeColor = Color.FromArgb(183, 201, 200);
            TrackingGiziButton.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            TrackingGiziButton.IconColor = Color.FromArgb(183, 201, 200);
            TrackingGiziButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TrackingGiziButton.IconSize = 36;
            TrackingGiziButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrackingGiziButton.Location = new Point(0, 333);
            TrackingGiziButton.Margin = new Padding(4, 5, 4, 5);
            TrackingGiziButton.Name = "TrackingGiziButton";
            TrackingGiziButton.Padding = new Padding(14, 0, 21, 0);
            TrackingGiziButton.Size = new Size(374, 100);
            TrackingGiziButton.TabIndex = 2;
            TrackingGiziButton.Text = "Tracking Gizi";
            TrackingGiziButton.TextAlign = ContentAlignment.MiddleLeft;
            TrackingGiziButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TrackingGiziButton.UseVisualStyleBackColor = true;
            TrackingGiziButton.Click += TrackingGiziButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Dock = DockStyle.Top;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.FromArgb(183, 201, 200);
            dashboardButton.IconChar = FontAwesome.Sharp.IconChar.House;
            dashboardButton.IconColor = Color.FromArgb(183, 201, 200);
            dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dashboardButton.IconSize = 36;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(0, 233);
            dashboardButton.Margin = new Padding(4, 5, 4, 5);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(14, 0, 21, 0);
            dashboardButton.Size = new Size(374, 100);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(logoApp);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(374, 233);
            panelLogo.TabIndex = 0;
            // 
            // logoApp
            // 
            logoApp.Image = Properties.Resources.nutrinyan_logo;
            logoApp.Location = new Point(80, 60);
            logoApp.Margin = new Padding(4, 5, 4, 5);
            logoApp.Name = "logoApp";
            logoApp.Size = new Size(199, 117);
            logoApp.SizeMode = PictureBoxSizeMode.Zoom;
            logoApp.TabIndex = 1;
            logoApp.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(17, 30, 29);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(374, 0);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1407, 1170);
            panelContent.TabIndex = 1;
            // 
            // DashboardMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 1170);
            Controls.Add(panelContent);
            Controls.Add(sidebarMenu);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1795, 1126);
            Name = "DashboardMainForm";
            Text = "NutriNyan - Dashboard";
            Load += DashboardMainForm_Load;
            sidebarMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarMenu;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton TrackingAirButton;
        private FontAwesome.Sharp.IconButton TrackingGiziButton;
        private FontAwesome.Sharp.IconButton settingButton;
        private FontAwesome.Sharp.IconButton reminderButton;
        private FontAwesome.Sharp.IconButton konsultasiButton;
        private PictureBox logoApp;
        private Panel panelContent;
    }
}