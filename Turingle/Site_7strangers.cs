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
    }
}
