using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var AllPortfolioList = portfolioManager.TGetList();
            return View(AllPortfolioList); // --> Views/Shared/SlideList/Default.cshtml ' de karşılanıyor. 
        }
    }
}
