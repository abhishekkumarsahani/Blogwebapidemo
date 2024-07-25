using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AssignBus
    {
        public int UserID { get; set; }
        public string Flag { get; set; }
        public int BusID { get; set; }
        public List<Student> StudentDetails { get; set; } // List of student details for bulk insert
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public int? AssignedID { get; set; }
    }

}
