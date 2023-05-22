using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Models.OneByOne
{
    public class Drivers
    {
        public string AntiVirus { get; set; }
        public string Firewall { get; set; }
        public string Proxy { get; set; }

        public override string ToString()
        {
            return "Antivirus=" + AntiVirus + ", Firewall=" + Firewall + ", Proxy=" + Proxy;
        }
    }
}
