using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Utils
{
    public class CredentialsCreator
    {
        static string path = PathFinder.solutionDirectory() + @"\infos\";
        static string fileWithPath = path + "user.txt";
        static bool exists = Directory.Exists(path);

        public static void createUsernameFile(string user)
        {
            if(!exists)
                Directory.CreateDirectory(path);

            File.WriteAllText(fileWithPath, user);
        }

        public static void createPasswordFile() 
        {
            if(!exists)
                Directory.CreateDirectory(path);
        }
    }
}
