using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_Tracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Guid g = Guid.NewGuid();
            string s = g.ToString();
            Guid g2 = Guid.Parse(s);

            InitializeDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());
        }

        public static string ApplicationDirectory
        {
            get;set; 
        }

        private static void InitializeDirectory()
        {
            try
            {
                ApplicationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Shopping_List_Tracker";
                if(!System.IO.Directory.Exists(ApplicationDirectory))
                {
                    System.IO.Directory.CreateDirectory(ApplicationDirectory);
                }
            }
            catch
            {

            }
        }

    }
}
