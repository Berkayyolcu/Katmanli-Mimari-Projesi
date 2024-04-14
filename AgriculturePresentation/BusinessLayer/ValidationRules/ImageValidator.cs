using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator:AbstractValidator<Image>
    {
        public ImageValidator() 
        {
            RuleFor(X => X.Title).NotEmpty().WithMessage("Başlığını Boş Geçemezsiniz");
            RuleFor(X => X.Description).NotEmpty().WithMessage("Açıklama Boş Geçemezsiniz");
            RuleFor(X => X.ImageUrl).NotEmpty().WithMessage("Resim Kısmını Boş Geçemezsiniz");
            RuleFor(X => X.Title).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapın");
            RuleFor(X => X.Title).MinimumLength(8).WithMessage("Lütfen En Az 8 Karakter Veri Girişi Yapın");
            RuleFor(X => X.Description).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Veri Girişi Yapın");
            RuleFor(X => X.Description).MinimumLength(15).WithMessage("Lütfen En Az 15 Karakter Veri Girişi Yapın");
        }
    }
}
