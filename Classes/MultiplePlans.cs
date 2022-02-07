using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    public class MultiplePlans
    {
        private List<MealPlan> mealList
        {
            get;set;
        }
        private string date
        {
            get;set;
        }

        public MultiplePlans()
        {
            mealList = new List<MealPlan>();
            date = "0/0/0000 0:00:00 AM";
        }

        public MultiplePlans(List<MealPlan> list, string date)
        {
            mealList = list;
            this.date = date;
        }
    }
}
