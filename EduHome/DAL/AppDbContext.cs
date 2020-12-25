using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DAL
{
    public class AppDbContext:DbContext
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
    }
}
