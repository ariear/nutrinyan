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
            label3 = new Label();
            label4 = new Label();
            unitSizeBox = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            periode = new Label();
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
            searchFoodButton.Location = new Point(33, 126);
            searchFoodButton.Name = "searchFoodButton";
            searchFoodButton.Padding = new Padding(5, 0, 5, 0);
            searchFoodButton.RightToLeft = RightToLeft.Yes;
            searchFoodButton.Size = new Size(179, 48);
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
            title.Location = new Point(33, 34);
            title.Name = "title";
            title.Size = new Size(490, 37);
            title.TabIndex = 1;
            title.Text = "Tambah Makanan yang Dikonsumsi";
            // 
            // foodNameBox
            // 
            foodNameBox.Font = new Font("Segoe UI", 14F);
            foodNameBox.Location = new Point(33, 240);
            foodNameBox.Name = "foodNameBox";
            foodNameBox.Size = new Size(334, 32);
            foodNameBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(33, 210);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 5;
            label3.Text = "Nama Makanan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(403, 210);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 7;
            label4.Text = "Satuan Penyajian";
            // 
            // unitSizeBox
            // 
            unitSizeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSizeBox.Font = new Font("Segoe UI", 13F);
            unitSizeBox.FormattingEnabled = true;
            unitSizeBox.Location = new Point(403, 241);
            unitSizeBox.Name = "unitSizeBox";
            unitSizeBox.Size = new Size(193, 31);
            unitSizeBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(627, 208);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 9;
            label5.Text = "Ukuran Penyajian";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(629, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 32);
            textBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(33, 299);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 12;
            label6.Text = "Lemak (gram)";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(33, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 32);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(299, 299);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 14;
            label7.Text = "Protein (gram)";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(299, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 32);
            textBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(563, 299);
            label8.Name = "label8";
            label8.Size = new Size(157, 21);
            label8.TabIndex = 16;
            label8.Text = "Karbohidrat (gram)";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(563, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 32);
            textBox4.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(563, 382);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 22;
            label9.Text = "Kalori ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(563, 412);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(239, 32);
            textBox5.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(299, 382);
            label10.Name = "label10";
            label10.Size = new Size(101, 21);
            label10.TabIndex = 20;
            label10.Text = "Gula (gram)";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14F);
            textBox6.Location = new Point(299, 412);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(239, 32);
            textBox6.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(33, 382);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 18;
            label11.Text = "Serat (gram)";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14F);
            textBox7.Location = new Point(33, 412);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(239, 32);
            textBox7.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 221, 220);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(1, 54, 63);
            button1.Location = new Point(33, 478);
            button1.Name = "button1";
            button1.Size = new Size(769, 42);
            button1.TabIndex = 23;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            // 
            // periode
            // 
            periode.AutoSize = true;
            periode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            periode.ForeColor = SystemColors.ControlLightLight;
            periode.Location = new Point(506, 137);
            periode.Name = "periode";
            periode.Size = new Size(154, 25);
            periode.TabIndex = 24;
            periode.Text = "Periode Makan : ";
            // 
            // AddGiziControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(periode);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(unitSizeBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(foodNameBox);
            Controls.Add(title);
            Controls.Add(searchFoodButton);
            Name = "AddGiziControl";
            Size = new Size(961, 614);
            Load += AddGiziControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton searchFoodButton;
        private Label title;
        private TextBox foodNameBox;
        private Label label3;
        private Label label4;
        private ComboBox unitSizeBox;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Button button1;
        private Label periode;
    }
}
