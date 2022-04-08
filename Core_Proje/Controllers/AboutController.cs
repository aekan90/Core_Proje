using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Url1 = "Hakkımda";
            ViewBag.Url2 = "About";

            List<About> AboutList = aboutManager.TGetList();
            return View(AboutList[0]);
        }

        [HttpPost]
        public IActionResult Index(About about) // Öne Çıkan Güncelle - POST(on form)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
