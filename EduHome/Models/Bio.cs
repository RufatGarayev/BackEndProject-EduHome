using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string HeaderLogo { get; set; }
        [Required]
        public string FooterLogo { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
    }
}
