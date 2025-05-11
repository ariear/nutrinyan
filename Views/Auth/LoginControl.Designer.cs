namespace NutriNyan.Views.Auth
{
    partial class LoginControl
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
            button1 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            WrongLogin = new Label();
            SuspendLayout();
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Segoe UI", 10F);
            linkToRegister.LinkColor = Color.White;
            linkToRegister.Location = new Point(51, 567);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(160, 23);
            linkToRegister.TabIndex = 15;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Belum punya akun?";
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 221, 220);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(17, 30, 29);
            button1.Location = new Point(515, 541);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 51);
            button1.TabIndex = 14;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Clicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 221, 220);
            label7.Location = new Point(53, 428);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(53, 460);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(573, 41);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 221, 220);
            label6.Location = new Point(53, 329);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 11;
            label6.Text = "Nama";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(51, 361);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 41);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(231, 173);
            label4.Name = "label4";
            label4.Size = new Size(234, 41);
            label4.TabIndex = 8;
            label4.Text = "Masuk ke Akun";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(129, 211);
            label5.Name = "label5";
            label5.Size = new Size(431, 99);
            label5.TabIndex = 9;
            label5.Text = "Nikmati fitur-fitur NutriNyan dengan memasukkan akun terlebih dahulu";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WrongLogin
            // 
            WrongLogin.AutoSize = true;
            WrongLogin.Font = new Font("Segoe UI", 12F);
            WrongLogin.ForeColor = Color.Red;
            WrongLogin.Location = new Point(263, 301);
            WrongLogin.Name = "WrongLogin";
            WrongLogin.Size = new Size(154, 28);
            WrongLogin.TabIndex = 16;
            WrongLogin.Text = "GAGAL MASUK!";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(WrongLogin);
            Controls.Add(linkToRegister);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginControl";
            Size = new Size(680, 709);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkToRegister;
        private Button button1;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label WrongLogin;
    }
}
