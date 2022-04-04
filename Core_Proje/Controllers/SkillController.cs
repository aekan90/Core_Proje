using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill() // Yeni Yetenek Ekle - Get
        {
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill) // Yeni Yetenek Ekle - Post
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
    }
}
