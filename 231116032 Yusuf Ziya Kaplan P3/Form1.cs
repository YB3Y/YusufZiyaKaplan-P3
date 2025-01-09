using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116032_Yusuf_Ziya_Kaplan_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmDepartmanlar frm;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        Formlar.FrmPersoneler frm2;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmPersoneler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
        Formlar.FrmPersonelİstatistik frm3;
        private void BtnPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelİstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void BtnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr = new Formlar.FrmGorevDetay();
            fr.Show();
        }
        Formlar.FrmAnaForm frm5;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.FrmAnaForm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Formlar.FrmAktifCagrilar fr;
        private void BtnAktifCagrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // new Formlar.FrmAktifCagrilar();
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
