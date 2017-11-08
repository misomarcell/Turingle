using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;


namespace Turingle
{
    public partial class Form1 : Form
    {

        Bot Cleverbot;

        public Form1()
        {
            InitializeComponent();
            Bot.BotCreated += Bot_BotCreated;
        }

        private void Bot_BotCreated()
        {
            buttonSend.Enabled = true;
            buttonTestBot.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://7strangers.com/talk");
            //webBrowser1.Navigate("file:///C:/Users/Marcell/Desktop/test.html");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // throw new NotImplementedException();
        }



        private void SendMessage(string message)
        {
            HtmlElement inputField = webBrowser1.Document.GetElementById("chatmsg");
            HtmlElement sendButton = webBrowser1.Document.GetElementById("sendbtn");

            if (inputField != null)
            {
                inputField.Focus();
                inputField.InnerText = message;
            }


            if (sendButton != null)
                sendButton.InvokeMember("Click");

            Debug.WriteLine("Message sent: " + message);
        }

        private string GetPartnerLstMessage()
        {
            HtmlElementCollection messages = webBrowser1.Document.GetElementsByTagName("div");


            HtmlElement last = null;
            foreach (HtmlElement message in messages)
            {
                if (message.GetAttribute("className") == "youmsg stranger")
                    last = message;
            }

            string lastMessage = last.InnerText.Replace("Stranger:", "");
            Debug.WriteLine("Last response: " + lastMessage);

            return lastMessage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = GetPartnerLstMessage();

            string response = Cleverbot.GetResponse(message);

            SendMessage(response);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Cleverbot.GetResponse(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cleverbot = new Bot(apiKey.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.cleverbot.com/api/howto/");
        }
    }
}
