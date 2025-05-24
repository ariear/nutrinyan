namespace NutriNyan.Views.Dashboard
{
    partial class SettingControl
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
            label1 = new Label();
            label2 = new Label();
            label15 = new Label();
            label3 = new Label();
            label4 = new Label();
            NamaBox = new TextBox();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            JKbox = new ComboBox();
            TGLlahirdates = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            TingkatAktivitas = new ComboBox();
            TargetTujuan = new ComboBox();
            TB = new TextBox();
            BB = new TextBox();
            TargetAir = new TextBox();
            label11 = new Label();
            label12 = new Label();
            PWlamaBox = new TextBox();
            PWbaruBox = new TextBox();
            PerbaruiButton = new Button();
            PerbaruiPasswordButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(68, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(68, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 1;
            label2.Text = "Pengaturan";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(68, 105);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(81, 32);
            label15.TabIndex = 24;
            label15.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(369, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 25;
            label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(687, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 26;
            label4.Text = "Tgl Lahir";
            label4.Click += label4_Click;
            // 
            // NamaBox
            // 
            NamaBox.Location = new Point(68, 154);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(258, 31);
            NamaBox.TabIndex = 27;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // JKbox
            // 
            JKbox.FormattingEnabled = true;
            JKbox.Location = new Point(371, 154);
            JKbox.Name = "JKbox";
            JKbox.Size = new Size(273, 33);
            JKbox.TabIndex = 28;
            JKbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TGLlahirdates
            // 
            TGLlahirdates.Location = new Point(687, 154);
            TGLlahirdates.Name = "TGLlahirdates";
            TGLlahirdates.Size = new Size(300, 31);
            TGLlahirdates.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(66, 214);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 32);
            label5.TabIndex = 30;
            label5.Text = "TB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(369, 214);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 31;
            label6.Text = "BB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(687, 214);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(210, 32);
            label7.TabIndex = 32;
            label7.Text = "Target Air Harian";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(66, 309);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(202, 32);
            label8.TabIndex = 33;
            label8.Text = "Tingkat Aktifitas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(369, 309);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 32);
            label9.TabIndex = 34;
            label9.Text = "Target Tujuan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(68, 557);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(226, 32);
            label10.TabIndex = 36;
            label10.Text = "Perbarui Password";
            label10.Click += label10_Click;
            // 
            // TingkatAktivitas
            // 
            TingkatAktivitas.FormattingEnabled = true;
            TingkatAktivitas.Location = new Point(66, 359);
            TingkatAktivitas.Name = "TingkatAktivitas";
            TingkatAktivitas.Size = new Size(258, 33);
            TingkatAktivitas.TabIndex = 37;
            // 
            // TargetTujuan
            // 
            TargetTujuan.FormattingEnabled = true;
            TargetTujuan.Location = new Point(369, 359);
            TargetTujuan.Name = "TargetTujuan";
            TargetTujuan.Size = new Size(273, 33);
            TargetTujuan.TabIndex = 38;
            // 
            // TB
            // 
            TB.Location = new Point(66, 259);
            TB.Name = "TB";
            TB.Size = new Size(258, 31);
            TB.TabIndex = 39;
            // 
            // BB
            // 
            BB.Location = new Point(369, 259);
            BB.Name = "BB";
            BB.Size = new Size(273, 31);
            BB.TabIndex = 40;
            // 
            // TargetAir
            // 
            TargetAir.Location = new Point(685, 259);
            TargetAir.Name = "TargetAir";
            TargetAir.Size = new Size(300, 31);
            TargetAir.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(68, 606);
            label11.Name = "label11";
            label11.Size = new Size(134, 25);
            label11.TabIndex = 42;
            label11.Text = "Password Lama";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(68, 692);
            label12.Name = "label12";
            label12.Size = new Size(127, 25);
            label12.TabIndex = 43;
            label12.Text = "Password Baru";
            // 
            // PWlamaBox
            // 
            PWlamaBox.Location = new Point(68, 643);
            PWlamaBox.Name = "PWlamaBox";
            PWlamaBox.Size = new Size(726, 31);
            PWlamaBox.TabIndex = 44;
            // 
            // PWbaruBox
            // 
            PWbaruBox.Location = new Point(68, 729);
            PWbaruBox.Name = "PWbaruBox";
            PWbaruBox.Size = new Size(726, 31);
            PWbaruBox.TabIndex = 45;
            // 
            // PerbaruiButton
            // 
            PerbaruiButton.BackColor = Color.FromArgb(0, 221, 220);
            PerbaruiButton.FlatStyle = FlatStyle.Flat;
            PerbaruiButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PerbaruiButton.ForeColor = Color.FromArgb(1, 54, 63);
            PerbaruiButton.Location = new Point(710, 458);
            PerbaruiButton.Margin = new Padding(4, 5, 4, 5);
            PerbaruiButton.Name = "PerbaruiButton";
            PerbaruiButton.Size = new Size(259, 51);
            PerbaruiButton.TabIndex = 47;
            PerbaruiButton.Text = "Perbarui";
            PerbaruiButton.UseVisualStyleBackColor = false;
            // 
            // PerbaruiPasswordButton
            // 
            PerbaruiPasswordButton.BackColor = Color.FromArgb(0, 221, 220);
            PerbaruiPasswordButton.FlatStyle = FlatStyle.Flat;
            PerbaruiPasswordButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PerbaruiPasswordButton.ForeColor = Color.FromArgb(1, 54, 63);
            PerbaruiPasswordButton.Location = new Point(535, 800);
            PerbaruiPasswordButton.Margin = new Padding(4, 5, 4, 5);
            PerbaruiPasswordButton.Name = "PerbaruiPasswordButton";
            PerbaruiPasswordButton.Size = new Size(259, 51);
            PerbaruiPasswordButton.TabIndex = 48;
            PerbaruiPasswordButton.Text = "Perbarui";
            PerbaruiPasswordButton.UseVisualStyleBackColor = false;
            // 
            // SettingControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(PerbaruiPasswordButton);
            Controls.Add(PerbaruiButton);
            Controls.Add(PWbaruBox);
            Controls.Add(PWlamaBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(TargetAir);
            Controls.Add(BB);
            Controls.Add(TB);
            Controls.Add(TargetTujuan);
            Controls.Add(TingkatAktivitas);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TGLlahirdates);
            Controls.Add(JKbox);
            Controls.Add(NamaBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label15);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SettingControl";
            Size = new Size(1029, 896);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label15;
        private Label label3;
        private Label label4;
        private TextBox NamaBox;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ComboBox JKbox;
        private DateTimePicker TGLlahirdates;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox TingkatAktivitas;
        private ComboBox TargetTujuan;
        private TextBox TB;
        private TextBox BB;
        private TextBox TargetAir;
        private Label label11;
        private Label label12;
        private TextBox PWlamaBox;
        private TextBox PWbaruBox;
        private Button PerbaruiButton;
        private Button PerbaruiPasswordButton;
    }
}
