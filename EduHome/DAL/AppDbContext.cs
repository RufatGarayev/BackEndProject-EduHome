using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<SectionDescription> SectionDescriptions { get; set; }
        public DbSet<ChooseEduHome> ChooseEduHomes { get; set; }
        public DbSet<CoursesWeOffer> CoursesWeOffers { get; set; }
        public DbSet<UpcomingEvent> UpcomingEvents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LatestFromBlog> LatestFromBlogs { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<WelcomeToEduHome> WelcomeToEduHomes { get; set; }
        public DbSet<TakeAVideoTour> TakeAVideoTours { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<OurTeacher> OurTeachers { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<CoursesText> CoursesTexts { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<BlogBanner> BlogBanners { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Explaining> Explainings { get; set; }
        public DbSet<TeacherBasicInfo> TeacherBasicInfos { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfos { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<LeaveMessage> LeaveMessages { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<TeacherSkillSkill> TeacherSkillSkills { get; set; }
        public DbSet<WorkShopSpeaker> WorkShopSpeakers { get; set; }
    }
}
