﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _featureManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            _featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
