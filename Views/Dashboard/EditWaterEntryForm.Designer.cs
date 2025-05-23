namespace NutriNyan.Views.Dashboard
{
    partial class EditWaterEntryForm
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
            airMlTextBox = new TextBox();
            label2 = new Label();
            jamTimePicker = new DateTimePicker();
            label3 = new Label();
            editButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(243, 33);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Ubah Data Air";
            // 
            // airMlTextBox
            // 
            airMlTextBox.Font = new Font("Segoe UI", 13F);
            airMlTextBox.Location = new Point(63, 117);
            airMlTextBox.Name = "airMlTextBox";
            airMlTextBox.Size = new Size(228, 31);
            airMlTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(63, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 2;
            label2.Text = "Air (ml)";
            // 
            // jamTimePicker
            // 
            jamTimePicker.Font = new Font("Segoe UI", 13F);
            jamTimePicker.Location = new Point(335, 117);
            jamTimePicker.Name = "jamTimePicker";
            jamTimePicker.Size = new Size(200, 31);
            jamTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(335, 90);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 4;
            label3.Text = "Jam";
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(0, 221, 220);
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editButton.Location = new Point(433, 178);
            editButton.Name = "editButton";
            editButton.Size = new Size(102, 40);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // EditWaterEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            ClientSize = new Size(658, 314);
            Controls.Add(editButton);
            Controls.Add(label3);
            Controls.Add(jamTimePicker);
            Controls.Add(label2);
            Controls.Add(airMlTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(674, 353);
            MinimumSize = new Size(674, 353);
            Name = "EditWaterEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditWaterEntryForm";
            Load += EditWaterEntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox airMlTextBox;
        private Label label2;
        private DateTimePicker jamTimePicker;
        private Label label3;
        private Button editButton;
    }
}