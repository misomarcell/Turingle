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

        protected ChatSite(WebBrowser webBrowser)
        {
            this.webBrowser = webBrowser;
        }

        abstract public string GetChatURL();
        abstract public string GetPartnerLastMessage();
        abstract public void SendMessage(string message);
    }
}
