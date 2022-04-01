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
using PdfSharp.Pdf;

namespace Shopping_List_Tracker
{
    public partial class Calendar : Form
    {
        /*
         *  [3]"DateTime Struct (System)", Docs.microsoft.com, 2022. [Online]. Available: https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=net-6.0. [Accessed: 07- Mar- 2022].

            [2]"JsonSerializer Class (System.Text.Json)", Docs.microsoft.com, 2022. [Online]. Available: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer?view=net-6.0. [Accessed: 07- Mar- 2022].

            [1]"Guid Struct (System)", Docs.microsoft.com, 2022. [Online]. Available: https://docs.microsoft.com/en-us/dotnet/api/system.guid?view=net-6.0. [Accessed: 07- Mar- 2022].
        */
        #region Variables
        private string fullPathToFile  = string.Empty;
        private readonly string fileName = "calendarStorage.Json";
        private string jsonString = string.Empty;
        private Dictionary<string, FlowLayoutPanel> weekFlpList= new Dictionary<string, FlowLayoutPanel>();
        public Dictionary<DateTime, Dictionary<Guid, MealPlan>> dicMealPLan = new Dictionary<DateTime, Dictionary<Guid, MealPlan>>();

        //Located on the sunday of the week
        public DateTime date = DateTime.Today;

        //Currently Selected Day of the Week
        public DateTime dayDate = DateTime.Today;

        //Lists
        List<Recipe> recipeList = new List<Recipe>();
        List<Control> controlList = new List<Control>();
        
        public bool weekView = true;
        public int[] count;
        #endregion
       
        public Calendar()
        {
            InitializeComponent();
            setControls();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            InitializeFIle();
            loadRecipesFromFile();
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


            date = date.AddDays(-6);


            #endregion
        }

        private void InitializeFIle()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);

            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                List<MealPlan> lstMealPlan = JsonSerializer.Deserialize<List<MealPlan>>(jsonString);

