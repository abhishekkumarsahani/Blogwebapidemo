using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BlogTags
    {
        public int TagsID { get; set; }
        public int UserID { get; set; }
        public string TagName { get; set; }
        public string Slug { get; set; }
        public bool IsTrending { get; set; }
        public string Flag { get; set; }
    }
}
