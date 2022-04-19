using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.MessageList
{
    public class MessageList : ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var messages = userMessageManager.TGetList();
            return View(messages);
        }
    }
}
