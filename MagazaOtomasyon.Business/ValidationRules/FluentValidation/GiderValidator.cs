using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class GiderValidator:AbstractValidator<Gider>
    {
        public GiderValidator()
        {
            RuleFor(p => p.Ay).NotEmpty().WithMessage("Ay Alanı Boş Bırakılamaz");
            RuleFor(p => p.Yil).NotEmpty().WithMessage("Yıl Alanı Boş Bırakılamaz");
            RuleFor(p => p.Dogalgaz).NotEmpty().WithMessage("Doğal Gaz Alanı Boş Bırakılamaz");
            RuleFor(p => p.Elektrik).NotEmpty().WithMessage("Elektrik Alanı Boş Bırakılamaz");
            RuleFor(p => p.Internet).NotEmpty().WithMessage("İnternet Alanı Boş Bırakılamaz");
            RuleFor(p => p.Maaslar).NotEmpty().WithMessage("Maaşlar Alanı Boş Bırakılamaz");
            RuleFor(p => p.Su).NotEmpty().WithMessage("Su Alanı Boş Bırakılamaz");
        }
    }
}
