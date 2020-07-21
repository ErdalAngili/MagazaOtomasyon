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
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;
using MagazaOtomasyon.Business.Abstract;

namespace MagazaOtomasyon.WinUI.Froms.FrmHareketler
{
    public partial class FrmHareket : DevExpress.XtraEditors.XtraForm
    {
        public FrmHareket()
        {
            InitializeComponent();
            _efMusteriHareketDal = InstanceFactory.GetInstance<EfMusteriHareketDal>();
            _efFirmaHareketDal = InstanceFactory.GetInstance<EfFirmaHareketDal>();
        }

        EfMusteriHareketDal _efMusteriHareketDal;
        EfFirmaHareketDal _efFirmaHareketDal;
        public void Listele()
        {
            gridControl1.DataSource = _efMusteriHareketDal.musteeriHareketDetails();
            gridControl2.DataSource = _efFirmaHareketDal.firmaHareketDetails();
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
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
    }
}