using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriNyan.Models.Enums;
using NutriNyan.Models;
using System.Windows.Forms.Design;

namespace NutriNyan.Views.Dashboard
{
    public partial class KonsultasiControl : UserControl
    {
        User user = Database.userLogged.user;
        private readonly ChatController _chatController;

        public KonsultasiControl()
        {
            InitializeComponent();
            _chatController = new ChatController();
            SetupChatPanel();
            LoadChatHistory();
        }

        private void SetupChatPanel()
        {
            chatPanel.AutoScroll = true;
            chatPanel.FlowDirection = FlowDirection.TopDown;
            chatPanel.WrapContents = false;
            chatPanel.AutoSize = false;
            chatPanel.AutoScrollMinSize = new Size(0, 0);
        }

        private void LoadChatHistory()
        {
            chatPanel.Controls.Clear();
            var chats = ChatController.GetChatHistory(user.Id);

            if (chats != null && chats.Count > 0)
            { 
                foreach (var chat in chats)
                {
                    AddMessageToChat(chat.Message, chat.Sender == SenderType.User);
                }
                ScrollToBottom();
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageBox.Text))
            {
                return;
            }

            var userMessage = messageBox.Text;

            DateTime birthDate = user.DateBirth;
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            var prompt = $"- Jenis kelamin : {user.Gender.Type}\r\n- Usia : {age} tahun\r\n- Tinggi badan : {user.Tb}\r\n- Berat badan : {user.Bb}\r\n- Tingkat aktivitas fisik : {user.TingkatAktivitas}\r\n- Tujuan : {user.Purpose.Title}\r\n\r\nPertanyaan : {userMessage}";
            messageBox.Clear();

            AddMessageToChat(userMessage, true);
            ChatController.SaveChatMessage(user.Id, SenderType.User, userMessage);

            var aiResponse = await _chatController.GetAIResponseAsync(prompt);

            AddMessageToChat(aiResponse, false);
            ChatController.SaveChatMessage(user.Id, SenderType.Bot, aiResponse);
        }

        private void AddMessageToChat(string message, bool isUserMessage)
        {
            var bubble = new Panel
            {
                AutoSize = true,
                MaximumSize = new Size((int)(chatPanel.Width * 0.8), 0),
                Padding = new Padding(10),
                Margin = new Padding(5, 5, 5, 15),
                BackColor = isUserMessage ? Color.LightBlue : Color.LightGray,
                Anchor = isUserMessage ? AnchorStyles.Right : AnchorStyles.Left
            };

            var label = new Label
            {
                AutoSize = true,
                Text = message,
                MaximumSize = new Size((int)(chatPanel.Width * 0.8) - 20, 0),
                Font = new Font("Segoe UI", 10),
                Dock = DockStyle.Fill,
            };

            bubble.Controls.Add(label);
            chatPanel.Controls.Add(bubble);

            bubble.PerformLayout();
            label.PerformLayout();
            chatPanel.PerformLayout();

            ScrollToBottom();
        }

        private void ScrollToBottom()
        {
            if (chatPanel.Controls.Count > 0)
            { 
                chatPanel.ScrollControlIntoView(chatPanel.Controls[chatPanel.Controls.Count - 1]);
            }
        }

        private void chatPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in chatPanel.Controls)
            {
                if (control is Panel bubble)
                {
                    bubble.MaximumSize = new Size((int)(chatPanel.Width * 0.8), 0);
                    foreach (Control c in bubble.Controls)
                    {
                        if (c is Label label)
                        {
                            label.MaximumSize = new Size((int)(chatPanel.Width * 0.8) - 20, 0);
                        }
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin membersihkan percakapan?", "Konfirmasi Hapus Percakapan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ChatController.DeleteChatByUserId(user.Id);
                MessageBox.Show("Berhasil membersihkan percakapan!!");
                chatPanel.Controls.Clear();
            }
        }
    }
}
