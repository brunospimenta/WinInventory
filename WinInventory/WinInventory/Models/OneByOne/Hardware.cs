using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInventory.Models.OneByOne
{
    public class Hardware
    {
        public string ManufacturerAndModel { get; set; }
        public string mRam { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public string MotherBoard { get; set; }
        public string ProductID { get; set; }
        public string GraphicCard { get; set; }
        public string Display { get; set; }

        public override string ToString()
        {
            return "ManufacturerAndModel=" + ManufacturerAndModel + ", mRam=" + mRam + ", Processor=" + Processor + ", HardDisk=" + HardDisk +
                ", MotherBoard=" + MotherBoard + ", ProductID=" + ProductID + ", GraphicCard=" + GraphicCard + ", Display=" + Display;
        }
    }
}
