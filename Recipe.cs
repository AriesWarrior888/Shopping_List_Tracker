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
    public partial class Recipe : Form
    {
        public Recipe()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnDelete1 = new Button();
            Button btnAdd1 = new Button();
            TextBox txtDescription1 = new TextBox();
            TextBox txtName1 = new TextBox();

            btnAdd1.Size = btnAdd.Size;
            btnAdd1.Click += new EventHandler(btnAdd_Click);
            btnAdd1.Text = "Add";

            btnDelete1.Size = btnDelete.Size;
            txtDescription1.Size = txtDescription.Size;
            txtName1.Size = txtName.Size;

            this.flowLayoutPanel1.Controls.Add(btnDelete1);
            this.flowLayoutPanel1.Controls.Add(txtDescription1);
            this.flowLayoutPanel1.Controls.Add(txtName1);
            this.flowLayoutPanel1.Controls.Add(btnAdd1);

        }
    }
}
