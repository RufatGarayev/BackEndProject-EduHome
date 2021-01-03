using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<SectionDescription> SectionDescriptions { get; set; }
        public ChooseEduHome ChooseEduHome { get; set; }
        public List<CoursesWeOffer> CoursesWeOffers { get; set; }
        public List<Student> Students { get; set; }
        public List<LatestFromBlog> LatestFromBlogs { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<WorkShop> WorkShops { get; set; }
        public List<Event> Events { get; set; }

        //public List<UpcomingEvent> UpcomingEvents { get; set; }
    }
}
