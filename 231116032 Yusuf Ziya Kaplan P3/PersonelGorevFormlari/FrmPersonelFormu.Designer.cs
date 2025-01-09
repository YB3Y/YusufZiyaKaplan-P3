namespace _231116032_Yusuf_Ziya_Kaplan_P3.PersonelGorevFormlari
{
    partial class FrmPersonelFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAktifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPasifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCagriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCagriL = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnAktifGorevler,
            this.BtnPasifGorevler,
            this.BtnCagriListesi,
            this.BtnCagriL});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 183);
            // 
            // BtnAktifGorevler
            // 
            this.BtnAktifGorevler.Caption = "Aktif Görevler";
            this.BtnAktifGorevler.Id = 1;
            this.BtnAktifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAktifGorevler.ImageOptions.LargeImage")));
            this.BtnAktifGorevler.Name = "BtnAktifGorevler";
            this.BtnAktifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktifGorevler_ItemClick);
            // 
            // BtnPasifGorevler
            // 
            this.BtnPasifGorevler.Caption = "Pasif Görevler";
            this.BtnPasifGorevler.Id = 2;
            this.BtnPasifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPasifGorevler.ImageOptions.LargeImage")));
            this.BtnPasifGorevler.Name = "BtnPasifGorevler";
            this.BtnPasifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPasifGorevler_ItemClick);
            // 
            // BtnCagriListesi
            // 
            this.BtnCagriListesi.Caption = "Çağrı Listesi";
            this.BtnCagriListesi.Id = 3;
            this.BtnCagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCagriListesi.ImageOptions.LargeImage")));
            this.BtnCagriListesi.Name = "BtnCagriListesi";
            // 
            // BtnCagriL
            // 
            this.BtnCagriL.Caption = "Çağri Listesi";
            this.BtnCagriL.Id = 4;
            this.BtnCagriL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCagriL.ImageOptions.LargeImage")));
            this.BtnCagriL.Name = "BtnCagriL";
            this.BtnCagriL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCagriL_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAktifGorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPasifGorevler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCagriL);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPersonelFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelFormu";
            this.Load += new System.EventHandler(this.FrmPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAktifGorevler;
        private DevExpress.XtraBars.BarButtonItem BtnPasifGorevler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnCagriListesi;
        private DevExpress.XtraBars.BarButtonItem BtnCagriL;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}