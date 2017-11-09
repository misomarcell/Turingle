using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    class Site_7strangers : ChatSite
    {
        public Site_7strangers(WebBrowser webBrowser) : base(webBrowser) { }

        public override string GetChatURL()
        {
            return "http://7strangers.com/talk";
        }

        public override string GetPartnerLastMessage()
        {
           HtmlElementCollection messages = webBrowser.Document.GetElementsByTagName("div");

            HtmlElement lastMessageElement = null;
            string lastMessage = String.Empty;
            foreach (HtmlElement message in messages)
            {
                if (message.GetAttribute("className") == "youmsg stranger")
                {
                    lastMessageElement = message;
                    lastMessage = lastMessageElement.InnerText.Replace("Stranger:", "");
                }
                    
            }     

            return lastMessage;
        }

        public override bool IsChatOver()
        {
            HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName("div");
            foreach ( HtmlElement element in elements )
            {
                if (element.Id == "startNew")
                {
                    if (element.Style.ToString() == "display: block;")
                        return true;
                }    
            }
            return false;
        }

        public override void SendMessage(string message)
        {
            HtmlElement inputField = webBrowser.Document.GetElementById("chatmsg");
            HtmlElement sendButton = webBrowser.Document.GetElementById("sendbtn");

            if (inputField != null)
            {
                inputField.Focus();
                inputField.InnerText = message;
            }


            if (sendButton != null)
                sendButton.InvokeMember("Click");

            Debug.WriteLine("Message sent: " + message);
        }

        public override void StartNewChat(Cleverbot bot)
        {
            bot.NewConversation();
            webBrowser.Document.InvokeScript("startNewChat");
        }

        public override int GetReceivedCount()
        {
            HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName("div");

            receivedCount = 0;
            foreach (HtmlElement element in elements)
            {
                if (element.GetAttribute("ClassName") == "youmsg stranger")
                    receivedCount++;
            }

            Debug.WriteLine("Received: " + receivedCount);
            return receivedCount;
        }
    }
}
