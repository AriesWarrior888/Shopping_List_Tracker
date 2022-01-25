using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker
{
    class Recipe
    {
        private string name
        {
            get;set;
        }
        private int servingAmount
        {
            get;set;
        }
/*        private List<Ingredient> ingredients
        {
            get;set;
        }*/
        private string description
        {
            get;set;
        }
        public Recipe(string name, int servingAmount, string description)
        {
            this.name = name;
            this.servingAmount = servingAmount;
            this.description = description;
        }
        public Recipe()
        {
            name = "";
            servingAmount = 0;
            description = "";
        }
    }
}
