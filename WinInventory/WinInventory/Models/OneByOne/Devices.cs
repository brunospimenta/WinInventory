using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Models.OneByOne
{
    public class Devices
    {
        public string AudioDevice { get; set; }
        public string NetworkAdapter { get; set; }
        public string Others { get; set; }

        public override string ToString()
        {
            return "AudioDevice=" + AudioDevice + ", NetworkAdapter=" + NetworkAdapter + ", Others=" + Others;
        }
    }
}
