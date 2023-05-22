using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Models.OneByOne
{
    public class SystemInfo
    {
        public string Hostname { get; set; }
        public string OS { get; set; }
        public string InstallDate { get; set; }
        public DateTime FirstSync { get; set; }
        public string LastUserName { get; set; }
        public string Domain { get; set; }
        public string IP { get; set; }
        public string UpTime { get; set; }

        public override string ToString()
        {
            return "Hostname=" + Hostname + ", OS=" + OS + ", InstallDate=" + InstallDate + ", FirstSync=" + FirstSync +
                ", LastUserName=" + LastUserName + ", Domain=" + Domain + ", IP=" + IP +
                ", UpTime=" + UpTime;
        }
    }
}
