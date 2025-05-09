namespace NutriNyan.Views.Auth
{
    partial class RegisterControl
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
            linkToRegister = new LinkLabel();
            buttonRegister = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            jkBox = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            aktivitasBox = new ComboBox();
            targetBox = new ComboBox();
            SuspendLayout();
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Segoe UI", 10F);
            linkToRegister.LinkColor = Color.White;
            linkToRegister.Location = new Point(40, 595);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(129, 19);
            linkToRegister.TabIndex = 23;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Sudah punya akun?";
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(0, 221, 220);
            buttonRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.FromArgb(17, 30, 29);
            buttonRegister.Location = new Point(446, 576);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(96, 38);
            buttonRegister.TabIndex = 22;
            buttonRegister.Text = "Buat";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 221, 220);
            label7.Location = new Point(40, 258);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 21;
            label7.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(40, 282);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(502, 34);
            textBox2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 221, 220);
            label6.Location = new Point(40, 184);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 19;
            label6.Text = "Nama";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(39, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(502, 34);
            textBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(231, 67);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 16;
            label4.Text = "Buat Akun";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(107, 95);
            label5.Name = "label5";
            label5.Size = new Size(377, 74);
            label5.TabIndex = 17;
            label5.Text = "Sudah waktunya membuat akunmu dan nikmati manfaatnya!!";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 221, 220);
            label1.Location = new Point(40, 411);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 25;
            label1.Text = "Tinggi Badan";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(40, 435);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(242, 34);
            textBox3.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 221, 220);
            label2.Location = new Point(300, 411);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 27;
            label2.Text = "Berat Badan";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(300, 435);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(242, 34);
            textBox4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 221, 220);
            label3.Location = new Point(299, 336);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 31;
            label3.Text = "Tgl Lahir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 221, 220);
            label8.Location = new Point(39, 336);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 29;
            label8.Text = "Jenis Kelamin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F);
            dateTimePicker1.Location = new Point(299, 361);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 31);
            dateTimePicker1.TabIndex = 32;
            // 
            // jkBox
            // 
            jkBox.DropDownStyle = ComboBoxStyle.DropDownList;
            jkBox.Font = new Font("Segoe UI", 13F);
            jkBox.FormattingEnabled = true;
            jkBox.Location = new Point(41, 361);
            jkBox.Name = "jkBox";
            jkBox.Size = new Size(241, 31);
            jkBox.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 221, 220);
            label9.Location = new Point(299, 491);
            label9.Name = "label9";
            label9.Size = new Size(107, 21);
            label9.TabIndex = 37;
            label9.Text = "Target Tujuan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 221, 220);
            label10.Location = new Point(39, 491);
            label10.Name = "label10";
            label10.Size = new Size(130, 21);
            label10.TabIndex = 35;
            label10.Text = "Tingkat Aktivitas";
            // 
            // aktivitasBox
            // 
            aktivitasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            aktivitasBox.Font = new Font("Segoe UI", 13F);
            aktivitasBox.FormattingEnabled = true;
            aktivitasBox.Location = new Point(39, 519);
            aktivitasBox.Name = "aktivitasBox";
            aktivitasBox.Size = new Size(242, 31);
            aktivitasBox.TabIndex = 38;
            // 
            // targetBox
            // 
            targetBox.DropDownStyle = ComboBoxStyle.DropDownList;
            targetBox.Font = new Font("Segoe UI", 13F);
            targetBox.FormattingEnabled = true;
            targetBox.Location = new Point(299, 519);
            targetBox.Name = "targetBox";
            targetBox.Size = new Size(242, 31);
            targetBox.TabIndex = 39;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(targetBox);
            Controls.Add(aktivitasBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(jkBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(linkToRegister);
            Controls.Add(buttonRegister);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "RegisterControl";
            Size = new Size(580, 676);
            Load += RegisterControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkToRegister;
        private Button buttonRegister;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ComboBox jkBox;
        private Label label9;
        private Label label10;
        private ComboBox aktivitasBox;
        private ComboBox targetBox;
    }
}
