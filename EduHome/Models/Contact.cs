using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Location { get; set; }
        [Required, StringLength(200)]
        public string Phone { get; set; }
        public string Website { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
