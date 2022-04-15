using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        // partial view view içinda .cshtml olarak tutulur.
        // controller da çalışır
        // layouttan çağırılır
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        //public PartialViewResult PartialFooter()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult PartialNavbar()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult PartialHead()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult PartialScript()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult PartialHeader() // eğitimde NavigationPartial adını veriyor
        //{
        //    return PartialView();
        //}
    }
}
