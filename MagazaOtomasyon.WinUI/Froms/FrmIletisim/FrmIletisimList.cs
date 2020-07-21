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

namespace MagazaOtomasyon.WinUI.Froms.FrmIletisim
{
    public partial class FrmIletisimList : DevExpress.XtraEditors.XtraForm
    {
        public FrmIletisimList()
        {
            InitializeComponent();
            _musteriService = InstanceFactory.GetInstance<IMusteriService>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IMusteriService _musteriService;
        IFirmaService _firmaService;
        public void MusteriIletisimListele()
        {
            gridControlMusteri.DataSource= _musteriService.GetAll();
        }
        public void FirmaIletisimListele()
        {
            gridControlFirma.DataSource = _firmaService.GetAll();
        }
        private void FrmIletisimList_Load(object sender, EventArgs e)
        {
            MusteriIletisimListele();
            FirmaIletisimListele();
        }

        private void gridControlMusteri_DoubleClick(object sender, EventArgs e)
        {
            FrmMailGonder frmMailGonder = new FrmMailGonder();
            frmMailGonder.mail = gridView1.GetFocusedRowCellValue("Mail").ToString();
            frmMailGonder.ShowDialog();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriIletisimListele();
            FirmaIletisimListele();
        }

        private void gridControlFirma_DoubleClick(object sender, EventArgs e)
        {
            FrmMailGonder frmMailGonder = new FrmMailGonder();
            frmMailGonder.mail = gridView2.GetFocusedRowCellValue("Mail").ToString();
            frmMailGonder.ShowDialog();
        }
    }
}