using Shopping_List_Tracker.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    public partial class CreateRecipe : Form
    {
        private List<Control> controlList = new List<Control>();

        public delegate void UpdateRecipeData(object sender, ReturnBackToRecipeEventArgs e);

        public event UpdateRecipeData UpdateDataBoxes;

         
        public CreateRecipe()
        {
            InitializeComponent();
            controlList.Add(txtName);
            controlList.Add(txtServingCount);
            controlList.Add(txtDescription);

            controlList.Add(txtIngredient);
            controlList.Add(txtQTY);
        }

        public CreateRecipe(Recipe recipe)
        {
            InitializeComponent();
            receiveAndSet(recipe);
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Button temp = new Button();
            TextBox txtNewName = new TextBox();
            TextBox txtNewQty = new TextBox();

            //desc
            txtNewName.Size = this.txtIngredient.Size;
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //qty
            txtNewQty.Size = this.txtQTY.Size;
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);

            //button
            temp = this.btnCreate;

            //adding to flow layout panel
            flpList.Controls.Add(txtNewName);
            controlList.Add(txtNewName);
            flpList.Controls.Add(txtNewQty);
            controlList.Add(txtNewQty);
            flpList.Controls.Add(temp);
        }

        public void tempCreateClick(Ingredient ingredient)
        {
            Button temp = new Button();
            TextBox txtNewName = new TextBox();
            TextBox txtNewQty = new TextBox();

            //Ingredient
            txtNewName.Size = this.txtIngredient.Size;
            txtNewName.Text = ingredient.name;
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //qty
            txtNewQty.Size = this.txtQTY.Size;
            txtNewQty.Text = ""+ingredient.qty;
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);

            //button
            temp = this.btnCreate;

            //adding to flow layout panel
            flpList.Controls.Add(txtNewName);
            controlList.Add(txtNewName);
            flpList.Controls.Add(txtNewQty);
            controlList.Add(txtNewQty);
            flpList.Controls.Add(temp);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in controlList)
            {
                if (control.Text.Equals(""))
                {
                    MessageBox.Show($"field {control.Name} is empty");
                    return;
                }
                
            }
            if (!Regex.IsMatch(controlList[1].Text, @"^[0-9]+$"))
            {
                MessageBox.Show("field Recipe Name has non-numbers");
                return;
            }
            if (!Regex.IsMatch(controlList[4].Text, @"^[0-9]+$"))
            {
                MessageBox.Show($"An ingredient quantity box has non-numbers");
                return;
            }
            for(int i = 6; i < controlList.Count; i += 2)
            {
                if (!Regex.IsMatch(controlList[i].Text, @"^[0-9]+$"))
                {
                    MessageBox.Show($"An ingredient quantity box has non-numbers");
                    return;
                }
            }
            List<Control> controls = new List<Control>();
            
            controls = controlList;

            ReturnBackToRecipeEventArgs args = new ReturnBackToRecipeEventArgs(controls);

            UpdateDataBoxes(this, args);

            this.Close();
        }

        public void receiveAndSet( Recipe recipe)
        {
            txtName.Text = recipe.name;
            txtServingCount.Text = ""+recipe.servingAmount;
            txtDescription.Text = recipe.description;
            txtIngredient.Text = recipe.ingredients[0].name;
            txtQTY.Text = "" + recipe.ingredients[0].qty;
            controlList.Add(txtName);
            controlList.Add(txtServingCount);
            controlList.Add(txtDescription);

            controlList.Add(txtIngredient);
            controlList.Add(txtQTY);
            for (int i = 1; i < recipe.ingredients.Count; i++)
            {
                tempCreateClick(recipe.ingredients[i]);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
