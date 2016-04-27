using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KutuphaneOtomasyon
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");
        baglanti dataCon = new baglanti();
        SqlConnection con = new SqlConnection();
        public anaSayfa ana;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet dtst1 = new DataSet();
            SqlDataAdapter adtr1 = new SqlDataAdapter("select * From Kullanici  where kartNo ='" + textBox1.Text + "'", con);
            adtr1.Fill(dtst1, "Kullanici");

            textBox2.Clear();
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("text", dtst1, "Kullanici.tur");
            adtr1.Dispose();
            con.Close();

            if (textBox2.Text == "3")
            {
            yonetim yntm = new yonetim();
            yntm.ana = this.ana;
            yntm.Show();
            this.Close();
            }
            else { MessageBox.Show("Yönetim Paneline Girmeye Yetkiniz Yok");}
            
        }

        private void giris_Load(object sender, EventArgs e)
        {
            con = dataCon.conn;
        }
    }
}
