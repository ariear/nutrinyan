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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 99D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 169D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 187D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 154D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 225D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 112D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            label18 = new Label();
            label20 = new Label();
            label14 = new Label();
            label21 = new Label();
            label15 = new Label();
            label22 = new Label();
            label16 = new Label();
            label23 = new Label();
            label17 = new Label();
            label24 = new Label();
            label19 = new Label();
            label25 = new Label();
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
            label1.Location = new Point(77, 42);
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
            chart2.Location = new Point(77, 387);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
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
            groupBox1.Location = new Point(77, 117);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1110, 182);
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
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(1, 54, 63);
            label20.Font = new Font("Segoe UI", 13F);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(1004, 111);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(57, 36);
            label20.TabIndex = 33;
            label20.Text = "112";
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
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(1, 54, 63);
            label21.Font = new Font("Segoe UI", 13F);
            label21.ForeColor = SystemColors.ControlLightLight;
            label21.Location = new Point(842, 111);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(29, 36);
            label21.TabIndex = 32;
            label21.Text = "7";
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
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(1, 54, 63);
            label22.Font = new Font("Segoe UI", 13F);
            label22.ForeColor = SystemColors.ControlLightLight;
            label22.Location = new Point(689, 111);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(29, 36);
            label22.TabIndex = 31;
            label22.Text = "9";
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
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(1, 54, 63);
            label23.Font = new Font("Segoe UI", 13F);
            label23.ForeColor = SystemColors.ControlLightLight;
            label23.Location = new Point(480, 108);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(43, 36);
            label23.TabIndex = 30;
            label23.Text = "20";
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
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(1, 54, 63);
            label24.Font = new Font("Segoe UI", 13F);
            label24.ForeColor = SystemColors.ControlLightLight;
            label24.Location = new Point(284, 108);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(43, 36);
            label24.TabIndex = 29;
            label24.Text = "30";
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
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(1, 54, 63);
            label25.Font = new Font("Segoe UI", 13F);
            label25.ForeColor = SystemColors.ControlLightLight;
            label25.Location = new Point(112, 108);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(43, 36);
            label25.TabIndex = 28;
            label25.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(77, 335);
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
        private Label label20;
        private Label label14;
        private Label label21;
        private Label label15;
        private Label label22;
        private Label label16;
        private Label label23;
        private Label label17;
        private Label label24;
        private Label label19;
        private Label label25;
        private Label label2;
    }
}
