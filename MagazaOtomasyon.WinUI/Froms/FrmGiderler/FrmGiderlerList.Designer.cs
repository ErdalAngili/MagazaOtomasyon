namespace MagazaOtomasyon.WinUI.Froms.FrmGiderler
{
    partial class FrmGiderlerList
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
            this.colGiderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colElektrik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogalgaz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInternet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaaslar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkstra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotlar = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.textAra.TextChanged += new System.EventHandler(this.textAra_TextChanged);
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
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGiderId,
            this.colAy,
            this.colYil,
            this.colElektrik,
            this.colSu,
            this.colDogalgaz,
            this.colInternet,
            this.colMaaslar,
            this.colEkstra,
            this.colNotlar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colGiderId
            // 
            this.colGiderId.Caption = "GiderId";
            this.colGiderId.FieldName = "GiderId";
            this.colGiderId.Name = "colGiderId";
            // 
            // colAy
            // 
            this.colAy.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colAy.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colAy.AppearanceHeader.Options.UseFont = true;
            this.colAy.AppearanceHeader.Options.UseForeColor = true;
            this.colAy.Caption = "Ay";
            this.colAy.FieldName = "Ay";
            this.colAy.Name = "colAy";
            this.colAy.OptionsColumn.AllowEdit = false;
            this.colAy.Visible = true;
            this.colAy.VisibleIndex = 0;
            this.colAy.Width = 78;
            // 
            // colYil
            // 
            this.colYil.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colYil.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colYil.AppearanceHeader.Options.UseFont = true;
            this.colYil.AppearanceHeader.Options.UseForeColor = true;
            this.colYil.Caption = "Yıl";
            this.colYil.FieldName = "Yil";
            this.colYil.Name = "colYil";
            this.colYil.OptionsColumn.AllowEdit = false;
            this.colYil.Visible = true;
            this.colYil.VisibleIndex = 1;
            this.colYil.Width = 76;
            // 
            // colElektrik
            // 
            this.colElektrik.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colElektrik.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colElektrik.AppearanceHeader.Options.UseFont = true;
            this.colElektrik.AppearanceHeader.Options.UseForeColor = true;
            this.colElektrik.Caption = "Elektrik";
            this.colElektrik.FieldName = "Elektrik";
            this.colElektrik.Name = "colElektrik";
            this.colElektrik.OptionsColumn.AllowEdit = false;
            this.colElektrik.Visible = true;
            this.colElektrik.VisibleIndex = 2;
            this.colElektrik.Width = 94;
            // 
            // colSu
            // 
            this.colSu.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colSu.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colSu.AppearanceHeader.Options.UseFont = true;
            this.colSu.AppearanceHeader.Options.UseForeColor = true;
            this.colSu.Caption = "Su";
            this.colSu.FieldName = "Su";
            this.colSu.Name = "colSu";
            this.colSu.OptionsColumn.AllowEdit = false;
            this.colSu.Visible = true;
            this.colSu.VisibleIndex = 3;
            this.colSu.Width = 72;
            // 
            // colDogalgaz
            // 
            this.colDogalgaz.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colDogalgaz.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colDogalgaz.AppearanceHeader.Options.UseFont = true;
            this.colDogalgaz.AppearanceHeader.Options.UseForeColor = true;
            this.colDogalgaz.Caption = "Doğal Gaz";
            this.colDogalgaz.FieldName = "Dogalgaz";
            this.colDogalgaz.Name = "colDogalgaz";
            this.colDogalgaz.OptionsColumn.AllowEdit = false;
            this.colDogalgaz.Visible = true;
            this.colDogalgaz.VisibleIndex = 4;
            this.colDogalgaz.Width = 90;
            // 
            // colInternet
            // 
            this.colInternet.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colInternet.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colInternet.AppearanceHeader.Options.UseFont = true;
            this.colInternet.AppearanceHeader.Options.UseForeColor = true;
            this.colInternet.Caption = "İnternet";
            this.colInternet.FieldName = "Internet";
            this.colInternet.Name = "colInternet";
            this.colInternet.OptionsColumn.AllowEdit = false;
            this.colInternet.Visible = true;
            this.colInternet.VisibleIndex = 5;
            this.colInternet.Width = 85;
            // 
            // colMaaslar
            // 
            this.colMaaslar.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colMaaslar.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colMaaslar.AppearanceHeader.Options.UseFont = true;
            this.colMaaslar.AppearanceHeader.Options.UseForeColor = true;
            this.colMaaslar.Caption = "Maaşlar";
            this.colMaaslar.FieldName = "Maaslar";
            this.colMaaslar.Name = "colMaaslar";
            this.colMaaslar.OptionsColumn.AllowEdit = false;
            this.colMaaslar.Visible = true;
            this.colMaaslar.VisibleIndex = 6;
            this.colMaaslar.Width = 82;
            // 
            // colEkstra
            // 
            this.colEkstra.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colEkstra.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colEkstra.AppearanceHeader.Options.UseFont = true;
            this.colEkstra.AppearanceHeader.Options.UseForeColor = true;
            this.colEkstra.Caption = "Ekstra";
            this.colEkstra.FieldName = "Ekstra";
            this.colEkstra.Name = "colEkstra";
            this.colEkstra.OptionsColumn.AllowEdit = false;
            this.colEkstra.Visible = true;
            this.colEkstra.VisibleIndex = 7;
            this.colEkstra.Width = 166;
            // 
            // colNotlar
            // 
            this.colNotlar.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colNotlar.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colNotlar.AppearanceHeader.Options.UseFont = true;
            this.colNotlar.AppearanceHeader.Options.UseForeColor = true;
            this.colNotlar.Caption = "Notlar";
            this.colNotlar.FieldName = "Notlar";
            this.colNotlar.Name = "colNotlar";
            this.colNotlar.OptionsColumn.AllowEdit = false;
            this.colNotlar.Visible = true;
            this.colNotlar.VisibleIndex = 8;
            this.colNotlar.Width = 248;
            // 
            // FrmGiderlerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmGiderlerList";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderlerList_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colGiderId;
        private DevExpress.XtraGrid.Columns.GridColumn colAy;
        private DevExpress.XtraGrid.Columns.GridColumn colYil;
        private DevExpress.XtraGrid.Columns.GridColumn colElektrik;
        private DevExpress.XtraGrid.Columns.GridColumn colSu;
        private DevExpress.XtraGrid.Columns.GridColumn colDogalgaz;
        private DevExpress.XtraGrid.Columns.GridColumn colInternet;
        private DevExpress.XtraGrid.Columns.GridColumn colMaaslar;
        private DevExpress.XtraGrid.Columns.GridColumn colEkstra;
        private DevExpress.XtraGrid.Columns.GridColumn colNotlar;
    }
}