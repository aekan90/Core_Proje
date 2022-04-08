using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        public IActionResult AddPortfolio()
        {
            ViewBag.Url1 = "Proje Ekle";
            ViewBag.Url2 = "Portfolio";
            ViewBag.Url3 = "AddPortfolio";
            return View();
        }


        [HttpPost] // portfolio ekleme kısmında taghelper kullanmadığım için bıraktım
        public IActionResult AddPortfolio(Portfolio portfolio) // Yeni Proje Ekle - Post
        {
            ViewBag.Url1 = "Proje Ekle";
            ViewBag.Url2 = "Portfolio";
            ViewBag.Url3 = "AddPortfolio";

            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResult = portfolioValidator.Validate(portfolio);
            if (validationResult.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
            Portfolio veri = portfolioManager.TGetById(id);
            return View(veri);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio) // Proje Güncelle - GET(urlden)
        {



            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResult = portfolioValidator.Validate(portfolio);
            if (validationResult.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}
