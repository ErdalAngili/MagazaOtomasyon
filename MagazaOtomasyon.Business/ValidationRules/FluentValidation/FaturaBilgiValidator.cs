using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class FaturaBilgiValidator:AbstractValidator<FaturaBilgi>
    {
        public FaturaBilgiValidator()
        {
            RuleFor(p => p.SiraNo).NotEmpty().WithMessage("Sıra No alanını Boş Bıraktınız");
            RuleFor(p => p.Seri).NotEmpty().WithMessage("Seri alanını Boş Bıraktınız");
            RuleFor(p => p.Tarih).NotEmpty().WithMessage("Tarih alanını Boş Bıraktınız");
            RuleFor(p => p.VergiDaire).NotEmpty().WithMessage("Vergi Dairesi alanını Boş Bıraktınız");
            RuleFor(p => p.Alici).NotEmpty().WithMessage("Alıcı alanını Boş Bıraktınız");
            RuleFor(p => p.TeslimAlan).NotEmpty().WithMessage("Teslim Alan alanını Boş Bıraktınız");
            RuleFor(p => p.TeslimEden).NotEmpty().WithMessage("Teslim Eden alanını Boş Bıraktınız");
        }
    }
}
