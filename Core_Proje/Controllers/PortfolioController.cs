using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.Url1 = "Projeler";
            ViewBag.Url2 = "Portfolio";

            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio() // Yeni Proje Ekle - Get
        {
            ViewBag.Url1 = "Proje Ekle";
            ViewBag.Url2 = "Portfolio";
            ViewBag.Url3 = "AddPortfolio";
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio) // Yeni Proje Ekle - Post
        {
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        [HttpGet] // bunu yazmasan da olur varsayılanı HttpGet zaten, ama sen yaz
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetById(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id) // Proje Güncelle - GET(urlden)
        {
            ViewBag.Url1 = "Proje Güncelleme";
            ViewBag.Url2 = "Portfolio";
            ViewBag.Url3 = "EditPortfolio";
            var values = portfolioManager.TGetById(id);
            List<Portfolio> veri = new List<Portfolio>
            {
                values
            };
            return View(veri);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio) // Proje Güncelle - GET(urlden)
        {
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }

    }
}
