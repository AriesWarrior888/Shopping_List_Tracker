using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Shopping_List_Tracker
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();

            this.webBrowser1.DocumentText = "<a href=\"EA9EB851-54E5-4C13-B6DE-33839D4083FC\">damnit</a>";
        }

        public static System.Timers.Timer timer;

        public void setControls()
        {
            this.CenterToScreen();
            //lables
            lblTitle.Text = "Shopping List";
            //form
            this.ControlBox = false;

        }

        private void LandingPage_Load(object sender, EventArgs e)
        { 
            //Find a filePath and finish this piece of code
            //FileManager.ReadFromFile()
            this.setControls();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            Recipes frmRecipe = new Recipes();
            frmRecipe.ShowDialog();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar frmCalendar = new Calendar();
            frmCalendar.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory frmInventory = new Inventory();
            frmInventory.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileManager.WriteToFile()
            this.Dispose();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //e.LinkText
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsolutePath != "blank")
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(e.Url.AbsolutePath);

                string szGuid = xDoc.ChildNodes[0].Attributes["guid"].ToString();
            }
        }
    }
}
