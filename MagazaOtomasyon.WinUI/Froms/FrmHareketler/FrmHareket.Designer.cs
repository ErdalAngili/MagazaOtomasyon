namespace MagazaOtomasyon.WinUI.Froms.FrmHareketler
{
    partial class FrmHareket
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMusteriHareketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirmaHareketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barYenile);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 75);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1291, 614);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1285, 586);
            this.xtraTabPage1.Text = "Müşteri Hareketler";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1285, 586);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMusteriHareketId,
            this.colUrunAd,
            this.colAdet,
            this.colPersonelAdSoyad,
            this.colMusteriAdSoyad,
            this.colFiyat,
            this.colToplam,
            this.colFaturaSiraNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMusteriHareketId
            // 
            this.colMusteriHareketId.Caption = "MusteriHareketId";
            this.colMusteriHareketId.FieldName = "MusteriHareketId";
            this.colMusteriHareketId.Name = "colMusteriHareketId";
            // 
            // colUrunAd
            // 
            this.colUrunAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colUrunAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colUrunAd.AppearanceHeader.Options.UseFont = true;
            this.colUrunAd.AppearanceHeader.Options.UseForeColor = true;
            this.colUrunAd.Caption = "Ürün Ad";
            this.colUrunAd.FieldName = "UrunAd";
            this.colUrunAd.Name = "colUrunAd";
            this.colUrunAd.OptionsColumn.AllowEdit = false;
            this.colUrunAd.Visible = true;
            this.colUrunAd.VisibleIndex = 0;
            this.colUrunAd.Width = 112;
            // 
            // colAdet
            // 
            this.colAdet.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colAdet.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colAdet.AppearanceHeader.Options.UseFont = true;
            this.colAdet.AppearanceHeader.Options.UseForeColor = true;
            this.colAdet.Caption = "Adet";
            this.colAdet.FieldName = "Miktar";
            this.colAdet.Name = "colAdet";
            this.colAdet.OptionsColumn.AllowEdit = false;
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 1;
            this.colAdet.Width = 109;
            // 
            // colPersonelAdSoyad
            // 
            this.colPersonelAdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colPersonelAdSoyad.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colPersonelAdSoyad.AppearanceHeader.Options.UseFont = true;
            this.colPersonelAdSoyad.AppearanceHeader.Options.UseForeColor = true;
            this.colPersonelAdSoyad.Caption = "Personel Ad Soyad";
            this.colPersonelAdSoyad.FieldName = "PersonelAdSoyad";
            this.colPersonelAdSoyad.Name = "colPersonelAdSoyad";
            this.colPersonelAdSoyad.OptionsColumn.AllowEdit = false;
            this.colPersonelAdSoyad.Visible = true;
            this.colPersonelAdSoyad.VisibleIndex = 2;
            this.colPersonelAdSoyad.Width = 135;
            // 
            // colMusteriAdSoyad
            // 
            this.colMusteriAdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colMusteriAdSoyad.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colMusteriAdSoyad.AppearanceHeader.Options.UseFont = true;
            this.colMusteriAdSoyad.AppearanceHeader.Options.UseForeColor = true;
            this.colMusteriAdSoyad.Caption = "Musteri Ad Soyad";
            this.colMusteriAdSoyad.FieldName = "MusteriAdSoyad";
            this.colMusteriAdSoyad.Name = "colMusteriAdSoyad";
            this.colMusteriAdSoyad.OptionsColumn.AllowEdit = false;
            this.colMusteriAdSoyad.Visible = true;
            this.colMusteriAdSoyad.VisibleIndex = 3;
            this.colMusteriAdSoyad.Width = 122;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFiyat.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFiyat.AppearanceHeader.Options.UseFont = true;
            this.colFiyat.AppearanceHeader.Options.UseForeColor = true;
            this.colFiyat.Caption = "Fiyat";
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowEdit = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 5;
            this.colFiyat.Width = 116;
            // 
            // colToplam
            // 
            this.colToplam.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colToplam.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colToplam.AppearanceHeader.Options.UseFont = true;
            this.colToplam.AppearanceHeader.Options.UseForeColor = true;
            this.colToplam.Caption = "Toplam";
            this.colToplam.FieldName = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 6;
            this.colToplam.Width = 103;
            // 
            // colFaturaSiraNo
            // 
            this.colFaturaSiraNo.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFaturaSiraNo.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFaturaSiraNo.AppearanceHeader.Options.UseFont = true;
            this.colFaturaSiraNo.AppearanceHeader.Options.UseForeColor = true;
            this.colFaturaSiraNo.Caption = "Fatura Sıra No";
            this.colFaturaSiraNo.FieldName = "FaturaSiraNo";
            this.colFaturaSiraNo.Name = "colFaturaSiraNo";
            this.colFaturaSiraNo.Visible = true;
            this.colFaturaSiraNo.VisibleIndex = 4;
            this.colFaturaSiraNo.Width = 129;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1285, 586);
            this.xtraTabPage2.Text = "Firma Hareketler";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1285, 586);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirmaHareketId,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colFirmaAd,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colFirmaHareketId
            // 
            this.colFirmaHareketId.Caption = "FirmaHareketId";
            this.colFirmaHareketId.FieldName = "FirmaHareketId";
            this.colFirmaHareketId.Name = "colFirmaHareketId";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "Ürün Ad";
            this.gridColumn2.FieldName = "UrunAd";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "Adet";
            this.gridColumn3.FieldName = "Adet";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 109;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "Personel Ad Soyad";
            this.gridColumn4.FieldName = "PersonelAdSoyad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 135;
            // 
            // colFirmaAd
            // 
            this.colFirmaAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFirmaAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFirmaAd.AppearanceHeader.Options.UseFont = true;
            this.colFirmaAd.AppearanceHeader.Options.UseForeColor = true;
            this.colFirmaAd.Caption = "Firma Ad";
            this.colFirmaAd.FieldName = "FirmaAd";
            this.colFirmaAd.Name = "colFirmaAd";
            this.colFirmaAd.OptionsColumn.AllowEdit = false;
            this.colFirmaAd.Visible = true;
            this.colFirmaAd.VisibleIndex = 3;
            this.colFirmaAd.Width = 122;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "Fiyat";
            this.gridColumn6.FieldName = "Fiyat";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 116;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn7.Caption = "Toplam";
            this.gridColumn7.FieldName = "Toplam";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 103;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn8.Caption = "Fatura Sıra No";
            this.gridColumn8.FieldName = "FaturaSiraNo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 129;
            // 
            // FrmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmHareket";
            this.Text = "FrmHareketler";
            this.Load += new System.EventHandler(this.FrmHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriHareketId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaSiraNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        protected DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaHareketId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}