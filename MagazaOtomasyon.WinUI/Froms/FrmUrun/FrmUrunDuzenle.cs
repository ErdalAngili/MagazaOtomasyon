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
using MagazaOtomasyon.Entities.Concrete;
using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;

namespace MagazaOtomasyon.WinUI.Forms.FrmUrun
{
    public partial class FrmUrunDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunDuzenle()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
        }
        private IUrunService _urunService;
        public string urunad, marka, model,detay;
        public int urunıd, yil, adet;
        public decimal maliyet, satisfiyati;
        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void FrmUrunDuzenle_Load(object sender, EventArgs e)
        {
            textId.Text = urunıd.ToString();
            textAd.Text = urunad;
            textMarka.Text = marka;
            textModel.Text = model;
            maskYil.Text = yil.ToString();
            numAdet.Text = adet.ToString();
            textMaliyet.Text = maliyet.ToString();
            textSatis.Text = satisfiyati.ToString();
            richDetay.Text = detay;
        }
        private void barBtnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ürünü Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _urunService.Update(new Urun
                    {
                        UrunId = int.Parse(textId.Text),
                        UrunAd = textAd.Text,
                        Marka = textMarka.Text,
                        Model = textModel.Text,
                        Yil = int.Parse(maskYil.Text),
                        Adet = int.Parse(numAdet.Text),
                        Maliyet = decimal.Parse(textMaliyet.Text),
                        SatisFiyat = decimal.Parse(textSatis.Text),
                        Detay = richDetay.Text
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Ürün Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}