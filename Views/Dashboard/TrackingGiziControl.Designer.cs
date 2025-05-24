namespace NutriNyan.Views.Dashboard
{
    partial class TrackingGiziControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            sarapanGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            makanSiangGridView = new DataGridView();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            makanMalamGridView = new DataGridView();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            jajanGridView = new DataGridView();
            trackingDateTimePicker = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            groupBox1 = new GroupBox();
            makanButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)sarapanGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)makanSiangGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)makanMalamGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jajanGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 0;
            label1.Text = "Tracking Gizi";
            // 
            // sarapanGridView
            // 
            sarapanGridView.AllowUserToAddRows = false;
            sarapanGridView.AllowUserToDeleteRows = false;
            sarapanGridView.AllowUserToResizeColumns = false;
            sarapanGridView.AllowUserToResizeRows = false;
            sarapanGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sarapanGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sarapanGridView.BackgroundColor = Color.FromArgb(1, 54, 63);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sarapanGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sarapanGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sarapanGridView.Location = new Point(38, 372);
            sarapanGridView.Margin = new Padding(3, 4, 3, 4);
            sarapanGridView.Name = "sarapanGridView";
            sarapanGridView.RowHeadersWidth = 51;
            sarapanGridView.Size = new Size(844, 392);
            sarapanGridView.TabIndex = 1;
            sarapanGridView.RowPostPaint += sarapanGridView_RowPostPaint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(80, 311);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 2;
            label2.Text = Database.MealTypes[0];
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(796, 289);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 3;
            label3.Text = "Kalori";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(805, 324);
            label4.Name = "label4";
            label4.Size = new Size(53, 32);
            label4.TabIndex = 4;
            label4.Text = "120";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(17, 30, 29);
            iconPictureBox1.ForeColor = Color.Yellow;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sun;
            iconPictureBox1.IconColor = Color.Yellow;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 37;
            iconPictureBox1.Location = new Point(38, 315);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(37, 43);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(17, 30, 29);
            iconPictureBox2.ForeColor = Color.Cyan;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Sun;
            iconPictureBox2.IconColor = Color.Cyan;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 37;
            iconPictureBox2.Location = new Point(38, 807);
            iconPictureBox2.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 43);
            iconPictureBox2.TabIndex = 10;
            iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(810, 816);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 9;
            label5.Text = "120";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(801, 781);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 8;
            label6.Text = "Kalori";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(80, 803);
            label7.Name = "label7";
            label7.Size = new Size(182, 37);
            label7.TabIndex = 7;
            label7.Text = Database.MealTypes[1];
            // 
            // makanSiangGridView
            // 
            makanSiangGridView.AllowUserToAddRows = false;
            makanSiangGridView.AllowUserToDeleteRows = false;
            makanSiangGridView.AllowUserToResizeColumns = false;
            makanSiangGridView.AllowUserToResizeRows = false;
            makanSiangGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            makanSiangGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            makanSiangGridView.BackgroundColor = Color.FromArgb(1, 54, 63);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            makanSiangGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            makanSiangGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makanSiangGridView.Location = new Point(38, 864);
            makanSiangGridView.Margin = new Padding(3, 4, 3, 4);
            makanSiangGridView.Name = "makanSiangGridView";
            makanSiangGridView.RowHeadersWidth = 51;
            makanSiangGridView.Size = new Size(844, 379);
            makanSiangGridView.TabIndex = 6;
            makanSiangGridView.RowPostPaint += makanSiangGridView_RowPostPaint;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(17, 30, 29);
            iconPictureBox3.ForeColor = Color.LightCoral;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            iconPictureBox3.IconColor = Color.LightCoral;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 37;
            iconPictureBox3.Location = new Point(38, 1285);
            iconPictureBox3.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(37, 45);
            iconPictureBox3.TabIndex = 15;
            iconPictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(810, 1297);
            label8.Name = "label8";
            label8.Size = new Size(53, 32);
            label8.TabIndex = 14;
            label8.Text = "120";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(801, 1263);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 13;
            label9.Text = "Kalori";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(80, 1281);
            label10.Name = "label10";
            label10.Size = new Size(200, 37);
            label10.TabIndex = 12;
            label10.Text = Database.MealTypes[2];
            // 
            // makanMalamGridView
            // 
            makanMalamGridView.AllowUserToAddRows = false;
            makanMalamGridView.AllowUserToDeleteRows = false;
            makanMalamGridView.AllowUserToResizeColumns = false;
            makanMalamGridView.AllowUserToResizeRows = false;
            makanMalamGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            makanMalamGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            makanMalamGridView.BackgroundColor = Color.FromArgb(1, 54, 63);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            makanMalamGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            makanMalamGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makanMalamGridView.Location = new Point(38, 1343);
            makanMalamGridView.Margin = new Padding(3, 4, 3, 4);
            makanMalamGridView.Name = "makanMalamGridView";
            makanMalamGridView.RowHeadersWidth = 51;
            makanMalamGridView.Size = new Size(850, 327);
            makanMalamGridView.TabIndex = 11;
            makanMalamGridView.RowPostPaint += makanMalamGridView_RowPostPaint;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(17, 30, 29);
            iconPictureBox4.ForeColor = Color.DarkSeaGreen;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Cookie;
            iconPictureBox4.IconColor = Color.DarkSeaGreen;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 37;
            iconPictureBox4.Location = new Point(38, 1719);
            iconPictureBox4.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(37, 45);
            iconPictureBox4.TabIndex = 20;
            iconPictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(810, 1731);
            label11.Name = "label11";
            label11.Size = new Size(53, 32);
            label11.TabIndex = 19;
            label11.Text = "120";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(801, 1696);
            label12.Name = "label12";
            label12.Size = new Size(64, 25);
            label12.TabIndex = 18;
            label12.Text = "Kalori";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(80, 1715);
            label13.Name = "label13";
            label13.Size = new Size(169, 37);
            label13.TabIndex = 17;
            label13.Text = "Jajan/Snack";
            // 
            // jajanGridView
            // 
            jajanGridView.AllowUserToAddRows = false;
            jajanGridView.AllowUserToDeleteRows = false;
            jajanGridView.AllowUserToResizeColumns = false;
            jajanGridView.AllowUserToResizeRows = false;
            jajanGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            jajanGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            jajanGridView.BackgroundColor = Color.FromArgb(1, 54, 63);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            jajanGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            jajanGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jajanGridView.Location = new Point(38, 1776);
            jajanGridView.Margin = new Padding(3, 4, 3, 4);
            jajanGridView.Name = "jajanGridView";
            jajanGridView.RowHeadersWidth = 51;
            jajanGridView.Size = new Size(850, 327);
            jajanGridView.TabIndex = 16;
            jajanGridView.RowPostPaint += jajanGridView_RowPostPaint;
            // 
            // trackingDateTimePicker
            // 
            trackingDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackingDateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
            trackingDateTimePicker.Font = new Font("Segoe UI", 14F);
            trackingDateTimePicker.Location = new Point(526, 52);
            trackingDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            trackingDateTimePicker.Name = "trackingDateTimePicker";
            trackingDateTimePicker.Size = new Size(355, 39);
            trackingDateTimePicker.TabIndex = 21;
            trackingDateTimePicker.ValueChanged += trackDatePickChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(1, 54, 63);
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(14, 44);
            label14.Name = "label14";
            label14.Size = new Size(73, 28);
            label14.TabIndex = 22;
            label14.Text = "Lemak";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(1, 54, 63);
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(158, 44);
            label15.Name = "label15";
            label15.Size = new Size(68, 28);
            label15.TabIndex = 23;
            label15.Text = "Karbo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(1, 54, 63);
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(304, 44);
            label16.Name = "label16";
            label16.Size = new Size(81, 28);
            label16.TabIndex = 24;
            label16.Text = "Protein";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(1, 54, 63);
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(471, 44);
            label17.Name = "label17";
            label17.Size = new Size(61, 28);
            label17.TabIndex = 25;
            label17.Text = "Serat";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(1, 54, 63);
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(633, 44);
            label18.Name = "label18";
            label18.Size = new Size(55, 28);
            label18.TabIndex = 26;
            label18.Text = "Gula";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(1, 54, 63);
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(808, 39);
            label19.Name = "label19";
            label19.Size = new Size(73, 30);
            label19.TabIndex = 27;
            label19.Text = "Kalori";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(1, 54, 63);
            label20.Font = new Font("Segoe UI", 13F);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(831, 83);
            label20.Name = "label20";
            label20.Size = new Size(49, 30);
            label20.TabIndex = 33;
            label20.Text = "112";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(1, 54, 63);
            label21.Font = new Font("Segoe UI", 13F);
            label21.ForeColor = SystemColors.ControlLightLight;
            label21.Location = new Point(648, 83);
            label21.Name = "label21";
            label21.Size = new Size(25, 30);
            label21.TabIndex = 32;
            label21.Text = "7";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(1, 54, 63);
            label22.Font = new Font("Segoe UI", 13F);
            label22.ForeColor = SystemColors.ControlLightLight;
            label22.Location = new Point(488, 83);
            label22.Name = "label22";
            label22.Size = new Size(25, 30);
            label22.TabIndex = 31;
            label22.Text = "9";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(1, 54, 63);
            label23.Font = new Font("Segoe UI", 13F);
            label23.ForeColor = SystemColors.ControlLightLight;
            label23.Location = new Point(326, 83);
            label23.Name = "label23";
            label23.Size = new Size(37, 30);
            label23.TabIndex = 30;
            label23.Text = "20";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(1, 54, 63);
            label24.Font = new Font("Segoe UI", 13F);
            label24.ForeColor = SystemColors.ControlLightLight;
            label24.Location = new Point(177, 83);
            label24.Name = "label24";
            label24.Size = new Size(37, 30);
            label24.TabIndex = 29;
            label24.Text = "30";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(1, 54, 63);
            label25.Font = new Font("Segoe UI", 13F);
            label25.ForeColor = SystemColors.ControlLightLight;
            label25.Location = new Point(30, 83);
            label25.Name = "label25";
            label25.Size = new Size(37, 30);
            label25.TabIndex = 28;
            label25.Text = "10";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(1, 54, 63);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label25);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(38, 117);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 147);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Kandungan GIzi";
            // 
            // makanButton
            // 
            makanButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            makanButton.BackColor = Color.FromArgb(0, 221, 220);
            makanButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            makanButton.ForeColor = Color.FromArgb(1, 54, 63);
            makanButton.IconChar = FontAwesome.Sharp.IconChar.None;
            makanButton.IconColor = Color.Black;
            makanButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            makanButton.Location = new Point(660, 299);
            makanButton.Margin = new Padding(3, 4, 3, 4);
            makanButton.Name = "makanButton";
            makanButton.Size = new Size(96, 52);
            makanButton.TabIndex = 35;
            makanButton.Tag = Database.MealTypes[0];
            makanButton.Text = "Makan";
            makanButton.UseVisualStyleBackColor = false;
            makanButton.Click += makanButton_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(0, 221, 220);
            iconButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            iconButton1.ForeColor = Color.FromArgb(1, 54, 63);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(660, 791);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(96, 52);
            iconButton1.TabIndex = 36;
            iconButton1.Tag = Database.MealTypes[1];
            iconButton1.Text = "Makan";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += makanButton_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(0, 221, 220);
            iconButton2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            iconButton2.ForeColor = Color.FromArgb(1, 54, 63);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(660, 1269);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(96, 52);
            iconButton2.TabIndex = 37;
            iconButton2.Tag = Database.MealTypes[2];
            iconButton2.Text = "Makan";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += makanButton_Click;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton3.BackColor = Color.FromArgb(0, 221, 220);
            iconButton3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            iconButton3.ForeColor = Color.FromArgb(1, 54, 63);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(660, 1703);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(96, 52);
            iconButton3.TabIndex = 38;
            iconButton3.Tag = Database.MealTypes[3];
            iconButton3.Text = "Makan";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += makanButton_Click;
            // 
            // TrackingGiziControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(makanButton);
            Controls.Add(trackingDateTimePicker);
            Controls.Add(iconPictureBox4);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(jajanGridView);
            Controls.Add(iconPictureBox3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(makanMalamGridView);
            Controls.Add(iconPictureBox2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(makanSiangGridView);
            Controls.Add(iconPictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sarapanGridView);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrackingGiziControl";
            Size = new Size(912, 1937);
            Load += TrackingGiziControl_Load;
            ((System.ComponentModel.ISupportInitialize)sarapanGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)makanSiangGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)makanMalamGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)jajanGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView sarapanGridView;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView makanSiangGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView makanMalamGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView jajanGridView;
        private DateTimePicker trackingDateTimePicker;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton makanButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
