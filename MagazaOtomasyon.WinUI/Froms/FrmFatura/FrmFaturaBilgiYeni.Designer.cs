namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    partial class FrmFaturaBilgiYeni
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
            this.txtseri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskTarih = new System.Windows.Forms.MaskedTextBox();
            this.MaskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comPersonelAd = new System.Windows.Forms.ComboBox();
            this.ComAlici = new System.Windows.Forms.ComboBox();
            this.comTeslimAlan = new System.Windows.Forms.ComboBox();
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
            this.ribbonControl1.Size = new System.Drawing.Size(634, 75);
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
            // txtseri
            // 
            this.txtseri.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtseri.Location = new System.Drawing.Point(81, 97);
            this.txtseri.Name = "txtseri";
            this.txtseri.Size = new System.Drawing.Size(183, 23);
            this.txtseri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Seri :";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiraNo.Location = new System.Drawing.Point(81, 135);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(183, 23);
            this.txtSiraNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Sıra No :";
            // 
            // MaskTarih
            // 
            this.MaskTarih.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.MaskTarih.Location = new System.Drawing.Point(81, 173);
            this.MaskTarih.Mask = "00/00/0000";
            this.MaskTarih.Name = "MaskTarih";
            this.MaskTarih.Size = new System.Drawing.Size(183, 23);
            this.MaskTarih.TabIndex = 3;
            this.MaskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MaskSaat
            // 
            this.MaskSaat.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.MaskSaat.Location = new System.Drawing.Point(81, 211);
            this.MaskSaat.Mask = "90:00";
            this.MaskSaat.Name = "MaskSaat";
            this.MaskSaat.Size = new System.Drawing.Size(183, 23);
            this.MaskSaat.TabIndex = 4;
            this.MaskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Saat :";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(427, 211);
            this.txtVergiDairesi.Multiline = true;
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(183, 41);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(314, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 83;
            this.label11.Text = "Vergi Dairesi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(371, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Alıcı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(317, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Teslim Eden :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(323, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Teslim Alan :";
            // 
            // comPersonelAd
            // 
            this.comPersonelAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comPersonelAd.FormattingEnabled = true;
            this.comPersonelAd.Location = new System.Drawing.Point(427, 135);
            this.comPersonelAd.Name = "comPersonelAd";
            this.comPersonelAd.Size = new System.Drawing.Size(183, 26);
            this.comPersonelAd.TabIndex = 6;
            // 
            // ComAlici
            // 
            this.ComAlici.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.ComAlici.FormattingEnabled = true;
            this.ComAlici.Items.AddRange(new object[] {
            "Müşteri",
            "Firma"});
            this.ComAlici.Location = new System.Drawing.Point(427, 97);
            this.ComAlici.Name = "ComAlici";
            this.ComAlici.Size = new System.Drawing.Size(183, 26);
            this.ComAlici.TabIndex = 5;
            this.ComAlici.SelectedIndexChanged += new System.EventHandler(this.ComAlici_SelectedIndexChanged);
            // 
            // comTeslimAlan
            // 
            this.comTeslimAlan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comTeslimAlan.FormattingEnabled = true;
            this.comTeslimAlan.Location = new System.Drawing.Point(427, 173);
            this.comTeslimAlan.Name = "comTeslimAlan";
            this.comTeslimAlan.Size = new System.Drawing.Size(183, 26);
            this.comTeslimAlan.TabIndex = 7;
            // 
            // FrmFaturaBilgiYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 262);
            this.Controls.Add(this.comTeslimAlan);
            this.Controls.Add(this.ComAlici);
            this.Controls.Add(this.comPersonelAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaskTarih);
            this.Controls.Add(this.MaskSaat);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtseri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturaBilgiYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Fatura Ekle";
            this.Load += new System.EventHandler(this.FrmFaturaBilgiYeni_Load);
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
        private System.Windows.Forms.TextBox txtseri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskTarih;
        private System.Windows.Forms.MaskedTextBox MaskSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comPersonelAd;
        private System.Windows.Forms.ComboBox ComAlici;
        private System.Windows.Forms.ComboBox comTeslimAlan;
    }
}