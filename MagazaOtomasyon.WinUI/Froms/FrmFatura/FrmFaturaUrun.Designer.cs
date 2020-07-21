namespace MagazaOtomasyon.WinUI.Froms.FrmFatura
{
    partial class FrmFaturaUrun
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaturaUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliciId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(851, 275);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaturaUrunId,
            this.colUrunAd,
            this.colMiktar,
            this.colFiyat,
            this.colTutar,
            this.colAliciId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFaturaUrunId
            // 
            this.colFaturaUrunId.Caption = "FaturaUrunId";
            this.colFaturaUrunId.FieldName = "FaturaUrunId";
            this.colFaturaUrunId.Name = "colFaturaUrunId";
            // 
            // colUrunAd
            // 
            this.colUrunAd.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colUrunAd.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colUrunAd.AppearanceHeader.Options.UseFont = true;
            this.colUrunAd.AppearanceHeader.Options.UseForeColor = true;
            this.colUrunAd.Caption = "ÜRÜN AD";
            this.colUrunAd.FieldName = "UrunAd";
            this.colUrunAd.Name = "colUrunAd";
            this.colUrunAd.Visible = true;
            this.colUrunAd.VisibleIndex = 0;
            this.colUrunAd.Width = 197;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colMiktar.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colMiktar.AppearanceHeader.Options.UseFont = true;
            this.colMiktar.AppearanceHeader.Options.UseForeColor = true;
            this.colMiktar.Caption = "MİKTAR";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 1;
            this.colMiktar.Width = 132;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colFiyat.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colFiyat.AppearanceHeader.Options.UseFont = true;
            this.colFiyat.AppearanceHeader.Options.UseForeColor = true;
            this.colFiyat.Caption = "FİYAT";
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowEdit = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 2;
            this.colFiyat.Width = 141;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colTutar.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colTutar.AppearanceHeader.Options.UseFont = true;
            this.colTutar.AppearanceHeader.Options.UseForeColor = true;
            this.colTutar.Caption = "TUTAR";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 143;
            // 
            // colAliciId
            // 
            this.colAliciId.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.colAliciId.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colAliciId.AppearanceHeader.Options.UseFont = true;
            this.colAliciId.AppearanceHeader.Options.UseForeColor = true;
            this.colAliciId.Caption = "ALICI NUMARA";
            this.colAliciId.FieldName = "FaturaId";
            this.colAliciId.Name = "colAliciId";
            this.colAliciId.OptionsColumn.AllowEdit = false;
            this.colAliciId.Visible = true;
            this.colAliciId.VisibleIndex = 4;
            this.colAliciId.Width = 193;
            // 
            // FrmFaturaUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 275);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturaUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ürün";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAliciId;
    }
}