namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    partial class FrmDetayYeni
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnkaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barbtngerial = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.comAlici = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comMusteriAlici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskFiyat = new DevExpress.XtraEditors.TextEdit();
            this.maskTutar = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.maskMiktar = new DevExpress.XtraEditors.TextEdit();
            this.comUrun = new System.Windows.Forms.ComboBox();
            this.comUrunId = new System.Windows.Forms.ComboBox();
            this.comPersonelAd = new System.Windows.Forms.ComboBox();
            this.compersonelId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comSec = new System.Windows.Forms.ComboBox();
            this.comUrunAdet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comFirmaAlici = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskMiktar.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(403, 75);
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
            // comAlici
            // 
            this.comAlici.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comAlici.FormattingEnabled = true;
            this.comAlici.Location = new System.Drawing.Point(119, 133);
            this.comAlici.Name = "comAlici";
            this.comAlici.Size = new System.Drawing.Size(227, 26);
            this.comAlici.TabIndex = 2;
            this.comAlici.SelectedIndexChanged += new System.EventHandler(this.comAlici_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(54, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 104;
            this.label11.Text = "Alıcı :";
            // 
            // comMusteriAlici
            // 
            this.comMusteriAlici.FormattingEnabled = true;
            this.comMusteriAlici.Location = new System.Drawing.Point(0, 358);
            this.comMusteriAlici.Name = "comMusteriAlici";
            this.comMusteriAlici.Size = new System.Drawing.Size(35, 21);
            this.comMusteriAlici.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Ürün Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Fiyat :";
            // 
            // maskFiyat
            // 
            this.maskFiyat.Location = new System.Drawing.Point(119, 297);
            this.maskFiyat.MenuManager = this.ribbonControl1;
            this.maskFiyat.Name = "maskFiyat";
            this.maskFiyat.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskFiyat.Properties.Appearance.Options.UseFont = true;
            this.maskFiyat.Properties.Mask.EditMask = "c";
            this.maskFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskFiyat.Size = new System.Drawing.Size(227, 24);
            this.maskFiyat.TabIndex = 6;
            // 
            // maskTutar
            // 
            this.maskTutar.Location = new System.Drawing.Point(119, 331);
            this.maskTutar.MenuManager = this.ribbonControl1;
            this.maskTutar.Name = "maskTutar";
            this.maskTutar.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTutar.Properties.Appearance.Options.UseFont = true;
            this.maskTutar.Properties.Mask.EditMask = "c";
            this.maskTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskTutar.Size = new System.Drawing.Size(227, 24);
            this.maskTutar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Tutar :";
            // 
            // maskMiktar
            // 
            this.maskMiktar.Location = new System.Drawing.Point(119, 257);
            this.maskMiktar.Name = "maskMiktar";
            this.maskMiktar.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskMiktar.Properties.Appearance.Options.UseFont = true;
            this.maskMiktar.Properties.Mask.EditMask = "d";
            this.maskMiktar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskMiktar.Size = new System.Drawing.Size(227, 26);
            this.maskMiktar.TabIndex = 5;
            this.maskMiktar.EditValueChanged += new System.EventHandler(this.maskMiktar_EditValueChanged);
            // 
            // comUrun
            // 
            this.comUrun.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comUrun.FormattingEnabled = true;
            this.comUrun.Location = new System.Drawing.Point(119, 175);
            this.comUrun.Name = "comUrun";
            this.comUrun.Size = new System.Drawing.Size(227, 26);
            this.comUrun.TabIndex = 3;
            this.comUrun.SelectedIndexChanged += new System.EventHandler(this.comUrun_SelectedIndexChanged);
            // 
            // comUrunId
            // 
            this.comUrunId.FormattingEnabled = true;
            this.comUrunId.Location = new System.Drawing.Point(38, 359);
            this.comUrunId.Name = "comUrunId";
            this.comUrunId.Size = new System.Drawing.Size(35, 21);
            this.comUrunId.TabIndex = 120;
            // 
            // comPersonelAd
            // 
            this.comPersonelAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comPersonelAd.FormattingEnabled = true;
            this.comPersonelAd.Location = new System.Drawing.Point(119, 216);
            this.comPersonelAd.Name = "comPersonelAd";
            this.comPersonelAd.Size = new System.Drawing.Size(227, 26);
            this.comPersonelAd.TabIndex = 4;
            this.comPersonelAd.SelectedIndexChanged += new System.EventHandler(this.comPersonelAd_SelectedIndexChanged);
            // 
            // compersonelId
            // 
            this.compersonelId.FormattingEnabled = true;
            this.compersonelId.Location = new System.Drawing.Point(79, 359);
            this.compersonelId.Name = "compersonelId";
            this.compersonelId.Size = new System.Drawing.Size(35, 21);
            this.compersonelId.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "Personel Ad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(52, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 127;
            this.label6.Text = "Satış :";
            // 
            // comSec
            // 
            this.comSec.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comSec.FormattingEnabled = true;
            this.comSec.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.comSec.Location = new System.Drawing.Point(119, 97);
            this.comSec.Name = "comSec";
            this.comSec.Size = new System.Drawing.Size(227, 26);
            this.comSec.TabIndex = 1;
            this.comSec.SelectedIndexChanged += new System.EventHandler(this.comSec_SelectedIndexChanged);
            // 
            // comUrunAdet
            // 
            this.comUrunAdet.FormattingEnabled = true;
            this.comUrunAdet.Location = new System.Drawing.Point(119, 359);
            this.comUrunAdet.Name = "comUrunAdet";
            this.comUrunAdet.Size = new System.Drawing.Size(35, 21);
            this.comUrunAdet.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "label7";
            // 
            // comFirmaAlici
            // 
            this.comFirmaAlici.FormattingEnabled = true;
            this.comFirmaAlici.Location = new System.Drawing.Point(160, 359);
            this.comFirmaAlici.Name = "comFirmaAlici";
            this.comFirmaAlici.Size = new System.Drawing.Size(35, 21);
            this.comFirmaAlici.TabIndex = 133;
            // 
            // FrmDetayYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 373);
            this.Controls.Add(this.comFirmaAlici);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comUrunAdet);
            this.Controls.Add(this.comSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.compersonelId);
            this.Controls.Add(this.comPersonelAd);
            this.Controls.Add(this.comUrunId);
            this.Controls.Add(this.comUrun);
            this.Controls.Add(this.maskMiktar);
            this.Controls.Add(this.maskTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comMusteriAlici);
            this.Controls.Add(this.comAlici);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetayYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Detay Yeni";
            this.Load += new System.EventHandler(this.FrmDetayYeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskMiktar.Properties)).EndInit();
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
        private System.Windows.Forms.ComboBox comAlici;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comMusteriAlici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit maskFiyat;
        private DevExpress.XtraEditors.TextEdit maskTutar;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit maskMiktar;
        private System.Windows.Forms.ComboBox comUrun;
        private System.Windows.Forms.ComboBox comUrunId;
        private System.Windows.Forms.ComboBox comPersonelAd;
        public System.Windows.Forms.ComboBox compersonelId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comSec;
        public System.Windows.Forms.ComboBox comUrunAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comFirmaAlici;
    }
}