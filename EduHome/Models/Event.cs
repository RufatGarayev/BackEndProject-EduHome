using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime? Day { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Venue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