                for (int i = 0; i < lstMealPlan.Count; i++)
                {
                    DateTime date = DateTime.Parse(lstMealPlan[i].date);

                    if (this.dicMealPLan.Keys.Contains(date))
                    {
                        dicMealPLan[date].Add(lstMealPlan[i].recipe.guid, lstMealPlan[i]); 
                    }
                    else
                    {
                        Dictionary<Guid, MealPlan> temp = new Dictionary<Guid, MealPlan>();
                        temp.Add(lstMealPlan[i].recipe.guid, lstMealPlan[i]);
                        dicMealPLan.Add(DateTime.Parse(lstMealPlan[i].date), temp);
                    }
                    
                }
                
            }
        }

        
        private void function()
        {
            if (flpList.Controls.Count > 0)
            {
                for (int i = flpList.Controls.Count; i > 0; i--)
                {
                    flpList.Controls.RemoveAt(i - 1);
                }
            }
        }
        public void functionForWeek()
        {
            foreach (FlowLayoutPanel flp in weekFlpList.Values)
            {
                for (int i = flp.Controls.Count; i > 0; i--)
                {
                    flp.Controls.RemoveAt(i - 1);
                }
            }
        }

        public void setRecipes(MealPlan plan)
        {
            if(dayDate.ToString().CompareTo(plan.date.ToString()) == 0 && !weekView)
            {
                ComboBox recipeButton = new ComboBox();
                NumericUpDown numeric = new NumericUpDown();
                Button deleteButton = new Button();
               
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
                recipeButton.Tag = plan;




                //Numeric Up Down
                numeric.Size = new Size(30, 20);
                numeric.Value = plan.qty;

                //Delete Button
                deleteButton.Size = new Size(55, 20);
                deleteButton.Text = "Delete";
                deleteButton.Click += new EventHandler(this.btnDelete_Click);


                flpList.Controls.Add(recipeButton);
                flpList.Controls.Add(numeric);
                flpList.Controls.Add(deleteButton);

                controlList.Add(recipeButton);
                controlList.Add(numeric);
                controlList.Add(deleteButton);
            }
            else if (weekView)
            {
                Button recipeButton = new Button();
                recipeButton.Tag = plan;
                recipeButton.Text = plan.recipe.name + " " + plan.qty;
                weekFlpList[DateTime.Parse(plan.date).DayOfWeek.ToString()].Controls.Add(recipeButton);
                recipeButton.Click += new EventHandler(weekButtonClick);

            }

        }

        private void weekButtonClick(object sender, EventArgs e)
        {
            weekView = false; 
            function();
            dayDate = DateTime.Parse(((MealPlan)(((Control)sender).Tag)).date);
            
            if(dicMealPLan.Keys.Contains(dayDate))
            {
                foreach (MealPlan plan in dicMealPLan[dayDate].Values)
                {
                    setRecipes(plan);
                }

            }
            
          
            tcCalendar.SelectedTab = tpDay;
            DateTime date = DateTime.Parse(((MealPlan)(((Control)sender).Tag)).date);

            lblDay.Text = $"{date.DayOfWeek} {date.Month}/{date.Day}";
            
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

            List<MealPlan> lstMealPlan = new List<MealPlan>();

            
            foreach (Dictionary<Guid, MealPlan> dic in dicMealPLan.Values)
            {
                foreach (MealPlan mealPlan in dic.Values)
                {
                    lstMealPlan.Add(mealPlan);
                }
                
            }

            jsonString = JsonSerializer.Serialize(lstMealPlan, options);
            FileManager.WriteToFile(fullPathToFile, jsonString);
  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            savesMealPlans();
            this.Close();
        }

        private void btnWeekPrevious_Click(object sender, EventArgs e)
        {
            savesMealPlans();
            weekView = true;
            functionForWeek();
            formatDates(-7);
            setWeekView();
        }

        private void btnWeekNext_Click(object sender, EventArgs e)
        {
            savesMealPlans();
            weekView = true;
            functionForWeek();
            formatDates(7);
            setWeekView();

        }

        private Recipe getRecipeFromList(string recipeName)
        {
            foreach(Recipe recipe in recipeList)
            {
                if(recipe.name == recipeName)
                {
                    return recipe;
                }
            }
            return null;
        }

        private void savesMealPlans()
        {
            if (flpList.Controls.Count > 0)
            {
                Dictionary<Guid, MealPlan> todayMealPlan = new Dictionary<Guid, MealPlan>();
                for (int i = 0; i < flpList.Controls.Count; i++)
                {
                    // 0 is recipe name
                    // 1 is qty
                    // 2 delete button
                    Recipe recipe = new Recipe(flpList.Controls[i].Text, 0, "");
                    i++;

                    MealPlan mealPlan = new MealPlan(recipe, int.Parse(flpList.Controls[i].Text), dayDate.ToString());
                    i++;

                    Recipe rr = getRecipeFromList(recipe.name);
                    todayMealPlan.Add(rr.guid, mealPlan);
                }

                dicMealPLan[dayDate] = todayMealPlan;
                save(); 

            }
            else if(flpList.Controls.Count == 0 )
            {
                dicMealPLan.Remove(dayDate);
            }
            
        }
        private void btnDayPrevious_Click(object sender, EventArgs e)
        {
            savesMealPlans();

            weekView = false;
            formatDates(-1);



            function();
            if (dicMealPLan.Keys.Contains(dayDate))
            {
               
                foreach (MealPlan mealplan in dicMealPLan[dayDate].Values)
                {
                    setRecipes(mealplan);
                }

            }




        }

        private void btnDayNext_Click(object sender, EventArgs e)
        {
            savesMealPlans();
            weekView = false;
            formatDates(1);

            function();
            if (dicMealPLan.Keys.Contains(dayDate))
            {
                
                foreach (MealPlan mealplan in dicMealPLan[dayDate].Values)
                {
                    setRecipes(mealplan);
                }

            }

        }


        private void loadRecipesFromFile()
        {
            Recipes frmRecipe = new Recipes();
            string tempString = "";
            if (System.IO.File.Exists(frmRecipe.fullPathToFile))
            {
                FileManager.ReadFromFile(System.IO.Path.Combine(Program.ApplicationDirectory, frmRecipe.fileName), out tempString);
            }
            else
            {
                MessageBox.Show("Please set up a recipe before using the calendar");
                return;
            }


 
            recipeList = JsonSerializer.Deserialize<List<Recipe>>(tempString);

            setWeekView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            ComboBox recipeButton = new ComboBox();
            NumericUpDown numeric = new NumericUpDown();
            Button deleteButton = new Button();
           
            
            
            String[] recipes = new String[recipeList.Count];
            count = new int[recipeList.Count];
            
            for (int i = 0; i < recipeList.Count; i++)
            {
                recipes[i] = recipeList[i].name;
                count[i] = recipeList[i].servingAmount;
            }


            recipeButton.DropDownStyle = ComboBoxStyle.DropDownList;
            recipeButton.Items.AddRange(recipes);
            recipeButton.Size = new Size(131, 20);



            //Numeric Up Down
            numeric.Size = new Size(30, 20);

            //Delete Button
            deleteButton.Size = new Size(55, 20);
            deleteButton.Text = "Delete";
            deleteButton.Click += new EventHandler(this.btnDelete_Click);
            

            flpList.Controls.Add(recipeButton);
            flpList.Controls.Add(numeric);
            flpList.Controls.Add(deleteButton);

            controlList.Add(recipeButton);
            controlList.Add(numeric);
            controlList.Add(deleteButton);

            MealPlan newPlan = new MealPlan();
            newPlan.date = dayDate.ToString();
        }

        private void btnDelete_Click(Object sender, EventArgs e)
        {
            flpList.Controls.RemoveAt(flpList.Controls.IndexOf((Control)sender) - 1);
            flpList.Controls.RemoveAt(flpList.Controls.IndexOf((Control)sender) - 1);
            flpList.Controls.RemoveAt(flpList.Controls.IndexOf((Control)sender));
        }

        private Dictionary<string, int> getNeededIngredients()
        {
            Dictionary<string, int> dicAllIngredients = new Dictionary<string, int>();
            foreach (Dictionary<Guid, MealPlan> dictionary in dicMealPLan.Values)
            {
                foreach (MealPlan mealPlan in dictionary.Values)
                {
                    if ((DateTime.Parse(mealPlan.date).CompareTo(DateTime.Today) >= 0))
                    {
                        foreach (Recipe recipe in recipeList)
                        {
                            if (recipe.name.Equals(mealPlan.recipe.name))
                            {
                                foreach (Ingredient ingredient in recipe.ingredients)
                                {
                                    if (dicAllIngredients.Keys.Contains(ingredient.name))
                                    {
                                        dicAllIngredients[ingredient.name] += ingredient.qty * mealPlan.qty;
                                    }
                                    else
                                    {
                                        dicAllIngredients.Add(ingredient.name, ingredient.qty * mealPlan.qty);
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
            return dicAllIngredients;
        }
        
        private Dictionary<string, int> getInventory()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string file = System.IO.Path.Combine(Program.ApplicationDirectory, "inventory.Json");
            string jsonString = "";

            if (System.IO.File.Exists(file))
            {
                FileManager.ReadFromFile(file, out jsonString);
                List<Storage> deserializedList = JsonSerializer.Deserialize<List<Storage>>(jsonString);
                foreach (Storage storage in deserializedList)
                {
                    if(inventory.Keys.Contains(storage.ingredient.name))
                    {
                        inventory[storage.ingredient.name] += storage.quantity;
                    }
                    else
                    {
                        inventory.Add(storage.ingredient.name, storage.quantity);
                    }
                }
            }
            return inventory;
            
        }
        private void btnGenList_Click(object sender, EventArgs e)
        {
            savesMealPlans();
            Dictionary<string, int> neededIngredients = getNeededIngredients();
            Dictionary<string, int> storedIngredients = getInventory();
            string output = string.Empty;

            foreach (string name in storedIngredients.Keys)
            {
                if(neededIngredients.Keys.Contains(name))
                {
                    neededIngredients[name] -= storedIngredients[name];
                }
                
            }
            foreach (KeyValuePair<string, int> pair in neededIngredients)
            {
                if(pair.Value > 0 )
                {
                    output = output + pair.Key + ":" + pair.Value + " needed\n";
                }
                else
                {

                }
                
            }

            string filePath = System.IO.Path.Combine(Program.ApplicationDirectory, $"Shopping List{DateTime.Today.ToString("yyyyMMdd")}.txt");
            if(FileManager.WriteToFile(filePath, output))
            {
                MessageBox.Show($"Your Shopping List has been saved successfully to {filePath}");
            }
            else
            {
                MessageBox.Show("Failed to write to file");
            }
            

            
        }

        private void tcCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(((TabControl)sender).SelectedTab.Name.Equals(tpDay.Name))
            {
                weekView = false;
                function();
                if (dicMealPLan.Keys.Contains(dayDate))
                {
                    foreach (MealPlan mealPlan in dicMealPLan[dayDate].Values)
                    {

                        setRecipes(mealPlan);
                    }
                }
                   
            }
            else
            {
                savesMealPlans();
                functionForWeek();
                setWeekView();
                
            }
        }

        private void setWeekDayView(DateTime date)
        {
            weekView = true;
            if (dicMealPLan.Keys.Contains(date))
            {
                function();
                foreach (MealPlan mealPlan in dicMealPLan[date].Values)
                {
                    setRecipes(mealPlan);
                }
            }     
           
        }

        private void setWeekView()
        {
            weekView = true;
            for (int i = 0; i < 7; i++)
            {
                setWeekDayView(this.date.AddDays(i));
            }
        }

        private void tcCalendar_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
