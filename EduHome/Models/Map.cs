using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Map
    {
        public int Id { get; set; }
        public int Year { get; set; }
        [Required]
        public string EmbedLink { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
