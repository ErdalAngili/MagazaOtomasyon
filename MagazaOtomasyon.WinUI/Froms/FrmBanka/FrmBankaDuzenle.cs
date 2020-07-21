using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;
using MagazaOtomasyon.Entities.Concrete;

namespace MagazaOtomasyon.WinUI.Froms.FrmBanka
{
    public partial class FrmBankaDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmBankaDuzenle()
        {
            InitializeComponent();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
            _bankaService = InstanceFactory.GetInstance<IBankaService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        public string bankaAd, firmaAd, yetkili, il, ilce, iban, sube, telefon, hesapno, tarih, hesapturu;
        public int firmaId, bankaId;
        IIlService _ılService;
        IIlceService _ılceService;
        IBankaService _bankaService;
        IFirmaService _firmaService;
        public void IlListele()
        {
            comIl.DataSource = _ılService.GetAll();
            comIl.DisplayMember = "Sehir";
            comIl.ValueMember = "IlId";
        }
        public void IlceListele()
        {
            try
            {
                comIlce.DataSource = _ılceService.GetIlByIlce(Convert.ToInt32(comIl.SelectedValue));
                comIlce.DisplayMember = "Ilceler";
                comIlce.ValueMember = "IlceId";
            }
            catch { }
        }
        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
        }
        public void Doldur()
        {
            comFirmaId.Text = firmaId.ToString();
            textBankaId.Text = bankaId.ToString();
            comFirma.Text = firmaAd;
            textBankaAd.Text = bankaAd;
            textYetkili.Text = yetkili;
            comIl.Text = il;
            comIlce.Text = ilce;
            mskIban.Text = iban;
            textSube.Text = sube;
            maskTelefon.Text = telefon;
            textHesapNo.Text = hesapno;
            maskTarih.Text = tarih;
            textHesapTuru.Text = hesapturu;
        }
        public void ComboFirmaListele()
        {
            comFirma.DataSource = _firmaService.GetAll();
            comFirma.DisplayMember = "FirmaAd";
            comFirma.ValueMember = "FirmaId";
        }
        public void FirmaId()
        {
            try
            {
                comFirmaId.DataSource = _bankaService.GetBankaByFırma(Convert.ToInt32(comFirma.SelectedValue));
                comFirmaId.ValueMember = "FirmaId";
            }
            catch
            {
            }

        }
        private void comFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirmaId();
        }
        private void FrmBankaDuzenle_Load(object sender, EventArgs e)
        {
            comFirmaId.Visible = false;
            textBankaId.Visible = false;
            IlListele();
            IlceListele();
            Doldur();
            FirmaId();
        }
        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Banka Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _bankaService.Update(new Banka
                    {
                        FirmaId = int.Parse(comFirmaId.Text),
                        BankaId = int.Parse(textBankaId.Text),
                        BankaAdı = textBankaAd.Text,
                        Iban = mskIban.Text,
                        Il = comIl.Text,
                        Ilce = comIlce.Text,
                        Sube = textSube.Text,
                        Telefon = maskTelefon.Text,
                        HesapNo = textHesapNo.Text,
                        Tarih = maskTarih.Text,
                        HesapTuru = textHesapTuru.Text,
                        Yetkili = textYetkili.Text
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Banka Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Banka Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}