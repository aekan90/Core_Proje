using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }
    }
}
