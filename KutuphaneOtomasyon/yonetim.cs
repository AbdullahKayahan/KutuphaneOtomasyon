using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace KutuphaneOtomasyon
{
    public partial class yonetim : Form
    {
        public yonetim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            int durum = 0;
            int cesitId = cmbCesit.SelectedIndex + 1;
            int adet = Convert.ToInt32(txtAdet.Text);
            MessageBox.Show("Connection opened");
            cmd.Connection = con;
            cmd.CommandText = "insert into EserSahibi(adi,soyadi) values ('" + txtEserSahibiAdi.Text + "','" + txtEserSahibiSoyadi.Text + "')";
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "insert into Eser(eseradi,tur,durum,cesitId,kod,adet) values ('" + txtEserAdi.Text + "','" + txtTuru.Text + "',"+ durum +","+ cesitId + ",'"+txtKod.Text+"',"+adet+")";
            cmd1.ExecuteNonQuery();
            con.Close();

            createEserToEserSahibi();//EserToEserSahibi tablosunu doldurmak için kullanıclak kodların bulunduğu fonksiyon.



            MessageBox.Show("işlem tamam");
        }
        void createEserToEserSahibi()
        {
            int eserSahibiId, eserId;
            string temp = txtKod.Text;

            /// Aşağıdaki Kodlar EserToEser Sahibi Tablosunu Oluşturmak İçin
            /// Eserler İle Eser Sahipleri Arasındaki İlişkiyi sağlamak amacıyla Kullanılan kodlar
            /// 
            con.Open();
            DataSet dtst1 = new DataSet();
            SqlDataAdapter adtr1 = new SqlDataAdapter("select * From EserSahibi  where adi ='" + txtEserSahibiAdi.Text + "'AND soyadi='" + txtEserSahibiSoyadi.Text + "'", con);
            adtr1.Fill(dtst1, "EserSahibi");

            txtKod.Clear();
            txtKod.DataBindings.Clear();
            txtKod.DataBindings.Add("text", dtst1, "EserSahibi.id");
            eserSahibiId = Convert.ToInt32(txtKod.Text);
            txtKod.Text = temp;
            adtr1.Dispose();

            adtr1 = new SqlDataAdapter("select * From Eser  where kod =" + txtKod.Text + "", con);
            adtr1.Fill(dtst1, "Eser");
            txtKod.Clear();
            txtKod.DataBindings.Clear();
            txtKod.DataBindings.Add("text", dtst1, "Eser.id");
            eserId = Convert.ToInt32(txtKod.Text);
            txtKod.Text = temp;
            adtr1.Dispose();
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into EserToEserSahibi(eserId,eserSahibiId) values (" + eserId + "," + eserSahibiId + ")";
            cmd2.ExecuteNonQuery();
            con.Close();

        }
        private void yonetim_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
