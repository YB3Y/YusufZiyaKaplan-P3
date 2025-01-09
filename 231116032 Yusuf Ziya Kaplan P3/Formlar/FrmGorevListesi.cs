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


namespace _231116032_Yusuf_Ziya_Kaplan_P3.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }


        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
          gridControl1.DataSource=(from x in db.TblGorevler select new 
          {
              x.Aciklama
          }).ToList();

            lblAktifGorev.Text= db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            lblPasifGorev.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            lblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler",int.Parse(lblPasifGorev.Text)); 
          
        }
    }
}
