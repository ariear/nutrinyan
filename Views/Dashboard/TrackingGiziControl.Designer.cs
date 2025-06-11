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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            sarapanGridView = new DataGridView();
            makanPagiLabel = new Label();
            label3 = new Label();
            totalKaloriPagi = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            totalKaloriSiang = new Label();
            label6 = new Label();
            makanSiangLabel = new Label();
            makanSiangGridView = new DataGridView();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            totalKaloriMalam = new Label();
            label9 = new Label();
            makanMalamLabel = new Label();
            makanMalamGridView = new DataGridView();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            totalKaloriJajan = new Label();
            label12 = new Label();
            jajanLabel = new Label();
            jajanGridView = new DataGridView();
            trackingDateTimePicker = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            KaloriValLab = new Label();
            GulaValLab = new Label();
            SeratValLab = new Label();
            ProteinValLab = new Label();
            KarboValLab = new Label();
            LemakValLab = new Label();
            groupBox1 = new GroupBox();
            mknPagiIconButton = new FontAwesome.Sharp.IconButton();
            mknSiangIconButton1 = new FontAwesome.Sharp.IconButton();
            mknMlmIconButton = new FontAwesome.Sharp.IconButton();
            jajanIconButton = new FontAwesome.Sharp.IconButton();
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            sarapanGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            sarapanGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sarapanGridView.Location = new Point(38, 372);
            sarapanGridView.Margin = new Padding(3, 4, 3, 4);
            sarapanGridView.Name = "sarapanGridView";
            sarapanGridView.Tag = "0";
            sarapanGridView.RowHeadersWidth = 51;
            sarapanGridView.Size = new Size(802, 392);
            sarapanGridView.TabIndex = 1;
            sarapanGridView.RowPostPaint += sarapanGridView_RowPostPaint;
            sarapanGridView.CellClick += DataGridContentClicked;
            // 
            // makanPagiLabel
            // 
            makanPagiLabel.AutoSize = true;
            makanPagiLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            makanPagiLabel.ForeColor = SystemColors.ControlLightLight;
            makanPagiLabel.Location = new Point(80, 311);
            makanPagiLabel.Name = "makanPagiLabel";
            makanPagiLabel.Size = new Size(0, 37);
            makanPagiLabel.TabIndex = 2;
            makanPagiLabel.Text = Database.MealsOfADay[0].mealType;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(754, 289);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 3;
            label3.Text = "Kalori";
            // 
            // totalKaloriPagi
            // 
            totalKaloriPagi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalKaloriPagi.AutoSize = true;
            totalKaloriPagi.Font = new Font("Segoe UI", 14F);
            totalKaloriPagi.ForeColor = SystemColors.ControlLightLight;
            totalKaloriPagi.Location = new Point(763, 324);
            totalKaloriPagi.Name = "totalKaloriPagi";
            totalKaloriPagi.Size = new Size(27, 32);
            totalKaloriPagi.TabIndex = 4;
            totalKaloriPagi.Text = "0";
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
            // totalKaloriSiang
            // 
            totalKaloriSiang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalKaloriSiang.AutoSize = true;
            totalKaloriSiang.Font = new Font("Segoe UI", 14F);
            totalKaloriSiang.ForeColor = SystemColors.ControlLightLight;
            totalKaloriSiang.Location = new Point(768, 816);
            totalKaloriSiang.Name = "totalKaloriSiang";
            totalKaloriSiang.Size = new Size(27, 32);
            totalKaloriSiang.TabIndex = 9;
            totalKaloriSiang.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(759, 781);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 8;
            label6.Text = "Kalori";
            // 
            // makanSiangLabel
            // 
            makanSiangLabel.AutoSize = true;
            makanSiangLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            makanSiangLabel.ForeColor = SystemColors.ControlLightLight;
            makanSiangLabel.Location = new Point(80, 803);
            makanSiangLabel.Name = "makanSiangLabel";
            makanSiangLabel.Size = new Size(0, 37);
            makanSiangLabel.TabIndex = 7;
            makanSiangLabel.Text = Database.MealsOfADay[1].mealType;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            makanSiangGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            makanSiangGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makanSiangGridView.Location = new Point(38, 864);
            makanSiangGridView.Margin = new Padding(3, 4, 3, 4);
            makanSiangGridView.Name = "makanSiangGridView";
            makanSiangGridView.RowHeadersWidth = 51;
            makanSiangGridView.Size = new Size(802, 379);
            makanSiangGridView.TabIndex = 6;
            makanSiangGridView.RowPostPaint += makanSiangGridView_RowPostPaint;
            makanSiangGridView.Tag = "1";
            makanSiangGridView.CellClick += DataGridContentClicked;
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
            // totalKaloriMalam
            // 
            totalKaloriMalam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalKaloriMalam.AutoSize = true;
            totalKaloriMalam.Font = new Font("Segoe UI", 14F);
            totalKaloriMalam.ForeColor = SystemColors.ControlLightLight;
            totalKaloriMalam.Location = new Point(768, 1297);
            totalKaloriMalam.Name = "totalKaloriMalam";
            totalKaloriMalam.Size = new Size(27, 32);
            totalKaloriMalam.TabIndex = 14;
            totalKaloriMalam.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(759, 1263);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 13;
            label9.Text = "Kalori";
            // 
            // makanMalamLabel
            // 
            makanMalamLabel.AutoSize = true;
            makanMalamLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            makanMalamLabel.ForeColor = SystemColors.ControlLightLight;
            makanMalamLabel.Location = new Point(80, 1281);
            makanMalamLabel.Name = "makanMalamLabel";
            makanMalamLabel.Size = new Size(0, 37);
            makanMalamLabel.TabIndex = 12;
            makanMalamLabel.Text = Database.MealsOfADay[2].mealType;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            makanMalamGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            makanMalamGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makanMalamGridView.Location = new Point(38, 1343);
            makanMalamGridView.Margin = new Padding(3, 4, 3, 4);
            makanMalamGridView.Name = "makanMalamGridView";
            makanMalamGridView.RowHeadersWidth = 51;
            makanMalamGridView.Size = new Size(808, 327);
            makanMalamGridView.TabIndex = 11;
            makanMalamGridView.RowPostPaint += makanMalamGridView_RowPostPaint;
            makanMalamGridView.Tag = "2";
            makanMalamGridView.CellClick += DataGridContentClicked;
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
            // totalKaloriJajan
            // 
            totalKaloriJajan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalKaloriJajan.AutoSize = true;
            totalKaloriJajan.Font = new Font("Segoe UI", 14F);
            totalKaloriJajan.ForeColor = SystemColors.ControlLightLight;
            totalKaloriJajan.Location = new Point(768, 1731);
            totalKaloriJajan.Name = "totalKaloriJajan";
            totalKaloriJajan.Size = new Size(27, 32);
            totalKaloriJajan.TabIndex = 19;
            totalKaloriJajan.Text = "0";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(759, 1696);
            label12.Name = "label12";
            label12.Size = new Size(64, 25);
            label12.TabIndex = 18;
            label12.Text = "Kalori";
            // 
            // jajanLabel
            // 
            jajanLabel.AutoSize = true;
            jajanLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            jajanLabel.ForeColor = SystemColors.ControlLightLight;
            jajanLabel.Location = new Point(80, 1715);
            jajanLabel.Name = "jajanLabel";
            jajanLabel.Size = new Size(169, 37);
            jajanLabel.TabIndex = 17;
            jajanLabel.Text = Database.MealsOfADay[3].mealType;
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            jajanGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            jajanGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jajanGridView.Location = new Point(38, 1776);
            jajanGridView.Margin = new Padding(3, 4, 3, 4);
            jajanGridView.Name = "jajanGridView";
            jajanGridView.RowHeadersWidth = 51;
            jajanGridView.Size = new Size(808, 327);
            jajanGridView.TabIndex = 16;
            jajanGridView.RowPostPaint += jajanGridView_RowPostPaint;
            jajanGridView.Tag = "3";
            jajanGridView.CellClick += DataGridContentClicked;
            // 
            // trackingDateTimePicker
            // 
            trackingDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackingDateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
            trackingDateTimePicker.Font = new Font("Segoe UI", 14F);
            trackingDateTimePicker.Location = new Point(484, 52);
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
            label14.Size = new Size(142, 28);
            label14.TabIndex = 22;
            label14.Text = "Lemak (gram)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(1, 54, 63);
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(158, 44);
            label15.Name = "label15";
            label15.Size = new Size(137, 28);
            label15.TabIndex = 23;
            label15.Text = "Karbo (gram)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(1, 54, 63);
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(304, 44);
            label16.Name = "label16";
            label16.Size = new Size(150, 28);
            label16.TabIndex = 24;
            label16.Text = "Protein (gram)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(1, 54, 63);
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(471, 44);
            label17.Name = "label17";
            label17.Size = new Size(130, 28);
            label17.TabIndex = 25;
            label17.Text = "Serat (gram)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(1, 54, 63);
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(633, 44);
            label18.Name = "label18";
            label18.Size = new Size(124, 28);
            label18.TabIndex = 26;
            label18.Text = "Gula (gram)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(1, 54, 63);
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(808, 39);
            label19.Name = "label19";
            label19.Size = new Size(137, 30);
            label19.TabIndex = 27;
            label19.Text = "Kalori (kkal)";
            // 
            // KaloriValLab
            // 
            KaloriValLab.AutoSize = true;
            KaloriValLab.BackColor = Color.FromArgb(1, 54, 63);
            KaloriValLab.Font = new Font("Segoe UI", 13F);
            KaloriValLab.ForeColor = SystemColors.ControlLightLight;
            KaloriValLab.Location = new Point(831, 83);
            KaloriValLab.Name = "KaloriValLab";
            KaloriValLab.Size = new Size(34, 30);
            KaloriValLab.TabIndex = 33;
            KaloriValLab.Text = "0/";
            // 
            // GulaValLab
            // 
            GulaValLab.AutoSize = true;
            GulaValLab.BackColor = Color.FromArgb(1, 54, 63);
            GulaValLab.Font = new Font("Segoe UI", 13F);
            GulaValLab.ForeColor = SystemColors.ControlLightLight;
            GulaValLab.Location = new Point(648, 83);
            GulaValLab.Name = "GulaValLab";
            GulaValLab.Size = new Size(58, 30);
            GulaValLab.TabIndex = 32;
            GulaValLab.Text = "7/50";
            // 
            // SeratValLab
            // 
            SeratValLab.AutoSize = true;
            SeratValLab.BackColor = Color.FromArgb(1, 54, 63);
            SeratValLab.Font = new Font("Segoe UI", 13F);
            SeratValLab.ForeColor = SystemColors.ControlLightLight;
            SeratValLab.Location = new Point(488, 83);
            SeratValLab.Name = "SeratValLab";
            SeratValLab.Size = new Size(34, 30);
            SeratValLab.TabIndex = 31;
            SeratValLab.Text = "0/";
            // 
            // ProteinValLab
            // 
            ProteinValLab.AutoSize = true;
            ProteinValLab.BackColor = Color.FromArgb(1, 54, 63);
            ProteinValLab.Font = new Font("Segoe UI", 13F);
            ProteinValLab.ForeColor = SystemColors.ControlLightLight;
            ProteinValLab.Location = new Point(326, 83);
            ProteinValLab.Name = "ProteinValLab";
            ProteinValLab.Size = new Size(46, 30);
            ProteinValLab.TabIndex = 30;
            ProteinValLab.Text = "0/";
            // 
            // KarboValLab
            // 
            KarboValLab.AutoSize = true;
            KarboValLab.BackColor = Color.FromArgb(1, 54, 63);
            KarboValLab.Font = new Font("Segoe UI", 13F);
            KarboValLab.ForeColor = SystemColors.ControlLightLight;
            KarboValLab.Location = new Point(177, 83);
            KarboValLab.Name = "KarboValLab";
            KarboValLab.Size = new Size(46, 30);
            KarboValLab.TabIndex = 29;
            KarboValLab.Text = "0/";
            // 
            // LemakValLab
            // 
            LemakValLab.AutoSize = true;
            LemakValLab.BackColor = Color.FromArgb(1, 54, 63);
            LemakValLab.Font = new Font("Segoe UI", 13F);
            LemakValLab.ForeColor = SystemColors.ControlLightLight;
            LemakValLab.Location = new Point(30, 83);
            LemakValLab.Name = "LemakValLab";
            LemakValLab.Size = new Size(46, 30);
            LemakValLab.TabIndex = 28;
            LemakValLab.Text = "10/";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(1, 54, 63);
            groupBox1.Controls.Add(LemakValLab);
            groupBox1.Controls.Add(SeratValLab);
            groupBox1.Controls.Add(ProteinValLab);
            groupBox1.Controls.Add(KarboValLab);
            groupBox1.Controls.Add(KaloriValLab);
            groupBox1.Controls.Add(GulaValLab);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label19);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(38, 117);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(951, 147);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Kandungan GIzi";
            // 
            // mknPagiIconButton
            // 
            mknPagiIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mknPagiIconButton.BackColor = Color.FromArgb(0, 221, 220);
            mknPagiIconButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            mknPagiIconButton.ForeColor = Color.FromArgb(1, 54, 63);
            mknPagiIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            mknPagiIconButton.IconColor = Color.Black;
            mknPagiIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mknPagiIconButton.Location = new Point(618, 299);
            mknPagiIconButton.Margin = new Padding(3, 4, 3, 4);
            mknPagiIconButton.Name = "mknPagiIconButton";
            mknPagiIconButton.Size = new Size(96, 52);
            mknPagiIconButton.TabIndex = 35;
            mknPagiIconButton.Text = "Makan";
            mknPagiIconButton.UseVisualStyleBackColor = false;
            mknPagiIconButton.Tag = "0";
            mknPagiIconButton.Click += makanButton_Click;
            // 
            // mknSiangIconButton1
            // 
            mknSiangIconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mknSiangIconButton1.BackColor = Color.FromArgb(0, 221, 220);
            mknSiangIconButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            mknSiangIconButton1.ForeColor = Color.FromArgb(1, 54, 63);
            mknSiangIconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            mknSiangIconButton1.IconColor = Color.Black;
            mknSiangIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mknSiangIconButton1.Location = new Point(618, 791);
            mknSiangIconButton1.Margin = new Padding(3, 4, 3, 4);
            mknSiangIconButton1.Name = "mknSiangIconButton1";
            mknSiangIconButton1.Size = new Size(96, 52);
            mknSiangIconButton1.TabIndex = 36;
            mknSiangIconButton1.Text = "Makan";
            mknSiangIconButton1.UseVisualStyleBackColor = false;
            mknSiangIconButton1.Tag = "1";
            mknSiangIconButton1.Click += makanButton_Click;
            // 
            // mknMlmIconButton
            // 
            mknMlmIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mknMlmIconButton.BackColor = Color.FromArgb(0, 221, 220);
            mknMlmIconButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            mknMlmIconButton.ForeColor = Color.FromArgb(1, 54, 63);
            mknMlmIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            mknMlmIconButton.IconColor = Color.Black;
            mknMlmIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mknMlmIconButton.Location = new Point(618, 1269);
            mknMlmIconButton.Margin = new Padding(3, 4, 3, 4);
            mknMlmIconButton.Name = "mknMlmIconButton";
            mknMlmIconButton.Size = new Size(96, 52);
            mknMlmIconButton.TabIndex = 37;
            mknMlmIconButton.Text = "Makan";
            mknMlmIconButton.UseVisualStyleBackColor = false;
            mknMlmIconButton.Tag = "2";
            mknMlmIconButton.Click += makanButton_Click;
            // 
            // jajanIconButton
            // 
            jajanIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            jajanIconButton.BackColor = Color.FromArgb(0, 221, 220);
            jajanIconButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            jajanIconButton.ForeColor = Color.FromArgb(1, 54, 63);
            jajanIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            jajanIconButton.IconColor = Color.Black;
            jajanIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            jajanIconButton.Location = new Point(618, 1703);
            jajanIconButton.Margin = new Padding(3, 4, 3, 4);
            jajanIconButton.Name = "jajanIconButton";
            jajanIconButton.Size = new Size(96, 52);
            jajanIconButton.TabIndex = 38;
            jajanIconButton.Text = "Makan";
            jajanIconButton.UseVisualStyleBackColor = false;
            jajanIconButton.Tag = "3";
            jajanIconButton.Click += makanButton_Click;
            // 
            // TrackingGiziControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(mknPagiIconButton);
            Controls.Add(mknSiangIconButton1);
            Controls.Add(mknMlmIconButton);
            Controls.Add(jajanIconButton);
            Controls.Add(trackingDateTimePicker);
            Controls.Add(iconPictureBox4);
            Controls.Add(totalKaloriJajan);
            Controls.Add(label12);
            Controls.Add(jajanLabel);
            Controls.Add(jajanGridView);
            Controls.Add(iconPictureBox3);
            Controls.Add(totalKaloriMalam);
            Controls.Add(label9);
            Controls.Add(makanMalamLabel);
            Controls.Add(makanMalamGridView);
            Controls.Add(iconPictureBox2);
            Controls.Add(totalKaloriSiang);
            Controls.Add(label6);
            Controls.Add(makanSiangLabel);
            Controls.Add(makanSiangGridView);
            Controls.Add(iconPictureBox1);
            Controls.Add(totalKaloriPagi);
            Controls.Add(label3);
            Controls.Add(makanPagiLabel);
            Controls.Add(sarapanGridView);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrackingGiziControl";
            Size = new Size(870, 1937);
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
        private Label makanPagiLabel;
        private Label label3;
        private Label totalKaloriPagi;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label totalKaloriSiang;
        private Label label6;
        private Label makanSiangLabel;
        private DataGridView makanSiangGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label totalKaloriMalam;
        private Label label9;
        private Label makanMalamLabel;
        private DataGridView makanMalamGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label totalKaloriJajan;
        private Label label12;
        private Label jajanLabel;
        private DataGridView jajanGridView;
        private DateTimePicker trackingDateTimePicker;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label KaloriValLab;
        private Label GulaValLab;
        private Label SeratValLab;
        private Label ProteinValLab;
        private Label KarboValLab;
        private Label LemakValLab;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton mknPagiIconButton;
        private FontAwesome.Sharp.IconButton mknSiangIconButton1;
        private FontAwesome.Sharp.IconButton mknMlmIconButton;
        private FontAwesome.Sharp.IconButton jajanIconButton;
    }
}
