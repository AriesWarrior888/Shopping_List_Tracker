using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    public class MultiplePlans
    {
        //mealList should always have sunday 
        public List<MealPlan> mealList
        {
            get;set;
        }
        

        public MultiplePlans()
        {
            mealList = new List<MealPlan>();
        }

        public MultiplePlans(List<MealPlan> list)
        {
            mealList = list;
        }
    }
}
