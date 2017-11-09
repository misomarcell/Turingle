using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;


namespace Turingle
{
    public partial class TuringleGUI : Form
    {

        Cleverbot bot;
        ChatSite chatSite;

        public TuringleGUI()
        {
            InitializeComponent();
            siteSelector.SelectedIndex = 0;
            Cleverbot.BotCreated += Bot_BotCreated;
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
            string message = chatSite.GetPartnerLastMessage();
            string response = bot.GetResponse(message);

            CID.Text = bot.convID;

            chatSite.SendMessage(response);
        }

        private void buttonTestBot_Click(object sender, EventArgs e)
        {
            textBox2.Text = bot.GetResponse(textBox3.Text);
        }

        private void buttonTestSite_Click(object sender, EventArgs e)
        {
            chatSite.SendMessage(textBox4.Text);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bot = new Cleverbot(apiKey.Text);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cleverbot.com/api/howto/");
        }

        private void buttonNewConv_Click(object sender, EventArgs e)
        {
            bot.NewConversation();
        }
    }
}
