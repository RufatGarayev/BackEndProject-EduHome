using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class OurTeacher     //---TEACHER---//
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public TeacherContactInfo TeacherContactInfo { get; set; }
        public TeacherBasicInfo TeacherBasicInfo { get; set; }
    }
}
