using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    interface IChatSite
    {
        WebBrowser webBrowser { get; set; }


        string GetChatURL();
        string GetPartnerLastMessage();
        void SendMessage(string message);
    }
}
