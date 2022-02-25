using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Shopping_List_Tracker
{
    public static class FileManager
    {
        public static bool ReadFromFile(string fileName, out string results)
        {

            try
            {
                results = File.ReadAllText(fileName);
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

            try
            {
                File.WriteAllText(fileName, contents);
                return true;
            }

            catch(Exception e)
            {
                Console.WriteLine($"Failed in writing to write to file {fileName} with exception {e}");
                return false;
            }
        }

        
    }
}
