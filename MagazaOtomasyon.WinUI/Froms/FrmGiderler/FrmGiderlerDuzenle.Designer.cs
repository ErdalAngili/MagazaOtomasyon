namespace MagazaOtomasyon.WinUI.Froms.FrmGiderler
{
    partial class FrmGiderlerDuzenle
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
            this.textEkstra = new DevExpress.XtraEditors.TextEdit();
            this.richNot = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textMaas = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textInternet = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textSu = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textElektrik = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.ComYil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textElektrik.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(584, 75);
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
            // textEkstra
            // 
            this.textEkstra.Location = new System.Drawing.Point(386, 214);
            this.textEkstra.MenuManager = this.ribbonControl1;
            this.textEkstra.Name = "textEkstra";
            this.textEkstra.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textEkstra.Properties.Appearance.Options.UseFont = true;
            this.textEkstra.Properties.Mask.EditMask = "c";
            this.textEkstra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEkstra.Size = new System.Drawing.Size(166, 24);
            this.textEkstra.TabIndex = 8;
            // 
            // richNot
            // 
            this.richNot.Location = new System.Drawing.Point(116, 266);
            this.richNot.Name = "richNot";
            this.richNot.Size = new System.Drawing.Size(436, 89);
            this.richNot.TabIndex = 9;
            this.richNot.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(65, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 95;
            this.label9.Text = "Not :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(316, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 94;
            this.label8.Text = "Ekstra :";
            // 
            // textMaas
            // 
            this.textMaas.Location = new System.Drawing.Point(116, 214);
            this.textMaas.MenuManager = this.ribbonControl1;
            this.textMaas.Name = "textMaas";
            this.textMaas.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textMaas.Properties.Appearance.Options.UseFont = true;
            this.textMaas.Properties.Mask.EditMask = "c";
            this.textMaas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textMaas.Size = new System.Drawing.Size(166, 24);
            this.textMaas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Maaşlar :";
            // 
            // textInternet
            // 
            this.textInternet.Location = new System.Drawing.Point(386, 174);
            this.textInternet.MenuManager = this.ribbonControl1;
            this.textInternet.Name = "textInternet";
            this.textInternet.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textInternet.Properties.Appearance.Options.UseFont = true;
            this.textInternet.Properties.Mask.EditMask = "c";
            this.textInternet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textInternet.Size = new System.Drawing.Size(166, 24);
            this.textInternet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(301, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "İnternet :";
            // 
            // textDogalgaz
            // 
            this.textDogalgaz.Location = new System.Drawing.Point(116, 174);
            this.textDogalgaz.MenuManager = this.ribbonControl1;
            this.textDogalgaz.Name = "textDogalgaz";
            this.textDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.textDogalgaz.Properties.Mask.EditMask = "c";
            this.textDogalgaz.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textDogalgaz.Size = new System.Drawing.Size(166, 24);
            this.textDogalgaz.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Doğal Gaz :";
            // 
            // textSu
            // 
            this.textSu.Location = new System.Drawing.Point(386, 133);
            this.textSu.MenuManager = this.ribbonControl1;
            this.textSu.Name = "textSu";
            this.textSu.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textSu.Properties.Appearance.Options.UseFont = true;
            this.textSu.Properties.Mask.EditMask = "c";
            this.textSu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textSu.Size = new System.Drawing.Size(166, 24);
            this.textSu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(342, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Su :";
            // 
            // textElektrik
            // 
            this.textElektrik.Location = new System.Drawing.Point(116, 133);
            this.textElektrik.MenuManager = this.ribbonControl1;
            this.textElektrik.Name = "textElektrik";
            this.textElektrik.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.textElektrik.Properties.Appearance.Options.UseFont = true;
            this.textElektrik.Properties.Mask.EditMask = "c";
            this.textElektrik.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textElektrik.Size = new System.Drawing.Size(166, 24);
            this.textElektrik.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Elektrik :";
            // 
            // ComYil
            // 
            this.ComYil.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.ComYil.FormattingEnabled = true;
            this.ComYil.Location = new System.Drawing.Point(386, 92);
            this.ComYil.Name = "ComYil";
            this.ComYil.Size = new System.Drawing.Size(166, 26);
            this.ComYil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(342, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Yıl :";
            // 
            // comAy
            // 
            this.comAy.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.comAy.FormattingEnabled = true;
            this.comAy.Location = new System.Drawing.Point(116, 91);
            this.comAy.Name = "comAy";
            this.comAy.Size = new System.Drawing.Size(166, 26);
            this.comAy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Ay :";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(88, 356);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(21, 21);
            this.textId.TabIndex = 97;
            this.textId.Visible = false;
            // 
            // FrmGiderlerDuzenle
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textEkstra);
            this.Controls.Add(this.richNot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMaas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textInternet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDogalgaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textElektrik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComYil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderlerDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler Düzenle";
            this.Load += new System.EventHandler(this.FrmGiderlerDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textElektrik.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnDuzenle;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit textEkstra;
        private System.Windows.Forms.RichTextBox richNot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textMaas;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textInternet;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textDogalgaz;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textSu;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textElektrik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        public System.Windows.Forms.ComboBox comAy;
        public System.Windows.Forms.ComboBox ComYil;
    }
}