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

namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    public partial class FrmFaturaUrun : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaUrun()
        {
            InitializeComponent();
            _faturaDetayService = InstanceFactory.GetInstance<IFaturaDetayService>();
        }
        IFaturaDetayService _faturaDetayService;
        public int id;

        public void Listele2()
        {
            gridControl1.DataSource = _faturaDetayService.Detay(id);
        }
    }
}