using System;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    public partial class Recipe : Form
    {
        public Recipe()
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
            for (int i = 5; i < 9; i++)
            {
                this.flpList.Controls.RemoveAt(removalIndex);
            }
        }

/*        private void btnCreateRow_Click(object sender, EventArgs e, string Name, string Description, int Quantity, int servingCount)
        {

        }*/
        private void btnCreateRow_Click(object sender, EventArgs e)
        {
            Button btnNewDeleteButton = new Button();
            Button btnNewAddButton = new Button();
            TextBox txtNewDescription = new TextBox();
            Button btnNewRecipe = new Button();

            //Add button
            btnNewAddButton.Size = this.btnAdd.Size;
            btnNewAddButton.Click += new EventHandler(btnAdd_Click);
            btnNewAddButton.Text = "Add";

            //Delete Button
            btnNewDeleteButton.Size = this.btnDelete.Size;
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Description
            txtNewDescription.Size = this.txtDescription.Size;

            //Name of Recipe
            btnNewRecipe.Size = this.btnRecipe.Size;
            btnNewRecipe.Text = "Recipe";


            //Adding to the Flow Layout Panel
            this.flpList.Controls.Add(btnNewDeleteButton);
            this.flpList.Controls.Add(btnNewRecipe);
            this.flpList.Controls.Add(txtNewDescription);
            this.flpList.Controls.Add(btnNewAddButton);
        }
    }
}
