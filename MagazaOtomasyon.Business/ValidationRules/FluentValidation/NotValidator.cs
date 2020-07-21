using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    partial class NotValidator:AbstractValidator<Not>
    {
        public NotValidator()
        {
            RuleFor(p => p.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Bırakılamaz");
            RuleFor(p => p.Olusturan).NotEmpty().WithMessage("Oluşturan Alanı Boş Bırakılamaz");
            RuleFor(p => p.Hitap).NotEmpty().WithMessage("Hitap Alanı Boş Bırakılamaz");
            RuleFor(p => p.Detay).NotEmpty().WithMessage("Detay Alanı Boş Bırakılamaz");
        }
    }
}
