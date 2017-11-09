using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    class Site_Shamchat : ChatSite
    {
        public Site_Shamchat(WebBrowser webBrowser) : base(webBrowser) { }

        public override string GetChatURL()
        {
            return "http://www.shamchat.com/";
        }

        public override string GetPartnerLastMessage()
        {
            List<HtmlElement> elements = GetElementsByClassName("div", "remoteuser");
            HtmlElement lastDiv = elements[elements.Count - 1];

            if(lastDiv != null)
            {
                foreach(HtmlElement child in lastDiv.Children)
                {
                    if (child.GetAttribute("className") == "messagespan")
                    {
                        return child.InnerText;
                    }
                }
            }

            return String.Empty;
        }

        public override int GetReceivedCount()
        {
            return GetElementsByClassName("div", "remoteuser").Count;
        }

        public override bool IsChatOver()
        {
            if (GetElementsByClassName("img", "savethisshamimg").Count > 0)
                return true;

            return false;       
        }

        public override void SendMessage(string message)
        {
            GetElementsByClassName("textarea", "message")[0].InnerText = message;
            GetElementsByClassName("img", "sendbuttonimg")[0].InvokeMember("Click");
        }

        public override void StartNewChat(Cleverbot bot)
        {
            bot.NewConversation();
            Debug.WriteLine("Starting new chat...");

            List<HtmlElement> leaveButtonElements = GetElementsByClassName("img", "leavebuttonimg");
            if( leaveButtonElements.Count > 0 )
            {
                leaveButtonElements[0].InvokeMember("Click");
            }               

            List<HtmlElement> startNewChatElements = GetElementsByClassName("img", "startanewchatimg");
            if (startNewChatElements.Count > 0 )
                startNewChatElements[0].InvokeMember("Click");
        }

    }
}
