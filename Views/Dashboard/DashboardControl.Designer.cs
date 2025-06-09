namespace NutriNyan.Views.Dashboard
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            label18 = new Label();
            KaloriLabel = new Label();
            label14 = new Label();
            GulaValLab = new Label();
            label15 = new Label();
            SeratValLabel = new Label();
            label16 = new Label();
            ProteinValLabel = new Label();
            label17 = new Label();
            KarboValLabel = new Label();
            label19 = new Label();
            LemakValLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(78, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 45);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // chart2
            // 
            chart2.BackColor = Color.FromArgb(0, 192, 192);
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(78, 388);
            chart2.Margin = new Padding(2);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Yellow;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.Yellow;
            series1.Name = "Kalori";
            dataPoint1.AxisLabel = "Senin";
            dataPoint1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
            dataPoint1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Tile;
            dataPoint1.Color = Color.Yellow;
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.IsVisibleInLegend = false;
            dataPoint1.Label = "";
            dataPoint1.LabelBackColor = Color.GreenYellow;
            dataPoint1.LabelForeColor = Color.Black;
            dataPoint1.LegendText = "";
            dataPoint1.LegendToolTip = "";
            dataPoint1.MarkerBorderColor = Color.Gold;
            dataPoint1.MarkerBorderWidth = 20;
            dataPoint2.AxisLabel = "Selasa";
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint2.LabelBackColor = Color.GreenYellow;
            dataPoint3.AxisLabel = "Rabu";
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint3.LabelBackColor = Color.GreenYellow;
            dataPoint4.AxisLabel = "Kamis";
            dataPoint4.IsValueShownAsLabel = true;
            dataPoint4.LabelBackColor = Color.GreenYellow;
            dataPoint5.AxisLabel = "Jum'at";
            dataPoint5.IsValueShownAsLabel = true;
            dataPoint5.LabelBackColor = Color.GreenYellow;
            dataPoint6.AxisLabel = "Sabtu";
            dataPoint6.IsValueShownAsLabel = true;
            dataPoint6.LabelBackColor = Color.GreenYellow;
            dataPoint7.AxisLabel = "Minggu";
            dataPoint7.IsValueShownAsLabel = true;
            dataPoint7.LabelBackColor = Color.GreenYellow;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.XValueMember = "12";
            chart2.Series.Add(series1);
            chart2.Size = new Size(806, 335);
            chart2.TabIndex = 35;
            chart2.Tag = "";
            chart2.Text = "chart2";
            title1.Name = "Title1";
            chart2.Titles.Add(title1);
            chart2.Click += chart2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(1, 54, 63);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(KaloriLabel);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(GulaValLab);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(SeratValLabel);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(ProteinValLabel);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(KarboValLabel);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(LemakValLabel);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(78, 118);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1110, 185);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kandungan Gizi Hari Ini";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(1, 54, 63);
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(818, 56);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(66, 32);
            label18.TabIndex = 26;
            label18.Text = "Gula";
            // 
            // KaloriLabel
            // 
            KaloriLabel.AutoSize = true;
            KaloriLabel.BackColor = Color.FromArgb(1, 54, 63);
            KaloriLabel.Font = new Font("Segoe UI", 13F);
            KaloriLabel.ForeColor = SystemColors.ControlLightLight;
            KaloriLabel.Location = new Point(1004, 111);
            KaloriLabel.Margin = new Padding(4, 0, 4, 0);
            KaloriLabel.Name = "KaloriLabel";
            KaloriLabel.Size = new Size(57, 36);
            KaloriLabel.TabIndex = 33;
            KaloriLabel.Text = "112";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(1, 54, 63);
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(90, 59);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(87, 32);
            label14.TabIndex = 22;
            label14.Text = "Lemak";
            // 
            // GulaValLab
            // 
            GulaValLab.AutoSize = true;
            GulaValLab.BackColor = Color.FromArgb(1, 54, 63);
            GulaValLab.Font = new Font("Segoe UI", 13F);
            GulaValLab.ForeColor = SystemColors.ControlLightLight;
            GulaValLab.Location = new Point(842, 111);
            GulaValLab.Margin = new Padding(4, 0, 4, 0);
            GulaValLab.Name = "GulaValLab";
            GulaValLab.Size = new Size(29, 36);
            GulaValLab.TabIndex = 32;
            GulaValLab.Text = "7";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(1, 54, 63);
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(262, 56);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(83, 32);
            label15.TabIndex = 23;
            label15.Text = "Karbo";
            // 
            // SeratValLabel
            // 
            SeratValLabel.AutoSize = true;
            SeratValLabel.BackColor = Color.FromArgb(1, 54, 63);
            SeratValLabel.Font = new Font("Segoe UI", 13F);
            SeratValLabel.ForeColor = SystemColors.ControlLightLight;
            SeratValLabel.Location = new Point(689, 111);
            SeratValLabel.Margin = new Padding(4, 0, 4, 0);
            SeratValLabel.Name = "SeratValLabel";
            SeratValLabel.Size = new Size(29, 36);
            SeratValLabel.TabIndex = 31;
            SeratValLabel.Text = "9";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(1, 54, 63);
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(452, 56);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(98, 32);
            label16.TabIndex = 24;
            label16.Text = "Protein";
            // 
            // ProteinValLabel
            // 
            ProteinValLabel.AutoSize = true;
            ProteinValLabel.BackColor = Color.FromArgb(1, 54, 63);
            ProteinValLabel.Font = new Font("Segoe UI", 13F);
            ProteinValLabel.ForeColor = SystemColors.ControlLightLight;
            ProteinValLabel.Location = new Point(480, 108);
            ProteinValLabel.Margin = new Padding(4, 0, 4, 0);
            ProteinValLabel.Name = "ProteinValLabel";
            ProteinValLabel.Size = new Size(43, 36);
            ProteinValLabel.TabIndex = 30;
            ProteinValLabel.Text = "20";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(1, 54, 63);
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(665, 56);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(72, 32);
            label17.TabIndex = 25;
            label17.Text = "Serat";
            // 
            // KarboValLabel
            // 
            KarboValLabel.AutoSize = true;
            KarboValLabel.BackColor = Color.FromArgb(1, 54, 63);
            KarboValLabel.Font = new Font("Segoe UI", 13F);
            KarboValLabel.ForeColor = SystemColors.ControlLightLight;
            KarboValLabel.Location = new Point(284, 108);
            KarboValLabel.Margin = new Padding(4, 0, 4, 0);
            KarboValLabel.Name = "KarboValLabel";
            KarboValLabel.Size = new Size(43, 36);
            KarboValLabel.TabIndex = 29;
            KarboValLabel.Text = "30";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(1, 54, 63);
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(975, 56);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(86, 36);
            label19.TabIndex = 27;
            label19.Text = "Kalori";
            // 
            // LemakValLabel
            // 
            LemakValLabel.AutoSize = true;
            LemakValLabel.BackColor = Color.FromArgb(1, 54, 63);
            LemakValLabel.Font = new Font("Segoe UI", 13F);
            LemakValLabel.ForeColor = SystemColors.ControlLightLight;
            LemakValLabel.Location = new Point(112, 108);
            LemakValLabel.Margin = new Padding(4, 0, 4, 0);
            LemakValLabel.Name = "LemakValLabel";
            LemakValLabel.Size = new Size(43, 36);
            LemakValLabel.TabIndex = 28;
            LemakValLabel.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(78, 335);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 32);
            label2.TabIndex = 37;
            label2.Text = "Kalori Minggu Ini";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(chart2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardControl";
            Size = new Size(1246, 876);
            Load += DashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private GroupBox groupBox1;
        private Label label18;
        private Label KaloriLabel;
        private Label label14;
        private Label GulaValLab;
        private Label label15;
        private Label SeratValLabel;
        private Label label16;
        private Label ProteinValLabel;
        private Label label17;
        private Label KarboValLabel;
        private Label label19;
        private Label LemakValLabel;
        private Label label2;
    }
}
