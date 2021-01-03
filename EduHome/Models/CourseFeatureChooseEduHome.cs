using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFeatureChooseEduHome
    {
        public int Id { get; set; }

        public int CourseFeatureId { get; set; }
        public CourseFeature CourseFeature { get; set; }

        public int ChooseEduHomeId { get; set; }
        public ChooseEduHome ChooseEduHome { get; set; }
    }
}
