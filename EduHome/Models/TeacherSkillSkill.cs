using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherSkillSkill
    {
        public int Id { get; set; }

        public int OurTeacherId { get; set; }
        public OurTeacher OurTeacher { get; set; }

        public int TeacherSkillId { get; set; }
        public TeacherSkill TeacherSkill { get; set; }
    }
}
