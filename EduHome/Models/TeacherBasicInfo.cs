using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherBasicInfo
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public int OurTeacherId { get; set; }
        public OurTeacher OurTeacher { get; set; }
    }
}
