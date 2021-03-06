﻿namespace MagazaOtomasyon.WinUI.Froms.FrmBanka
{
    partial class FrmBankaDuzenle
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
            this.barDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.barCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.comFirmaId = new System.Windows.Forms.ComboBox();
            this.comFirma = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textHesapTuru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textYetkili = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textHesapNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSube = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskIban = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comIlce = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comIl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBankaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBankaId = new System.Windows.Forms.TextBox();
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
            this.barDuzenle,
            this.barCikis});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
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
            this.ribbonControl1.Size = new System.Drawing.Size(622, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barDuzenle
            // 
            this.barDuzenle.Caption = "Düzenle";
            this.barDuzenle.Id = 1;
            this.barDuzenle.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Duzenle;
            this.barDuzenle.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barDuzenle.ItemAppearance.Hovered.Options.UseFont = true;
            this.barDuzenle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barDuzenle.ItemAppearance.Normal.Options.UseFont = true;
            this.barDuzenle.Name = "barDuzenle";
            this.barDuzenle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDuzenle_ItemClick);
            // 
            // barCikis
            // 
            this.barCikis.Caption = "Çıkış";
            this.barCikis.Id = 2;
            this.barCikis.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Cikis;
            this.barCikis.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barCikis.ItemAppearance.Hovered.Options.UseFont = true;
            this.barCikis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barCikis.ItemAppearance.Normal.Options.UseFont = true;
            this.barCikis.Name = "barCikis";
            this.barCikis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // comFirmaId
            // 
            this.comFirmaId.FormattingEnabled = true;
            this.comFirmaId.Location = new System.Drawing.Point(-9, 315);
            this.comFirmaId.Name = "comFirmaId";
            this.comFirmaId.Size = new System.Drawing.Size(35, 21);
            this.comFirmaId.TabIndex = 130;
            // 
            // comFirma
            // 
            this.comFirma.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comFirma.FormattingEnabled = true;
            this.comFirma.Location = new System.Drawing.Point(123, 91);
            this.comFirma.Name = "comFirma";
            this.comFirma.Size = new System.Drawing.Size(487, 26);
            this.comFirma.TabIndex = 1;
            this.comFirma.SelectedIndexChanged += new System.EventHandler(this.comFirma_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(27, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Firma Ad :";
            // 
            // textHesapTuru
            // 
            this.textHesapTuru.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textHesapTuru.Location = new System.Drawing.Point(123, 288);
            this.textHesapTuru.Name = "textHesapTuru";
            this.textHesapTuru.Size = new System.Drawing.Size(192, 23);
            this.textHesapTuru.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 127;
            this.label8.Text = "Hesap Türü :";
            // 
            // maskTarih
            // 
            this.maskTarih.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTarih.Location = new System.Drawing.Point(427, 249);
            this.maskTarih.Mask = "00/00/0000";
            this.maskTarih.Name = "maskTarih";
            this.maskTarih.Size = new System.Drawing.Size(183, 23);
            this.maskTarih.TabIndex = 10;
            this.maskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(358, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 125;
            this.label7.Text = "Tarih :";
            // 
            // maskTelefon
            // 
            this.maskTelefon.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTelefon.Location = new System.Drawing.Point(427, 210);
            this.maskTelefon.Mask = "(999) 000-0000";
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(183, 23);
            this.maskTelefon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(340, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 123;
            this.label6.Text = "Telefon :";
            // 
            // textYetkili
            // 
            this.textYetkili.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYetkili.Location = new System.Drawing.Point(427, 288);
            this.textYetkili.Name = "textYetkili";
            this.textYetkili.Size = new System.Drawing.Size(183, 23);
            this.textYetkili.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(349, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "Yetkili :";
            // 
            // textHesapNo
            // 
            this.textHesapNo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textHesapNo.Location = new System.Drawing.Point(123, 249);
            this.textHesapNo.Name = "textHesapNo";
            this.textHesapNo.Size = new System.Drawing.Size(192, 23);
            this.textHesapNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Hesap No :";
            // 
            // textSube
            // 
            this.textSube.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSube.Location = new System.Drawing.Point(123, 210);
            this.textSube.Name = "textSube";
            this.textSube.Size = new System.Drawing.Size(192, 23);
            this.textSube.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "Şube :";
            // 
            // mskIban
            // 
            this.mskIban.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.mskIban.Location = new System.Drawing.Point(123, 172);
            this.mskIban.Mask = "TR000000000000000000000000";
            this.mskIban.Name = "mskIban";
            this.mskIban.Size = new System.Drawing.Size(192, 23);
            this.mskIban.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "İban :";
            // 
            // comIlce
            // 
            this.comIlce.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIlce.FormattingEnabled = true;
            this.comIlce.Location = new System.Drawing.Point(427, 172);
            this.comIlce.Name = "comIlce";
            this.comIlce.Size = new System.Drawing.Size(183, 26);
            this.comIlce.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(367, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "İlçe :";
            // 
            // comIl
            // 
            this.comIl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIl.FormattingEnabled = true;
            this.comIl.Location = new System.Drawing.Point(427, 134);
            this.comIl.Name = "comIl";
            this.comIl.Size = new System.Drawing.Size(183, 26);
            this.comIl.TabIndex = 7;
            this.comIl.SelectedIndexChanged += new System.EventHandler(this.comIl_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(384, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 112;
            this.label10.Text = "İl :";
            // 
            // textBankaAd
            // 
            this.textBankaAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBankaAd.Location = new System.Drawing.Point(123, 134);
            this.textBankaAd.Name = "textBankaAd";
            this.textBankaAd.Size = new System.Drawing.Size(192, 23);
            this.textBankaAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Banka Ad :";
            // 
            // textBankaId
            // 
            this.textBankaId.Location = new System.Drawing.Point(589, 315);
            this.textBankaId.Name = "textBankaId";
            this.textBankaId.Size = new System.Drawing.Size(33, 21);
            this.textBankaId.TabIndex = 131;
            // 
            // FrmBankaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 331);
            this.Controls.Add(this.textBankaId);
            this.Controls.Add(this.comFirmaId);
            this.Controls.Add(this.comFirma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textHesapTuru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textYetkili);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textHesapNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comIlce);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comIl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBankaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Düzenle";
            this.Load += new System.EventHandler(this.FrmBankaDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barDuzenle;
        private DevExpress.XtraBars.BarButtonItem barCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.ComboBox comFirmaId;
        private System.Windows.Forms.ComboBox comFirma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textHesapTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textYetkili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHesapNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskIban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comIlce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comIl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBankaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBankaId;
    }
}