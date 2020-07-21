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

namespace MagazaOtomasyon.WinUI.Froms.FrmMusteri
{
    public partial class FrmMusteriDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriDuzenle()
        {
            InitializeComponent();
            _musteriService = InstanceFactory.GetInstance<IMusteriService>();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
        }
        IMusteriService _musteriService;
        IIlService _ılService;
        IIlceService _ılceService;
        public string Ad, Soyad, Telefon1, Telefon2, Mail, Il, Ilce, VergiDairesi, Adres, TCKimlikNo;
        public int MusteriId;

        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

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
        public void doldur()
        {
            textId.Text = MusteriId.ToString();
            textAd.Text = Ad;
            textSoyad.Text = Soyad;
            maskTCKimlik.Text = TCKimlikNo;
            txtMail.Text = Mail;
            maskTelefon1.Text = Telefon1;
            maskTelefon2.Text = Telefon2;
            comIl.Text = Il;
            comIlce.Text = Ilce;
            textvergiDairesi.Text = VergiDairesi;
            richAdres.Text = Adres;
        }
        private void FrmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            IlListele();
            IlceListele();
            doldur();
        }
        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Müşteri Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _musteriService.Update(new Musteri
                    {
                        MusteriId = int.Parse(textId.Text),
                        Ad = textAd.Text,
                        Soyad = textSoyad.Text,
                        Tc = maskTCKimlik.Text,
                        Telefon1 = maskTelefon1.Text,
                        Telefon2 = maskTelefon2.Text,
                        Mail = txtMail.Text,
                        Il = comIl.Text,
                        Ilce = comIlce.Text,
                        Adres = richAdres.Text,
                        VergiDaire = textvergiDairesi.Text,
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Müşteri Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Müşteri Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}