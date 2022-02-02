﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shopping_List_Tracker.Events;

namespace Shopping_List_Tracker
{
    public partial class Recipes : Form
    {
        public List<Control> updatedControlList;
        public List<Control> currentControlList;
        Dictionary<int, List<Control>> recipeValues = new Dictionary<int, List<Control>>();
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
            if (recipeValues.Remove(removalIndex / 4))
            {
                int tempIndex = removalIndex / 4;
                for(int i = tempIndex; i < recipeValues.Count; i++)
                {
                    recipeValues.Add(i, recipeValues[i + 1]);
                    recipeValues.Remove(i + 1);
                }
            }
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
                recipeValues.Add(currentControlList.Count / 4 - 1, updatedControlList);
            }
            else
            {
                if(recipeValues.Remove(objectPlacement))
                {
                    recipeValues.Add(objectPlacement, updatedControlList);
                }
            }


            currentControlList[currentControlList.Count - 3].Text = updatedControlList[0].Text;
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
                
                int objectLocation = flpList.Controls.IndexOf((Control)sender)/4;
                objectPlacement = flpList.Controls.IndexOf((Control)sender)/4;
                CreateRecipe frmCreateRecipe = new CreateRecipe(recipeValues[objectLocation]);
                frmCreateRecipe.UpdateDataBoxes += new CreateRecipe.UpdateRecipeData(FillInData);
                frmCreateRecipe.ShowDialog();
                frmCreateRecipe.receiveAndSet(recipeValues[objectLocation]);

                

            }
            
        }
    }
}
