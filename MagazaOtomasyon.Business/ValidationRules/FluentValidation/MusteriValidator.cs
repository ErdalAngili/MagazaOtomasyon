using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class MusteriValidator: AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(p=>p.Ad).NotEmpty().WithMessage("Müşteri Ad Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Soyad).NotEmpty().WithMessage("Müşteri Soyad Alanı Boş Bırakılamaz");
            RuleFor(p => p.Tc).NotEmpty().WithMessage("Müşteri T.C. Kimlik Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Telefon1).NotEmpty().WithMessage("Müşteri Telefon Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Telefon2).NotEmpty().WithMessage("Müşteri Telefon Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Il).NotEmpty().WithMessage("Müşteri Il Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Ilce).NotEmpty().WithMessage("Müşteri Ilce Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Adres).NotEmpty().WithMessage("Müşteri Adres Alanı Boş Bırakılamaz");
        }
    }
}
