using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class PersonelValidator: AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.Ad).NotEmpty().WithMessage("Ad Alanını Boş Bıraktınız.");
            RuleFor(p => p.Soyad).NotEmpty().WithMessage("Soyad Alanını Boş Bıraktınız.");
            RuleFor(p => p.Tc).NotEmpty().WithMessage("TC Alanını Boş Bıraktınız.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Alanını Boş Bıraktınız.");
            RuleFor(p => p.Gorev).NotEmpty().WithMessage("Görev Alanını Boş Bıraktınız.");
            RuleFor(p => p.Il).NotEmpty().WithMessage("Telefon Alanını Boş Bıraktınız.");
            RuleFor(p => p.Ilce).NotEmpty().WithMessage("Telefon Alanını Boş Bıraktınız.");
        }
    }
}
