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
            //lables
            lblTitle.Text = "Shopping List";
            //form
            this.ControlBox = false;

        }
/* Figure Something out for this, use different code the following code was merely an attempt that did not work
 * 
            timer = new System.Timers.Timer(10000);
            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //find some way to constantly check for this condition
            Rectangle bounds = new Rectangle(Bounds.Location, Bounds.Size);
            if (this.Bounds != bounds)
            {
                bounds = this.Bounds;

                btnRecipe.Location = new Point(this.Width / 3, this.Height / 4);
                btnRecipe.Size = new Size(75, 23);

                Button btnCalendar = btnRecipe;
                this.btnCalendar.Left = btnRecipe.Right + 5;

                Button btnInventory = btnCalendar;
                this.btnInventory.Left = btnCalendar.Right + 5;
            }
        }
*/
        private void LandingPage_Load(object sender, EventArgs e)
        { 
            //Find a filePath and finish this piece of code
            //FileManager.ReadFromFile()
            this.setControls();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            Recipe frmRecipe = new Recipe();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Same as above, create a filePath and write to it
            FileManager.WriteToFile(someFilePath, ListOfRecipes); //Recipes

            this.Dispose();
        }
    }
}
