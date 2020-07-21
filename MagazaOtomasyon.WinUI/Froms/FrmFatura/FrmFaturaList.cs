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
    public partial class FrmFaturaList : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaList()
        {
            InitializeComponent();
            _faturaBilgiService = InstanceFactory.GetInstance<IFaturaBilgiService>();
        }
        IFaturaBilgiService _faturaBilgiService;
        FrmFaturaBilgiYeni frmFaturaBilgiYeni;
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                frmFaturaBilgiYeni = new FrmFaturaBilgiYeni();
                frmFaturaBilgiYeni.ShowDialog();
        }
        public void Listele()
        {
           gridControl1.DataSource= _faturaBilgiService.GetAll();
        }

        private void FrmFaturaList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Fatura Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _faturaBilgiService.Delete(new FaturaBilgi
                {
                    FaturaBilgiId = int.Parse(gridView1.GetFocusedRowCellValue("FaturaBilgiId").ToString())
                });
                MessageBox.Show("Fatura Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Fatura Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _faturaBilgiService.GetSiraNo(int.Parse(textAra.Text));
            }
            else
            {
                MessageBox.Show("Arama Alanı Boş Bırakıldı");
            }
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textAra.Text))
            {
                Listele();
            }
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturaBilgiDuzenle frmFaturaBilgiDuzenle = new FrmFaturaBilgiDuzenle();
            frmFaturaBilgiDuzenle.FaturaBilgiId = int.Parse(gridView1.GetFocusedRowCellValue("FaturaBilgiId").ToString());
            frmFaturaBilgiDuzenle.seri = gridView1.GetFocusedRowCellValue("Seri").ToString();
            frmFaturaBilgiDuzenle.sirano = gridView1.GetFocusedRowCellValue("SiraNo").ToString();
            frmFaturaBilgiDuzenle.tarih = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            frmFaturaBilgiDuzenle.saat = gridView1.GetFocusedRowCellValue("Saat").ToString();
            frmFaturaBilgiDuzenle.vergidairesi = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
            frmFaturaBilgiDuzenle.alici = gridView1.GetFocusedRowCellValue("Alici").ToString();
            frmFaturaBilgiDuzenle.teslimalan = gridView1.GetFocusedRowCellValue("TeslimAlan").ToString();
            frmFaturaBilgiDuzenle.teslimeden = gridView1.GetFocusedRowCellValue("TeslimEden").ToString();
            frmFaturaBilgiDuzenle.ShowDialog();
        }
        FrmDetayList _frmDetayList;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _frmDetayList = new FrmDetayList();
            _frmDetayList.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrun faturaUrun = new FrmFaturaUrun();
            faturaUrun.id = int.Parse(gridView1.GetFocusedRowCellValue("FaturaBilgiId").ToString());
            faturaUrun.Listele2();
            faturaUrun.ShowDialog();
        }
    }
}