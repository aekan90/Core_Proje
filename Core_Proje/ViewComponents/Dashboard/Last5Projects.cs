﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            // verilerden 5 tanesi lazımdı view tarafında sayaç ile hallettim
            // ancak veri fazlaysa bu yöntemi deneme bile şöyle yap;
            // Context--> ViewBag v1= c.Messages.Take(1).ToList();
            // (c.Services.ToList().Take(1) değil)
            return View(values);
        }
    }
}
