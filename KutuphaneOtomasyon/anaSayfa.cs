using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        public string kimlikNo;
        private void button3_Click(object sender, EventArgs e)
        {
            kitapOkut kitOkt = new kitapOkut();
            kitOkt.ana = this;
            kitOkt.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapAra kitAra = new kitapAra();
            kitAra.ana = this;
            kitAra.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.ana = this;            
            grs.Show();
           
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ziyaretciKayit zkyt = new ziyaretciKayit();
            zkyt.ana = this;
            zkyt.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

            label1.Text = "AYDINLIK ÜNİVERSİTESİ\n    "+DateTime.Now.ToString();
            label1.Left = this.Right;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Right > this.Left)
            {
                label1.Text = "AYDINLIK ÜNİVERSİTESİ\n    " + DateTime.Now.ToString();
                label1.Left -= 10;
            }
            else
            label1.Left = this.Right;

        }
    }
}
