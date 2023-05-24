using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Utils
{
    public class CredentialsCreator
    {
        private static string path = PathFinder.solutionDirectory() + @"\infos\";
        private static string userPath = path + "user.txt";
        private static bool exists = Directory.Exists(path);

        public static void createUsernameFile(string user)
        {
            if(!exists)
                Directory.CreateDirectory(path);

            File.WriteAllText(userPath, user);
        }

        public static void createPasswordFile() 
        {
            if(!exists)
                Directory.CreateDirectory(path);
        }
    }
}
