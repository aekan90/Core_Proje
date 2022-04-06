using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

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
    }
}
