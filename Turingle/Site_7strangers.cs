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
            List<HtmlElement> elements = GetElementsByClassName("div", "youmsg stranger");
            if ( elements.Count > 0 )
                return elements[elements.Count - 1].InnerText.Replace("Stranger:", "");

            return String.Empty;
        }

        public override bool IsChatOver()
        {
            HtmlElement element = webBrowser.Document.GetElementById("startNew");
            if (element == null)
                return false;
            if (element.Style.ToString() == "display: block;")
                return true;

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
            return GetElementsByClassName("div", "youmsg stranger").Count;
        }
    }
}
