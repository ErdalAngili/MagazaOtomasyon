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
    public partial class FrmPersonelYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonelYeni()
        {
            InitializeComponent();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
        }
        IIlService _ılService;
        IIlceService _ılceService;
        IPersonelService _personelService;
        public void IlListe()
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
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Personeli Kayıt Etmek İstiyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    _personelService.Add(new Personel
                    {
                        Ad = textAd.Text,
                        Soyad = textSoyad.Text,
                        Tc=maskTCKimlik.Text,
                        Telefon=maskTelefon1.Text,
                        Gorev=textGorev.Text,
                        Mail=txtMail.Text,
                        Il=comIl.Text,
                        Ilce=comIlce.Text,
                        Adres=richAdres.Text
                    });
                    MessageBox.Show("Kayıt İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Personel Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GeriAl()
        {
            textAd.Text = string.Empty;
            textSoyad.Text = string.Empty;
            maskTCKimlik.Text = string.Empty;
            maskTelefon1.Text = string.Empty;
            textGorev.Text = string.Empty;
            txtMail.Text = string.Empty;
            comIl.Text = string.Empty;
            comIlce.Text = string.Empty;
            richAdres.Text = string.Empty;
        }
        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GeriAl();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmPersonelYeni_Load(object sender, EventArgs e)
        {
            IlListe();
            IlceListele();
        }

        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
        }
    }
}