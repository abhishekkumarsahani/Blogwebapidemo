using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class AssignBus
    {
        public int UserID { get; set; }
        public int SchID { get; set; }
        public int ImeiID { get; set; }
        public string Flag { get; set; }
        public int BusID { get; set; }
        public List<Student> Students { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public int AssignedID { get; set; }
    }

}
