using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class CoursesDetailsVM
    {
        public List<CourseFeature> CourseFeatures { get; set; }
        public BlogBanner BlogBanner { get; set; }
        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public LeaveMessage LeaveMessage { get; set; }
        public List<CoursesWeOffer> CoursesWeOffers { get; set; }
        public List<LatestFromBlog> LatestFromBlogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
    }
}
