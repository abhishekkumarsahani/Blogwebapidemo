using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BlogPost
    {
        public int BlogsID { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Post { get; set; }
        public string FeatImg { get; set; } // Path or URL of the featured image
        public string Excerpt { get; set; }
        public string Meta { get; set; }
        public string Flag { get; set; }
        public bool IsVideoFeat { get; set; } // Indicates if the post is a featured video
        public int PostView {  get; set; }
        public bool IsPublished { get; set; } // Indicates if the post is published
    }

}
