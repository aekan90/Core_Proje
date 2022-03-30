using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()  // MVC de ActionResult .core da IActionResult
        {
            return View();
        }

        // Head Tagının olduğu kısmı ayırarak partial view olarak göstermek istedik
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // Mesajın kaydedildiği tarihi DB ye yaz
            p.Status = true; // Okunduktan sonra false yapacaz
            messageManager.TAdd(p);
            return PartialView();
        }
    }
}
