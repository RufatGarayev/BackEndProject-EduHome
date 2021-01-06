using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public int LatestFromBlogId { get; set; }
        public LatestFromBlog LatestFromBlog { get; set; }
    }
}
