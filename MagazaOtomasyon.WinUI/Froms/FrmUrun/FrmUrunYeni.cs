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
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;

namespace MagazaOtomasyon.WinUI.Forms.FrmUrun
{
    public partial class FrmUrunYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunYeni()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _stokService = InstanceFactory.GetInstance<IStokService>();
        }
        private IUrunService _urunService;
        IStokService _stokService;
        public void GeriAl()
        {
            textAd.Text = string.Empty;
            textMarka.Text = string.Empty;
            textModel.Text = string.Empty;
            maskYil.Text = string.Empty;
            numAdet.Value = 0;
            textMaliyet.Text = string.Empty;
            textSatis.Text = string.Empty;
            richDetay.Text = string.Empty;
        }

        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GeriAl();
        }
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ürünü Kayıt Etmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _urunService.Add(new Urun
                    {
                        UrunAd = textAd.Text,
                        Marka = textMarka.Text,
                        Model = textModel.Text,
                        Yil = int.Parse(maskYil.Text),
                        Adet = int.Parse(numAdet.Text),
                        Maliyet = decimal.Parse(textMaliyet.Text),
                        SatisFiyat = decimal.Parse(textSatis.Text),
                        Detay = richDetay.Text
                    });
                    _stokService.Add(new Stok
                    {
                        StokTur = textAd.Text,
                        StokAdet= int.Parse(numAdet.Text)
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
                MessageBox.Show("Ürün Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}