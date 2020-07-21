using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class FaturaDetayValidator:AbstractValidator<FaturaDetay>
    {
        public FaturaDetayValidator()
        {
            RuleFor(p => p.Tutar).NotEmpty().WithMessage("Tutarı Giriniz");
            RuleFor(p => p.Miktar).NotEmpty().WithMessage("Miktarı Giriniz");
            RuleFor(p => p.Fiyat).NotEmpty().WithMessage("Fiyatı Giriniz");
        }
    }
}
