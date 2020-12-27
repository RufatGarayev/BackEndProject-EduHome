﻿using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class EventDetailsVM
    {
        public WorkShop WorkShop { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<Category> Categories { get; set; }
        public BlogBanner BlogBanner { get; set; }
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
    }
}