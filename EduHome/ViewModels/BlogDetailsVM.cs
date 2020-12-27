﻿using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class BlogDetailsVM
    {
        public List<Category> Categories { get; set; }
        public BlogBanner BlogBanner { get; set; }
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
        public Explaining Explaining { get; set; }
    }
}
