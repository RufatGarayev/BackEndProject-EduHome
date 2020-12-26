using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class CoursesDetailsVM
    {
        public List<CoursesText> CoursesTexts { get; set; }
        public CourseFeature CourseFeature { get; set; }
        public BlogBanner BlogBanner { get; set; }
        public List<Post> Posts { get; set; }
    }
}
