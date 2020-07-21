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
    public partial class FrmDetayDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetayDuzenle()
        {
            InitializeComponent();
            _faturaDetayService = InstanceFactory.GetInstance<IFaturaDetayService>();
            _faturaBilgiService = InstanceFactory.GetInstance<IFaturaBilgiService>();
        }
        IFaturaDetayService _faturaDetayService;
        IFaturaBilgiService _faturaBilgiService;
        public string urunad, alici, miktar, fiyat, tutar;
        public int aliciId, detayId;

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Fatura Detay Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _faturaDetayService.Update(new FaturaDetay
                    {
                        FaturaId = int.Parse(comAliciId.Text),
                        FaturaUrunId = int.Parse(textDetayId.Text),
                        UrunAd = textUrunAd.Text,
                        Miktar = int.Parse(maskMiktar.Text),
                        Fiyat = decimal.Parse(maskFiyat.Text),
                        Tutar = decimal.Parse(maskTutar.Text)
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Fatura Detay Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fatura Detay Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void Doldur()
        {
            comAliciId.Text = aliciId.ToString();
            textDetayId.Text = detayId.ToString();
            textUrunAd.Text = urunad;
            comAlici.Text = alici;
            maskMiktar.Text = miktar;
            maskFiyat.Text = fiyat;
            maskTutar.Text = tutar;
        }
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
                comAliciId.DataSource = _faturaDetayService.GetFaturaDetayByFaturaBilgi(Convert.ToInt32(comAlici.SelectedValue));
                comAliciId.ValueMember = "FaturaBilgiId";
            }
            catch
            {
            }
        }
        private void comAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            AliciId();
        }
        private void FrmDetayDuzenle_Load(object sender, EventArgs e)
        {

            comAliciId.Visible = false;
            textDetayId.Visible = false;
            Doldur();
            AliciId();
        }
    }
}