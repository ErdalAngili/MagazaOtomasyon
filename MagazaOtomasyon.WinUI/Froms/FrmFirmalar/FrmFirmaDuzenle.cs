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

namespace MagazaOtomasyon.WinUI.Froms.FrmFirmalar
{
    public partial class FrmFirmaDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmaDuzenle()
        {
            InitializeComponent();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IIlService _ılService;
        IIlceService _ılceService;
        IFirmaService _firmaService;
        public string firmaAd, YetkiliAdSoyad, YetkiliStatu, Sektor, Telefon1, Telefon2, Fax, Mail, Il, Ilce, VergiDairesi, Adres, OzelKod1, ozelKod2;

        public int firmaId;

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
            txtFirmaId.Text = firmaId.ToString();
            textfirmaAd.Text = firmaAd;
            txtyetkiliAdSoyad.Text = YetkiliAdSoyad;
            txtyetkiliStatu.Text = YetkiliStatu;
            txtSektor.Text = Sektor;
            maskTelefon1.Text = Telefon1;
            maskTelefon2.Text = Telefon2;
            mskFax.Text = Fax;
            txtMail.Text = Mail;
            comIl.Text = Il;
            comIlce.Text = Ilce;
            txtVergiDairesi.Text = VergiDairesi;
            richAdres.Text = Adres;
            txtOzelkod1.Text = OzelKod1;
            txtOzelKod2.Text = ozelKod2;
        }
        private void FrmFirmaDuzenle_Load(object sender, EventArgs e)
        {
            IlListele();
            IlceListele();
            Doldur();
        }
        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Firma Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _firmaService.Update(new Firma
                    {
                        FirmaId = int.Parse(txtFirmaId.Text),
                        FirmaAd=textfirmaAd.Text,
                        YetkiliAdSoyad=txtyetkiliAdSoyad.Text,
                        YetkiliStatu=txtyetkiliStatu.Text,
                        Sektor=txtSektor.Text,
                        Telefon1=maskTelefon1.Text,
                        Telefon2=maskTelefon2.Text,
                        Mail=txtMail.Text,
                        Fax=mskFax.Text,
                        Il=comIl.Text,
                        Ilce=comIlce.Text,
                        VergiDaire=txtVergiDairesi.Text,
                        Adres=richAdres.Text,
                        OzelKod1=txtOzelkod1.Text,
                        OzelKod2=txtOzelKod2.Text
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Firma Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Firma Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}