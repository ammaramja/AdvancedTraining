using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myCart
{
    public partial class myGoogle : Form
    {
        string keyWordToBeSearched;

        public myGoogle()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            keyWordToBeSearched = textBox1.Text;
            textBox1.Visible = false;
            button1.Visible = false;
            webBrowser3.Visible = true;
            //string address = "https://www.google.co.in/search?q=" + keyWordToBeSearched;
            //webBrowser3.Navigate(new Uri(address));
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser3_VisibleChanged(object sender, EventArgs e)
        {
            string address = "https://www.google.co.in/search?q=" + keyWordToBeSearched;
            webBrowser3.Navigate(new Uri(address));
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
