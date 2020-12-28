using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        public DateTime? Starts { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int Students { get; set; }
        public string Assesments { get; set; }
        public int CourseFee { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        //[ForeignKey("CoursesWeOffers")]
        //public int CoursesWeOfferId { get; set; }
        //public virtual CoursesWeOffer CoursesWeOffer { get; set; }
    }
}
