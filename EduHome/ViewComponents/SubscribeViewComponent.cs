﻿using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class SubscribeViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public SubscribeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            SubscribeVM subscribe = new SubscribeVM()
            {
                Subscribe = _context.Subscribes.FirstOrDefault()
            };
            return View(await Task.FromResult(subscribe));
        }
    }
}
