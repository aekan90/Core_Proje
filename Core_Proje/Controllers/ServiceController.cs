using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.Url1 = "Hizmetler";
            ViewBag.Url2 = "Service";

            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService() // Yeni Hizmet Ekle - Get - on url
        {
            ViewBag.Url1 = "Hizmet Ekle";
            ViewBag.Url2 = "Service";
            ViewBag.Url3 = "AddService";
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service) // Yeni Yetenek Ekle - Post - on form
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet] // bunu yazmasan da olur varsayılanı HttpGet zaten, ama sen yaz
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetById(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id) // Hizmet Güncelle - GET(urlden)
        {
            ViewBag.Url1 = "Hizmet Güncelleme";
            ViewBag.Url2 = "Experience";
            ViewBag.Url3 = "EditExperience";
            Service veri = serviceManager.TGetById(id);
            return View(veri);
        }

        [HttpPost]
        public IActionResult EditService(Service service) // Hizmet Güncelle - GET(urlden)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
