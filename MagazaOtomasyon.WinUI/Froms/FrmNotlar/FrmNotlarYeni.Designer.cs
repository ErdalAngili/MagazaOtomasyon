namespace MagazaOtomasyon.WinUI.Froms.FrmNotlar
{
    partial class FrmNotlarYeni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnkaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barbtngerial = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textBaslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOlusturan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHitap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richDetay = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaskSaat = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtnkaydet,
            this.barbtngerial,
            this.barBtnCikis});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(539, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barbtnkaydet
            // 
            this.barbtnkaydet.Caption = "Kaydet";
            this.barbtnkaydet.Id = 1;
            this.barbtnkaydet.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Kaydet;
            this.barbtnkaydet.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barbtnkaydet.ItemAppearance.Normal.Options.UseFont = true;
            this.barbtnkaydet.Name = "barbtnkaydet";
            this.barbtnkaydet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnkaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnkaydet_ItemClick);
            // 
            // barbtngerial
            // 
            this.barbtngerial.Caption = "Geri Al";
            this.barbtngerial.Id = 2;
            this.barbtngerial.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Gerial;
            this.barbtngerial.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barbtngerial.ItemAppearance.Hovered.Options.UseFont = true;
            this.barbtngerial.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barbtngerial.ItemAppearance.Normal.Options.UseFont = true;
            this.barbtngerial.Name = "barbtngerial";
            this.barbtngerial.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtngerial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtngerial_ItemClick);
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 3;
            this.barBtnCikis.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Cikis;
            this.barBtnCikis.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barBtnCikis.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnCikis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barBtnCikis.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnCikis.Name = "barBtnCikis";
            this.barBtnCikis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCikis_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnkaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtngerial);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // textBaslik
            // 
            this.textBaslik.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBaslik.Location = new System.Drawing.Point(126, 140);
            this.textBaslik.Name = "textBaslik";
            this.textBaslik.Size = new System.Drawing.Size(363, 23);
            this.textBaslik.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Başlık :";
            // 
            // textOlusturan
            // 
            this.textOlusturan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOlusturan.Location = new System.Drawing.Point(126, 181);
            this.textOlusturan.Name = "textOlusturan";
            this.textOlusturan.Size = new System.Drawing.Size(363, 23);
            this.textOlusturan.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Oluşturan :";
            // 
            // textHitap
            // 
            this.textHitap.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textHitap.Location = new System.Drawing.Point(126, 220);
            this.textHitap.Name = "textHitap";
            this.textHitap.Size = new System.Drawing.Size(363, 23);
            this.textHitap.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Hitap :";
            // 
            // richDetay
            // 
            this.richDetay.Location = new System.Drawing.Point(126, 259);
            this.richDetay.Name = "richDetay";
            this.richDetay.Size = new System.Drawing.Size(363, 157);
            this.richDetay.TabIndex = 85;
            this.richDetay.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(48, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Detay :";
            // 
            // maskTarih
            // 
            this.maskTarih.Enabled = false;
            this.maskTarih.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTarih.Location = new System.Drawing.Point(126, 99);
            this.maskTarih.Mask = "00/00/0000";
            this.maskTarih.Name = "maskTarih";
            this.maskTarih.Size = new System.Drawing.Size(144, 23);
            this.maskTarih.TabIndex = 97;
            this.maskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(289, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Saat :";
            // 
            // MaskSaat
            // 
            this.MaskSaat.Enabled = false;
            this.MaskSaat.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.MaskSaat.Location = new System.Drawing.Point(345, 100);
            this.MaskSaat.Mask = "90:00";
            this.MaskSaat.Name = "MaskSaat";
            this.MaskSaat.Size = new System.Drawing.Size(144, 23);
            this.MaskSaat.TabIndex = 99;
            this.MaskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmNotlarYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaskSaat);
            this.Controls.Add(this.maskTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richDetay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textHitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOlusturan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotlarYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ynei Not Ekle";
            this.Load += new System.EventHandler(this.FrmNotlarYeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barbtnkaydet;
        private DevExpress.XtraBars.BarButtonItem barbtngerial;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TextBox textBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOlusturan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHitap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDetay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MaskSaat;
        private System.Windows.Forms.Timer timer1;
    }
}