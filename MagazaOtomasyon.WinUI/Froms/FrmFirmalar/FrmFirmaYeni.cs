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
    public partial class FrmFirmaYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmaYeni()
        {
            InitializeComponent();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IIlService _ılService;
        IIlceService _ılceService;
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
        private void FrmFirmaYeni_Load(object sender, EventArgs e)
        {
            IlListele();
            IlceListele();
        }

        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
        }

        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Firmayı Kaydetmek İstiyor musunuz?","Uarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    _firmaService.Add(new Firma
                    {
                        FirmaAd = textfirmaAd.Text,
                        YetkiliAdSoyad = txtyetkiliAdSoyad.Text,
                        YetkiliStatu = txtyetkiliStatu.Text,
                        Sektor=txtSektor.Text,
                        Telefon1 = maskTelefon1.Text,
                        Telefon2 = maskTelefon2.Text,
                        Mail = txtMail.Text,
                        Fax = mskFax.Text,
                        Il = comIl.Text,
                        Ilce = comIlce.Text,
                        VergiDaire = txtVergiDairesi.Text,
                        Adres = richAdres.Text,
                        OzelKod1 = txtOzelkod1.Text,
                        OzelKod2 = txtOzelKod2.Text
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
                MessageBox.Show("Firma Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GeriAl()
        {
            textfirmaAd.Text = string.Empty;
            txtyetkiliAdSoyad.Text = string.Empty;
            txtSektor.Text = string.Empty;
            txtyetkiliStatu.Text = string.Empty;
            maskTelefon1.Text = string.Empty;
            maskTelefon2.Text = string.Empty;
            txtMail.Text = string.Empty;
            mskFax.Text = string.Empty;
            comIl.Text = string.Empty;
            comIlce.Text = string.Empty;
            txtVergiDairesi.Text = string.Empty;
            richAdres.Text = string.Empty;
            txtOzelkod1.Text = string.Empty;
            txtOzelKod2.Text = string.Empty;
        }
        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GeriAl();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKodAciklama frmKodAciklama = new FrmKodAciklama();
            frmKodAciklama.Show();
        }
    }
}