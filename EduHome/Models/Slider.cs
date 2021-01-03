using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(255), Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
