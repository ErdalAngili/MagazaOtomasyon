﻿namespace MagazaOtomasyon.WinUI.Froms.FrmPersonel
{
    partial class FrmPersonelYeni
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
            this.textAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskTCKimlik = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new MagazaOtomasyon.WinUI.Froms.UserControl.MyTextMail.MyTextMail();
            this.label6 = new System.Windows.Forms.Label();
            this.comIl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comIlce = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(663, 75);
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
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(135, 97);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(206, 23);
            this.textAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ad :";
            // 
            // textSoyad
            // 
            this.textSoyad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(444, 96);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(206, 23);
            this.textSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(372, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Soyad :";
            // 
            // maskTCKimlik
            // 
            this.maskTCKimlik.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTCKimlik.Location = new System.Drawing.Point(135, 136);
            this.maskTCKimlik.Mask = "00000000000";
            this.maskTCKimlik.Name = "maskTCKimlik";
            this.maskTCKimlik.Size = new System.Drawing.Size(206, 23);
            this.maskTCKimlik.TabIndex = 3;
            this.maskTCKimlik.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "T.C. Kimlik No :";
            // 
            // maskTelefon1
            // 
            this.maskTelefon1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTelefon1.Location = new System.Drawing.Point(444, 136);
            this.maskTelefon1.Mask = "(999) 000-0000";
            this.maskTelefon1.Name = "maskTelefon1";
            this.maskTelefon1.Size = new System.Drawing.Size(206, 23);
            this.maskTelefon1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(347, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Telefon 1 :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(444, 175);
            this.txtMail.MenuManager = this.ribbonControl1;
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtMail.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.txtMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMail.Properties.MaxLength = 60;
            this.txtMail.Size = new System.Drawing.Size(206, 24);
            this.txtMail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(385, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Mail :";
            // 
            // comIl
            // 
            this.comIl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIl.FormattingEnabled = true;
            this.comIl.Location = new System.Drawing.Point(135, 213);
            this.comIl.Name = "comIl";
            this.comIl.Size = new System.Drawing.Size(206, 26);
            this.comIl.TabIndex = 7;
            this.comIl.SelectedIndexChanged += new System.EventHandler(this.comIl_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(91, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "İl :";
            // 
            // comIlce
            // 
            this.comIlce.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIlce.FormattingEnabled = true;
            this.comIlce.Location = new System.Drawing.Point(444, 213);
            this.comIlce.Name = "comIlce";
            this.comIlce.Size = new System.Drawing.Size(206, 26);
            this.comIlce.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(388, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "İlçe :";
            // 
            // richAdres
            // 
            this.richAdres.Location = new System.Drawing.Point(135, 254);
            this.richAdres.Name = "richAdres";
            this.richAdres.Size = new System.Drawing.Size(515, 119);
            this.richAdres.TabIndex = 9;
            this.richAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(59, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Adres :";
            // 
            // textGorev
            // 
            this.textGorev.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textGorev.Location = new System.Drawing.Point(135, 175);
            this.textGorev.Name = "textGorev";
            this.textGorev.Size = new System.Drawing.Size(206, 23);
            this.textGorev.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Görev :";
            // 
            // FrmPersonelYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 381);
            this.Controls.Add(this.textGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comIlce);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comIl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskTelefon1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskTCKimlik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.FrmPersonelYeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
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
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskTCKimlik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskTelefon1;
        private System.Windows.Forms.Label label5;
        private UserControl.MyTextMail.MyTextMail txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comIl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comIlce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textGorev;
        private System.Windows.Forms.Label label3;
    }
}