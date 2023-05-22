using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinInventory.Models.OneByOne;

namespace WinInventory.Models
{
    public class Geral
    {
        public string DeviceId { get; set; }
        public float ExecutionTime { get; set; }

        public Drivers Drivers { get; set; }
        public Hardware Hardware { get; set; }
        public Applications Applications { get; set; }
        public SystemInfo SystemInfo { get; set; }
        public Devices Devices { get; set; }

        public override string ToString()
        {
            return "DeviceID=" + DeviceId + ", Timer=" + ExecutionTime + ", OperationalSystemInfo=" + SystemInfo + ", Hardware=" + Hardware + ", Devices=" + Devices +
                ", DriversAndOthers=" + Drivers + ", Applications=" + Applications;
        }
    }
}
