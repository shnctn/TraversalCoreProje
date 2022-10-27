using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama  kısmını boş geçemezsiniz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("lğtfen  görsel seciniz...!");
            RuleFor(x=>x.Description).NotEmpty().MinimumLength(50).MaximumLength(1500).WithMessage("Mesajınız 50 ile 1500 karakter arasında olmaluıdır.");
        }
    }
}
