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

namespace MagazaOtomasyon.WinUI.Froms.FrmNotlar
{
    public partial class FrmNotlarDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlarDuzenle()
        {
            InitializeComponent();
            _notlarService = InstanceFactory.GetInstance<INotlarService>();
        }
        INotlarService _notlarService;
        public string baslik, olusturan, hitap, detay, tarih, saat;
        public int notId;

        public void Doldur()
        {
            txtNotId.Text = notId.ToString();
            textBaslik.Text = baslik;
            textOlusturan.Text = olusturan;
            textHitap.Text = hitap;
            richDetay.Text = detay;
            MaskSaat.Text = saat;
            maskTarih.Text = tarih;
        }
        private void FrmNotlarDuzenle_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Not Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _notlarService.Update(new Not
                    {
                        NotId = int.Parse(txtNotId.Text),
                        Baslik = textBaslik.Text,
                        Olusturan = textOlusturan.Text,
                        Hitap = textHitap.Text,
                        Detay = richDetay.Text,
                        Tarih = maskTarih.Text,
                        Saat = MaskSaat.Text
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Not Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Not Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}