namespace NutriNyan.Views.Dashboard
{
    partial class KonsultasiControl
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
            messageBox = new TextBox();
            sendButton = new Button();
            chatPanel = new FlowLayoutPanel();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "Konsultasi Gizi";
            // 
            // messageBox
            // 
            messageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageBox.Font = new Font("Segoe UI", 14F);
            messageBox.Location = new Point(158, 552);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(411, 32);
            messageBox.TabIndex = 1;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.BackColor = Color.FromArgb(0, 221, 220);
            sendButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sendButton.Location = new Point(591, 552);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(89, 32);
            sendButton.TabIndex = 2;
            sendButton.Text = "Kirim";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // chatPanel
            // 
            chatPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.White;
            chatPanel.FlowDirection = FlowDirection.TopDown;
            chatPanel.Location = new Point(49, 94);
            chatPanel.Name = "chatPanel";
            chatPanel.Padding = new Padding(20);
            chatPanel.Size = new Size(747, 431);
            chatPanel.TabIndex = 3;
            chatPanel.WrapContents = false;
            chatPanel.SizeChanged += chatPanel_SizeChanged;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.BackColor = Color.FromArgb(255, 99, 99);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            clearButton.ForeColor = SystemColors.ControlLightLight;
            clearButton.Location = new Point(661, 33);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(135, 38);
            clearButton.TabIndex = 4;
            clearButton.Text = "Bersihkan Chat";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // KonsultasiControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 29);
            Controls.Add(clearButton);
            Controls.Add(chatPanel);
            Controls.Add(sendButton);
            Controls.Add(messageBox);
            Controls.Add(label1);
            Name = "KonsultasiControl";
            Size = new Size(941, 666);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox messageBox;
        private Button sendButton;
        private FlowLayoutPanel chatPanel;
        private Button clearButton;
    }
}
