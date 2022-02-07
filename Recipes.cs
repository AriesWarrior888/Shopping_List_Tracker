using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shopping_List_Tracker.Events;
using System.Text.Json;

namespace Shopping_List_Tracker
{
    public partial class Recipes : Form
    {
        #region Declared Variables
        public List<Control> updatedControlList = new List<Control>();
        public List<Control> currentControlList = new List<Control>();
        Dictionary<Guid, Recipe> recipeValues = new Dictionary<Guid, Recipe>();
        List<Guid> objectGuid = new List<Guid>();
        private bool create;
        private int indexOfSender = 0;
        int ingredientListSize = 0;

        private string fullPathToFile = string.Empty;
        private readonly string fileName = "recipeStorage.Json";
        private string jsonString = string.Empty;
        #endregion

        public Recipes()
        {
            InitializeComponent();
            InitializeFile();
            objectGuid.Add(Guid.NewGuid());
        }

        private void InitializeFile()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);
            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                List<Recipe> recipe = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

                for(int i = 0; i < recipe.Count; i++)
                {
                    recipeValues.Add(recipe[i].guid, recipe[i]);
                    createButtons(recipe[i]);
                    currentControlList[currentControlList.Count - 4].Tag = recipe[i].guid;
                    currentControlList[currentControlList.Count - 3].Tag = recipe[i].guid;
                    currentControlList[currentControlList.Count - 2].Tag = recipe[i].guid;
                    currentControlList[currentControlList.Count - 1].Tag = recipe[i].guid;
                }
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //implement soon
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int removalIndex = flpList.Controls.IndexOf((Control)sender);
            
            objectGuid[0] = (Guid)currentControlList[flpList.Controls.IndexOf((Control)sender)].Tag;
            recipeValues.Remove(objectGuid[0]);
            
