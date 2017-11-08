using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turingle
{
    public delegate void BotCreatedEventHandler();
    public delegate void BotConversationChanger();
    public class Cleverbot
    {
        public string convID { get; set; }
        public string apiKey { get; set; }

        public static event BotCreatedEventHandler BotCreated;
        public event BotConversationChanger ConversationChanged;

        public Cleverbot(string apiKey)
        {
            this.apiKey = apiKey;
            BotCreated.Invoke();
        }

        public string GetResponse(string input)
        {
            string request = String.Format("http://www.cleverbot.com/getreply?key={0}&input={1}&cs={2}", apiKey, input, convID);
            Debug.WriteLine("Bot Request: " + request);

            string json;
            try
            {              
                json = new WebClient().DownloadString(request);
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't receive response from bot.\n\n" + e.Message);
                return null;
            }

            dynamic response = JObject.Parse(json);
            convID = response.cs;

            return response.output;
        }

        public void NewConversation()
        {
            ConversationChanged.Invoke();
            convID = String.Empty;
        }
    }

    
}
