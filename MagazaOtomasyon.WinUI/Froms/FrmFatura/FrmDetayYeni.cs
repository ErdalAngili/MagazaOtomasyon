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
using MagazaOtomasyon.WinUI.Froms.FrmHareketler;

namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    public partial class FrmDetayYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetayYeni()
        {
            InitializeComponent();
            _faturaDetayService = InstanceFactory.GetInstance<IFaturaDetayService>();
            _faturaBilgiService = InstanceFactory.GetInstance<IFaturaBilgiService>();
            _MusteriHareketService = InstanceFactory.GetInstance<IMusteriHareketService>();
            _firmaHareketService = InstanceFactory.GetInstance<IFirmaHareketService>();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _stokService = InstanceFactory.GetInstance<IStokService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IFaturaDetayService _faturaDetayService;
        IFaturaBilgiService _faturaBilgiService;
        IMusteriHareketService _MusteriHareketService;
        IFirmaHareketService _firmaHareketService;
        IPersonelService _personelService;
        IStokService _stokService;
        IFirmaService _firmaService;

        int stok, mskMiktar, topla;
        
        public void AliciListele()
        {
                comAlici.DataSource = _faturaBilgiService.GetAll();
                comAlici.DisplayMember = "Alici";
                comAlici.ValueMember = "FaturaBilgiId";
        }
        public void AliciId()
        {
            try
            {
                comMusteriAlici.DataSource = _faturaDetayService.GetFaturaDetayByFaturaBilgi(Convert.ToInt32(comAlici.SelectedValue));
                comMusteriAlici.ValueMember = "FaturaBilgiId";
            }
            catch
            {
            }
        }
        public void AliciFirma()
        {
            try
            {
                comFirmaAlici.DataSource = _firmaService.GetFirmaId(Convert.ToInt32(comAlici.SelectedValue));
                comFirmaAlici.ValueMember = "FirmaId";
            }
            catch { }
        }

        public void UrunListele()
        {
            comUrun.DataSource = _stokService.GetAll();
            comUrun.DisplayMember = "StokTur";
            comUrun.ValueMember = "StokId";

        }
        public void UrunIdList()
        {
            try
            {
                comUrunId.DataSource = _stokService.GetUrunAdet(Convert.ToInt32(comUrun.SelectedValue));
                comUrunId.ValueMember = "StokId";
            }
            catch
            {
            }
        }
        public void PersonelCek()
        {
            comPersonelAd.DataSource = _personelService.GetAll();
            comPersonelAd.DisplayMember = "Ad";
            comPersonelAd.ValueMember = "PersonelId";
        }
        public void PersonelId()
        {
            try
            {
                compersonelId.DataSource = _faturaBilgiService.GetPersonelAd(Convert.ToInt32(comPersonelAd.SelectedValue));
                compersonelId.ValueMember = "PersonelId";
            }
            catch
            {
            }
        }
        public void UrunAdetListele()
        {
            try
            {
                comUrunAdet.DataSource = _stokService.GetUrunAdet(Convert.ToInt32(comUrun.SelectedValue));
                comUrunAdet.ValueMember = "StokAdet";
            }
            catch
            {
            }
        }
        private void FrmDetayYeni_Load(object sender, EventArgs e)
        {
            UrunListele();
            UrunIdList();
            PersonelCek();
            PersonelId();
            UrunAdetListele();
            AliciFirma();
            comMusteriAlici.Visible = false;
            comUrunId.Visible = false;
            comFirmaAlici.Visible = false;
            compersonelId.Visible = false;
            comUrunAdet.Visible = false;
            label7.Visible = false;
        }

        private void comAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            AliciId();
            AliciFirma();
        }
        private void comUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunIdList();
            UrunAdetListele();
        }
        private void comPersonelAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelId();
        }
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Fatura Detayı Kaydetmek İstiyor musunuz?", "Uarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _faturaDetayService.Add(new FaturaDetay
                    {
                        UrunAd = comUrun.Text,
                        Miktar = int.Parse(maskMiktar.Text),
                        Fiyat = int.Parse(maskFiyat.Text),
                        Tutar = int.Parse(maskTutar.Text),
                        FaturaId = int.Parse(comMusteriAlici.Text)
                    });
                    _stokService.Update(new Stok
                    {
                        StokId = int.Parse(comUrunId.Text),
                        StokTur = comUrun.Text,
                        StokAdet = int.Parse(label7.Text)
                    });
                    if (comSec.Text == "Müşteri")
                    {
                        _MusteriHareketService.Add(new MusteriHareket
                        {
                            UrunId = int.Parse(comUrunId.Text),
                            MusteriId = int.Parse(comMusteriAlici.Text),
                            Miktar = int.Parse(maskMiktar.Text),
                            FiyatId = int.Parse(maskFiyat.Text),
                            ToplamId = int.Parse(maskTutar.Text),
                            PersonelId = int.Parse(compersonelId.Text),
                            FaturaId = int.Parse(comMusteriAlici.Text),
                        });
                    }
                    else if (comSec.Text == "Firma")
                    {
                        _firmaHareketService.Add(new FirmaHareket
                        {
                            UrunId = int.Parse(comUrunId.Text),
                            Adet = int.Parse(maskMiktar.Text),
                            Personel = int.Parse(compersonelId.Text),
                            Firma = int.Parse(comFirmaAlici.Text),
                            Fiyat = int.Parse(maskFiyat.Text),
                            Toplam = int.Parse(maskTutar.Text),
                            FaturaId = int.Parse(comMusteriAlici.Text),
                        });
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                MessageBox.Show("Kayıt İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fatura Detayı Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comMusteriAlici.Text = string.Empty;
            compersonelId.Text = string.Empty;
            comUrunId.Text = string.Empty;
            maskMiktar.Text = string.Empty;
            maskFiyat.Text = string.Empty;
            maskTutar.Text = string.Empty;
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSec.Text == "Müşteri")
            {
                AliciListele();
                AliciId();
            }
            else if (comSec.Text == "Firma")
            {
                AliciListele();
                AliciFirma();
            }
        }

        private void maskMiktar_EditValueChanged(object sender, EventArgs e)
        {
            stok = int.Parse(comUrunAdet.Text);
            mskMiktar = int.Parse(maskMiktar.Text);
            topla = stok - mskMiktar;
            label7.Text = topla.ToString();
            if (label7.Text=="0")
            {
                MessageBox.Show("Ürün Stoklarda Tükendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}