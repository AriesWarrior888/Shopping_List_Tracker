using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker
{
    class Ingredient
    {
        private string name;
        private int qty;
        public enum UnitOfMeasurement
        {
            Cup = 0,
            Ounce = 1,
            Pint = 2,
            Gallon = 3,
            Tablespoon = 4,
            Teaspoon = 5,
        }

        private UnitOfMeasurement measurement;

        public Ingredient(string name, int qty, UnitOfMeasurement uom)
        {
            this.name = name;
            this.qty = qty;
            measurement = uom;
        }

        public void setUOM(UnitOfMeasurement unitOfMeasurement)
        {
            measurement = unitOfMeasurement;
        }
    }
}
