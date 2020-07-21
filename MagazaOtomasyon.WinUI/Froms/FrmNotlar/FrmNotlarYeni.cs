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
    public partial class FrmNotlarYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlarYeni()
        {
            InitializeComponent();
            _notlarService = InstanceFactory.GetInstance<INotlarService>();
        }
        INotlarService _notlarService;
        private void FrmNotlarYeni_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.Date.ToString("dd.MM.yyyy");
            string saat = DateTime.Now.ToLongTimeString();
            MaskSaat.Text = saat.ToString();
            maskTarih.Text = tarih.ToString();
            timer1.Start();

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==60)
            {
                MaskSaat.Text= DateTime.Now.ToLongTimeString();
            }
            if (sayac==61)
            {
                sayac = 0;
            }
        }

        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textBaslik.Text = string.Empty;
            textOlusturan.Text = string.Empty;
            textHitap.Text = string.Empty;
            richDetay.Text = string.Empty;
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Notu Kaydetmek İstiyor musunuz?", "Uarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _notlarService.Add(new Not
                    {
                        Baslik = textBaslik.Text,
                        Olusturan = textOlusturan.Text,
                        Hitap = textHitap.Text,
                        Detay = richDetay.Text,
                        Tarih = maskTarih.Text,
                        Saat = MaskSaat.Text
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
                MessageBox.Show("Not Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}