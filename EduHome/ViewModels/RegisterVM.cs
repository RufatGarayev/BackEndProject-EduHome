using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]      //DataType(DataType.EmailAddress)-email type oldugunu bildirir ve qadagalar qoyur
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]          //DataType(DataType.Password)-password type oldugunu bildirir
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }
        
    }
}
