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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //FileManager.ReadFromFile("Ingredients.dat", out string json);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int removalIndex = flpInventory.Controls.IndexOf((Control)sender);
            for (int i = 5; i < 9; i++)
            {
                this.flpInventory.Controls.RemoveAt(removalIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnNewDeleteButton = new Button();
            TextBox txtNewQty = new TextBox();
            TextBox txtNewName = new TextBox();
            TextBox txtNewUOM = new TextBox();

            //QTY box
            txtNewQty.Size = this.txtQty.Size;
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);

            //Delete Button
            btnNewDeleteButton.Size = this.btnDelete.Size;
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Description box
            txtNewName.Size = this.txtName.Size;
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //UOM box
            txtNewUOM.Size = this.txtUOM.Size;
            txtNewUOM.Font = new System.Drawing.Font("Arial", 8);
            txtNewUOM.Enabled = false;


            //Adding to the Flow Layout Panel
            this.flpInventory.Controls.Add(txtNewName);
            this.flpInventory.Controls.Add(txtNewQty);
            this.flpInventory.Controls.Add(txtNewUOM);
            this.flpInventory.Controls.Add(btnNewDeleteButton);
        }
    }
}
