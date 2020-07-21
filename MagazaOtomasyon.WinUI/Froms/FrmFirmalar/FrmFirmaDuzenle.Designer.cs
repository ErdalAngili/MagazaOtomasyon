namespace MagazaOtomasyon.WinUI.Froms.FrmFirmalar
{
    partial class FrmFirmaDuzenle
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtOzelKod2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOzelkod1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richAdres = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comIlce = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comIl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskFax = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new MagazaOtomasyon.WinUI.Froms.UserControl.MyTextMail.MyTextMail();
            this.label7 = new System.Windows.Forms.Label();
            this.maskTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSektor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyetkiliStatu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textfirmaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmaId = new System.Windows.Forms.TextBox();
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
            this.barCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCikis_ItemClick);
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(153, 475);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 24);
            this.simpleButton1.TabIndex = 120;
            this.simpleButton1.Text = "Kod Açılamaları";
            // 
            // txtOzelKod2
            // 
            this.txtOzelKod2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzelKod2.Location = new System.Drawing.Point(443, 509);
            this.txtOzelKod2.Name = "txtOzelKod2";
            this.txtOzelKod2.Size = new System.Drawing.Size(166, 23);
            this.txtOzelKod2.TabIndex = 104;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(340, 510);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 118;
            this.label14.Text = "Özel Kod 2 :";
            // 
            // txtOzelkod1
            // 
            this.txtOzelkod1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzelkod1.Location = new System.Drawing.Point(153, 510);
            this.txtOzelkod1.Name = "txtOzelkod1";
            this.txtOzelkod1.Size = new System.Drawing.Size(166, 23);
            this.txtOzelkod1.TabIndex = 103;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(41, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 117;
            this.label13.Text = "Özel Kod 1 :";
            // 
            // richAdres
            // 
            this.richAdres.Location = new System.Drawing.Point(153, 379);
            this.richAdres.Name = "richAdres";
            this.richAdres.Size = new System.Drawing.Size(456, 85);
            this.richAdres.TabIndex = 12;
            this.richAdres.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(78, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 116;
            this.label12.Text = "Adres :";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(153, 329);
            this.txtVergiDairesi.Multiline = true;
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(456, 35);
            this.txtVergiDairesi.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(31, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 115;
            this.label11.Text = "Vergi Dairesi :";
            // 
            // comIlce
            // 
            this.comIlce.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIlce.FormattingEnabled = true;
            this.comIlce.Location = new System.Drawing.Point(443, 288);
            this.comIlce.Name = "comIlce";
            this.comIlce.Size = new System.Drawing.Size(166, 26);
            this.comIlce.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(392, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 114;
            this.label9.Text = "İlçe :";
            // 
            // comIl
            // 
            this.comIl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comIl.FormattingEnabled = true;
            this.comIl.Location = new System.Drawing.Point(153, 288);
            this.comIl.Name = "comIl";
            this.comIl.Size = new System.Drawing.Size(183, 26);
            this.comIl.TabIndex = 9;
            this.comIl.SelectedIndexChanged += new System.EventHandler(this.comIl_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(110, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 113;
            this.label10.Text = "İl :";
            // 
            // mskFax
            // 
            this.mskFax.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.mskFax.Location = new System.Drawing.Point(443, 249);
            this.mskFax.Mask = "(999) 000-0000";
            this.mskFax.Name = "mskFax";
            this.mskFax.Size = new System.Drawing.Size(166, 23);
            this.mskFax.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(393, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 112;
            this.label8.Text = "Fax :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(154, 249);
            this.txtMail.MenuManager = this.ribbonControl1;
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtMail.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.txtMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMail.Properties.MaxLength = 60;
            this.txtMail.Size = new System.Drawing.Size(182, 24);
            this.txtMail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(90, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 111;
            this.label7.Text = "Mail :";
            // 
            // maskTelefon2
            // 
            this.maskTelefon2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTelefon2.Location = new System.Drawing.Point(443, 211);
            this.maskTelefon2.Mask = "(999) 000-0000";
            this.maskTelefon2.Name = "maskTelefon2";
            this.maskTelefon2.Size = new System.Drawing.Size(166, 23);
            this.maskTelefon2.TabIndex = 6;
            // 
            // maskTelefon1
            // 
            this.maskTelefon1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskTelefon1.Location = new System.Drawing.Point(154, 211);
            this.maskTelefon1.Mask = "(999) 000-0000";
            this.maskTelefon1.Name = "maskTelefon1";
            this.maskTelefon1.Size = new System.Drawing.Size(182, 23);
            this.maskTelefon1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(351, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "Telefon 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 109;
            this.label5.Text = "Telefon 1 :";
            // 
            // txtSektor
            // 
            this.txtSektor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSektor.Location = new System.Drawing.Point(443, 172);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(166, 23);
            this.txtSektor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(372, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "Sektör :";
            // 
            // txtyetkiliAdSoyad
            // 
            this.txtyetkiliAdSoyad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyetkiliAdSoyad.Location = new System.Drawing.Point(153, 135);
            this.txtyetkiliAdSoyad.Name = "txtyetkiliAdSoyad";
            this.txtyetkiliAdSoyad.Size = new System.Drawing.Size(456, 23);
            this.txtyetkiliAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Yetkili Ad-Soyad :";
            // 
            // txtyetkiliStatu
            // 
            this.txtyetkiliStatu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyetkiliStatu.Location = new System.Drawing.Point(153, 173);
            this.txtyetkiliStatu.Name = "txtyetkiliStatu";
            this.txtyetkiliStatu.Size = new System.Drawing.Size(183, 23);
            this.txtyetkiliStatu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Yetkili Statü :";
            // 
            // textfirmaAd
            // 
            this.textfirmaAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textfirmaAd.Location = new System.Drawing.Point(153, 96);
            this.textfirmaAd.Name = "textfirmaAd";
            this.textfirmaAd.Size = new System.Drawing.Size(456, 23);
            this.textfirmaAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Firma Ad :";
            // 
            // txtFirmaId
            // 
            this.txtFirmaId.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaId.Location = new System.Drawing.Point(0, 521);
            this.txtFirmaId.Name = "txtFirmaId";
            this.txtFirmaId.Size = new System.Drawing.Size(20, 23);
            this.txtFirmaId.TabIndex = 122;
            this.txtFirmaId.Visible = false;
            // 
            // FrmFirmaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 542);
            this.Controls.Add(this.txtFirmaId);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtOzelKod2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtOzelkod1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richAdres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comIlce);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comIl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskFax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskTelefon2);
            this.Controls.Add(this.maskTelefon1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSektor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyetkiliAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyetkiliStatu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textfirmaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFirmaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Düzenle";
            this.Load += new System.EventHandler(this.FrmFirmaDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barDuzenle;
        private DevExpress.XtraBars.BarButtonItem barCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtOzelKod2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOzelkod1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richAdres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comIlce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comIl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskFax;
        private System.Windows.Forms.Label label8;
        private UserControl.MyTextMail.MyTextMail txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskTelefon2;
        private System.Windows.Forms.MaskedTextBox maskTelefon1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSektor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyetkiliAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyetkiliStatu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textfirmaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmaId;
    }
}