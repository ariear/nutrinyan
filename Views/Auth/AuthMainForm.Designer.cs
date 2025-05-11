namespace NutriNyan.Views.Auth
{
    public partial class AuthMainForm
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
            components = new System.ComponentModel.Container();
            panelHiasan = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            panelAuth = new Panel();
            panelHiasan.SuspendLayout();
            SuspendLayout();
            // 
            // panelHiasan
            // 
            panelHiasan.BackColor = Color.FromArgb(1, 54, 63);
            panelHiasan.BackgroundImage = Properties.Resources.Group_1;
            panelHiasan.Controls.Add(label1);
            panelHiasan.Controls.Add(label2);
            panelHiasan.Controls.Add(label3);
            panelHiasan.Dock = DockStyle.Right;
            panelHiasan.Location = new Point(714, 0);
            panelHiasan.Margin = new Padding(3, 4, 3, 4);
            panelHiasan.Name = "panelHiasan";
            panelHiasan.Size = new Size(709, 935);
            panelHiasan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Bottom;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 580);
            label1.Name = "label1";
            label1.Padding = new Padding(29, 0, 0, 11);
            label1.Size = new Size(745, 73);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di NutriNyan !!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Bottom;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 715);
            label2.Name = "label2";
            label2.Padding = new Padding(29, 0, 0, 120);
            label2.Size = new Size(460, 161);
            label2.TabIndex = 1;
            label2.Text = "Mulai hidup sehatmu di sini!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Bottom;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 876);
            label3.Name = "label3";
            label3.Padding = new Padding(29, 0, 0, 27);
            label3.Size = new Size(348, 59);
            label3.TabIndex = 2;
            label3.Text = "By Kelompok 2 Kelas PBO D";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panelAuth
            // 
            panelAuth.BackColor = Color.FromArgb(17, 30, 29);
            panelAuth.Dock = DockStyle.Fill;
            panelAuth.Location = new Point(0, 0);
            panelAuth.Margin = new Padding(3, 4, 3, 4);
            panelAuth.Name = "panelAuth";
            panelAuth.Size = new Size(1423, 935);
            panelAuth.TabIndex = 3;
            // 
            // AuthMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 935);
            Controls.Add(panelHiasan);
            Controls.Add(panelAuth);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1441, 982);
            MinimumSize = new Size(1441, 982);
            Name = "AuthMainForm";
            Text = "AuthMainForm";
            Load += AuthMainForm_Load;
            panelHiasan.ResumeLayout(false);
            panelHiasan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHiasan;
        private Label label1;
        private Label label2;
        private Label label3;
        private ImageList imageList1;
        public Panel panelAuth;
    }
}