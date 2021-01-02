using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class BlogDetailsVM
    {
        public List<LatestFromBlog> LatestFromBlogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Category> Categories { get; set; }
        public List<BlogBanner> BlogBanners { get; set; }
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Explaining> Explainings { get; set; }
    }
}
