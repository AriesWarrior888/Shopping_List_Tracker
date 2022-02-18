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
        public DateTime dayDate = DateTime.Today;
        List<MealPlan> mealPlans = new List<MealPlan>();
        List<Recipe> recipeList = new List<Recipe>();
        List<Control> controlList = new List<Control>();
        public bool weekView = true;
        public int[] count;

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

            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                mealPlans = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);
                for (int i = 0; i < mealPlans.Count; i++)
                {
                    setRecipes(mealPlans[i]);
                }
                
            }
        }

        public void setRecipes(MealPlan plan)
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

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            jsonString = JsonSerializer.Serialize(mealPlans, options);
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
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int location = flpList.Controls.IndexOf((Control)sender)/3;
            count[location]++;
            mealPlans[location].qty += 1;
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
        }

        private void btnGenList_Click(object sender, EventArgs e)
        {
            List<Recipe> finalRecipeList = new List<Recipe>();
            Inventory inventory = new Inventory();
            Recipes recipe = new Recipes();
            

            for(int i = 0; i < mealPlans.Count; i++)
            {
                if(mealPlans[i].date.CompareTo(DateTime.Today.ToString()) >= 0)
                {
                    finalRecipeList.Add(mealPlans[i].recipe);
                }
            }

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

            for(int i = totalRecipe; i >= 0+1; i--)
            {
                foreach (Ingredient ingredient in finalRecipeList[i-1].ingredients)
                {
                    if(nameList.Contains(ingredient.name))
                    {
                        qtyList[nameList.IndexOf(ingredient.name)] += ingredient.qty;
                    }
                    else
                    {
                        nameList.Add(ingredient.name);
                        qtyList.Add(ingredient.qty);
                    }
                }
            }

            int[] theDifference = new int[qtyList.Count];
            for (int i = 0; i < nameList.Count; i++)
            {
                foreach (Storage ingredient in inventory.ingredientList)
                {
                    if(nameList[i].Equals(ingredient.ingredient.name))
                    {
                        qtyList[i] -= ingredient.ingredient.qty;
                    }
                }
            }
        }
    }
}
