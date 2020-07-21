namespace MagazaOtomasyon.WinUI.Froms.FrmMusteri
{
    partial class FrmMusteriList
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
            this.barbtnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.barDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.barYenile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barFiltrele = new DevExpress.XtraBars.BarButtonItem();
            this.barSil = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.textAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMusteriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLVergiDaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barbtnYeni,
            this.barDuzenle,
            this.barYenile,
            this.barButtonItem4,
            this.barFiltrele,
            this.barSil,
            this.barButtonItem7,
            this.barCikis});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
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
            this.ribbonControl1.Size = new System.Drawing.Size(1291, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barbtnYeni
            // 
            this.barbtnYeni.Caption = "Yeni";
            this.barbtnYeni.Id = 1;
            this.barbtnYeni.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Ekle;
            this.barbtnYeni.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barbtnYeni.ItemAppearance.Hovered.Options.UseFont = true;
            this.barbtnYeni.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barbtnYeni.ItemAppearance.Normal.Options.UseFont = true;
            this.barbtnYeni.Name = "barbtnYeni";
            this.barbtnYeni.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnYeni_ItemClick);
            // 
            // barDuzenle
            // 
            this.barDuzenle.Caption = "Düzenle";
            this.barDuzenle.Id = 2;
            this.barDuzenle.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Duzenle;
            this.barDuzenle.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barDuzenle.ItemAppearance.Hovered.Options.UseFont = true;
            this.barDuzenle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barDuzenle.ItemAppearance.Normal.Options.UseFont = true;
            this.barDuzenle.Name = "barDuzenle";
            this.barDuzenle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDuzenle_ItemClick);
            // 
            // barYenile
            // 
            this.barYenile.Caption = "Yenile";
            this.barYenile.Id = 3;
            this.barYenile.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Gerial;
            this.barYenile.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barYenile.ItemAppearance.Hovered.Options.UseFont = true;
            this.barYenile.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barYenile.ItemAppearance.Normal.Options.UseFont = true;
            this.barYenile.Name = "barYenile";
            this.barYenile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYenile_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Kopyala";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.kopyala;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barFiltrele
            // 
            this.barFiltrele.Caption = "Ara";
            this.barFiltrele.Id = 5;
            this.barFiltrele.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.ara;
            this.barFiltrele.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barFiltrele.ItemAppearance.Hovered.Options.UseFont = true;
            this.barFiltrele.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barFiltrele.ItemAppearance.Normal.Options.UseFont = true;
            this.barFiltrele.Name = "barFiltrele";
            this.barFiltrele.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSil
            // 
            this.barSil.Caption = "Sil";
            this.barSil.Id = 6;
            this.barSil.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Sil;
            this.barSil.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barSil.ItemAppearance.Hovered.Options.UseFont = true;
            this.barSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barSil.ItemAppearance.Normal.Options.UseFont = true;
            this.barSil.Name = "barSil";
            this.barSil.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSil_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Ara";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.ara;
            this.barButtonItem7.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barButtonItem7.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barCikis
            // 
            this.barCikis.Caption = "Çıkış";
            this.barCikis.Id = 8;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.barYenile);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.textAra);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 622);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1291, 67);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.ara;
            this.btnAra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(949, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(114, 39);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textAra
            // 
            this.textAra.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAra.Location = new System.Drawing.Point(725, 31);
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(209, 23);
            this.textAra.TabIndex = 2;
            this.textAra.TextChanged += new System.EventHandler(this.textAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(675, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ara :";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1291, 547);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMusteriId,
            this.colAd,
            this.colSoyad,
            this.colTC,
            this.colTelefon1,
            this.colTelefon2,
            this.colMail,
            this.colIl,
            this.colIlce,
            this.colAdres,
            this.COLVergiDaire});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMusteriId
            // 
            this.colMusteriId.Caption = "MusteriId";
            this.colMusteriId.FieldName = "MusteriId";
            this.colMusteriId.Name = "colMusteriId";
            // 
            // colAd
            // 
            this.colAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colAd.AppearanceHeader.Options.UseFont = true;
            this.colAd.AppearanceHeader.Options.UseForeColor = true;
            this.colAd.Caption = "AD";
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.OptionsColumn.AllowEdit = false;
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 0;
            this.colAd.Width = 103;
            // 
            // colSoyad
            // 
            this.colSoyad.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colSoyad.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colSoyad.AppearanceHeader.Options.UseFont = true;
            this.colSoyad.AppearanceHeader.Options.UseForeColor = true;
            this.colSoyad.Caption = "SOYAD";
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.OptionsColumn.AllowEdit = false;
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 1;
            this.colSoyad.Width = 103;
            // 
            // colTelefon1
            // 
            this.colTelefon1.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTelefon1.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTelefon1.AppearanceHeader.Options.UseFont = true;
            this.colTelefon1.AppearanceHeader.Options.UseForeColor = true;
            this.colTelefon1.Caption = "TELEFON 1";
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.OptionsColumn.AllowEdit = false;
            this.colTelefon1.Visible = true;
            this.colTelefon1.VisibleIndex = 3;
            this.colTelefon1.Width = 82;
            // 
            // colTelefon2
            // 
            this.colTelefon2.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTelefon2.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTelefon2.AppearanceHeader.Options.UseFont = true;
            this.colTelefon2.AppearanceHeader.Options.UseForeColor = true;
            this.colTelefon2.Caption = "TELEFON 2";
            this.colTelefon2.FieldName = "Telefon2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.OptionsColumn.AllowEdit = false;
            this.colTelefon2.Visible = true;
            this.colTelefon2.VisibleIndex = 4;
            this.colTelefon2.Width = 82;
            // 
            // colMail
            // 
            this.colMail.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colMail.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colMail.AppearanceHeader.Options.UseFont = true;
            this.colMail.AppearanceHeader.Options.UseForeColor = true;
            this.colMail.Caption = "MAİL";
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.OptionsColumn.AllowEdit = false;
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 5;
            this.colMail.Width = 92;
            // 
            // colIl
            // 
            this.colIl.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIl.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIl.AppearanceHeader.Options.UseFont = true;
            this.colIl.AppearanceHeader.Options.UseForeColor = true;
            this.colIl.Caption = "İL";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 6;
            this.colIl.Width = 76;
            // 
            // colIlce
            // 
            this.colIlce.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIlce.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIlce.AppearanceHeader.Options.UseFont = true;
            this.colIlce.AppearanceHeader.Options.UseForeColor = true;
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 7;
            this.colIlce.Width = 94;
            // 
            // colAdres
            // 
            this.colAdres.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colAdres.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colAdres.AppearanceHeader.Options.UseFont = true;
            this.colAdres.AppearanceHeader.Options.UseForeColor = true;
            this.colAdres.Caption = "ADRES";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 8;
            this.colAdres.Width = 123;
            // 
            // COLVergiDaire
            // 
            this.COLVergiDaire.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.COLVergiDaire.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.COLVergiDaire.AppearanceHeader.Options.UseFont = true;
            this.COLVergiDaire.AppearanceHeader.Options.UseForeColor = true;
            this.COLVergiDaire.Caption = "VERGİ DAİRESİ";
            this.COLVergiDaire.FieldName = "VergiDaire";
            this.COLVergiDaire.Name = "COLVergiDaire";
            this.COLVergiDaire.Visible = true;
            this.COLVergiDaire.VisibleIndex = 9;
            this.COLVergiDaire.Width = 149;
            // 
            // colTC
            // 
            this.colTC.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTC.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTC.AppearanceHeader.Options.UseFont = true;
            this.colTC.AppearanceHeader.Options.UseForeColor = true;
            this.colTC.Caption = "T.C. KİMLİK NO";
            this.colTC.FieldName = "TC";
            this.colTC.Name = "colTC";
            this.colTC.OptionsColumn.AllowEdit = false;
            this.colTC.Visible = true;
            this.colTC.VisibleIndex = 2;
            this.colTC.Width = 87;
            // 
            // FrmMusteriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmMusteriList";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmMusteriList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barbtnYeni;
        private DevExpress.XtraBars.BarButtonItem barDuzenle;
        private DevExpress.XtraBars.BarButtonItem barYenile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barFiltrele;
        private DevExpress.XtraBars.BarButtonItem barSil;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.TextBox textAra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriId;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon2;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn COLVergiDaire;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTC;
    }
}