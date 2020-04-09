using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);

        }

        private void NavigateToPage()
        {
            button2.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                {
                    webBrowser1.Navigate(textBox1.Text);

                }
            }


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button2.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "navigation complete";
            //foreach  webBrowser1.Document.Images
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(e.CurrentProgress>0 & e.MaximumProgress>0){
                toolStripProgressBar1.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
           
        }

    }
}
