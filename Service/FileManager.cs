using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shopping_List_Tracker
{
    public static class FileManager
    {
        public static bool ReadFromFile(string fileName, out string results)
        {
            var path = fileName;

            try
            {
                results = File.ReadAllText(path);
                return true;
            }

            catch(Exception e)
            {
                Console.WriteLine($"Failed to read from file {fileName} with exception {e}");
                results = "";
                return false;
            }
        }

        public static bool WriteToFile(string fileName, string contents)
        {
            var path = fileName;

            try
            {
                File.WriteAllText(path, contents);
                return true;
            }

            catch(Exception e)
            {
                Console.WriteLine($"Writing to write to file {fileName} with exception {e}");
                return false;
            }
        }
    }
}
