using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker.Events
{
    public class ReturnBackToRecipeEventArgs : EventArgs
    {
        private List<Control> _list= null;
        public ReturnBackToRecipeEventArgs(List<Control> list)
        {
            _list = list;
        }

        public List<Control> GetList
        {
            get
            {
                return _list;
            }
        }
    }
}
