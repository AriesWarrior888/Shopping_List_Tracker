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
using System.Text.Json;

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
            lblDate.Text = $"{DateTime.Today.DayOfWeek} {DateTime.Today.Month}/{DateTime.Today.Day}";


            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            updatePage();

        }

        private void LandingPage_Load(object sender, EventArgs e)
        { 
            this.setControls();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            Recipes frmRecipe = new Recipes();
            frmRecipe.ShowDialog();

            updatePage();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar frmCalendar = new Calendar();
            frmCalendar.ShowDialog();

            updatePage();

            

            
        }

        public void updatePage()
        {
            for(int i = flpList.Controls.Count - 1; i >= 0; i--)
            {
                flpList.Controls.RemoveAt(i);
            }

            if (System.IO.File.Exists(System.IO.Path.Combine(Program.ApplicationDirectory, "calendarStorage.Json")))
            {
                Dictionary<DateTime, Dictionary<Guid, MealPlan>> dicMealPlan = new Dictionary<DateTime, Dictionary<Guid, MealPlan>>();
                string jsonString = string.Empty;
                FileManager.ReadFromFile(System.IO.Path.Combine(Program.ApplicationDirectory, "calendarStorage.Json"), out jsonString);
                List<MealPlan> lstMealPlan = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);

                for (int i = 0; i < lstMealPlan.Count; i++)
                {
                    DateTime date = DateTime.Parse(lstMealPlan[i].date);

                    if (date == DateTime.Today)
                    {
                        TextBox txtRecipe = new TextBox();
                        TextBox txtQuantity = new TextBox();


                        txtRecipe.Size = new Size(260, 20);
                        txtRecipe.Text = lstMealPlan[i].recipe.name;

                        txtQuantity.Size = new Size(100, 20);
                        txtQuantity.Text = lstMealPlan[i].qty.ToString();

                        flpList.Controls.Add(txtRecipe);
                        flpList.Controls.Add(txtQuantity);
                    }

                }
            }
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
