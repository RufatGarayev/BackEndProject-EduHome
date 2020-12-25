using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required, StringLength(70)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        [Required]
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
