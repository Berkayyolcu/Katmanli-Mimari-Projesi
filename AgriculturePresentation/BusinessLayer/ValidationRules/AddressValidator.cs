using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator:AbstractValidator<Address>
    {
       public AddressValidator() 
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama Boş Gecilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama Boş Gecilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama Boş Gecilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama Boş Gecilemez");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarası Boş Gecilemez");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Harita Bilgisi Boş Gecilemez");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("Lütfen 25'den Fazla Karakter Girmeyiniz ");      
        }
    }
}
