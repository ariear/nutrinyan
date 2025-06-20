﻿namespace NutriNyan.Views.Dashboard
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
            logoutButton = new FontAwesome.Sharp.IconButton();
            settingButton = new FontAwesome.Sharp.IconButton();
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
            sidebarMenu.Controls.Add(logoutButton);
            sidebarMenu.Controls.Add(settingButton);
            sidebarMenu.Controls.Add(konsultasiButton);
            sidebarMenu.Controls.Add(TrackingAirButton);
            sidebarMenu.Controls.Add(TrackingGiziButton);
            sidebarMenu.Controls.Add(dashboardButton);
            sidebarMenu.Controls.Add(panelLogo);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(262, 637);
            sidebarMenu.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logoutButton.BackColor = Color.FromArgb(255, 99, 99);
            logoutButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            logoutButton.ForeColor = SystemColors.ControlLightLight;
            logoutButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logoutButton.IconColor = Color.White;
            logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logoutButton.IconSize = 28;
            logoutButton.Location = new Point(54, 562);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(133, 43);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Keluar";
            logoutButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
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
            settingButton.Location = new Point(0, 380);
            settingButton.Name = "settingButton";
            settingButton.Padding = new Padding(10, 0, 15, 0);
            settingButton.Size = new Size(262, 60);
            settingButton.TabIndex = 6;
            settingButton.Text = "Pengaturan";
            settingButton.TextAlign = ContentAlignment.MiddleLeft;
            settingButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
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
            konsultasiButton.Location = new Point(0, 320);
            konsultasiButton.Name = "konsultasiButton";
            konsultasiButton.Padding = new Padding(10, 0, 15, 0);
            konsultasiButton.Size = new Size(262, 60);
            konsultasiButton.TabIndex = 4;
            konsultasiButton.Text = "Konsultasi Gizi";
            konsultasiButton.TextAlign = ContentAlignment.MiddleLeft;
            konsultasiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            konsultasiButton.UseVisualStyleBackColor = true;
            konsultasiButton.Click += konsultasiButton_Click;
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
            TrackingAirButton.Location = new Point(0, 260);
            TrackingAirButton.Name = "TrackingAirButton";
            TrackingAirButton.Padding = new Padding(10, 0, 15, 0);
            TrackingAirButton.Size = new Size(262, 60);
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
            TrackingGiziButton.Location = new Point(0, 200);
            TrackingGiziButton.Name = "TrackingGiziButton";
            TrackingGiziButton.Padding = new Padding(10, 0, 15, 0);
            TrackingGiziButton.Size = new Size(262, 60);
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
            dashboardButton.Location = new Point(0, 140);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(10, 0, 15, 0);
            dashboardButton.Size = new Size(262, 60);
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(262, 140);
            panelLogo.TabIndex = 0;
            // 
            // logoApp
            // 
            logoApp.Image = Properties.Resources.nutrinyan_logo;
            logoApp.Location = new Point(56, 36);
            logoApp.Name = "logoApp";
            logoApp.Size = new Size(139, 70);
            logoApp.SizeMode = PictureBoxSizeMode.Zoom;
            logoApp.TabIndex = 1;
            logoApp.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(17, 30, 29);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(262, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(985, 637);
            panelContent.TabIndex = 1;
            // 
            // DashboardMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 637);
            Controls.Add(panelContent);
            Controls.Add(sidebarMenu);
            MinimumSize = new Size(1261, 638);
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
        private FontAwesome.Sharp.IconButton konsultasiButton;
        private PictureBox logoApp;
        private Panel panelContent;
        private FontAwesome.Sharp.IconButton logoutButton;
    }
}