namespace NutriNyan.Views.Dashboard
{
    partial class TrackingAirControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            trackingWaterTimePicker = new DateTimePicker();
            progressBar = new ProgressBar();
            label2 = new Label();
            maxWaterValue = new Label();
            changeTargetWaterButton = new FontAwesome.Sharp.IconButton();
            inputWaterButton = new FontAwesome.Sharp.IconButton();
            inputWaterBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            waterGridView = new DataGridView();
            daftarAirLabel = new Label();
            targetTercapailabel = new Label();
            totalAirLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)waterGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 0;
            label1.Text = "Tracking Air";
            // 
            // trackingWaterTimePicker
            // 
            trackingWaterTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackingWaterTimePicker.CalendarFont = new Font("Segoe UI", 12F);
            trackingWaterTimePicker.Font = new Font("Segoe UI", 14.5F);
            trackingWaterTimePicker.Location = new Point(539, 38);
            trackingWaterTimePicker.MaxDate = new DateTime(2025, 5, 19, 0, 0, 0, 0);
            trackingWaterTimePicker.Name = "trackingWaterTimePicker";
            trackingWaterTimePicker.Size = new Size(199, 33);
            trackingWaterTimePicker.TabIndex = 1;
            trackingWaterTimePicker.Value = new DateTime(2025, 5, 19, 0, 0, 0, 0);
            trackingWaterTimePicker.CloseUp += trackingWaterTimePicker_CloseUp;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.BackColor = Color.White;
            progressBar.Location = new Point(77, 140);
            progressBar.Maximum = 1000;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(661, 45);
            progressBar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(77, 197);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "0 ml";
            // 
            // maxWaterValue
            // 
            maxWaterValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxWaterValue.AutoSize = true;
            maxWaterValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            maxWaterValue.ForeColor = SystemColors.ControlLightLight;
            maxWaterValue.Location = new Point(660, 197);
            maxWaterValue.Name = "maxWaterValue";
            maxWaterValue.Size = new Size(78, 25);
            maxWaterValue.TabIndex = 4;
            maxWaterValue.Text = "2000 ml";
            // 
            // changeTargetWaterButton
            // 
            changeTargetWaterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            changeTargetWaterButton.BackColor = Color.FromArgb(0, 221, 220);
            changeTargetWaterButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            changeTargetWaterButton.IconChar = FontAwesome.Sharp.IconChar.None;
            changeTargetWaterButton.IconColor = Color.Black;
            changeTargetWaterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            changeTargetWaterButton.Location = new Point(371, 38);
            changeTargetWaterButton.Name = "changeTargetWaterButton";
            changeTargetWaterButton.Size = new Size(143, 33);
            changeTargetWaterButton.TabIndex = 5;
            changeTargetWaterButton.Text = "Ubah Target Air";
            changeTargetWaterButton.UseVisualStyleBackColor = false;
            changeTargetWaterButton.Click += changeTargetWaterButton_Click;
            // 
            // inputWaterButton
            // 
            inputWaterButton.BackColor = Color.FromArgb(0, 221, 220);
            inputWaterButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            inputWaterButton.IconChar = FontAwesome.Sharp.IconChar.None;
            inputWaterButton.IconColor = Color.Black;
            inputWaterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inputWaterButton.Location = new Point(261, 290);
            inputWaterButton.Name = "inputWaterButton";
            inputWaterButton.Size = new Size(98, 37);
            inputWaterButton.TabIndex = 6;
            inputWaterButton.Text = "Minum";
            inputWaterButton.UseVisualStyleBackColor = false;
            inputWaterButton.Click += inputWaterButton_Click;
            // 
            // inputWaterBox
            // 
            inputWaterBox.Font = new Font("Segoe UI", 16F);
            inputWaterBox.Location = new Point(78, 291);
            inputWaterBox.Name = "inputWaterBox";
            inputWaterBox.Size = new Size(117, 36);
            inputWaterBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(203, 298);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 8;
            label4.Text = "ml";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(75, 256);
            label5.Name = "label5";
            label5.Size = new Size(278, 21);
            label5.TabIndex = 9;
            label5.Text = "Masukkan air yang sudah diminum";
            // 
            // waterGridView
            // 
            waterGridView.AllowUserToAddRows = false;
            waterGridView.AllowUserToDeleteRows = false;
            waterGridView.AllowUserToResizeColumns = false;
            waterGridView.AllowUserToResizeRows = false;
            waterGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            waterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            waterGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            waterGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            waterGridView.Location = new Point(75, 398);
            waterGridView.Name = "waterGridView";
            waterGridView.Size = new Size(663, 150);
            waterGridView.TabIndex = 10;
            waterGridView.CellClick += waterGridView_CellClick;
            waterGridView.RowPostPaint += waterGridView_RowPostPaint;
            // 
            // daftarAirLabel
            // 
            daftarAirLabel.AutoSize = true;
            daftarAirLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            daftarAirLabel.ForeColor = SystemColors.ControlLightLight;
            daftarAirLabel.Location = new Point(75, 364);
            daftarAirLabel.Name = "daftarAirLabel";
            daftarAirLabel.Size = new Size(290, 21);
            daftarAirLabel.TabIndex = 11;
            daftarAirLabel.Text = "Daftar air yang diminum pada hari --";
            // 
            // targetTercapailabel
            // 
            targetTercapailabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetTercapailabel.AutoSize = true;
            targetTercapailabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            targetTercapailabel.ForeColor = SystemColors.ControlLightLight;
            targetTercapailabel.Location = new Point(353, 256);
            targetTercapailabel.Name = "targetTercapailabel";
            targetTercapailabel.Size = new Size(0, 21);
            targetTercapailabel.TabIndex = 12;
            // 
            // totalAirLabel
            // 
            totalAirLabel.AutoSize = true;
            totalAirLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalAirLabel.ForeColor = SystemColors.ControlLightLight;
            totalAirLabel.Location = new Point(77, 107);
            totalAirLabel.Name = "totalAirLabel";
            totalAirLabel.Size = new Size(154, 21);
            totalAirLabel.TabIndex = 13;
            totalAirLabel.Text = "Total air diminum :";
            // 
            // TrackingAirControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(totalAirLabel);
            Controls.Add(targetTercapailabel);
            Controls.Add(daftarAirLabel);
            Controls.Add(waterGridView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputWaterBox);
            Controls.Add(inputWaterButton);
            Controls.Add(changeTargetWaterButton);
            Controls.Add(maxWaterValue);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(trackingWaterTimePicker);
            Controls.Add(label1);
            Name = "TrackingAirControl";
            Size = new Size(832, 645);
            Load += TrackingAirControl_Load;
            ((System.ComponentModel.ISupportInitialize)waterGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker trackingWaterTimePicker;
        private ProgressBar progressBar;
        private Label label2;
        private Label maxWaterValue;
        private FontAwesome.Sharp.IconButton changeTargetWaterButton;
        private FontAwesome.Sharp.IconButton inputWaterButton;
        private TextBox inputWaterBox;
        private Label label4;
        private Label label5;
        private DataGridView waterGridView;
        private Label daftarAirLabel;
        private Label targetTercapailabel;
        private Label totalAirLabel;
    }
}
