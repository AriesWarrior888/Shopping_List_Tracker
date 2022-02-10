using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shopping_List_Tracker.Events;

namespace Shopping_List_Tracker
{
    public class MealPlan
    {
        public Recipe recipe
        {
            get;set;
        }
        public int qty
        {
            get; set;
        }

        public string date
        {
            get;set;
        }



        public MealPlan()
        {
            recipe = new Recipe();
            qty = 0;
            date = "";
        }

        public MealPlan(Recipe recipe, int qty, string date)
        {
            this.recipe = recipe;
            this.qty = qty;
            this.date = date;
        }
    }
}
