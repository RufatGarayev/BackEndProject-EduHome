using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class TeacherDetailsVM
    {
        public TeacherBasicInfo TeacherBasicInfo { get; set; }
        public TeacherContactInfo TeacherContactInfo { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public List<TeacherSkillSkill> TeacherSkillSkills { get; set; }
    }
}
