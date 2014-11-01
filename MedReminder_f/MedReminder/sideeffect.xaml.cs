using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MedReminder
{
    public partial class sideeffect : PhoneApplicationPage
    {
        public int n1;
        public int n2;
        public string content;
        char letter;
        public sideeffect()
        {
            InitializeComponent();
        }
        private void WebBrowser_OnLoaded(object sender, RoutedEventArgs e)
        {

            string s = webBrowser1.SaveToString();
            MessageBox.Show("sd" + s);
            //n1 = s.IndexOf("For the Consumer");

        }

        void Detail_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("fghj");
                return;
            }
            string s = (string)(e.Result);
            MessageBox.Show((string)(e.Result));
            n1 = s.IndexOf("For the Consumer");
            n2 = s.IndexOf("For Healthcare Professionals");
            // MessageBox.Show("" + n1 + "completed" + n2);
            string sub = s.Substring(n1, n2 - n1);

            MessageBox.Show("<html><body><h2>" + sub + "</h2></body></html>");
            webBrowser1.NavigateToString("<html><body><h2>" + sub + "</h2></body></html>");

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string selectedItemText = autoTxtBoxProductCode.SelectedItem.ToString();
                //MessageBox.Show(selectedItemText);
                content = selectedItemText;
                content.Trim();
                int n1 = content.Length;
                MessageBox.Show(content);
                content = content.ToLower();
                // content = "yaz";
                int n2 = content.Length;
                MessageBox.Show("dfc" + content);
                //  WebClient client = new WebClient();
                // string reply = client.DownloadStringAsync("http://www.drugs.com"); 
                WebClient Detail = new WebClient();
                Detail.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Detail_DownloadStringCompleted);
                Detail.DownloadStringAsync(new Uri("http://www.drugs.com/sfx/" + content + "-side-effects.html"));
                //String htmlCode = client.DownloadString("http://XYZ.com");
                // webBrowser1.Source= new Uri("http://www.drugs.com/sfx/" + content + "-side-effects.html", UriKind.Absolute);
                // webBrowser1. += WebBrowser_OnLoaded;

                // WebClient client = new WebClient();

                //sfx/" + content + "-side-effects.html");
                //string s = "http://drugs.com/sfx/";      // + content + "-side-effects.html";

                //string html = new WebClient().DownloadString("http://twitter.com");
                // string sub = s.Substring(n1, n2-n1);

                // MessageBox.Show("<html><body><h2>"+sub+"</h2></body></html>");
                // public int n1= s.IndexOf("For the Consumer");
                //webBrowser1.NavigateToString(str2+"</html>"); 
                //MessageBox.Show("sd" +b);

            }
            catch
            {
               // MessageBox.Show(autoTxtBoxProductCode.Text);
                
                content = autoTxtBoxProductCode.Text;
                if (string.IsNullOrEmpty(content))
                {
                    
                }
                else
                {

                    letter = content[0];
                    webBrowser1.Source = new Uri("http://www.drugs.com/alpha/" + letter + "1.html", UriKind.Absolute);
                }
            }
            
        }
        
    }
}