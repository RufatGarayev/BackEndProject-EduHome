using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class WorkShopSpeaker
    {
        public int Id { get; set; }

        public int WorkShopId { get; set; }
        public WorkShop WorkShop { get; set; }

        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}
