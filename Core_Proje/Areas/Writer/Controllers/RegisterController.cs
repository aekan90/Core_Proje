using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager; // UserManager : Identity sınıfı

        // Dependency Injection kullanmamız gerekiyor, class ismine ctrl+. --> Generate Constructor
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] // burası çok önemli burayı mutlaka anla ve kendin yazabilir hale gel
        public async Task<IActionResult> Index(UserRegisterViewModel _userRegisterViewModel)
        {// AspNetUsersTablosu.sütunlar'a--> RegisterViewModel.propertiler
         // modelden gelen değerlerin ataması yapılıyor
         // eşleştirilerek bir kayıt yapılmak isteniyor.
         // bunun için bize bir model nesnesi bir de db nesnesi gerekli


            //if (!ModelState.IsValid)
            //{

            WriterUser writerUser = new WriterUser()
            {// WriterUser.propertyleri = AspNetUsersTablosu.sütunları
                Name = _userRegisterViewModel.Name,
                Surname = _userRegisterViewModel.Surname,
                ImageUrl = _userRegisterViewModel.ImageUrl,
                UserName = _userRegisterViewModel.UserName,
                Email = _userRegisterViewModel.Email,
            };


            if (_userRegisterViewModel.Password == _userRegisterViewModel.ConfirmPassword)
            {
                // _userManager vasıtası ile oluşturulan _writerUser --> AspNetUser tablosuna yazılıyor
                var result = await _userManager.CreateAsync(writerUser, _userRegisterViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(_userRegisterViewModel);
            //}
        }
    }
}
