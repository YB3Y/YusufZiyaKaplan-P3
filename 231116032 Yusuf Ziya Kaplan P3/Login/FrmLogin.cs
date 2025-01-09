using _231116032_Yusuf_Ziya_Kaplan_P3.Entity;
using _231116032_Yusuf_Ziya_Kaplan_P3.Formlar;
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

namespace _231116032_Yusuf_Ziya_Kaplan_P3.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
            fr.Show();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin2.Where (x =>x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorevFormlari.FrmPersonelFormu fr =new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
