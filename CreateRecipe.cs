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
        public CreateRecipe()
        {
            InitializeComponent();
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



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //delegate things
        }


        public string getRecipeName()
        {
            return this.txtName.Text;
        }

        public int getServingCount()
        {
            return int.Parse(txtServingCount.Text);
        }

        public string getDescription()
        {
            return this.txtDescription.Text;
        }

        public string getIngredientName()
        {
            return this.txtIngredient.Text;
        }

        public int getIngredientQty()
        {
            return int.Parse(this.txtQTY.Text);
        }
    }
}
