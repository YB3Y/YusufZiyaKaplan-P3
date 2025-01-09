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
    public partial class FrmPersonelİstatistik : Form
    {
        public FrmPersonelİstatistik()
        {
            InitializeComponent();
        }

        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void FrmPersonelİstatistik_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.TblDepartmanlar.Count ().ToString();
            lblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            lblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            lblAktifİs.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            lblPasifİs.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            lblSonGorev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblSonGorevDetayı.Text= db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            lblSehirSayısı.Text = db.TblFirmalar.Select(x=>x.il).Distinct().Count().ToString();
            lblSektor.Text = db.TblFirmalar.Select (x=>x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunAcılanGorevler.Text  = db.TblGorevler.Count (x =>x.Tarih == bugun).ToString();
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.TblPersonel.Where(x=>x.ID==d1).Select(y=>y.Ad+""+y.Soyad).FirstOrDefault().ToString();
            
            

        }

        
    }
}
