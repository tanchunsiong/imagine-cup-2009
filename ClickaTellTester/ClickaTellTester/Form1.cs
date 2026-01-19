using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ClickaTellTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phonenumber = "+6593632452";
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozillia/4.0 (compatible; MSIE 6.0, Windows NT 5.2; .NET CLR 1.00.3705;)");
            client.QueryString.Add("user", "micsmsgateway");
            client.QueryString.Add("password", "test123");
            client.QueryString.Add("api_id", "3077985");
            client.QueryString.Add("to", phonenumber);
            client.QueryString.Add("text", "SMS+Gateway+has+stopped+running");

            String baseurl = "http://api.clickatell.com/http/sendmsg";

            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            String s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            txtoutput.Text = s;
        }
    }
}
