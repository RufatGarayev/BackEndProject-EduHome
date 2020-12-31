using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public string CompletedPercent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public ICollection<TeacherSkillSkill> TeacherSkillSkills { get; set; }
    }
}
