namespace MagazaOtomasyon.WinUI.Forms.FrmUrun
{
    partial class FrmUrunDuzenle
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
            this.barBtnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textSatis = new DevExpress.XtraEditors.TextEdit();
            this.textMaliyet = new DevExpress.XtraEditors.TextEdit();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.maskYil = new System.Windows.Forms.MaskedTextBox();
            this.richDetay = new System.Windows.Forms.RichTextBox();
            this.textMarka = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaliyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
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
            this.barBtnDuzenle,
            this.barBtnCikis});
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
            this.ribbonControl1.Size = new System.Drawing.Size(524, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barBtnDuzenle
            // 
            this.barBtnDuzenle.Caption = "Düzenle";
            this.barBtnDuzenle.Id = 1;
            this.barBtnDuzenle.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Duzenle;
            this.barBtnDuzenle.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barBtnDuzenle.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnDuzenle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barBtnDuzenle.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnDuzenle.Name = "barBtnDuzenle";
            this.barBtnDuzenle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDuzenle_ItemClick);
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 2;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // textSatis
            // 
            this.textSatis.Location = new System.Drawing.Point(103, 192);
            this.textSatis.Name = "textSatis";
            this.textSatis.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textSatis.Properties.Appearance.Options.UseFont = true;
            this.textSatis.Properties.Mask.EditMask = "c";
            this.textSatis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textSatis.Size = new System.Drawing.Size(163, 24);
            this.textSatis.TabIndex = 21;
            // 
            // textMaliyet
            // 
            this.textMaliyet.Location = new System.Drawing.Point(103, 153);
            this.textMaliyet.MenuManager = this.ribbonControl1;
            this.textMaliyet.Name = "textMaliyet";
            this.textMaliyet.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textMaliyet.Properties.Appearance.Options.UseFont = true;
            this.textMaliyet.Properties.Mask.EditMask = "c";
            this.textMaliyet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textMaliyet.Size = new System.Drawing.Size(163, 24);
            this.textMaliyet.TabIndex = 17;
            // 
            // numAdet
            // 
            this.numAdet.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.numAdet.Location = new System.Drawing.Point(103, 115);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(163, 23);
            this.numAdet.TabIndex = 13;
            // 
            // maskYil
            // 
            this.maskYil.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maskYil.Location = new System.Drawing.Point(347, 153);
            this.maskYil.Mask = "0000";
            this.maskYil.Name = "maskYil";
            this.maskYil.Size = new System.Drawing.Size(163, 23);
            this.maskYil.TabIndex = 19;
            this.maskYil.ValidatingType = typeof(int);
            // 
            // richDetay
            // 
            this.richDetay.Location = new System.Drawing.Point(103, 232);
            this.richDetay.Name = "richDetay";
            this.richDetay.Size = new System.Drawing.Size(407, 124);
            this.richDetay.TabIndex = 23;
            this.richDetay.Text = "";
            // 
            // textMarka
            // 
            this.textMarka.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMarka.Location = new System.Drawing.Point(347, 77);
            this.textMarka.Name = "textMarka";
            this.textMarka.Size = new System.Drawing.Size(163, 23);
            this.textMarka.TabIndex = 11;
            // 
            // textModel
            // 
            this.textModel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textModel.Location = new System.Drawing.Point(347, 115);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(163, 23);
            this.textModel.TabIndex = 15;
            // 
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(103, 77);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(163, 23);
            this.textAd.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(36, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Detay :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Satış Fiyat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Maliyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(304, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yıl :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(279, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad :";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(75, 355);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(22, 21);
            this.textId.TabIndex = 28;
            this.textId.Visible = false;
            // 
            // FrmUrunDuzenle
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 368);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textSatis);
            this.Controls.Add(this.textMaliyet);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.maskYil);
            this.Controls.Add(this.richDetay);
            this.Controls.Add(this.textMarka);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Düzenle";
            this.Load += new System.EventHandler(this.FrmUrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaliyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnDuzenle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
        private DevExpress.XtraEditors.TextEdit textSatis;
        private DevExpress.XtraEditors.TextEdit textMaliyet;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.MaskedTextBox maskYil;
        private System.Windows.Forms.RichTextBox richDetay;
        private System.Windows.Forms.TextBox textMarka;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
    }
}