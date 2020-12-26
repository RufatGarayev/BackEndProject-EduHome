using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class AboutVM
    {
        public WelcomeToEduHome WelcomeToEduHome { get; set; }
        public List<OurTeacher> OurTeachers { get; set; }
        public List<Student> Students { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public TakeAVideoTour TakeAVideoTour { get; set; }
    }
}
