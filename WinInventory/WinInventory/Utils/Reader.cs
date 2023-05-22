using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace WinInventory.Utils
{
    public class Reader
    {
        public static string UserOrPassReader(string fileName)
        {
            string rootFolder = PathFinder.solutionDirectory().ToString() + @"\infos\";
            bool exists = Directory.Exists(rootFolder);
            string textFile = rootFolder + fileName + ".txt";

            if(!exists) 
            {
                Directory.CreateDirectory(rootFolder);
            }

            if(File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                return text;
            }
            else
            {
                return "Erro na Leitura dos txt";
            }
        }

        public static string InfoReader(string fileName)
        {
            string rootFolder = PathFinder.solutionDirectory().ToString() + @"\colecteds\";
            bool exists = Directory.Exists(rootFolder);
            string textFile = rootFolder + fileName + ".txt";

            if (!exists)
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                return text;
            }
            else
            {
                return "Erro na Leitura dos txt";
            }
        }

        public static string teste(string fileName)
        {
            string rootFolder = PathFinder.solutionDirectory().ToString() + @"\colecteds\";
            bool exists = Directory.Exists(rootFolder);
            string textFile = rootFolder + fileName + ".txt";

            if (!exists)
                Directory.CreateDirectory(rootFolder);

            return textFile;
        }
        
    }
}
