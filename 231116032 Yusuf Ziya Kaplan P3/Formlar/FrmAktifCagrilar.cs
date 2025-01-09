using _231116032_Yusuf_Ziya_Kaplan_P3.Entity;
using _231116032_Yusuf_Ziya_Kaplan_P3.PersonelGorevFormlari;
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
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            Dbis_TakipEntities db = new Dbis_TakipEntities();

            var degerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                Personel = x.TblPersonel.Ad,
                                x.Durum
                            }).Where (y =>y.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr = new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
