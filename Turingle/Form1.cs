using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;


namespace Turingle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString(String.Format("http://www.cleverbot.com/getreply?key={0}&input={1}", textBox1.Text, textBox3.Text));
            dynamic message = JObject.Parse(json);

            textBox2.Text = message.output;
        }
    }
}
