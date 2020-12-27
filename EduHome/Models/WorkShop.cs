using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class WorkShop
    {
        public int Id { get; set; }
        public DateTime? Day { get; set; }
        [Required]
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime? TimeSpan { get; set; }
        [Required]
        public string Venue { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
