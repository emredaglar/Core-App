﻿using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
    public class FeatureStatistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = context.Experiences.Count();
            return View();
        }
    }
}