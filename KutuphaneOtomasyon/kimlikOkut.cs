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
    public partial class kimlikOkut : Form
    {
        public kimlikOkut()
        {
            InitializeComponent();
        }
        public anaSayfa ana;
        public int kitapNo;
        private void button1_Click(object sender, EventArgs e)
        {         
            kitapAl ka = new kitapAl();            
            ka.kimlikNo = Convert.ToInt32(textBox1.Text);
            ka.kitapId = kitapNo;
            ka.ana = this.ana;
            ka.Show();
            this.Close();
        }

        private void kimlikOkut_Load(object sender, EventArgs e)
        {

        }
    }
}
