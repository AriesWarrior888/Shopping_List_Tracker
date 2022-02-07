using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shopping_List_Tracker.Events;

namespace Shopping_List_Tracker
{
    public class MealPlan
    {
        private Recipe recipe
        {
            get;set;
        }
        private int qty
        {
            get; set;
        }


        public MealPlan()
        {
            recipe = new Recipe();
            qty = 0;
        }

        public MealPlan(Recipe recipe, int qty)
        {
            this.recipe = recipe;
            this.qty = qty;
        }
    }
}
