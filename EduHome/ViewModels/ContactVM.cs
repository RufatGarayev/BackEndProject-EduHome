using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class ContactVM
    {
        public Map Map { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
