using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsCbLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(tsCbLocation.Text);
            }
        }

        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void tsBtnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void tsBtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tsCbLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "G Browser-" + webBrowser1.Document.Title;
        }
    }
}
