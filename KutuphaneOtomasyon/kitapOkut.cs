﻿using System;
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
    public partial class kitapOkut : Form
    {
        public kitapOkut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kimlikOkut kimOkt = new kimlikOkut();
            kimOkt.Show();
            kimOkt.kitapNo = Convert.ToInt32(textBox1.Text);
            this.Hide();
        }
    }
}
