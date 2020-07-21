using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunAd).NotEmpty().WithMessage("Ürün Ad Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Marka).NotEmpty().WithMessage("Marka Alanı Boş Bırakılamaz");
            RuleFor(p=>p.Model).NotEmpty().WithMessage("Model Alanı Boş Bırakılamaz");
            RuleFor(p => p.Yil).NotEmpty().WithMessage("Yıl Alanı Boş Bırakılamaz").LessThan(2021).WithMessage("Yıl Alanı 2021 Yılından Küçük Olmalı");
            RuleFor(p => p.Adet).GreaterThan(0).WithMessage("Adet Alanı Boş Bırakılamaz veya Sıfırdan(0) Büyük Değer Olmalı");
            RuleFor(p => p.Maliyet).GreaterThan(0).NotEmpty().WithMessage("Maliyet Alanı Boş Bırakılamaz veya Sıfırdan(0) Büyük Değer Olmalı");
            RuleFor(p => p.SatisFiyat).GreaterThan(0).NotEmpty().WithMessage("Satış Fiyatı Alanı Boş Bırakılamaz veya Sıfırdan(0) Büyük Değer Olmalı");
        }
    }
}
