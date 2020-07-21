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

namespace MagazaOtomasyon.WinUI.Froms.FrmPersonel
{
    public partial class FrmPersonelDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonelDuzenle()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
            _ılService = InstanceFactory.GetInstance<IIlService>();
        }
        IPersonelService _personelService;
        IIlService _ılService;
        IIlceService _ılceService;
        public string Ad, Soyad, Telefon1, Mail, Il, Ilce, Gorev, Adres, TCKimlikNo;

        public int personelId;
        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
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
            txtId.Text = personelId.ToString();
            textAd.Text = Ad;
            textSoyad.Text = Soyad;
            maskTCKimlik.Text = TCKimlikNo;
            txtMail.Text = Mail;
            maskTelefon1.Text = Telefon1;
            comIl.Text = Il;
            comIlce.Text = Ilce;
            textGorev.Text = Gorev;
            richAdres.Text = Adres;
        }

        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            doldur();
            IlListele();
            IlceListele();
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Personel Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _personelService.Update(new Personel
                    {
                        PersonelId = int.Parse(txtId.Text),
                        Ad = textAd.Text,
                        Soyad = textSoyad.Text,
                        Tc = maskTCKimlik.Text,
                        Telefon = maskTelefon1.Text,
                        Gorev = textGorev.Text,
                        Mail = txtMail.Text,
                        Il = comIl.Text,
                        Ilce = comIlce.Text,
                        Adres = richAdres.Text
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
                MessageBox.Show("Personel Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}