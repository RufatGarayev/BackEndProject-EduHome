using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class EventDetailsVM
    {
        public List<WorkShop> WorkShops { get; set; }
        public List<WorkShopSpeaker> WorkShopSpeakers { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<Category> Categories { get; set; }
        public List<BlogBanner> BlogBanners { get; set; }
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
        public List<LatestFromBlog> LatestFromBlogs { get; set; }
        public List<Event> Events { get; set; }
        public List<Explaining> Explainings { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
    }
}
