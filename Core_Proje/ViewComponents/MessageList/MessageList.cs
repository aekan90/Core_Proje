using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.MessageList
{
    public class MessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
