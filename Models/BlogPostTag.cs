using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PostTag
    {
        public int PostTagsId { get; set; }
        public int UserID { get; set; }
        public int PostId { get; set; }
        public int TagsId { get; set; }
        public string Flag { get; set; }


    }

}
