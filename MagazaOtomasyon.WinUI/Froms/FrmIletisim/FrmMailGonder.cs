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
using System.Net.Mail;

namespace MagazaOtomasyon.WinUI.Froms.FrmIletisim
{
    public partial class FrmMailGonder : DevExpress.XtraEditors.XtraForm
    {
        public FrmMailGonder()
        {
            InitializeComponent();
        }
        public string mail;

        private void FrmMailGonder_Load(object sender, EventArgs e)
        {
            TxtMailAdres.Text = mail;
        }

        private void barGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Mesajı Göndermek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MailMessage msj = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("Gönderen Mail", "Gönderen Mail Şifre");
                    istemci.Port = 587;
                    istemci.Host = "smtp.live.com";
                    istemci.EnableSsl = true;
                    msj.To.Add(TxtMailAdres.Text);
                    msj.From = new MailAddress("Gönderen Mail");
                    msj.Subject = txtBaslik.Text;
                    msj.Body = RichMesaj.Text;
                    istemci.Send(msj);
                    MessageBox.Show("Mesaj Gönderildi", "Uyarı", MessageBoxButtons.OK);
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Mesajı Gönderilemedi?", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}