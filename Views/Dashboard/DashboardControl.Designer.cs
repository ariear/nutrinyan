namespace NutriNyan.Views.Dashboard
{
    partial class DashboardControl
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
            foodName = new TextBox();
            foodSearchLab = new Label();
            ResultLab = new Label();
            searchBut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(179, 113);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 0;
            label1.Text = "Ini Dashboard";
            // 
            // foodName
            // 
            foodName.Location = new Point(190, 202);
            foodName.MaxLength = 40;
            foodName.Name = "foodName";
            foodName.Size = new Size(232, 27);
            foodName.TabIndex = 1;
            // 
            // foodSearchLab
            // 
            foodSearchLab.AutoSize = true;
            foodSearchLab.BackColor = Color.Transparent;
            foodSearchLab.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodSearchLab.ForeColor = SystemColors.ControlLightLight;
            foodSearchLab.Location = new Point(190, 168);
            foodSearchLab.Name = "foodSearchLab";
            foodSearchLab.Size = new Size(139, 31);
            foodSearchLab.TabIndex = 2;
            foodSearchLab.Text = "Search Food";
            // 
            // ResultLab
            // 
            ResultLab.AutoSize = true;
            ResultLab.BackColor = Color.Transparent;
            ResultLab.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLab.ForeColor = SystemColors.ControlLightLight;
            ResultLab.Location = new Point(190, 262);
            ResultLab.Name = "ResultLab";
            ResultLab.Size = new Size(55, 23);
            ResultLab.TabIndex = 3;
            ResultLab.Text = "label2";
            // 
            // searchBut
            // 
            searchBut.BackColor = SystemColors.HotTrack;
            searchBut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBut.ForeColor = SystemColors.ControlLightLight;
            searchBut.Location = new Point(439, 202);
            searchBut.Name = "searchBut";
            searchBut.Size = new Size(69, 29);
            searchBut.TabIndex = 4;
            searchBut.Text = "search";
            searchBut.UseVisualStyleBackColor = false;
            searchBut.Click += button1_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBut);
            Controls.Add(ResultLab);
            Controls.Add(foodSearchLab);
            Controls.Add(foodName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardControl";
            Size = new Size(678, 517);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox foodName;
        private Label foodSearchLab;
        private Label ResultLab;
        private Button searchBut;
    }
}
