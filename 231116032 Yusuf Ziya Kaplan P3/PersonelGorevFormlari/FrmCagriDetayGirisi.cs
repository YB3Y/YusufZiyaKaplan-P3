using _231116032_Yusuf_Ziya_Kaplan_P3.Entity;
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

namespace _231116032_Yusuf_Ziya_Kaplan_P3.PersonelGorevFormlari
{
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }

        Dbis_TakipEntities db = new Dbis_TakipEntities();
        public int id;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToLongTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagriID.Text);
            t.Saat = TxtSaat.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text); 
            t.Aciklama = TxtAcıklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çagrı Detay Sisteme Başarılı Bir Şekilde Kaydedildi");
        }
    }
}
