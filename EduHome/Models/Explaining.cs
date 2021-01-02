using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Explaining     //---Blog.Explaining---//
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public Post Post { get; set; }
    }
}
