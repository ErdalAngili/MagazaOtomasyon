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

namespace MagazaOtomasyon.WinUI.Froms.FrmStok
{
    public partial class FrmStokList : DevExpress.XtraEditors.XtraForm
    {
        public FrmStokList()
        {
            InitializeComponent();
            _stokService = InstanceFactory.GetInstance<IStokService>();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
        }
        IStokService _stokService;
        IUrunService _urunService;
        public void GenelStokListele()
        {
            gridControl1.DataSource = _urunService.GetAll();
        }
        public void SonStokListele()
        {
            gridControl2.DataSource = _stokService.GetAll();
        }

        private void FrmStokList_Load(object sender, EventArgs e)
        {
            GenelStokListele();
            SonStokListele();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GenelStokListele();
            SonStokListele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}