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
    public partial class kitapAl : Form
    {
        public kitapAl()
        {
            InitializeComponent();
        }
        public int kimlikNo;
        public int kitapId;

        private void kitapAl_Load(object sender, EventArgs e)
        {
            textBox1.Text = kimlikNo.ToString();
            textBox4.Text = kitapId.ToString();
        }
    }
    }

