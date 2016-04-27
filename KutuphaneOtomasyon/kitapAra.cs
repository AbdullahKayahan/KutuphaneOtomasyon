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
    public partial class kitapAra : Form
    {
        public kitapAra()
        {
            InitializeComponent();
        }
        public anaSayfa ana;
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text=comboBox1.Text+" GİRİNİZ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kitapAra_Load(object sender, EventArgs e)
        {
            
           

        }

        private void kitapAra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana.WindowState = FormWindowState.Maximized;
        }
    }
}
