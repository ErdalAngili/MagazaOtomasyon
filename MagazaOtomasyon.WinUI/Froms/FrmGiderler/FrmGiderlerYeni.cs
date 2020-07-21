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

namespace MagazaOtomasyon.WinUI.Froms.FrmGiderler
{
    public partial class FrmGiderlerYeni : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiderlerYeni()
        {
            InitializeComponent();
            _giderService = InstanceFactory.GetInstance<IGiderService>();
        }
        IGiderService _giderService;
        public void GeriAl()
        {
            comAy.Text = string.Empty;
            ComYil.Text = string.Empty;
            textSu.Text = string.Empty;
            textElektrik.Text = string.Empty;
            textDogalgaz.Text = string.Empty;
            textMaas.Text = string.Empty;
            textInternet.Text = string.Empty;
            textEkstra.Text = string.Empty;
            richNot.Text = string.Empty;
        }
        public void AyEkle()
        {
            comAy.Items.Add("Ocak");
            comAy.Items.Add("Şubat");
            comAy.Items.Add("Mart");
            comAy.Items.Add("Nisan");
            comAy.Items.Add("Mayıs");
            comAy.Items.Add("Haziran");
            comAy.Items.Add("Temmuz");
            comAy.Items.Add("Ağustos");
            comAy.Items.Add("Eylül");
            comAy.Items.Add("Ekim");
            comAy.Items.Add("Kasım");
            comAy.Items.Add("Aralık");
        }
        public void YilEkle()
        {
            ComYil.Items.Add("2020");
            ComYil.Items.Add("2019");
            ComYil.Items.Add("2018");
            ComYil.Items.Add("2017");
        }
        private void barbtnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Giderleri Kayıt Etmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _giderService.Add(new Gider
                    {
                        Ay = comAy.Text,
                        Yil = ComYil.Text,
                        Elektrik = decimal.Parse(textElektrik.Text),
                        Su = decimal.Parse(textSu.Text),
                        Dogalgaz = decimal.Parse(textDogalgaz.Text),
                        Internet = decimal.Parse(textInternet.Text),
                        Maaslar = decimal.Parse(textMaas.Text),
                        Ekstra = decimal.Parse(textEkstra.Text),
                        Notlar = richNot.Text
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
                MessageBox.Show("Giderler Kayıt Edilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmGiderlerYeni_Load(object sender, EventArgs e)
        {
            AyEkle();
            YilEkle();
        }

        private void barbtngerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GeriAl();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}