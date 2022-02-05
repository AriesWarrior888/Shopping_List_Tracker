using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker
{
    public class Recipe
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        public Recipe()
        {
            name = "";
            servingAmount = 0;
            description = "";
        }

        public Recipe(string name, int servingAmount, string description)
        {
            this.name = name;
            this.servingAmount = servingAmount;
            this.description = description;
        }

        private string name;
        private int servingAmount;
        private string description;

        public void addIngredients(Ingredient ingredients)
        {
            this.ingredients.Add(ingredients);
        }

        public string getName()
        {
            return name;
        }

        public int getServingAmount()
        {
            return servingAmount;
        }

        public string getDescription()
        {
            return description;
        }

        public List<Ingredient> getIngredients()
        {
            return ingredients;
        }

    }
}
