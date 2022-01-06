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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        public void setControls()
        {
            
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            Recipe frmRecipe = new Recipe();
            frmRecipe.ShowDialog();
        }
    }
}
