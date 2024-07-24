using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBlogInterface
    {
        Task<dynamic> BlogCategory(BlogCategory req);
        Task<dynamic> BlogTags(BlogTags req);
        Task<dynamic> BlogPost(BlogPost req);
        Task<dynamic> BlogPostTags(PostTag req);
        Task<dynamic> Bus(Bus request);
        Task<dynamic> AssignBus(AssignBus request);

    }
}
