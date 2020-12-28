using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TakeAVideoTour
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        [Required]
        public string Video { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        //public int CoursesId { get; set; }
        //public Courses Courses { get; set; }
    }
}
