using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı Adını Boş Geçemezsiniz");
            RuleFor(x => x.PersonSurname).NotEmpty().WithMessage("Takım Arkadaşı Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.PersonName).MaximumLength(25).WithMessage("Lütfen 25 Karakterden Daha Az Veri Girişi Yapınız");
            RuleFor(x => x.PersonSurname).MaximumLength(25).WithMessage("Lütfen 25 Karakterden Daha Az Veri Girişi Yapınız");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen en az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.PersonSurname).MinimumLength(5).WithMessage("Lütfen 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Title).MaximumLength(25).WithMessage("Lütfen 25 Karakterden Daha Az Veri Girişi Yapınız");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 Karakter Veri Girişi Yapınız");
        }
    }
}
