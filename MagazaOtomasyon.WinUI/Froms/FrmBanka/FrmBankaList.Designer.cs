namespace MagazaOtomasyon.WinUI.Froms.FrmBanka
{
    partial class FrmBankaList
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
            this.colBankaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankaAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHesapTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFirmaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            this.barCikis,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
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
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.ara;
            this.btnAra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(1053, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(114, 39);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textAra
            // 
            this.textAra.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAra.Location = new System.Drawing.Point(829, 31);
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(209, 23);
            this.textAra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(712, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yıla Göre Ara :";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1291, 547);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankaId,
            this.colBankaAdı,
            this.colIl,
            this.colIlce,
            this.colSube,
            this.colIban,
            this.colHesapNo,
            this.colYetkili,
            this.colTelefon,
            this.colTarih,
            this.gridHesapTuru,
            this.gridFirmaId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.Name = "colBankaId";
            // 
            // colBankaAdı
            // 
            this.colBankaAdı.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colBankaAdı.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colBankaAdı.AppearanceHeader.Options.UseFont = true;
            this.colBankaAdı.AppearanceHeader.Options.UseForeColor = true;
            this.colBankaAdı.Caption = "Banka Adı";
            this.colBankaAdı.FieldName = "BankaAdı";
            this.colBankaAdı.Name = "colBankaAdı";
            this.colBankaAdı.OptionsColumn.AllowEdit = false;
            this.colBankaAdı.Visible = true;
            this.colBankaAdı.VisibleIndex = 0;
            this.colBankaAdı.Width = 93;
            // 
            // colIl
            // 
            this.colIl.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIl.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIl.AppearanceHeader.Options.UseFont = true;
            this.colIl.AppearanceHeader.Options.UseForeColor = true;
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 1;
            this.colIl.Width = 72;
            // 
            // colIlce
            // 
            this.colIlce.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIlce.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIlce.AppearanceHeader.Options.UseFont = true;
            this.colIlce.AppearanceHeader.Options.UseForeColor = true;
            this.colIlce.Caption = "İlce";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 2;
            // 
            // colSube
            // 
            this.colSube.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colSube.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colSube.AppearanceHeader.Options.UseFont = true;
            this.colSube.AppearanceHeader.Options.UseForeColor = true;
            this.colSube.Caption = "Şube";
            this.colSube.FieldName = "Sube";
            this.colSube.Name = "colSube";
            this.colSube.OptionsColumn.AllowEdit = false;
            this.colSube.Visible = true;
            this.colSube.VisibleIndex = 3;
            this.colSube.Width = 66;
            // 
            // colIban
            // 
            this.colIban.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colIban.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colIban.AppearanceHeader.Options.UseFont = true;
            this.colIban.AppearanceHeader.Options.UseForeColor = true;
            this.colIban.Caption = "İban";
            this.colIban.FieldName = "Iban";
            this.colIban.Name = "colIban";
            this.colIban.OptionsColumn.AllowEdit = false;
            this.colIban.Visible = true;
            this.colIban.VisibleIndex = 4;
            this.colIban.Width = 83;
            // 
            // colHesapNo
            // 
            this.colHesapNo.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colHesapNo.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colHesapNo.AppearanceHeader.Options.UseFont = true;
            this.colHesapNo.AppearanceHeader.Options.UseForeColor = true;
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.Visible = true;
            this.colHesapNo.VisibleIndex = 5;
            this.colHesapNo.Width = 82;
            // 
            // colYetkili
            // 
            this.colYetkili.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colYetkili.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colYetkili.AppearanceHeader.Options.UseFont = true;
            this.colYetkili.AppearanceHeader.Options.UseForeColor = true;
            this.colYetkili.Caption = "Yetkili";
            this.colYetkili.FieldName = "Yetkili";
            this.colYetkili.Name = "colYetkili";
            this.colYetkili.OptionsColumn.AllowEdit = false;
            this.colYetkili.Visible = true;
            this.colYetkili.VisibleIndex = 6;
            this.colYetkili.Width = 100;
            // 
            // colTelefon
            // 
            this.colTelefon.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTelefon.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTelefon.AppearanceHeader.Options.UseFont = true;
            this.colTelefon.AppearanceHeader.Options.UseForeColor = true;
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 7;
            this.colTelefon.Width = 91;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTarih.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTarih.AppearanceHeader.Options.UseFont = true;
            this.colTarih.AppearanceHeader.Options.UseForeColor = true;
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            this.colTarih.Width = 87;
            // 
            // gridHesapTuru
            // 
            this.gridHesapTuru.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridHesapTuru.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridHesapTuru.AppearanceHeader.Options.UseFont = true;
            this.gridHesapTuru.AppearanceHeader.Options.UseForeColor = true;
            this.gridHesapTuru.Caption = "Hesap Türü";
            this.gridHesapTuru.FieldName = "HesapTuru";
            this.gridHesapTuru.Name = "gridHesapTuru";
            this.gridHesapTuru.Visible = true;
            this.gridHesapTuru.VisibleIndex = 9;
            this.gridHesapTuru.Width = 85;
            // 
            // gridFirmaId
            // 
            this.gridFirmaId.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridFirmaId.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridFirmaId.AppearanceHeader.Options.UseFont = true;
            this.gridFirmaId.AppearanceHeader.Options.UseForeColor = true;
            this.gridFirmaId.Caption = "Firma Adı";
            this.gridFirmaId.FieldName = "FirmaAd";
            this.gridFirmaId.Name = "gridFirmaId";
            this.gridFirmaId.Visible = true;
            this.gridFirmaId.VisibleIndex = 10;
            this.gridFirmaId.Width = 157;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sil";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = global::MagazaOtomasyon.WinUI.Properties.Resources.Sil;
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // FrmBankaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmBankaList";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBankaList_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colBankaId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankaAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colIban;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapNo;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkili;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridHesapTuru;
        private DevExpress.XtraGrid.Columns.GridColumn gridFirmaId;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}