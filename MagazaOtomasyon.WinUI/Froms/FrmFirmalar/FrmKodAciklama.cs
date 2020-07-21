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

namespace MagazaOtomasyon.WinUI.Froms.FrmFirmalar
{
    public partial class FrmKodAciklama : DevExpress.XtraEditors.XtraForm
    {
        public FrmKodAciklama()
        {
            InitializeComponent();
        }

        private void FrmKodAciklama_Load(object sender, EventArgs e)
        {
            richKodBir.Text = "Sektör bazında raporlama almak için kullanacağız. Firma Sektörünün sessiz harflerini yazarak ve iki sayı ekleyerek en fazla 8 karakter uzunluğunda kodlar oluşturulur";
        }
    }
}