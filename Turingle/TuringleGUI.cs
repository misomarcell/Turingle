using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;


namespace Turingle
{
    public partial class TuringleGUI : Form
    {

        Cleverbot cleverBot;
        ChatSite chatSite;
        int receivedCount = 0;

        public TuringleGUI()
        {
            InitializeComponent();
            siteSelector.SelectedIndex = 0;
            Cleverbot.BotCreated += Bot_BotCreated;

            Timer timer = new Timer() { Interval = 3000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (chatSite.IsChatOver())
            {
                chatSite.StartNewChat(cleverBot);
                receivedCount = 0;
            }

            if (!checkBox1.Checked)
                return;
            int temp_receivedCount = chatSite.GetReceivedCount();
            if (temp_receivedCount != receivedCount)
            {
                receivedCount = temp_receivedCount;
                SendAutoMessage();
            }
        }

        private void Bot_BotCreated()
        {
            buttonSend.Enabled = true;
            buttonTestBot.Enabled = true;
        }

        private void TuringleGUI_Load(object sender, EventArgs e)
        {
            switch (siteSelector.Text)
            {
                case "7strangers.com":
                    chatSite = new Site_7strangers(webBrowser1);
                    break;
                default:
                    break;
            }

            webBrowser1.Navigate(chatSite.GetChatURL());
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendAutoMessage();
        }

        private void SendAutoMessage()
        {
            string message = chatSite.GetPartnerLastMessage();
            string response = cleverBot.GetResponse(message);

            CID.Text = cleverBot.convID;

            chatSite.SendMessage(response);
        }

        private void buttonTestBot_Click(object sender, EventArgs e)
        {
            textBox2.Text = cleverBot.GetResponse(textBox3.Text);
        }

        private void buttonTestSite_Click(object sender, EventArgs e)
        {
            chatSite.SendMessage(textBox4.Text);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            cleverBot = new Cleverbot(apiKey.Text);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cleverbot.com/api/howto/");
        }

        private void buttonNewConv_Click(object sender, EventArgs e)
        {
            cleverBot.NewConversation();
        }

        private void buttonStartNew_Click(object sender, EventArgs e)
        {
            chatSite.StartNewChat(cleverBot);
        }
    }
}
