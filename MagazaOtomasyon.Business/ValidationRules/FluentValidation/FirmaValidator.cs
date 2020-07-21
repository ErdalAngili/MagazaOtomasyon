using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    class FirmaValidator:AbstractValidator<Firma>
    {
        public FirmaValidator()
        {
            RuleFor(p => p.FirmaAd).NotEmpty().WithMessage("Firma Adı Alanını Boş Bıraktınız.");
            RuleFor(p => p.YetkiliAdSoyad).NotEmpty().WithMessage("Yetkilinin Ad ve Soyad Alanını Boş Bıraktınız.");
            RuleFor(p => p.YetkiliStatu).NotEmpty().WithMessage("Yetkilinin Statü Alanını Boş Bıraktınız.");
            RuleFor(P => P.Sektor).NotEmpty().WithMessage("Sektör Alanını Boş Bıraktınız.");
            RuleFor(p => p.Telefon1).NotEmpty().WithMessage("Telefon 1 Alanını Boş Bıraktınız.");
            RuleFor(p => p.Telefon2).NotEmpty().WithMessage("Telefon 2 Alanını Boş Bıraktınız.");
            RuleFor(p => p.Il).NotEmpty().WithMessage("İl Alanını Boş Bırakılamaz");
            RuleFor(p => p.Ilce).NotEmpty().WithMessage("İlce Alanını Boş Bırakılamaz");
            RuleFor(p => p.Adres).NotEmpty().WithMessage("Adres Alanını Boş Bırakılamaz");
        }
    }
}
