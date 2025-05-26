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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 99D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 169D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 187D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 154D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 225D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 112D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            label1.Location = new Point(62, 34);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // chart2
            // 
            chart2.BackColor = Color.FromArgb(0, 192, 192);
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(62, 310);
            chart2.Margin = new Padding(2);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.Yellow;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = Color.Yellow;
            series2.Name = "Kalori";
            dataPoint8.AxisLabel = "Senin";
            dataPoint8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint8.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
            dataPoint8.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Tile;
            dataPoint8.Color = Color.Yellow;
            dataPoint8.IsValueShownAsLabel = true;
            dataPoint8.IsVisibleInLegend = false;
            dataPoint8.Label = "";
            dataPoint8.LabelBackColor = Color.GreenYellow;
            dataPoint8.LabelForeColor = Color.Black;
            dataPoint8.LegendText = "";
            dataPoint8.LegendToolTip = "";
            dataPoint8.MarkerBorderColor = Color.Gold;
            dataPoint8.MarkerBorderWidth = 20;
            dataPoint9.AxisLabel = "Selasa";
            dataPoint9.IsValueShownAsLabel = true;
            dataPoint9.LabelBackColor = Color.GreenYellow;
            dataPoint10.AxisLabel = "Rabu";
            dataPoint10.IsValueShownAsLabel = true;
            dataPoint10.LabelBackColor = Color.GreenYellow;
            dataPoint11.AxisLabel = "Kamis";
            dataPoint11.IsValueShownAsLabel = true;
            dataPoint11.LabelBackColor = Color.GreenYellow;
            dataPoint12.AxisLabel = "Jum'at";
            dataPoint12.IsValueShownAsLabel = true;
            dataPoint12.LabelBackColor = Color.GreenYellow;
            dataPoint13.AxisLabel = "Sabtu";
            dataPoint13.IsValueShownAsLabel = true;
            dataPoint13.LabelBackColor = Color.GreenYellow;
            dataPoint14.AxisLabel = "Minggu";
            dataPoint14.IsValueShownAsLabel = true;
            dataPoint14.LabelBackColor = Color.GreenYellow;
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.XValueMember = "12";
            chart2.Series.Add(series2);
            chart2.Size = new Size(645, 268);
            chart2.TabIndex = 35;
            chart2.Tag = "";
            chart2.Text = "chart2";
            title2.Name = "Title1";
            chart2.Titles.Add(title2);
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
            groupBox1.Location = new Point(62, 94);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(888, 148);
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
            label18.Location = new Point(654, 45);
            label18.Name = "label18";
            label18.Size = new Size(55, 28);
            label18.TabIndex = 26;
            label18.Text = "Gula";
            // 
            // KaloriLabel
            // 
            KaloriLabel.AutoSize = true;
            KaloriLabel.BackColor = Color.FromArgb(1, 54, 63);
            KaloriLabel.Font = new Font("Segoe UI", 13F);
            KaloriLabel.ForeColor = SystemColors.ControlLightLight;
            KaloriLabel.Location = new Point(803, 89);
            KaloriLabel.Name = "KaloriLabel";
            KaloriLabel.Size = new Size(49, 30);
            KaloriLabel.TabIndex = 33;
            KaloriLabel.Text = "112";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(1, 54, 63);
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(72, 47);
            label14.Name = "label14";
            label14.Size = new Size(73, 28);
            label14.TabIndex = 22;
            label14.Text = "Lemak";
            // 
            // GulaValLab
            // 
            GulaValLab.AutoSize = true;
            GulaValLab.BackColor = Color.FromArgb(1, 54, 63);
            GulaValLab.Font = new Font("Segoe UI", 13F);
            GulaValLab.ForeColor = SystemColors.ControlLightLight;
            GulaValLab.Location = new Point(674, 89);
            GulaValLab.Name = "GulaValLab";
            GulaValLab.Size = new Size(25, 30);
            GulaValLab.TabIndex = 32;
            GulaValLab.Text = "7";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(1, 54, 63);
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(210, 45);
            label15.Name = "label15";
            label15.Size = new Size(68, 28);
            label15.TabIndex = 23;
            label15.Text = "Karbo";
            // 
            // SeratValLabel
            // 
            SeratValLabel.AutoSize = true;
            SeratValLabel.BackColor = Color.FromArgb(1, 54, 63);
            SeratValLabel.Font = new Font("Segoe UI", 13F);
            SeratValLabel.ForeColor = SystemColors.ControlLightLight;
            SeratValLabel.Location = new Point(551, 89);
            SeratValLabel.Name = "SeratValLabel";
            SeratValLabel.Size = new Size(25, 30);
            SeratValLabel.TabIndex = 31;
            SeratValLabel.Text = "9";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(1, 54, 63);
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(362, 45);
            label16.Name = "label16";
            label16.Size = new Size(81, 28);
            label16.TabIndex = 24;
            label16.Text = "Protein";
            // 
            // ProteinValLabel
            // 
            ProteinValLabel.AutoSize = true;
            ProteinValLabel.BackColor = Color.FromArgb(1, 54, 63);
            ProteinValLabel.Font = new Font("Segoe UI", 13F);
            ProteinValLabel.ForeColor = SystemColors.ControlLightLight;
            ProteinValLabel.Location = new Point(384, 86);
            ProteinValLabel.Name = "ProteinValLabel";
            ProteinValLabel.Size = new Size(37, 30);
            ProteinValLabel.TabIndex = 30;
            ProteinValLabel.Text = "20";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(1, 54, 63);
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(532, 45);
            label17.Name = "label17";
            label17.Size = new Size(61, 28);
            label17.TabIndex = 25;
            label17.Text = "Serat";
            // 
            // KarboValLabel
            // 
            KarboValLabel.AutoSize = true;
            KarboValLabel.BackColor = Color.FromArgb(1, 54, 63);
            KarboValLabel.Font = new Font("Segoe UI", 13F);
            KarboValLabel.ForeColor = SystemColors.ControlLightLight;
            KarboValLabel.Location = new Point(227, 86);
            KarboValLabel.Name = "KarboValLabel";
            KarboValLabel.Size = new Size(37, 30);
            KarboValLabel.TabIndex = 29;
            KarboValLabel.Text = "30";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(1, 54, 63);
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(780, 45);
            label19.Name = "label19";
            label19.Size = new Size(73, 30);
            label19.TabIndex = 27;
            label19.Text = "Kalori";
            // 
            // LemakValLabel
            // 
            LemakValLabel.AutoSize = true;
            LemakValLabel.BackColor = Color.FromArgb(1, 54, 63);
            LemakValLabel.Font = new Font("Segoe UI", 13F);
            LemakValLabel.ForeColor = SystemColors.ControlLightLight;
            LemakValLabel.Location = new Point(90, 86);
            LemakValLabel.Name = "LemakValLabel";
            LemakValLabel.Size = new Size(37, 30);
            LemakValLabel.TabIndex = 28;
            LemakValLabel.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 268);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 37;
            label2.Text = "Kalori Minggu Ini";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(chart2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardControl";
            Size = new Size(997, 701);
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