            for (int i = 5; i < 9; i++)
            {
                currentControlList.Remove(currentControlList[removalIndex]);
                this.flpList.Controls.RemoveAt(removalIndex);
            }
        }

        public void createButtons()
        {
            Button btnNewDeleteButton = new Button();
            Button btnNewAddButton = new Button();
            TextBox txtNewDescription = new TextBox();
            Button btnNewRecipe = new Button();

            //Add button
            btnNewAddButton.Size = new System.Drawing.Size(107, 38);
            btnNewAddButton.Click += new EventHandler(btnAdd_Click);
            btnNewAddButton.Text = "Add";

            //Delete Button
            btnNewDeleteButton.Size = new System.Drawing.Size(107, 38);
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Description
            txtNewDescription.Size = new System.Drawing.Size(275, 38);
            txtNewDescription.Font = new System.Drawing.Font("Arial", 20);

            //Name of Recipe
            btnNewRecipe.Size = new System.Drawing.Size(107, 38);
            btnNewRecipe.Click += new EventHandler(this.btnRecipe_Click);
            btnNewRecipe.Text = "Recipe";


            //Adding to the Flow Layout Panel
            this.flpList.Controls.Add(btnNewDeleteButton);
            this.flpList.Controls.Add(btnNewRecipe);
            this.flpList.Controls.Add(txtNewDescription);
            this.flpList.Controls.Add(btnNewAddButton);

            //Adding to current List

            this.currentControlList.Add(btnNewDeleteButton);
            this.currentControlList.Add(btnNewRecipe);
            this.currentControlList.Add(txtNewDescription);
            this.currentControlList.Add(btnNewAddButton);
        }
        public void createButtons(Recipe recipe)
        {
            Button btnNewDeleteButton = new Button();
            Button btnNewAddButton = new Button();
            TextBox txtNewDescription = new TextBox();
            Button btnNewRecipe = new Button();

            //Add button
            btnNewAddButton.Size = new System.Drawing.Size(107, 38);
            btnNewAddButton.Click += new EventHandler(btnAdd_Click);
            btnNewAddButton.Text = "Add";

            //Delete Button
            btnNewDeleteButton.Size = new System.Drawing.Size(107, 38);
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Description
            txtNewDescription.Size = new System.Drawing.Size(275, 38);
            txtNewDescription.Font = new System.Drawing.Font("Arial", 20);
            txtNewDescription.Text = recipe.description;

            //Name of Recipe
            btnNewRecipe.Size = new System.Drawing.Size(107, 38);
            btnNewRecipe.Click += new EventHandler(this.btnRecipe_Click);
            btnNewRecipe.Text = recipe.name;


            //Adding to the Flow Layout Panel
            this.flpList.Controls.Add(btnNewDeleteButton);
            this.flpList.Controls.Add(btnNewRecipe);
            this.flpList.Controls.Add(txtNewDescription);
            this.flpList.Controls.Add(btnNewAddButton);

            //Adding to current List

            this.currentControlList.Add(btnNewDeleteButton);
            this.currentControlList.Add(btnNewRecipe);
            this.currentControlList.Add(txtNewDescription);
            this.currentControlList.Add(btnNewAddButton);
        }

        private void btnCreateRow_Click(object sender, EventArgs e)
        {
            
            createButtons();

            CreateRecipe frmCreateRecipe = new CreateRecipe();
            create = true;
            frmCreateRecipe.UpdateDataBoxes += new CreateRecipe.UpdateRecipeData(FillInData);
            frmCreateRecipe.ShowDialog();

            
        }

        public void FillInData(object sender, ReturnBackToRecipeEventArgs e)
        {
            Recipe recipe;
            updatedControlList = e.GetList; 

            if (create)
            {
                recipe = new Recipe(updatedControlList[0].Text, Int32.Parse(updatedControlList[1].Text), updatedControlList[2].Text);
               
                for (int i = 3; i + 2 <= updatedControlList.Count; i += 2)
                {
                    Ingredient ingredients = new Ingredient();
                    ingredients.name = updatedControlList[i].Text;
                    ingredients.qty = Int32.Parse(updatedControlList[i + 1].Text);
                    recipe.addIngredients(ingredients);
                }
                //set tags
                currentControlList[currentControlList.Count - 1].Tag = recipe.guid;
                currentControlList[currentControlList.Count - 2].Tag = recipe.guid;
                currentControlList[currentControlList.Count - 3].Tag = recipe.guid;
                currentControlList[currentControlList.Count - 4].Tag = recipe.guid;
                //set text
                currentControlList[currentControlList.Count - 3].Text = updatedControlList[0].Text;
                currentControlList[currentControlList.Count - 2].Text = updatedControlList[2].Text;
                
                recipeValues.Add(recipe.guid, recipe);
            }
            else
            {
                int count = 1;
                int timesThroughLoop = 0;
                recipe = recipeValues[objectGuid[0]];
                recipe.setName(updatedControlList[0].Text);
                recipe.setServingAmount(Int32.Parse(updatedControlList[1].Text));
                recipe.setDesctiption(updatedControlList[2].Text);
                
                for(int i = 3; timesThroughLoop < ingredientListSize; i += 2)
                {
                    recipe.setIngredients(timesThroughLoop, new Ingredient(updatedControlList[i].Text, Int32.Parse(updatedControlList[i + 1].Text), Ingredient.UnitOfMeasurement.nothing));
                    if(i > 3)
                    {
                        count += 2;
                    }
                    else
                    {
                        count++;
                    }
                    timesThroughLoop++;
                }
                

                for(int i = 3 + (count); i < updatedControlList.Count; i+= 2)
                {
                    Ingredient ingredients = new Ingredient();
                    ingredients.name = updatedControlList[i].Text;
                    ingredients.qty = Int32.Parse(updatedControlList[i + 1].Text);
                    recipe.ingredients.Add(ingredients);
                }
                currentControlList[indexOfSender].Text = updatedControlList[0].Text;
                currentControlList[indexOfSender + 1].Text = updatedControlList[2].Text;
                recipeValues[objectGuid[0]] = recipe;
            }
            
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            setControls();
        }

        public void setControls()
        {
            this.ControlBox = false;
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            indexOfSender = flpList.Controls.IndexOf((Control)sender);
            if (flpList.Controls[1].Text.Equals("Recipe")) 
            {
                MessageBox.Show("Recipe is Null");
                return;
            }
            else
            {
                
                objectGuid[0] = (Guid)currentControlList[flpList.Controls.IndexOf((Control)sender)].Tag;
                create = false;

                Recipe currentRecipe = recipeValues[(Guid)currentControlList[flpList.Controls.IndexOf((Control)sender)].Tag];
                ingredientListSize = currentRecipe.ingredients.Count;

                CreateRecipe frmCreateRecipe = new CreateRecipe(currentRecipe);
                frmCreateRecipe.UpdateDataBoxes += new CreateRecipe.UpdateRecipeData(FillInData);
                frmCreateRecipe.ShowDialog();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(recipeValues.Values, options);
            FileManager.WriteToFile(fullPathToFile, jsonString);
            Close();
        }
    }
}
