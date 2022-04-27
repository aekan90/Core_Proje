using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {// AspNetUsers tablosundaki sütunlara karşılık gelen propertyler
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Parola Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Parolayı Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Eposta Giriniz")]
        public string Email { get; set; }
    }
}
