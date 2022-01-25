using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List_Tracker.Events
{
    class ReturnBackToRecipeEventArgs : EventArgs
    {
        private Recipe _recipe = null;
        public ReturnBackToRecipeEventArgs(Recipe recipe)
        {
            _recipe = recipe;
        }

        public Recipe getRecipe
        {
            get
            {
                return _recipe;
            }
        }
    }
}
