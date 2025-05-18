namespace NutriNyan.Views.Dashboard
{
    partial class SearchFoodForm
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
            cariMakananTabControl = new TabControl();
            cariMakanTabPage = new TabPage();
            label2 = new Label();
            searchButton = new Button();
            searchTextBox = new TextBox();
            panel1 = new Panel();
            rekomenFoodTabPage = new TabPage();
            label1 = new Label();
            cariMakananTabControl.SuspendLayout();
            cariMakanTabPage.SuspendLayout();
            rekomenFoodTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // cariMakananTabControl
            // 
            cariMakananTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cariMakananTabControl.Controls.Add(cariMakanTabPage);
            cariMakananTabControl.Controls.Add(rekomenFoodTabPage);
            cariMakananTabControl.Font = new Font("Segoe UI", 12F);
            cariMakananTabControl.Location = new Point(0, 0);
            cariMakananTabControl.Name = "cariMakananTabControl";
            cariMakananTabControl.SelectedIndex = 0;
            cariMakananTabControl.Size = new Size(833, 551);
            cariMakananTabControl.TabIndex = 0;
            // 
            // cariMakanTabPage
            // 
            cariMakanTabPage.BackColor = Color.FromArgb(17, 30, 29);
            cariMakanTabPage.Controls.Add(label2);
            cariMakanTabPage.Controls.Add(searchButton);
            cariMakanTabPage.Controls.Add(searchTextBox);
            cariMakanTabPage.Controls.Add(panel1);
            cariMakanTabPage.Location = new Point(4, 30);
            cariMakanTabPage.Name = "cariMakanTabPage";
            cariMakanTabPage.Padding = new Padding(3);
            cariMakanTabPage.Size = new Size(825, 517);
            cariMakanTabPage.TabIndex = 0;
            cariMakanTabPage.Text = "Cari Makanan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(1, 54, 63);
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(22, 22);
            label2.Name = "label2";
            label2.Size = new Size(234, 25);
            label2.TabIndex = 2;
            label2.Text = "Masukkan nama makanan";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(0, 221, 220);
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchButton.ForeColor = Color.FromArgb(1, 54, 63);
            searchButton.Location = new Point(680, 55);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(114, 36);
            searchButton.TabIndex = 1;
            searchButton.Text = "Cari";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButtonClicked;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 16F);
            searchTextBox.Location = new Point(22, 55);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(637, 36);
            searchTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(1, 54, 63);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 106);
            panel1.TabIndex = 3;
            // 
            // rekomenFoodTabPage
            // 
            rekomenFoodTabPage.BackColor = Color.FromArgb(17, 30, 29);
            rekomenFoodTabPage.Controls.Add(label1);
            rekomenFoodTabPage.Location = new Point(4, 30);
            rekomenFoodTabPage.Name = "rekomenFoodTabPage";
            rekomenFoodTabPage.Padding = new Padding(3);
            rekomenFoodTabPage.Size = new Size(825, 517);
            rekomenFoodTabPage.TabIndex = 1;
            rekomenFoodTabPage.Text = "Rekomendasi Makanan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 10, 0, 0);
            label1.Size = new Size(246, 38);
            label1.TabIndex = 0;
            label1.Text = "Rekomendasi Makanan";
            // 
            // SearchFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            ClientSize = new Size(832, 550);
            Controls.Add(cariMakananTabControl);
            Name = "SearchFoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cari Makanan";
            Load += SearchFoodForm_Load;
            cariMakananTabControl.ResumeLayout(false);
            cariMakanTabPage.ResumeLayout(false);
            cariMakanTabPage.PerformLayout();
            rekomenFoodTabPage.ResumeLayout(false);
            rekomenFoodTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl cariMakananTabControl;
        private TabPage cariMakanTabPage;
        private TabPage rekomenFoodTabPage;
        private Label label1;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label2;
        private Panel panel1;
    }
}