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

namespace MagazaOtomasyon.WinUI.Froms.FrmGiderler
{
    public partial class FrmGiderlerList : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiderlerList()
        {
            InitializeComponent();
            _giderService = InstanceFactory.GetInstance<IGiderService>();
        }
        private IGiderService _giderService;
        FrmGiderlerYeni frmGiderlerYeni;
        public void Listele()
        {
            gridControl1.DataSource = _giderService.GetAll();
        }
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGiderlerYeni == null || frmGiderlerYeni.IsDisposed)
            {
                frmGiderlerYeni = new FrmGiderlerYeni();
                frmGiderlerYeni.ShowDialog();
            }
        }

        private void FrmGiderlerList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           FrmGiderlerDuzenle frmGiderlerDuzenle = new FrmGiderlerDuzenle();
            frmGiderlerDuzenle.giderId = int.Parse(gridView1.GetFocusedRowCellValue("GiderId").ToString());
            if (frmGiderlerDuzenle.ay==null)
            {
                frmGiderlerDuzenle.ay = gridView1.GetFocusedDisplayText().ToString();
                frmGiderlerDuzenle.comAy.Items.Add("Ocak");
                frmGiderlerDuzenle.comAy.Items.Add("Şubat");
                frmGiderlerDuzenle.comAy.Items.Add("Mart");
                frmGiderlerDuzenle.comAy.Items.Add("Nisan");
                frmGiderlerDuzenle.comAy.Items.Add("Mayıs");
                frmGiderlerDuzenle.comAy.Items.Add("Haziran");
                frmGiderlerDuzenle.comAy.Items.Add("Temmuz");
                frmGiderlerDuzenle.comAy.Items.Add("Ağustos");
                frmGiderlerDuzenle.comAy.Items.Add("Eylül");
                frmGiderlerDuzenle.comAy.Items.Add("Ekim");
                frmGiderlerDuzenle.comAy.Items.Add("Kasım");
                frmGiderlerDuzenle.comAy.Items.Add("Aralık");
            }
            else
            {
                frmGiderlerDuzenle.ay = gridView1.GetFocusedRowCellValue("Ay").ToString();
            }
            frmGiderlerDuzenle.yil = gridView1.GetFocusedRowCellValue("Yil").ToString();
            frmGiderlerDuzenle.elektrik =decimal.Parse(gridView1.GetFocusedRowCellValue("Elektrik").ToString());
            frmGiderlerDuzenle.su = decimal.Parse(gridView1.GetFocusedRowCellValue("Su").ToString());
            frmGiderlerDuzenle.dogalgaz = decimal.Parse(gridView1.GetFocusedRowCellValue("Dogalgaz").ToString());
            frmGiderlerDuzenle.internet = decimal.Parse(gridView1.GetFocusedRowCellValue("Internet").ToString());
            frmGiderlerDuzenle.maas = decimal.Parse(gridView1.GetFocusedRowCellValue("Maaslar").ToString());
            frmGiderlerDuzenle.ekstra = decimal.Parse(gridView1.GetFocusedRowCellValue("Ekstra").ToString());
            frmGiderlerDuzenle.not = gridView1.GetFocusedRowCellValue("Notlar").ToString();
            frmGiderlerDuzenle.ShowDialog();
        }
        
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _giderService.GetGiderYil(textAra.Text);
            }
            else
            {
                MessageBox.Show("Arama Alanı Boş Bırakıldı");
            }
            var list = _giderService.GetGiderYil(textAra.Text);
            if (!list.Any())
            {
                    MessageBox.Show("Herhangi bir veri bulunamadı");
            }
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textAra.Text))
            {
                Listele();
            }
        }
    }
}