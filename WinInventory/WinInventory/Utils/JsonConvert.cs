using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinInventory.Models;

namespace WinInventory.Utils
{
    public class JsonConvert
    {
        public static void CStoJson(string saida, Geral obj)
        {
            var jsonFormattedContent = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            string fileName = PathFinder.solutionDirectory().ToString() + $@"\json\{saida}.json";

            File.WriteAllText(fileName, jsonFormattedContent);
        }      


    }
}
