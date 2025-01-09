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
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }
        // crud --> create read update delete

        Dbis_TakipEntities db = new Dbis_TakipEntities();
        void Listele()
        {
            
            var degerler = (from x in db.TblDepartmanlar
                            select new 
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {

        }

        private void BrnListele_Click(object sender, EventArgs e)
        {
                Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = TxtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarılı Bir Şekilde Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Silme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text= gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text=gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.Ad = TxtAd.Text;
            
            db.SaveChanges();
            XtraMessageBox.Show("Departman Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();

        }
    }
}
