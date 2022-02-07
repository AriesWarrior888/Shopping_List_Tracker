using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    public class Storage
    {
        public Ingredient ingredient
        {
            get; set;
        }
        public int quantity
        {
            get; set;
        }
        public Storage()
        {
            ingredient = new Ingredient();
            quantity = 0;
        }

        public Storage(int quantity, Ingredient ingredient)
        {
            this.ingredient = ingredient;
            this.quantity = quantity;
        }

    }
}
