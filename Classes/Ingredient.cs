using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker
{
    public class Ingredient
    {
        public string name
        {
            get;set;
        }
        public int qty
        {
            get;set;
        }
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

        public Ingredient()
        {
            name = "";
            qty = 0;

        }
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
