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
            gram = 0,
            count = 1
        }

        public UnitOfMeasurement measurement
        {
            get;set;
        }

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

    }
}
