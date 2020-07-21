using FluentValidation;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.ValidationRules.FluentValidation
{
    public class BankaValidator:AbstractValidator<Banka>
    {
        public BankaValidator()
        {
            RuleFor(p => p.BankaAdı).NotEmpty().WithMessage("Banka Adı Alanını Boş Bıraktınız !");
            RuleFor(p => p.HesapNo).NotEmpty().WithMessage("Hesap No Alanını Boş Bıraktınız !");
            RuleFor(p => p.HesapTuru).NotEmpty().WithMessage("Hesap Türü Alanını Boş Bıraktınız !");
            RuleFor(p => p.Iban).NotEmpty().WithMessage("İban Alanını Boş Bıraktınız !");
            RuleFor(p => p.Il).NotEmpty().WithMessage("İl Alanını Boş Bıraktınız !");
            RuleFor(p => p.Ilce).NotEmpty().WithMessage("İlçe Alanını Boş Bıraktınız !");
            RuleFor(p => p.Sube).NotEmpty().WithMessage("Şube Alanını Boş Bıraktınız !");
            RuleFor(p => p.Tarih).NotEmpty().WithMessage("Tarih Alanını Boş Bıraktınız !");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Alanını Boş Bıraktınız !");
            RuleFor(p => p.Yetkili).NotEmpty().WithMessage("Yetkili Alanını Boş Bıraktınız !");
            RuleFor(p => p.FirmaId).NotEmpty().WithMessage("Firma Adı Alanını Boş Bıraktınız !");
        }
    }
}
