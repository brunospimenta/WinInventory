using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Utils
{
    public class ThreadCmd
    {
        private static string  path = PathFinder.solutionDirectory().ToString() + @"\colecteds\";
        public static string comando(string comando, string nometxt, string user, SecureString pwd)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Domain = "";
            process.StartInfo.UserName = user;
            process.StartInfo.Password = pwd;

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine(comando + @$"> {path}\{nometxt}.txt");
            process.StandardInput.Flush();
            process.StandardInput.Close();

            Console.WriteLine($"arquivo {nometxt}.txt criado com sucesso");

            string saida = process.StandardOutput.ReadToEnd();
            return saida;
        }
    }
}
