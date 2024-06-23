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
        public PortfolioValidator() 
        {
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakter İçermeli"); 
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Proje Adı En Fazla 50 Karakter İçermeli"); 
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Alanı Boş Geçilemez");
            RuleFor(x => x.Url).NotEmpty().WithMessage("Proje Url Boş Geçilemez");
        }
    }
}
