using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Description { get; set; }
        public string Composer { get; set; }
        public DateTime? Date { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        [ForeignKey("WorkShop")]
        public int WorkSopId { get; set; }
        public WorkShop WorkShop { get; set; }
    }
}
