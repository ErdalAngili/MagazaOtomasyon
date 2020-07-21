namespace MagazaOtomasyon.WinUI.Froms.FrmFirmalar
{
    partial class FrmFirmaList
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
            this.colFirmaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliStatu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSektor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLVergiDaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.TabIndex = 4;
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
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirmaId,
            this.colFirmaAd,
            this.colYetkiliAdSoyad,
            this.colYetkiliStatu,
            this.colSektor,
            this.colTelefon1,
            this.colTelefon2,
            this.colMail,
            this.colFax,
            this.colIl,
            this.colIlce,
            this.COLVergiDaire,
            this.colAdres,
            this.colOzelKod1,
            this.colOzelKod2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFirmaId
            // 
            this.colFirmaId.Caption = "FirmaId";
            this.colFirmaId.FieldName = "FirmaId";
            this.colFirmaId.Name = "colFirmaId";
            // 
            // colFirmaAd
            // 
            this.colFirmaAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFirmaAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFirmaAd.AppearanceHeader.Options.UseFont = true;
            this.colFirmaAd.AppearanceHeader.Options.UseForeColor = true;
            this.colFirmaAd.Caption = "FİRMA AD";
            this.colFirmaAd.FieldName = "FirmaAd";
            this.colFirmaAd.Name = "colFirmaAd";
            this.colFirmaAd.OptionsColumn.AllowEdit = false;
            this.colFirmaAd.Visible = true;
            this.colFirmaAd.VisibleIndex = 0;
            this.colFirmaAd.Width = 87;
            // 
            // colYetkiliAdSoyad
            // 
            this.colYetkiliAdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colYetkiliAdSoyad.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colYetkiliAdSoyad.AppearanceHeader.Options.UseFont = true;
            this.colYetkiliAdSoyad.AppearanceHeader.Options.UseForeColor = true;
            this.colYetkiliAdSoyad.Caption = "YETKİLİ AD SOYAD";
            this.colYetkiliAdSoyad.FieldName = "YetkiliAdSoyad";
            this.colYetkiliAdSoyad.Name = "colYetkiliAdSoyad";
            this.colYetkiliAdSoyad.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdSoyad.Visible = true;
            this.colYetkiliAdSoyad.VisibleIndex = 1;
            this.colYetkiliAdSoyad.Width = 118;
            // 
            // colYetkiliStatu
            // 
            this.colYetkiliStatu.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colYetkiliStatu.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colYetkiliStatu.AppearanceHeader.Options.UseFont = true;
            this.colYetkiliStatu.AppearanceHeader.Options.UseForeColor = true;
            this.colYetkiliStatu.Caption = "YETKİLİ STATÜ";
            this.colYetkiliStatu.FieldName = "YetkiliStatu";
            this.colYetkiliStatu.Name = "colYetkiliStatu";
            this.colYetkiliStatu.OptionsColumn.AllowEdit = false;
            this.colYetkiliStatu.Visible = true;
            this.colYetkiliStatu.VisibleIndex = 2;
            this.colYetkiliStatu.Width = 102;
            // 
            // colSektor
            // 
            this.colSektor.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colSektor.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colSektor.AppearanceHeader.Options.UseFont = true;
            this.colSektor.AppearanceHeader.Options.UseForeColor = true;
            this.colSektor.Caption = "SEKTÖR";
            this.colSektor.FieldName = "Sektor";
            this.colSektor.Name = "colSektor";
            this.colSektor.OptionsColumn.AllowEdit = false;
            this.colSektor.Visible = true;
            this.colSektor.VisibleIndex = 3;
            this.colSektor.Width = 76;
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
            this.colTelefon1.VisibleIndex = 4;
            this.colTelefon1.Width = 76;
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
            this.colTelefon2.VisibleIndex = 5;
            this.colTelefon2.Width = 86;
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
            this.colMail.VisibleIndex = 6;
            this.colMail.Width = 70;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFax.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFax.AppearanceHeader.Options.UseFont = true;
            this.colFax.AppearanceHeader.Options.UseForeColor = true;
            this.colFax.Caption = "FAX";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            this.colFax.Width = 72;
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
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 8;
            this.colIl.Width = 72;
            // 
            // colIlce
            // 
            this.colIlce.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIlce.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIlce.AppearanceHeader.Options.UseFont = true;
            this.colIlce.AppearanceHeader.Options.UseForeColor = true;
            this.colIlce.Caption = "İLÇE";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 9;
            this.colIlce.Width = 88;
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
            this.COLVergiDaire.VisibleIndex = 11;
            this.COLVergiDaire.Width = 130;
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
            this.colAdres.VisibleIndex = 10;
            this.colAdres.Width = 98;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colOzelKod1.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colOzelKod1.AppearanceHeader.Options.UseFont = true;
            this.colOzelKod1.AppearanceHeader.Options.UseForeColor = true;
            this.colOzelKod1.Caption = "ÖZEL KOD 1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.VisibleIndex = 12;
            this.colOzelKod1.Width = 78;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colOzelKod2.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colOzelKod2.AppearanceHeader.Options.UseFont = true;
            this.colOzelKod2.AppearanceHeader.Options.UseForeColor = true;
            this.colOzelKod2.Caption = "ÖZEL KOD 2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.VisibleIndex = 13;
            this.colOzelKod2.Width = 120;
            // 
            // FrmFirmaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmFirmaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.FrmFirmaList_Load);
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaAd;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliStatu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon2;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn COLVergiDaire;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
    }
}