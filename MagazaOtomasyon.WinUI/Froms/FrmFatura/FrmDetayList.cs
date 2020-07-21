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
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;

namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    public partial class FrmDetayList : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetayList()
        {
            InitializeComponent();
            _efFaturaDetayDal = InstanceFactory.GetInstance<EfFaturaDetayDal>();
        }
        EfFaturaDetayDal _efFaturaDetayDal;
        public int PersonelId;
        public void Listele()
        {
            gridControl1.DataSource = _efFaturaDetayDal.GetfaturaDetayDetails();
        }
        private void FrmDetayList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }
        FrmDetayYeni frmDetayYeni;
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDetayYeni = new FrmDetayYeni();
            frmDetayYeni.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDetayDuzenle frmDetayDuzenle = new FrmDetayDuzenle();
            frmDetayDuzenle.detayId = int.Parse(gridView1.GetFocusedRowCellValue("FaturaUrunId").ToString());
            frmDetayDuzenle.urunad = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
            frmDetayDuzenle.miktar = gridView1.GetFocusedRowCellValue("Miktar").ToString();
            frmDetayDuzenle.fiyat = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            frmDetayDuzenle.tutar = gridView1.GetFocusedRowCellValue("Tutar").ToString();
            frmDetayDuzenle.alici = gridView1.GetFocusedRowCellValue("AliciAd").ToString();
            frmDetayDuzenle.AliciListele();
            frmDetayDuzenle.ShowDialog();
        }
    }
}