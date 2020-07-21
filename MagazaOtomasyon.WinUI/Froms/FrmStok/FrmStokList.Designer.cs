namespace MagazaOtomasyon.WinUI.Froms.FrmStok
{
    partial class FrmStokList
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
            this.colStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1285, 586);
            this.xtraTabPage1.Text = "Stok Giriş";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1285, 586);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokId,
            this.colUrunAd,
            this.colStokAdet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "StokId";
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            // 
            // colUrunAd
            // 
            this.colUrunAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUrunAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colUrunAd.AppearanceHeader.Options.UseFont = true;
            this.colUrunAd.AppearanceHeader.Options.UseForeColor = true;
            this.colUrunAd.AppearanceHeader.Options.UseTextOptions = true;
            this.colUrunAd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunAd.Caption = "Ürün Ad";
            this.colUrunAd.FieldName = "UrunAd";
            this.colUrunAd.Name = "colUrunAd";
            this.colUrunAd.OptionsColumn.AllowEdit = false;
            this.colUrunAd.Visible = true;
            this.colUrunAd.VisibleIndex = 0;
            this.colUrunAd.Width = 608;
            // 
            // colStokAdet
            // 
            this.colStokAdet.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.colStokAdet.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colStokAdet.AppearanceHeader.Options.UseFont = true;
            this.colStokAdet.AppearanceHeader.Options.UseForeColor = true;
            this.colStokAdet.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokAdet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokAdet.Caption = "Adet";
            this.colStokAdet.FieldName = "Adet";
            this.colStokAdet.Name = "colStokAdet";
            this.colStokAdet.OptionsColumn.AllowEdit = false;
            this.colStokAdet.Visible = true;
            this.colStokAdet.VisibleIndex = 1;
            this.colStokAdet.Width = 659;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1285, 586);
            this.xtraTabPage2.Text = "Stok Çıkış";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1285, 586);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "StokId";
            this.gridColumn1.FieldName = "StokId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Stok Adı";
            this.gridColumn2.FieldName = "StokTur";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 608;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Adet";
            this.gridColumn3.FieldName = "StokAdet";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 659;
            // 
            // FrmStokList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmStokList";
            this.Text = "Stok List";
            this.Load += new System.EventHandler(this.FrmStokList_Load);
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
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdet;
        protected DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}