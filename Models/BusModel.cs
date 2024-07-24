using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bus
    {
        public int BusID { get; set; }
        public string IsActive { get; set; }
        public string BusNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverContact { get; set; }
        public string Flag { get; set; }
        public int UserID { get; set; }
        public int SchID { get; set; }
    }

}
