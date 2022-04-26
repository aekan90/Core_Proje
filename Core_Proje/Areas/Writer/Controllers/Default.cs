using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
