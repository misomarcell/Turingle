using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    class Site_7strangers : ChatSite, IChatSite
    {
        public WebBrowser webBrowser { get; set; }

        public Site_7strangers(WebBrowser WebBrowser) : base(WebBrowser)
        {
            this.webBrowser = WebBrowser;
        }

        public string GetChatURL()
        {
            return "http://7strangers.com/talk";
        }

        public string GetPartnerLastMessage()
        {
            HtmlElementCollection messages = webBrowser.Document.GetElementsByTagName("div");


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

        public void SendMessage(string message)
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
