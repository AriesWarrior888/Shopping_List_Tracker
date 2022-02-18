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

namespace Shopping_List_Tracker
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        public static System.Timers.Timer timer;

        public void setControls()
        {
            this.CenterToScreen();
            //lables
            lblTitle.Text = "Shopping List";

        }

        private void LandingPage_Load(object sender, EventArgs e)
        { 
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
            this.Dispose();
        }
    }
}
