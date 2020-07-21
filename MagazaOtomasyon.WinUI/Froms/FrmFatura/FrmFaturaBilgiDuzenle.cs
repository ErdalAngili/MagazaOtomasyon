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
    public partial class FrmFaturaBilgiDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaBilgiDuzenle()
        {
            InitializeComponent();
            _faturaBilgiService = InstanceFactory.GetInstance<IFaturaBilgiService>();
        }
        IFaturaBilgiService _faturaBilgiService;
        public string seri, sirano, tarih, saat, alici, teslimeden, teslimalan, vergidairesi;

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public int FaturaBilgiId;
        public void Doldur()
        {
            textId.Text = FaturaBilgiId.ToString();
            txtseri.Text = seri;
            txtSiraNo.Text = sirano;
            MaskTarih.Text = tarih;
            MaskSaat.Text = saat;
            textAlici.Text = alici;
            textTeslimAlan.Text = teslimalan;
            textTeslimEden.Text = teslimeden;
            txtVergiDairesi.Text = vergidairesi;
        }
        private void FrmFaturaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Fatura Bilgilerini Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _faturaBilgiService.Update(new FaturaBilgi
                    {
                        FaturaBilgiId = int.Parse(textId.Text),
                        Seri = txtseri.Text,
                        SiraNo = txtSiraNo.Text,
                        Tarih = MaskTarih.Text,
                        Saat = MaskSaat.Text,
                        Alici = textAlici.Text,
                        TeslimAlan = textTeslimAlan.Text,
                        TeslimEden = textTeslimEden.Text,
                        VergiDaire = txtVergiDairesi.Text
                    });
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Fatura Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fatura Bilgileri Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}