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
        public CreateRecipe()
        {
            InitializeComponent();
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TextBox txtNewName = new TextBox();
            TextBox txtNewQty = new TextBox();

            //desc
            txtNewName.Size = this.txtIngredient.Size;
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //qty
            txtNewQty.Size = this.txtQTY.Size;
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);

            //adding to flow layout panel
            flpList.Controls.Add(txtNewName);
            flpList.Controls.Add(txtNewQty);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //delegate things
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //delegate things
        }
    }
}
