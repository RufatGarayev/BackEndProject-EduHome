using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class UpcomingEvent  
    {
        public int Id { get; set; }
        [Required, StringLength(70)]
        public string Title { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string TimeSpan { get; set; }
        [Required]
        public string Location { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
