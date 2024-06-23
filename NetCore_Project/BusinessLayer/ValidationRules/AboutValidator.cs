using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Phone).MinimumLength(5).WithMessage("Proje Adı En Az 11 Karakter İçermeli");
            RuleFor(x => x.Phone).MaximumLength(12).WithMessage("Proje Adı En Fazla 12 Karakter İçermeli");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Alanı Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
        }
    }
}
