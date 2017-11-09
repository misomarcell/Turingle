using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    public abstract class ChatSite
    {
        protected WebBrowser webBrowser { get; set; }
        protected int receivedCount { get; set; }

        protected ChatSite(WebBrowser webBrowser)
        {
            this.webBrowser = webBrowser;
        }

        abstract public string GetChatURL();
        abstract public string GetPartnerLastMessage();
        abstract public void SendMessage(string message);
        abstract public void StartNewChat(Cleverbot bot);
        abstract public bool IsChatOver();
        abstract public int GetReceivedCount();

        protected List<HtmlElement> GetElementsByClassName(string tagName, string className)
        {
            HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName(tagName);

            var foundElements = new List<HtmlElement>();
            foreach (HtmlElement element in elements)
            {
                if (element.GetAttribute("ClassName") == className)
                {
                    foundElements.Add(element);
                }
            }
            return foundElements;
        }
    }
}
