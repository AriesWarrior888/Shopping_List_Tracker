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

        public DateTime date
        {
            get;set;
        }



        public MealPlan()
        {
            recipe = new Recipe();
            qty = 0;
            date = new DateTime();
        }

        public MealPlan(Recipe recipe, int qty, string date)
        {
            this.recipe = recipe;
            this.qty = qty;
            this.date = DateTime.Parse(date, new System.Globalization.CultureInfo("en-US"));
        }
    }
}
