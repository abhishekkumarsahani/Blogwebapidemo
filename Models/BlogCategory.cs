using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BlogCategory
    {
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string CategoryIcon { get; set; }
        public bool IsPrimary { get; set; }
        public string Flag { get; set; }
    }
    }
