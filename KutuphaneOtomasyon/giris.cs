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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///Kullanıcı adı ve şifre doğru ise yönetim paneline geçecek
            ///
            yonetim yntm = new yonetim();
            yntm.Show();
            this.Close();
        }
    }
}
