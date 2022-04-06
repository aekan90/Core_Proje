using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList :ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal()); // başka bişe denedim normali böyle değil
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

    }
}
