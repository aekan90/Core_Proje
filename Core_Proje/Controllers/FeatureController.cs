using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Url1 = "Öne Çıkan";
            ViewBag.Url2 = "Feature";
            ViewBag.Url3 = "";

            List<Feature> featureList = featureManager.TGetList();
            return View(featureList[0]);
        }

        [HttpPost]
        public IActionResult Index(Feature feature) // Öne Çıkan Güncelle - POST(on form)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
