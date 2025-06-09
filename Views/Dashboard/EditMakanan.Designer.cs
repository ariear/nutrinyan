namespace NutriNyan.Views.Dashboard
{
    partial class EditMakanan
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
            label1 = new Label();
            TotalWeightPanel = new Panel();
            TWPanelLabel = new Label();
            TotalWeightLabel = new Label();
            periode = new Label();
            SaveFoodButton = new Button();
            label9 = new Label();
            KaloriTextBox = new TextBox();
            label10 = new Label();
            GulaTextBox = new TextBox();
            label11 = new Label();
            SeratTextBox = new TextBox();
            label8 = new Label();
            KarbTextBox = new TextBox();
            label7 = new Label();
            ProtTextBox = new TextBox();
            label6 = new Label();
            LemakTextBox = new TextBox();
            UnitValueBox = new TextBox();
            label5 = new Label();
            unitSizeComboBox = new ComboBox();
            UnitLab = new Label();
            foodNameLab = new Label();
            panel1 = new Panel();
            FoodNameLabel = new Label();
            TotalWeightPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(299, 55);
            label1.TabIndex = 0;
            label1.Text = "Edit Makanan";
            label1.Click += label1_Click;
            // 
            // TotalWeightPanel
            // 
            TotalWeightPanel.BackColor = Color.White;
            TotalWeightPanel.Controls.Add(TWPanelLabel);
            TotalWeightPanel.ForeColor = SystemColors.ActiveCaptionText;
            TotalWeightPanel.Location = new Point(804, 675);
            TotalWeightPanel.Margin = new Padding(4);
            TotalWeightPanel.Name = "TotalWeightPanel";
            TotalWeightPanel.RightToLeft = RightToLeft.No;
            TotalWeightPanel.Size = new Size(342, 56);
            TotalWeightPanel.TabIndex = 49;
            // 
            // TWPanelLabel
            // 
            TWPanelLabel.AutoSize = true;
            TWPanelLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TWPanelLabel.Location = new Point(0, 11);
            TWPanelLabel.Margin = new Padding(4, 0, 4, 0);
            TWPanelLabel.Name = "TWPanelLabel";
            TWPanelLabel.Size = new Size(101, 37);
            TWPanelLabel.TabIndex = 0;
            TWPanelLabel.Text = "0 gram";
            // 
            // TotalWeightLabel
            // 
            TotalWeightLabel.AutoSize = true;
            TotalWeightLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalWeightLabel.ForeColor = SystemColors.ControlLightLight;
            TotalWeightLabel.Location = new Point(601, 686);
            TotalWeightLabel.Margin = new Padding(4, 0, 4, 0);
            TotalWeightLabel.Name = "TotalWeightLabel";
            TotalWeightLabel.Size = new Size(167, 38);
            TotalWeightLabel.TabIndex = 48;
            TotalWeightLabel.Text = "Total Berat:";
            // 
            // periode
            // 
            periode.AutoSize = true;
            periode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            periode.ForeColor = SystemColors.ControlLightLight;
            periode.Location = new Point(724, 140);
            periode.Margin = new Padding(4, 0, 4, 0);
            periode.Name = "periode";
            periode.Size = new Size(219, 36);
            periode.TabIndex = 47;
            periode.Text = "Periode Makan : ";
            // 
            // SaveFoodButton
            // 
            SaveFoodButton.BackColor = Color.FromArgb(0, 221, 220);
            SaveFoodButton.FlatStyle = FlatStyle.Flat;
            SaveFoodButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SaveFoodButton.ForeColor = Color.FromArgb(1, 54, 63);
            SaveFoodButton.Location = new Point(50, 766);
            SaveFoodButton.Margin = new Padding(4, 5, 4, 5);
            SaveFoodButton.Name = "SaveFoodButton";
            SaveFoodButton.Size = new Size(1099, 70);
            SaveFoodButton.TabIndex = 46;
            SaveFoodButton.Text = "Tambah";
            SaveFoodButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(806, 547);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 32);
            label9.TabIndex = 45;
            label9.Text = "Kalori ";
            // 
            // KaloriTextBox
            // 
            KaloriTextBox.Font = new Font("Segoe UI", 14F);
            KaloriTextBox.Location = new Point(806, 597);
            KaloriTextBox.Margin = new Padding(4, 5, 4, 5);
            KaloriTextBox.Name = "KaloriTextBox";
            KaloriTextBox.Size = new Size(340, 45);
            KaloriTextBox.TabIndex = 44;
            KaloriTextBox.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(430, 547);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(151, 32);
            label10.TabIndex = 43;
            label10.Text = "Gula (gram)";
            // 
            // GulaTextBox
            // 
            GulaTextBox.Font = new Font("Segoe UI", 14F);
            GulaTextBox.Location = new Point(430, 597);
            GulaTextBox.Margin = new Padding(4, 5, 4, 5);
            GulaTextBox.Name = "GulaTextBox";
            GulaTextBox.Size = new Size(340, 45);
            GulaTextBox.TabIndex = 42;
            GulaTextBox.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(50, 547);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(157, 32);
            label11.TabIndex = 41;
            label11.Text = "Serat (gram)";
            // 
            // SeratTextBox
            // 
            SeratTextBox.Font = new Font("Segoe UI", 14F);
            SeratTextBox.Location = new Point(50, 597);
            SeratTextBox.Margin = new Padding(4, 5, 4, 5);
            SeratTextBox.Name = "SeratTextBox";
            SeratTextBox.Size = new Size(340, 45);
            SeratTextBox.TabIndex = 40;
            SeratTextBox.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(806, 410);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(236, 32);
            label8.TabIndex = 39;
            label8.Text = "Karbohidrat (gram)";
            // 
            // KarbTextBox
            // 
            KarbTextBox.Font = new Font("Segoe UI", 14F);
            KarbTextBox.Location = new Point(806, 460);
            KarbTextBox.Margin = new Padding(4, 5, 4, 5);
            KarbTextBox.Name = "KarbTextBox";
            KarbTextBox.Size = new Size(340, 45);
            KarbTextBox.TabIndex = 38;
            KarbTextBox.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(430, 410);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 32);
            label7.TabIndex = 37;
            label7.Text = "Protein (gram)";
            // 
            // ProtTextBox
            // 
            ProtTextBox.Font = new Font("Segoe UI", 14F);
            ProtTextBox.Location = new Point(430, 460);
            ProtTextBox.Margin = new Padding(4, 5, 4, 5);
            ProtTextBox.Name = "ProtTextBox";
            ProtTextBox.Size = new Size(340, 45);
            ProtTextBox.TabIndex = 36;
            ProtTextBox.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(50, 410);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 32);
            label6.TabIndex = 35;
            label6.Text = "Lemak (gram)";
            // 
            // LemakTextBox
            // 
            LemakTextBox.Font = new Font("Segoe UI", 14F);
            LemakTextBox.Location = new Point(50, 460);
            LemakTextBox.Margin = new Padding(4, 5, 4, 5);
            LemakTextBox.Name = "LemakTextBox";
            LemakTextBox.Size = new Size(340, 45);
            LemakTextBox.TabIndex = 34;
            LemakTextBox.Text = "0";
            // 
            // UnitValueBox
            // 
            UnitValueBox.Font = new Font("Segoe UI", 14F);
            UnitValueBox.Location = new Point(901, 324);
            UnitValueBox.Margin = new Padding(4, 5, 4, 5);
            UnitValueBox.Name = "UnitValueBox";
            UnitValueBox.Size = new Size(245, 45);
            UnitValueBox.TabIndex = 33;
            UnitValueBox.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(898, 271);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 32;
            label5.Text = "Ukuran Penyajian";
            // 
            // unitSizeComboBox
            // 
            unitSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSizeComboBox.Font = new Font("Segoe UI", 13F);
            unitSizeComboBox.FormattingEnabled = true;
            unitSizeComboBox.Location = new Point(578, 326);
            unitSizeComboBox.Margin = new Padding(4, 5, 4, 5);
            unitSizeComboBox.Name = "unitSizeComboBox";
            unitSizeComboBox.Size = new Size(274, 44);
            unitSizeComboBox.TabIndex = 31;
            // 
            // UnitLab
            // 
            UnitLab.AutoSize = true;
            UnitLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UnitLab.ForeColor = SystemColors.ControlLightLight;
            UnitLab.Location = new Point(578, 275);
            UnitLab.Margin = new Padding(4, 0, 4, 0);
            UnitLab.Name = "UnitLab";
            UnitLab.Size = new Size(209, 32);
            UnitLab.TabIndex = 30;
            UnitLab.Text = "Satuan Penyajian";
            // 
            // foodNameLab
            // 
            foodNameLab.AutoSize = true;
            foodNameLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            foodNameLab.ForeColor = SystemColors.ControlLightLight;
            foodNameLab.Location = new Point(50, 275);
            foodNameLab.Margin = new Padding(4, 0, 4, 0);
            foodNameLab.Name = "foodNameLab";
            foodNameLab.Size = new Size(193, 32);
            foodNameLab.TabIndex = 29;
            foodNameLab.Text = "Nama Makanan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FoodNameLabel);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(50, 324);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(480, 45);
            panel1.TabIndex = 50;
            // 
            // FoodNameLabel
            // 
            FoodNameLabel.AutoSize = true;
            FoodNameLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            FoodNameLabel.Location = new Point(-2, 2);
            FoodNameLabel.Margin = new Padding(4, 0, 4, 0);
            FoodNameLabel.Name = "FoodNameLabel";
            FoodNameLabel.Size = new Size(208, 37);
            FoodNameLabel.TabIndex = 0;
            FoodNameLabel.Text = "Bakso uget uget";
            // 
            // EditMakanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            ClientSize = new Size(1189, 1018);
            Controls.Add(panel1);
            Controls.Add(TotalWeightPanel);
            Controls.Add(TotalWeightLabel);
            Controls.Add(periode);
            Controls.Add(SaveFoodButton);
            Controls.Add(label9);
            Controls.Add(KaloriTextBox);
            Controls.Add(label10);
            Controls.Add(GulaTextBox);
            Controls.Add(label11);
            Controls.Add(SeratTextBox);
            Controls.Add(label8);
            Controls.Add(KarbTextBox);
            Controls.Add(label7);
            Controls.Add(ProtTextBox);
            Controls.Add(label6);
            Controls.Add(LemakTextBox);
            Controls.Add(UnitValueBox);
            Controls.Add(label5);
            Controls.Add(unitSizeComboBox);
            Controls.Add(UnitLab);
            Controls.Add(foodNameLab);
            Controls.Add(label1);
            Name = "EditMakanan";
            Load += EditMakanan_Load;
            TotalWeightPanel.ResumeLayout(false);
            TotalWeightPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel TotalWeightPanel;
        private Label TWPanelLabel;
        private Label TotalWeightLabel;
        private Label periode;
        private Button SaveFoodButton;
        private Label label9;
        private TextBox KaloriTextBox;
        private Label label10;
        private TextBox GulaTextBox;
        private Label label11;
        private TextBox SeratTextBox;
        private Label label8;
        private TextBox KarbTextBox;
        private Label label7;
        private TextBox ProtTextBox;
        private Label label6;
        private TextBox LemakTextBox;
        private TextBox UnitValueBox;
        private Label label5;
        private ComboBox unitSizeComboBox;
        private Label UnitLab;
        private Label foodNameLab;
        private Panel panel1;
        private Label FoodNameLabel;
    }
}