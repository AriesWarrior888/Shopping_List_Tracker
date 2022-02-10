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
                date.AddDays(-7);
            }
            if (direction > 0)
            {
                date.AddDays(7);
            }

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
        }

        private void InitializeFIle()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);

            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                mealPlans = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);
            }                  
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

            string jsonString = JsonSerializer.Serialize(mealPlans, options);
            FileManager.WriteToFile(fullPathToFile, jsonString);
            this.Close();
        }
    }
}
