using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Utils
{
    public class FolderCreator
    {
        private static string rootFolder = PathFinder.solutionDirectory().ToString();
        public static void Create()
        { 
            bool infoExists = Directory.Exists(rootFolder + @"\infos\");
            bool colectedsExists = Directory.Exists(rootFolder + @"\colecteds\");
            bool jsonExists = Directory.Exists(rootFolder + @"\json\");

            if (!infoExists)
                Directory.CreateDirectory(rootFolder + @"\infos\");
            if (!colectedsExists)
                Directory.CreateDirectory(rootFolder + @"\colecteds\");
            if (!jsonExists)
                Directory.CreateDirectory(rootFolder + @"\json\");
        }
    }
}
