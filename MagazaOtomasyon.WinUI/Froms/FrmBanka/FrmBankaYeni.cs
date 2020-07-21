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
    public partial class FrmBankaYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmBankaYeni()
        {
            InitializeComponent();
            _bankaService = InstanceFactory.GetInstance<IBankaService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
            _ılService = InstanceFactory.GetInstance<IIlService>();
            _ılceService = InstanceFactory.GetInstance<IIlceService>();
        }
        IBankaService _bankaService;
        IFirmaService _firmaService;
        IIlService _ılService;
        IIlceService _ılceService;
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
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bankayı Kaydetmek İstiyor musunuz?", "Uarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _bankaService.Add(new Banka
                    {
                        BankaAdı = textBankaAd.Text,
                        FirmaId = int.Parse(comboBox1.Text),
                        Yetkili = textYetkili.Text,
                        Il = comIl.Text,
                        Ilce = comIlce.Text,
                        Iban = mskIban.Text,
                        Sube = textSube.Text,
                        Telefon = maskTelefon.Text,
                        HesapNo = textHesapNo.Text,
                        Tarih = maskTarih.Text,
                        HesapTuru=textHesapTuru.Text,
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                MessageBox.Show("Kayıt İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Firma Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                comboBox1.DataSource = _bankaService.GetBankaByFırma(Convert.ToInt32(comFirma.SelectedValue));
                comboBox1.ValueMember = "FirmaId";
            }
            catch
            {
            }

        }
        private void FrmBankaYeni_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            ComboFirmaListele();
            FirmaId();
            IlListele();
            IlceListele();
        }

        private void comFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirmaId();
        }

        private void comIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceListele();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comFirma.Text = string.Empty;
            textBankaAd.Text = string.Empty;
            comIl.Text = string.Empty;
            comIlce.Text = string.Empty;
            mskIban.Text = string.Empty;
            textSube.Text = string.Empty;
            maskTelefon.Text = string.Empty;
            textHesapNo.Text = string.Empty;
            maskTarih.Text = string.Empty;
            textHesapTuru.Text = string.Empty;
            textYetkili.Text = string.Empty;
        }
    }
}