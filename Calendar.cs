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


        public Calendar()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            InitializeFIle();
            setControls();
           
        }


        public void setControls()
        {
            lblDay.Text = $"{date.DayOfWeek}";
        }

        private void InitializeFIle()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);
            
            if(System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
            }
            
            List<MultiplePlans> tempList = JsonSerializer.Deserialize<List<MultiplePlans>>(jsonString);
           
         
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }
    }
}
