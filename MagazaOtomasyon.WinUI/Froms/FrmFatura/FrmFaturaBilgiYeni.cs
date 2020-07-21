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

namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    public partial class FrmFaturaBilgiYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaBilgiYeni()
        {
            InitializeComponent();
            _faturaBilgiService = InstanceFactory.GetInstance<IFaturaBilgiService>();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _musteriService = InstanceFactory.GetInstance<IMusteriService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IFaturaBilgiService _faturaBilgiService;
        IPersonelService _personelService;
        IMusteriService _musteriService;
        IFirmaService _firmaService;
        public void Personel()
        {
            comPersonelAd.DataSource = _personelService.GetAll();
            comPersonelAd.DisplayMember = "Ad";
            comPersonelAd.ValueMember = "PersonelId";
        }
        public void Alici()
        {
            if (ComAlici.Text== "Müşteri")
            {
                comTeslimAlan.DataSource = _musteriService.GetAll();
                comTeslimAlan.DisplayMember = "Ad";
                comTeslimAlan.ValueMember = "MusteriId";
            }
            else if (ComAlici.Text=="Firma")
            {
                comTeslimAlan.DataSource = _firmaService.GetAll();
                comTeslimAlan.DisplayMember = "FirmaAd";
                comTeslimAlan.ValueMember = "FirmaId";
            }
        }
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Fatura Bilgilerini Kaydetmek İstiyor musunuz?", "Uarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _faturaBilgiService.Add(new FaturaBilgi
                    {
                        Seri = txtseri.Text,
                        SiraNo = txtSiraNo.Text,
                        Tarih = MaskTarih.Text,
                        Saat = MaskSaat.Text,
                        Alici = ComAlici.Text,
                        TeslimAlan = comTeslimAlan.Text,
                        TeslimEden = comPersonelAd.Text,
                        VergiDaire = txtVergiDairesi.Text
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
                MessageBox.Show("Fatura Bilgileri Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void GeriAl()
        {
            txtseri.Text = string.Empty;
            txtSiraNo.Text = string.Empty;
            MaskTarih.Text = string.Empty;
            MaskSaat.Text = string.Empty;
            ComAlici.Text = string.Empty;
            comTeslimAlan.Text = string.Empty;
            comPersonelAd.Text = string.Empty;
            txtVergiDairesi.Text = string.Empty;
        }
        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GeriAl();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmFaturaBilgiYeni_Load(object sender, EventArgs e)
        {
            Personel();
        }

        private void ComAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alici();
        }
    }
}