using _231116032_Yusuf_Ziya_Kaplan_P3.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116032_Yusuf_Ziya_Kaplan_P3.Formlar
{
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            // Lookupedit için verilerin listenmesi
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;


            TxtCagriID.Text = id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            TxtAcıklama.Text = gelenveri.Aciklama;
            TxtTarih.Text = gelenveri.Tarih.ToString();
            TxtKonu.Text = gelenveri.Konu.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu = TxtKonu.Text;
            gelenveri.Tarih = Convert.ToDateTime(TxtTarih.Text);
            gelenveri.Aciklama = TxtAcıklama.Text;
            gelenveri.CagriPersonel =int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
