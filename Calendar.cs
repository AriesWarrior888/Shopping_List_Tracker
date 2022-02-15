using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Shopping_List_Tracker
{
    public partial class Calendar : Form
    {
        private string fullPathToFile  = string.Empty;
        private readonly string fileName = "calendarStorage.Json";
        private string jsonString = string.Empty;
        public DateTime date = DateTime.Today;
        List<MealPlan> mealPlans = new List<MealPlan>();
        public bool weekView = true;

        public Calendar()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            InitializeFIle();
            setControls();
           
        }


        public void setControls()
        {
            ControlBox = false;
            formatDates(0);
        }
        
        public void formatDates(int direction)
        {
            int distanceFromSunday = 0;

            if (direction < 0)
            {
                date = date.AddDays(direction);
            }
            if (direction > 0)
            {
                date = date.AddDays(direction);
            }

            #region Set the Labels with Days of the Week
            lblDay.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            distanceFromSunday = (int)date.DayOfWeek;

            date = date.AddDays(-distanceFromSunday);
            lblSunday.Text = $"Sunday {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblMonday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblTuesday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblWednesday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblThursday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblFriday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            date = date.AddDays(1);
            lblSaturday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";

            
            #endregion
        }

        private void InitializeFIle()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);
            //fullPathToFile = "C:\\Isaac Jones\\calendarStorage.Json";

            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                mealPlans = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);
                setRecipes(mealPlans);
            }
        }

        public void setRecipes(List<MealPlan> list)
        {
            Button Recipebutton = new Button();
            NumericUpDown numeric = new NumericUpDown();
            Button deleteButton = new Button();

            //Recipe Buttons


            //Numeric Up Down


            //Delete Button



        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            FileManager.WriteToFile(fullPathToFile, jsonString);
            this.Close();
        }

        private void btnWeekPrevious_Click(object sender, EventArgs e)
        {
            weekView = true;
            formatDates(-7);
        }

        private void btnWeekNext_Click(object sender, EventArgs e)
        {
            weekView = true;
            formatDates(7);
        }

        private void btnDayPrevious_Click(object sender, EventArgs e)
        {
            weekView = false;
            formatDates(-1);
            
        }

        private void btnDayNext_Click(object sender, EventArgs e)
        {
            weekView = false;
            formatDates(1);
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ComboBox recipeButton = new ComboBox();
            NumericUpDown numeric = new NumericUpDown();
            Button deleteButton = new Button();
            Form frmRecipe = new Form();
            string tempString = "";
           /* List<Recipe> recipeList = JsonSerializer.Deserialize<List<Recipe>>(tempString);
            String[] recipes = new String[recipeList.Count];
            int[] count = new int[recipeList.Count];
            
            for (int i = 0; i < recipeList.Count; i++)
            {
                recipes[i] = recipeList[i].name;
            }

            

            FileManager.ReadFromFile(System.IO.Path.Combine(Program.ApplicationDirectory, frmRecipe.fileName), out tempString);*/

            recipeButton.DropDownStyle = ComboBoxStyle.DropDownList;

            recipeButton.Size = new Size(131, 20);


            //recipeButton.Items.AddRange(recipes);

            //Numeric Up Down
            numeric.Size = new Size(30, 20);

            //Delete Button
            deleteButton.Size = new Size(55, 20);




        }
    }
}
