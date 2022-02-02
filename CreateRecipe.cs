using Shopping_List_Tracker.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        public CreateRecipe(List<Control> controls)
        {
            InitializeComponent();
            receiveAndSet(controls);
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            controlList.Add(txtName);
            controlList.Add(txtServingCount);
            controlList.Add(txtDescription);

            controlList.Add(txtIngredient);
            controlList.Add(txtQTY);
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

        public void tempCreateClick(string ingredientName, string quantity)
        {
            Button temp = new Button();
            TextBox txtNewName = new TextBox();
            TextBox txtNewQty = new TextBox();

            //Ingredient
            txtNewName.Size = this.txtIngredient.Size;
            txtNewName.Text = ingredientName;
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //qty
            txtNewQty.Size = this.txtQTY.Size;
            txtNewQty.Text = quantity;
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

            List<Control> controls = new List<Control>();
            
            controls = controlList;

            ReturnBackToRecipeEventArgs args = new ReturnBackToRecipeEventArgs(controls);

            UpdateDataBoxes(this, args);

            this.Close();
        }

        public void receiveAndSet( List<Control> controls)
        {
            txtName.Text = controls[0].Text;
            txtServingCount.Text = controls[1].Text;
            txtDescription.Text = controls[2].Text;
            txtIngredient.Text = controls[3].Text;
            txtQTY.Text = controls[4].Text;
            if(controls.Count > 5)
            {
                for (int i = 4; i+2 < controls.Count; i += 2)
                {
                    tempCreateClick(controls[i+1].Text, controls[i+2].Text);

                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //delegate things
        }
    }
}
