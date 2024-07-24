using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AssignBus
    {
        public int AssignedID { get; set; }
        public int StudentID { get; set; }
        public int UserID { get; set; }
        public int BusID { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }       
        public string Flag { get; set; }
    }
}
