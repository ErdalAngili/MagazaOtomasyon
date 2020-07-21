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
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using System.Xml;

namespace MagazaOtomasyon.WinUI.Froms.FrmAnaModul
{
    public partial class FrmAnaSayfaModul : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaSayfaModul()
        {
            InitializeComponent();
            _stokService = InstanceFactory.GetInstance<IStokService>();
            _notlarService = InstanceFactory.GetInstance<INotlarService>();
            _efFirmaHareketDal = InstanceFactory.GetInstance<EfFirmaHareketDal>();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IStokService _stokService;
        INotlarService _notlarService;
        EfFirmaHareketDal _efFirmaHareketDal;
        IFirmaService _firmaService;
        public void Stok()
        {
            gridControl2.DataSource = _stokService.GetAll();
        }
        public void Ajanda()
        {
            gridControl1.DataSource = _notlarService.GetAll();
        }
        public void Hareket()
        {
            gridControl3.DataSource = _efFirmaHareketDal.firmaHareketDetails();
        }
        public void Fihrist()
        {
            gridControl4.DataSource= _firmaService.GetAll();
        }
        void döviz()
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
        void haberler()
        {
            XmlTextReader oku = new XmlTextReader("https://www.sabah.com.tr/rss/anasayfa.xml");
            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }
        }
        private void FrmAnaSayfaModul_Load(object sender, EventArgs e)
        {
            Stok();
            Ajanda();
            Hareket();
            Fihrist();
            döviz();
            haberler();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 60)
            {
                webBrowser1.Refresh();
                listBox1.Items.Clear();
                haberler();
                Stok();
                Ajanda();
                Hareket();
                Fihrist();
            }
            if (sayac == 61)
            {
                sayac = 0;
            }
        }
    }
}