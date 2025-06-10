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
            FoodNameValLabel = new Label();
            kaloriPanel = new Panel();
            kaloriValLab = new Label();
            TotalWeightPanel.SuspendLayout();
            panel1.SuspendLayout();
            kaloriPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(38, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 46);
            label1.TabIndex = 0;
            label1.Text = "Edit Makanan";
            // 
            // TotalWeightPanel
            // 
            TotalWeightPanel.BackColor = Color.White;
            TotalWeightPanel.Controls.Add(TWPanelLabel);
            TotalWeightPanel.ForeColor = SystemColors.ActiveCaptionText;
            TotalWeightPanel.Location = new Point(643, 540);
            TotalWeightPanel.Name = "TotalWeightPanel";
            TotalWeightPanel.RightToLeft = RightToLeft.No;
            TotalWeightPanel.Size = new Size(274, 45);
            TotalWeightPanel.TabIndex = 49;
            // 
            // TWPanelLabel
            // 
            TWPanelLabel.AutoSize = true;
            TWPanelLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TWPanelLabel.Location = new Point(0, 9);
            TWPanelLabel.Name = "TWPanelLabel";
            TWPanelLabel.Size = new Size(86, 31);
            TWPanelLabel.TabIndex = 0;
            TWPanelLabel.Text = "0 gram";
            // 
            // TotalWeightLabel
            // 
            TotalWeightLabel.AutoSize = true;
            TotalWeightLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalWeightLabel.ForeColor = SystemColors.ControlLightLight;
            TotalWeightLabel.Location = new Point(481, 549);
            TotalWeightLabel.Name = "TotalWeightLabel";
            TotalWeightLabel.Size = new Size(136, 31);
            TotalWeightLabel.TabIndex = 48;
            TotalWeightLabel.Text = "Total Berat:";
            // 
            // periode
            // 
            periode.AutoSize = true;
            periode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            periode.ForeColor = SystemColors.ControlLightLight;
            periode.Location = new Point(579, 112);
            periode.Name = "periode";
            periode.Size = new Size(186, 30);
            periode.TabIndex = 47;
            periode.Text = "Periode Makan : ";
            // 
            // SaveFoodButton
            // 
            SaveFoodButton.BackColor = Color.FromArgb(0, 221, 220);
            SaveFoodButton.FlatStyle = FlatStyle.Flat;
            SaveFoodButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SaveFoodButton.ForeColor = Color.FromArgb(1, 54, 63);
            SaveFoodButton.Location = new Point(40, 613);
            SaveFoodButton.Margin = new Padding(3, 4, 3, 4);
            SaveFoodButton.Name = "SaveFoodButton";
            SaveFoodButton.Size = new Size(879, 56);
            SaveFoodButton.TabIndex = 46;
            SaveFoodButton.Text = "Simpan";
            SaveFoodButton.UseVisualStyleBackColor = false;
            SaveFoodButton.Click += SaveFoodButton_Clicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(645, 438);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 45;
            label9.Text = "Kalori ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(344, 438);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 43;
            label10.Text = "Gula (gram)";
            // 
            // GulaTextBox
            // 
            GulaTextBox.Font = new Font("Segoe UI", 14F);
            GulaTextBox.Location = new Point(344, 478);
            GulaTextBox.Margin = new Padding(3, 4, 3, 4);
            GulaTextBox.Name = "GulaTextBox";
            GulaTextBox.Size = new Size(273, 39);
            GulaTextBox.TabIndex = 42;
            GulaTextBox.Text = "0";
            GulaTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(40, 438);
            label11.Name = "label11";
            label11.Size = new Size(130, 28);
            label11.TabIndex = 41;
            label11.Text = "Serat (gram)";
            // 
            // SeratTextBox
            // 
            SeratTextBox.Font = new Font("Segoe UI", 14F);
            SeratTextBox.Location = new Point(40, 478);
            SeratTextBox.Margin = new Padding(3, 4, 3, 4);
            SeratTextBox.Name = "SeratTextBox";
            SeratTextBox.Size = new Size(273, 39);
            SeratTextBox.TabIndex = 40;
            SeratTextBox.Text = "0";
            SeratTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(645, 328);
            label8.Name = "label8";
            label8.Size = new Size(194, 28);
            label8.TabIndex = 39;
            label8.Text = "Karbohidrat (gram)";
            // 
            // KarbTextBox
            // 
            KarbTextBox.Font = new Font("Segoe UI", 14F);
            KarbTextBox.Location = new Point(645, 368);
            KarbTextBox.Margin = new Padding(3, 4, 3, 4);
            KarbTextBox.Name = "KarbTextBox";
            KarbTextBox.Size = new Size(273, 39);
            KarbTextBox.TabIndex = 38;
            KarbTextBox.Text = "0";
            KarbTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(344, 328);
            label7.Name = "label7";
            label7.Size = new Size(150, 28);
            label7.TabIndex = 37;
            label7.Text = "Protein (gram)";
            // 
            // ProtTextBox
            // 
            ProtTextBox.Font = new Font("Segoe UI", 14F);
            ProtTextBox.Location = new Point(344, 368);
            ProtTextBox.Margin = new Padding(3, 4, 3, 4);
            ProtTextBox.Name = "ProtTextBox";
            ProtTextBox.Size = new Size(273, 39);
            ProtTextBox.TabIndex = 36;
            ProtTextBox.Text = "0";
            ProtTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(40, 328);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 35;
            label6.Text = "Lemak (gram)";
            // 
            // LemakTextBox
            // 
            LemakTextBox.Font = new Font("Segoe UI", 14F);
            LemakTextBox.Location = new Point(40, 368);
            LemakTextBox.Margin = new Padding(3, 4, 3, 4);
            LemakTextBox.Name = "LemakTextBox";
            LemakTextBox.Size = new Size(273, 39);
            LemakTextBox.TabIndex = 34;
            LemakTextBox.Text = "0";
            LemakTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // UnitValueBox
            // 
            UnitValueBox.Font = new Font("Segoe UI", 14F);
            UnitValueBox.Location = new Point(721, 259);
            UnitValueBox.Margin = new Padding(3, 4, 3, 4);
            UnitValueBox.Name = "UnitValueBox";
            UnitValueBox.Size = new Size(197, 39);
            UnitValueBox.TabIndex = 33;
            UnitValueBox.Text = "0";
            UnitValueBox.TextChanged += FloatTextBoxhanged;
            UnitValueBox.TextChanged += UnitValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(718, 217);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 32;
            label5.Text = "Ukuran Penyajian";
            // 
            // unitSizeComboBox
            // 
            unitSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSizeComboBox.Font = new Font("Segoe UI", 13F);
            unitSizeComboBox.FormattingEnabled = true;
            unitSizeComboBox.Location = new Point(462, 261);
            unitSizeComboBox.Margin = new Padding(3, 4, 3, 4);
            unitSizeComboBox.Name = "unitSizeComboBox";
            unitSizeComboBox.Size = new Size(220, 38);
            unitSizeComboBox.TabIndex = 31;
            unitSizeComboBox.SelectionChangeCommitted += UnitChanged;
            // 
            // UnitLab
            // 
            UnitLab.AutoSize = true;
            UnitLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UnitLab.ForeColor = SystemColors.ControlLightLight;
            UnitLab.Location = new Point(462, 220);
            UnitLab.Name = "UnitLab";
            UnitLab.Size = new Size(174, 28);
            UnitLab.TabIndex = 30;
            UnitLab.Text = "Satuan Penyajian";
            // 
            // foodNameLab
            // 
            foodNameLab.AutoSize = true;
            foodNameLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            foodNameLab.ForeColor = SystemColors.ControlLightLight;
            foodNameLab.Location = new Point(40, 220);
            foodNameLab.Name = "foodNameLab";
            foodNameLab.Size = new Size(161, 28);
            foodNameLab.TabIndex = 29;
            foodNameLab.Text = "Nama Makanan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FoodNameValLabel);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(40, 259);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(384, 36);
            panel1.TabIndex = 50;
            // 
            // FoodNameValLabel
            // 
            FoodNameValLabel.AutoSize = true;
            FoodNameValLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodNameValLabel.ForeColor = SystemColors.ActiveCaptionText;
            FoodNameValLabel.Location = new Point(-2, 2);
            FoodNameValLabel.Name = "FoodNameValLabel";
            FoodNameValLabel.Size = new Size(179, 31);
            FoodNameValLabel.TabIndex = 0;
            FoodNameValLabel.Text = "Bakso uget uget";
            // 
            // kaloriPanel
            // 
            kaloriPanel.BackColor = Color.White;
            kaloriPanel.Controls.Add(kaloriValLab);
            kaloriPanel.ForeColor = SystemColors.ActiveCaptionText;
            kaloriPanel.Location = new Point(645, 478);
            kaloriPanel.Name = "kaloriPanel";
            kaloriPanel.RightToLeft = RightToLeft.No;
            kaloriPanel.Size = new Size(274, 39);
            kaloriPanel.TabIndex = 51;
            // 
            // kaloriValLab
            // 
            kaloriValLab.AutoSize = true;
            kaloriValLab.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kaloriValLab.Location = new Point(1, 4);
            kaloriValLab.Name = "kaloriValLab";
            kaloriValLab.Size = new Size(72, 31);
            kaloriValLab.TabIndex = 0;
            kaloriValLab.Text = "0 kkal";
            // 
            // EditMakanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(kaloriPanel);
            Controls.Add(panel1);
            Controls.Add(TotalWeightPanel);
            Controls.Add(TotalWeightLabel);
            Controls.Add(periode);
            Controls.Add(SaveFoodButton);
            Controls.Add(label9);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "EditMakanan";
            Size = new Size(951, 814);
            Load += EditMakanan_Load;
            TotalWeightPanel.ResumeLayout(false);
            TotalWeightPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            kaloriPanel.ResumeLayout(false);
            kaloriPanel.PerformLayout();
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
        private Label FoodNameValLabel;
        private Panel kaloriPanel;
        private Label kaloriValLab;
    }
}