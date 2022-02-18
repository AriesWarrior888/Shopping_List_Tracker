using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker
{
    public class Recipe
    {
        public List<Ingredient> ingredients
        {
            get;set;
        }
        
        //desearializer fails to deserialize guid as such string is used
        public Guid guid
        {
            get; set;
        }

        public string name
        {
            get; set;
        }
        public int servingAmount
        {
            get;set;
        }
        public string description
        {
            get;set;
        }
        public Recipe()
        {
            name = "";
            servingAmount = 0;
            description = "";
        }

        public Recipe(string name, int servingAmount, string description)
        {
            this.name = name;
            guid = Guid.NewGuid();
            ingredients = new List<Ingredient>();
            this.servingAmount = servingAmount;
            this.description = description;
        }



        public void addIngredients(Ingredient ingredients)
        {
            this.ingredients.Add(ingredients);
        }

        public void setIngredients(int location, Ingredient ingredient)
        {
            this.ingredients[location] = ingredient;         
        }
    }
}
