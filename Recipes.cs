using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shopping_List_Tracker.Events;

namespace Shopping_List_Tracker
{
    public partial class Recipes : Form
    {
        public List<Control> updatedControlList;
        public List<Control> currentControlList;
        Dictionary<string, Recipe> recipeValues = new Dictionary<string, Recipe>();
        int objectPlacement = -1;
        public Recipes()
        {
            InitializeComponent();
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //implement soon
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int removalIndex = flpList.Controls.IndexOf((Control)sender);
            recipeValues.Remove(currentControlList[removalIndex + 1].Text);
            for (int i = 5; i < 9; i++)
            {
                this.flpList.Controls.RemoveAt(removalIndex);
            }
        }

        private void btnCreateRow_Click(object sender, EventArgs e)
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


            CreateRecipe frmCreateRecipe = new CreateRecipe();
            objectPlacement = -1;
            frmCreateRecipe.UpdateDataBoxes += new CreateRecipe.UpdateRecipeData(FillInData);
            frmCreateRecipe.ShowDialog();

            
        }

        public void FillInData(object sender, ReturnBackToRecipeEventArgs e)
        {

            updatedControlList = e.GetList; 
            if (objectPlacement == -1)
            {
                Recipe recipe = new Recipe(updatedControlList[0].Text, Int32.Parse(updatedControlList[1].Text), updatedControlList[2].Text);
                for (int i = 3; i + 2 <= updatedControlList.Count; i += 2)
                {
                    Ingredient ingredients = new Ingredient();
                    ingredients.name = updatedControlList[i].Text;
                    ingredients.qty = Int32.Parse(updatedControlList[i + 1].Text);
                    recipe.addIngredients(ingredients);
                }
                recipeValues.Add(recipe.getName(), recipe);
            }
            currentControlList[currentControlList.Count - 3].Text = updatedControlList[1].Text;
            currentControlList[currentControlList.Count - 2].Text = updatedControlList[2].Text;
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            setControls();
        }

        public void setControls()
        {
            currentControlList = new List<Control>();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            if (flpList.Controls[1].Text.Equals("Recipe")) 
            {
                MessageBox.Show("Recipe is Null");
                return;
            }
            else
            {          
                CreateRecipe frmCreateRecipe = new CreateRecipe(recipeValues[currentControlList[flpList.Controls.IndexOf((Control)sender)+1].Text]);
                frmCreateRecipe.UpdateDataBoxes += new CreateRecipe.UpdateRecipeData(FillInData);
                frmCreateRecipe.ShowDialog();
            }
            
        }
    }
}
