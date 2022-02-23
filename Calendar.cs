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
        #region Variables
        private string fullPathToFile  = string.Empty;
        private readonly string fileName = "calendarStorage.Json";
        private string jsonString = string.Empty;
        private Dictionary<string, FlowLayoutPanel> weekFlpList= new Dictionary<string, FlowLayoutPanel>();

        //Located on the sunday of the week
        public DateTime date = DateTime.Today;

        //Currently Selected Day of the Week
        public DateTime dayDate = DateTime.Today;

        //Lists
        List<MealPlan> mealPlans = new List<MealPlan>();
        List<Recipe> recipeList = new List<Recipe>();
        List<Control> controlList = new List<Control>();
        
        public bool weekView = true;
        public int[] count;
        #endregion
       
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

            weekFlpList.Add("Sunday", flpSunday);
            weekFlpList.Add("Monday", flpMonday);
            weekFlpList.Add("Tuesday", flpTuesday);
            weekFlpList.Add("Wednesday", flpWednesday);
            weekFlpList.Add("Thursday", flpThursday);
            weekFlpList.Add("Friday", flpFriday);
            weekFlpList.Add("Saturday", flpSaturday);

            formatDates(0);
        }
        
        public void formatDates(int direction)
        {
            int distanceFromSunday = 0;

            if (direction < 0)
            {
                if (weekView == true)
                {
                    date = date.AddDays(direction);
                }
                else
                {
                    dayDate = dayDate.AddDays(direction);
                }
            }
            else if (direction > 0)
            {
                if (weekView == true)
                {
                    date = date.AddDays(direction);
                }    
                else
                {
                    dayDate = dayDate.AddDays(direction);
                }
            }


            #region Set the Labels with Days of the Week
            lblDay.Text = $"{dayDate.DayOfWeek} {dayDate.Month}/{dayDate.Day}";
            distanceFromSunday = (int)date.DayOfWeek;

            date = date.AddDays(-distanceFromSunday);
            lblSunday.Text = $"Sunday {date.Month}/{date.Day}";
            lblSunday.Tag = date.ToString();

            date = date.AddDays(1);
            lblMonday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblMonday.Tag = date.ToString();

            date = date.AddDays(1);
            lblTuesday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblTuesday.Tag = date.ToString();

            date = date.AddDays(1);
            lblWednesday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblWednesday.Tag = date.ToString();

            date = date.AddDays(1);
            lblThursday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblThursday.Tag = date.ToString();

            date = date.AddDays(1);
            lblFriday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblFriday.Tag = date.ToString();

            date = date.AddDays(1);
            lblSaturday.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            lblSaturday.Tag = date.ToString();


            #endregion
        }

        private void InitializeFIle()
        {
/*            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);

            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                mealPlans = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);
                if (flpList.Controls.Count > 0)
                {
                    foreach (Control control in flpList.Controls)
                    {
                        flpList.Controls.Remove(control);
                    }
                }
                for (int i = 0; i < mealPlans.Count; i++)
                {
                    setRecipes(mealPlans[i]);
                }
                
            }*/
        }

        public void setRecipes(MealPlan plan)
        {
            if(dayDate.ToString().CompareTo(plan.date.ToString()) == 0 && !weekView)
            {

                ComboBox recipeButton = new ComboBox();
                NumericUpDown numeric = new NumericUpDown();
                Button deleteButton = new Button();
                Recipes frmRecipe = new Recipes();
                string tempString = "";


                if (System.IO.File.Exists(frmRecipe.fullPathToFile))
                {
                    FileManager.ReadFromFile(frmRecipe.fullPathToFile, out tempString);
                    recipeList = JsonSerializer.Deserialize<List<Recipe>>(tempString);
                }

                String[] recipes = new String[recipeList.Count];
                count = new int[recipeList.Count];

                for (int i = 0; i < recipeList.Count; i++)
                {
                    recipes[i] = recipeList[i].name;
                    count[i] = recipeList[i].servingAmount;
                }

                //Recipe 
                int index = 0;

                recipeButton.Text = plan.recipe.name;
                recipeButton.DropDownStyle = ComboBoxStyle.DropDownList;
                recipeButton.Items.AddRange(recipes);
                foreach (var item in recipeButton.Items)
                {
                    if (item.Equals(plan.recipe.name))
                    {
                        index = recipeButton.Items.IndexOf(item);
                    }
                }
                recipeButton.SelectedIndex = index;
                recipeButton.Size = new Size(131, 20);
                recipeButton.Tag = plan.recipe.guid;
                recipeButton.SelectedValueChanged += new EventHandler(comboBox_ValueChanged);




                //Numeric Up Down
                numeric.Size = new Size(30, 20);
                numeric.Value = plan.qty;
                numeric.ValueChanged += new EventHandler(numericUpDown_ValueChanged);

                //Delete Button
                deleteButton.Size = new Size(55, 20);
                deleteButton.Text = "Delete";


                flpList.Controls.Add(recipeButton);
                flpList.Controls.Add(numeric);
                flpList.Controls.Add(deleteButton);

                controlList.Add(recipeButton);
                controlList.Add(numeric);
                controlList.Add(deleteButton);
            }
            else if (date.ToString().CompareTo(plan.date.ToString()) == 0 && weekView)
            {
                Button recipeButton = new Button();
                recipeButton.Tag = plan;
                recipeButton.Text = plan.recipe.name + " " + plan.qty;
                weekFlpList[date.DayOfWeek.ToString()].Controls.Add(recipeButton);
                recipeButton.Click += new EventHandler(weekButtonClick);

            }

        }

        private void weekButtonClick(object sender, EventArgs e)
        {
            weekView = false;
            setRecipes((MealPlan)(((Control)sender).Tag));
            tcCalendar.SelectedTab = tpDay;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            jsonString = JsonSerializer.Serialize(mealPlans, options);
            FileManager.WriteToFile(fullPathToFile, jsonString);
  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            save();
            this.Close();
        }

        private void btnWeekPrevious_Click(object sender, EventArgs e)
        {
            weekView = true;
            formatDates(-7);
            List<MealPlan> temp = determineDate(dayDate, mealPlans);
            if(System.IO.File.Exists(fullPathToFile))
            {
                if (flpList.Controls.Count > 0)
                {
                    foreach (Control control in flpList.Controls)
                    {
                        flpList.Controls.Remove(control);
                    }
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    setRecipes(temp[i]);
                    formatDates(1);
                }
                formatDates(-7);

            }
        }

        private void btnWeekNext_Click(object sender, EventArgs e)
        {
            weekView = true;
            formatDates(7);
            List<MealPlan> temp = determineDate(dayDate, mealPlans);
            if (System.IO.File.Exists(fullPathToFile))
            {
                if (flpList.Controls.Count > 0)
                {
                    foreach (Control control in flpList.Controls)
                    {
                        flpList.Controls.Remove(control);
                    }
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    setRecipes(temp[i]);
                    formatDates(1);
                }
                formatDates(-7);

            }
        }

        private void btnDayPrevious_Click(object sender, EventArgs e)
        {
            weekView = false;
            formatDates(-1);
            List<MealPlan> temp = determineDate(dayDate, mealPlans);
            if (System.IO.File.Exists(fullPathToFile))
            {
                if (flpList.Controls.Count > 0)
                {
                    foreach (Control control in flpList.Controls)
                    {
                        flpList.Controls.Remove(control);
                    }
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    setRecipes(temp[i]);
                }

            }

        }

        private void btnDayNext_Click(object sender, EventArgs e)
        {
            weekView = false;
            formatDates(1);
            List<MealPlan> temp = determineDate(dayDate, mealPlans);
            if (System.IO.File.Exists(fullPathToFile))
            {
                if (flpList.Controls.Count > 0)
                {
                    foreach (Control control in flpList.Controls)
                    {
                        flpList.Controls.Remove(control);
                    }
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    setRecipes(temp[i]);
                }

            }

        }

        private List<MealPlan> determineDate(DateTime date, List<MealPlan> list)
        {
            List<MealPlan> returnList = new List<MealPlan>();
            
            foreach (MealPlan mealPlan in list)
            {
                if (mealPlan.date.ToString().CompareTo(date.ToString()) == 0)
                {
                    returnList.Add(mealPlan);
                }
            }

            return returnList;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            ComboBox recipeButton = new ComboBox();
            NumericUpDown numeric = new NumericUpDown();
            Button deleteButton = new Button();
            string tempString = "";
            
            Recipes frmRecipe = new Recipes();
            if(System.IO.File.Exists(frmRecipe.fullPathToFile))
            {
                FileManager.ReadFromFile(System.IO.Path.Combine(Program.ApplicationDirectory, frmRecipe.fileName), out tempString);
            }
            else
            {
                MessageBox.Show("Please set up a recipe before using the calendar");
                return;
            }

            
            
            recipeList = JsonSerializer.Deserialize<List<Recipe>>(tempString);
            String[] recipes = new String[recipeList.Count];
            count = new int[recipeList.Count];
            
            for (int i = 0; i < recipeList.Count; i++)
            {
                recipes[i] = recipeList[i].name;
                count[i] = recipeList[i].servingAmount;
            }

            

            


            recipeButton.DropDownStyle = ComboBoxStyle.DropDownList;
            recipeButton.Items.AddRange(recipes);
            recipeButton.SelectedValueChanged += new EventHandler(comboBox_ValueChanged);
            recipeButton.Size = new Size(131, 20);



            //Numeric Up Down
            numeric.Size = new Size(30, 20);
            numeric.ValueChanged += new EventHandler(numericUpDown_ValueChanged);

            //Delete Button
            deleteButton.Size = new Size(55, 20);
            deleteButton.Text = "Delete";


            flpList.Controls.Add(recipeButton);
            flpList.Controls.Add(numeric);
            flpList.Controls.Add(deleteButton);

            controlList.Add(recipeButton);
            controlList.Add(numeric);
            controlList.Add(deleteButton);

            MealPlan newPlan = new MealPlan();
            newPlan.date = dayDate.ToString();
            mealPlans.Add(newPlan);
            save();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int location = flpList.Controls.IndexOf((Control)sender)/3;
            count[location]++;
            mealPlans[location].qty += 1;
            save();
        }

        private void comboBox_ValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < recipeList.Count; i++)
            {
                if(recipeList[i].name.Equals(((Control)sender).Text))
                {
                    ((Control)sender).Tag = recipeList[i].guid;
                    mealPlans[flpList.Controls.IndexOf((Control)sender) / 3].recipe = recipeList[i];
                }
            }
            save();
        }

        private void btnGenList_Click(object sender, EventArgs e)
        {
            List<Recipe> finalRecipeList = new List<Recipe>();
            List<int> finalQtyList = new List<int>();
            Inventory inventory = new Inventory();
            Recipes recipe = new Recipes();
            
            //makes the final lists for the generation of the text
            for(int i = 0; i < mealPlans.Count; i++)
            {
                if(mealPlans[i].date.CompareTo(dayDate.ToString()) >= 0)
                {
                    finalRecipeList.Add(mealPlans[i].recipe);
                    finalQtyList.Add(mealPlans[i].qty);
                }
            }

            //finds the total number of recipes located in the recipes, accounts for worst case scenario
            List<int> qtyList = new List<int>();
            List<string> nameList = new List<string>();
            int totalRecipe = 0;
            for(int i = 0; i < finalRecipeList.Count; i++)
            {
                foreach (Ingredient ingredient in finalRecipeList[i].ingredients)
                {
                    totalRecipe++;
                }
            }

            /*Takes finalRecipeList which was made earlier and performs a linear scan finding each ingredient, their name and quantity
            After that it will compare to the lists of names and qty and add them in, or increment the value if  it was already present
            Replace with dictionary if things get too complicated*/
            for(int i = totalRecipe; i >= 1; i--)
            {
                foreach (Ingredient ingredient in finalRecipeList[i-1].ingredients)
                {
                    if(nameList.Contains(ingredient.name))
                    {
                        qtyList[nameList.IndexOf(ingredient.name)] += finalQtyList[i - 1] * ingredient.qty;
                    }
                    else
                    {
                        nameList.Add(ingredient.name);
                        qtyList.Add(finalQtyList[i - 1] * ingredient.qty);
                    }
                }
            }

            //subtract from the qty list and append to string
            int[] theDifference = new int[qtyList.Count];
            string outputString = "";
            for (int i = 0; i < nameList.Count; i++)
            {
                foreach (Storage ingredient in inventory.ingredientList)
                {
                    if(nameList[i].Equals(ingredient.ingredient.name))
                    {
                        for (int j = 0; j < inventory.ingredientList.Length; j++)
                        {
                            if(inventory.ingredientList[j].Equals(nameList[i]))
                            {
                                qtyList[i] -= inventory.ingredientList[0].quantity;
                            }
                        }                      
                    }
                }
                if(qtyList[i] > 0)
                {
                    outputString = outputString + $"You need {qtyList[i]} {nameList[i]}\n";
                }
                
            }

            MessageBox.Show(outputString);
        }
    }
}
