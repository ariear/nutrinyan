namespace NutriNyan.Views.Dashboard
{
    partial class AddGiziControl
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
            searchFoodButton = new FontAwesome.Sharp.IconButton();
            title = new Label();
            foodNameBox = new TextBox();
            foodNameLab = new Label();
            UnitLab = new Label();
            unitSizeComboBox = new ComboBox();
            label5 = new Label();
            UnitValueBox = new TextBox();
            label6 = new Label();
            LemakTextBox = new TextBox();
            label7 = new Label();
            ProtTextBox = new TextBox();
            label8 = new Label();
            KarbTextBox = new TextBox();
            label9 = new Label();
            KaloriTextBox = new TextBox();
            label10 = new Label();
            GulaTextBox = new TextBox();
            label11 = new Label();
            SeratTextBox = new TextBox();
            SaveFoodButton = new Button();
            periode = new Label();
            TotalWeightLabel = new Label();
            TotalWeightPanel = new Panel();
            TWPanelLabel = new Label();
            TotalWeightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchFoodButton
            // 
            searchFoodButton.BackColor = Color.FromArgb(0, 221, 220);
            searchFoodButton.BackgroundImageLayout = ImageLayout.None;
            searchFoodButton.FlatStyle = FlatStyle.Flat;
            searchFoodButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchFoodButton.ForeColor = Color.FromArgb(1, 54, 63);
            searchFoodButton.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            searchFoodButton.IconColor = Color.FromArgb(1, 54, 63);
            searchFoodButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchFoodButton.IconSize = 40;
            searchFoodButton.ImageAlign = ContentAlignment.MiddleRight;
            searchFoodButton.Location = new Point(38, 168);
            searchFoodButton.Margin = new Padding(3, 4, 3, 4);
            searchFoodButton.Name = "searchFoodButton";
            searchFoodButton.Padding = new Padding(6, 0, 6, 0);
            searchFoodButton.RightToLeft = RightToLeft.Yes;
            searchFoodButton.Size = new Size(205, 64);
            searchFoodButton.TabIndex = 0;
            searchFoodButton.Text = "Cari Makanan";
            searchFoodButton.TextAlign = ContentAlignment.MiddleLeft;
            searchFoodButton.UseVisualStyleBackColor = false;
            searchFoodButton.Click += searchFoodButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ControlLight;
            title.Location = new Point(38, 45);
            title.Name = "title";
            title.Size = new Size(611, 46);
            title.TabIndex = 1;
            title.Text = "Tambah Makanan yang Dikonsumsi";
            // 
            // foodNameBox
            // 
            foodNameBox.Font = new Font("Segoe UI", 14F);
            foodNameBox.Location = new Point(38, 320);
            foodNameBox.Margin = new Padding(3, 4, 3, 4);
            foodNameBox.Name = "foodNameBox";
            foodNameBox.Size = new Size(381, 39);
            foodNameBox.TabIndex = 4;
            // 
            // foodNameLab
            // 
            foodNameLab.AutoSize = true;
            foodNameLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            foodNameLab.ForeColor = SystemColors.ControlLightLight;
            foodNameLab.Location = new Point(38, 280);
            foodNameLab.Name = "foodNameLab";
            foodNameLab.Size = new Size(161, 28);
            foodNameLab.TabIndex = 5;
            foodNameLab.Text = "Nama Makanan";
            // 
            // UnitLab
            // 
            UnitLab.AutoSize = true;
            UnitLab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UnitLab.ForeColor = SystemColors.ControlLightLight;
            UnitLab.Location = new Point(461, 280);
            UnitLab.Name = "UnitLab";
            UnitLab.Size = new Size(174, 28);
            UnitLab.TabIndex = 7;
            UnitLab.Text = "Satuan Penyajian";
            // 
            // unitSizeComboBox
            // 
            unitSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSizeComboBox.Font = new Font("Segoe UI", 13F);
            unitSizeComboBox.FormattingEnabled = true;
            unitSizeComboBox.Location = new Point(461, 321);
            unitSizeComboBox.Margin = new Padding(3, 4, 3, 4);
            unitSizeComboBox.Name = "unitSizeComboBox";
            unitSizeComboBox.Size = new Size(220, 38);
            unitSizeComboBox.TabIndex = 8;
            unitSizeComboBox.SelectionChangeCommitted += UnitChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(717, 277);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 9;
            label5.Text = "Ukuran Penyajian";
            // 
            // UnitValueBox
            // 
            UnitValueBox.Font = new Font("Segoe UI", 14F);
            UnitValueBox.Location = new Point(719, 319);
            UnitValueBox.Margin = new Padding(3, 4, 3, 4);
            UnitValueBox.Name = "UnitValueBox";
            UnitValueBox.Size = new Size(197, 39);
            UnitValueBox.TabIndex = 10;
            UnitValueBox.Text = "0";
            UnitValueBox.TextChanged += FloatTextBoxhanged;
            UnitValueBox.TextChanged += UnitValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(38, 399);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 12;
            label6.Text = "Lemak (gram)";
            // 
            // LemakTextBox
            // 
            LemakTextBox.Font = new Font("Segoe UI", 14F);
            LemakTextBox.Location = new Point(38, 439);
            LemakTextBox.Margin = new Padding(3, 4, 3, 4);
            LemakTextBox.Name = "LemakTextBox";
            LemakTextBox.Size = new Size(273, 39);
            LemakTextBox.TabIndex = 11;
            LemakTextBox.Text = "0";
            LemakTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(342, 399);
            label7.Name = "label7";
            label7.Size = new Size(150, 28);
            label7.TabIndex = 14;
            label7.Text = "Protein (gram)";
            // 
            // ProtTextBox
            // 
            ProtTextBox.Font = new Font("Segoe UI", 14F);
            ProtTextBox.Location = new Point(342, 439);
            ProtTextBox.Margin = new Padding(3, 4, 3, 4);
            ProtTextBox.Name = "ProtTextBox";
            ProtTextBox.Size = new Size(273, 39);
            ProtTextBox.TabIndex = 13;
            ProtTextBox.Text = "0";
            ProtTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(643, 399);
            label8.Name = "label8";
            label8.Size = new Size(194, 28);
            label8.TabIndex = 16;
            label8.Text = "Karbohidrat (gram)";
            // 
            // KarbTextBox
            // 
            KarbTextBox.Font = new Font("Segoe UI", 14F);
            KarbTextBox.Location = new Point(643, 439);
            KarbTextBox.Margin = new Padding(3, 4, 3, 4);
            KarbTextBox.Name = "KarbTextBox";
            KarbTextBox.Size = new Size(273, 39);
            KarbTextBox.TabIndex = 15;
            KarbTextBox.Text = "0";
            KarbTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(643, 509);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 22;
            label9.Text = "Kalori ";
            // 
            // KaloriTextBox
            // 
            KaloriTextBox.Font = new Font("Segoe UI", 14F);
            KaloriTextBox.Location = new Point(643, 549);
            KaloriTextBox.Margin = new Padding(3, 4, 3, 4);
            KaloriTextBox.Name = "KaloriTextBox";
            KaloriTextBox.Size = new Size(273, 39);
            KaloriTextBox.TabIndex = 21;
            KaloriTextBox.Text = "0";
            KaloriTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(342, 509);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 20;
            label10.Text = "Gula (gram)";
            // 
            // GulaTextBox
            // 
            GulaTextBox.Font = new Font("Segoe UI", 14F);
            GulaTextBox.Location = new Point(342, 549);
            GulaTextBox.Margin = new Padding(3, 4, 3, 4);
            GulaTextBox.Name = "GulaTextBox";
            GulaTextBox.Size = new Size(273, 39);
            GulaTextBox.TabIndex = 19;
            GulaTextBox.Text = "0";
            GulaTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(38, 509);
            label11.Name = "label11";
            label11.Size = new Size(130, 28);
            label11.TabIndex = 18;
            label11.Text = "Serat (gram)";
            // 
            // SeratTextBox
            // 
            SeratTextBox.Font = new Font("Segoe UI", 14F);
            SeratTextBox.Location = new Point(38, 549);
            SeratTextBox.Margin = new Padding(3, 4, 3, 4);
            SeratTextBox.Name = "SeratTextBox";
            SeratTextBox.Size = new Size(273, 39);
            SeratTextBox.TabIndex = 17;
            SeratTextBox.Text = "0";
            SeratTextBox.TextChanged += FloatTextBoxhanged;
            // 
            // SaveFoodButton
            // 
            SaveFoodButton.BackColor = Color.FromArgb(0, 221, 220);
            SaveFoodButton.FlatStyle = FlatStyle.Flat;
            SaveFoodButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SaveFoodButton.ForeColor = Color.FromArgb(1, 54, 63);
            SaveFoodButton.Location = new Point(38, 684);
            SaveFoodButton.Margin = new Padding(3, 4, 3, 4);
            SaveFoodButton.Name = "SaveFoodButton";
            SaveFoodButton.Size = new Size(879, 56);
            SaveFoodButton.TabIndex = 23;
            SaveFoodButton.Text = "Tambah";
            SaveFoodButton.UseVisualStyleBackColor = false;
            SaveFoodButton.Click += SaveFoodButtonClicked;
            // 
            // periode
            // 
            periode.AutoSize = true;
            periode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            periode.ForeColor = SystemColors.ControlLightLight;
            periode.Location = new Point(578, 183);
            periode.Name = "periode";
            periode.Size = new Size(186, 30);
            periode.TabIndex = 24;
            periode.Text = "Periode Makan : ";
            // 
            // TotalWeightLabel
            // 
            TotalWeightLabel.AutoSize = true;
            TotalWeightLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalWeightLabel.ForeColor = SystemColors.ControlLightLight;
            TotalWeightLabel.Location = new Point(479, 620);
            TotalWeightLabel.Name = "TotalWeightLabel";
            TotalWeightLabel.Size = new Size(136, 31);
            TotalWeightLabel.TabIndex = 25;
            TotalWeightLabel.Text = "Total Berat:";
            // 
            // TotalWeightPanel
            // 
            TotalWeightPanel.BackColor = Color.White;
            TotalWeightPanel.Controls.Add(TWPanelLabel);
            TotalWeightPanel.ForeColor = SystemColors.ActiveCaptionText;
            TotalWeightPanel.Location = new Point(642, 611);
            TotalWeightPanel.Name = "TotalWeightPanel";
            TotalWeightPanel.RightToLeft = RightToLeft.No;
            TotalWeightPanel.Size = new Size(274, 45);
            TotalWeightPanel.TabIndex = 26;
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
            // AddGiziControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
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
            Controls.Add(foodNameBox);
            Controls.Add(title);
            Controls.Add(searchFoodButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddGiziControl";
            Size = new Size(1098, 819);
            Load += AddGiziControl_Load;
            TotalWeightPanel.ResumeLayout(false);
            TotalWeightPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton searchFoodButton;
        private Label title;
        private TextBox foodNameBox;
        private Label foodNameLab;
        private Label UnitLab;
        private ComboBox unitSizeComboBox;
        private Label label5;
        private TextBox UnitValueBox;
        private Label label6;
        private TextBox LemakTextBox;
        private Label label7;
        private TextBox ProtTextBox;
        private Label label8;
        private TextBox KarbTextBox;
        private Label label9;
        private TextBox KaloriTextBox;
        private Label label10;
        private TextBox GulaTextBox;
        private Label label11;
        private TextBox SeratTextBox;
        private Button SaveFoodButton;
        private Label periode;
        private Label TotalWeightLabel;
        private Panel TotalWeightPanel;
        private Label TWPanelLabel;
    }
}
