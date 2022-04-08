using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.Url1 = "Deneyimler";
            ViewBag.Url2 = "Experience";

            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience() // Yeni Deneyim Ekle - Get
        {
            ViewBag.Url1 = "Deneyim Ekle";
            ViewBag.Url2 = "Experience";
            ViewBag.Url3 = "AddExperience";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience) // Yeni Yetenek Ekle - Post
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet] // bunu yazmasan da olur varsayılanı HttpGet zaten, ama sen yaz
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id) // Deneyim Güncelle - GET(urlden)
        {
            ViewBag.Url1 = "Deneyim Güncelleme";
            ViewBag.Url2 = "Experience";
            ViewBag.Url3 = "EditExperience";
            Experience veri = experienceManager.TGetById(id);
            return View(veri);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience) // Deneyim Güncelle - GET(urlden)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
