namespace NutriNyan.Views
{
    partial class ChangeTargetWaterForm
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
            title = new Label();
            watertextBox = new TextBox();
            label2 = new Label();
            ubahButton = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            title.ForeColor = SystemColors.ControlLightLight;
            title.Location = new Point(93, 49);
            title.Name = "title";
            title.Size = new Size(263, 25);
            title.TabIndex = 0;
            title.Text = "Ubah Target Air pada Hari ...";
            // 
            // watertextBox
            // 
            watertextBox.Font = new Font("Segoe UI", 16F);
            watertextBox.Location = new Point(95, 110);
            watertextBox.Name = "watertextBox";
            watertextBox.Size = new Size(371, 36);
            watertextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(476, 113);
            label2.Name = "label2";
            label2.Size = new Size(39, 30);
            label2.TabIndex = 2;
            label2.Text = "ml";
            // 
            // ubahButton
            // 
            ubahButton.BackColor = Color.FromArgb(0, 221, 220);
            ubahButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ubahButton.Location = new Point(95, 168);
            ubahButton.Name = "ubahButton";
            ubahButton.Size = new Size(420, 37);
            ubahButton.TabIndex = 3;
            ubahButton.Text = "Ubah";
            ubahButton.UseVisualStyleBackColor = false;
            ubahButton.Click += ubahButton_Click;
            // 
            // ChangeTargetWaterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            ClientSize = new Size(604, 297);
            Controls.Add(ubahButton);
            Controls.Add(label2);
            Controls.Add(watertextBox);
            Controls.Add(title);
            Name = "ChangeTargetWaterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeTargetWaterForm";
            Load += ChangeTargetWaterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox watertextBox;
        private Label label2;
        private Button ubahButton;
    }
}