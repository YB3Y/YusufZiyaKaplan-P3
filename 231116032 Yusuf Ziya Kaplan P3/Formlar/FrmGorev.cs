using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231116032_Yusuf_Ziya_Kaplan_P3.Entity;
using DevExpress.XtraEditors;

namespace _231116032_Yusuf_Ziya_Kaplan_P3.Formlar
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();
            t.Aciklama = TxtAcıklama.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.GorevVeren = 1;
            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarılı bir şekilde tanımlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                                select new
                                {
                                    x.ID,
                                   AdSoyad = x.Ad +" "+ x.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}
