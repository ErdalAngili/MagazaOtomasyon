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
    public partial class FrmGiderlerDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiderlerDuzenle()
        {
            InitializeComponent();
            _giderService = InstanceFactory.GetInstance<IGiderService>();
        }
        IGiderService _giderService;
        public string ay, yil,not;
        public int giderId;
        public decimal elektrik, su, dogalgaz, internet, maas, ekstra;

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmGiderlerDuzenle_Load(object sender, EventArgs e)
        {
            textId.Text = giderId.ToString();
            comAy.Text = ay.ToString();
            ComYil.Text = yil.ToString();
            textElektrik.Text = elektrik.ToString();
            textSu.Text = su.ToString();
            textInternet.Text = internet.ToString();
            textDogalgaz.Text = dogalgaz.ToString();
            textMaas.Text = maas.ToString();
            textMaas.Text = maas.ToString();
            textEkstra.Text = ekstra.ToString();
            richNot.Text = not.ToString();
        }
        private void barBtnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Giderler Güncellemek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _giderService.Update(new Gider
                    {
                        GiderId = int.Parse(textId.Text),
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
                    MessageBox.Show("Güncelleme İşlemi Başarılı. Değişiklikleri Görmek için YENİLE Butonuna Basınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Giderler Güncellenemedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}