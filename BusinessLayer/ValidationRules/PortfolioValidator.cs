using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator() // kısıtlamalar contructor içine yazılır
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");
            RuleFor(x => x.SmallImageUrl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");
            RuleFor(x => x.Url).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Proje Adı Minimum 3 karakter olmalı");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı Maximum 100 karakter olmalı");
        }
    }
}
