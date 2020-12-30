using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class LatestFromBlog     //---BLOG---//
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Composer { get; set; }
        public DateTime? Date { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public BlogDetail BlogDetail { get; set; }
    }
}
