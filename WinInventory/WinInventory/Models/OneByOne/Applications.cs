using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Models.OneByOne
{
    public class Applications
    {
        public string AllApplications { get; set; }

        public override string ToString()
        {
            return "Appliucations=" + AllApplications;
        }
    }
}
