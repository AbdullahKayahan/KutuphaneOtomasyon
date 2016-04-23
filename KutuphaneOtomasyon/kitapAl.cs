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
    public partial class kitapAl : Form
    {
        public kitapAl()
        {
            InitializeComponent();
        }
        public int kimlikNo;
        public int kitapId;
        SqlConnection con=new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");


        void ara()
        {
           

            con.Open();
            DataSet dtst1 = new DataSet();
            SqlDataAdapter adtr1 = new SqlDataAdapter("select * From Kullanici  where kartNo ='" + textBox1.Text + "'", con);
            adtr1.Fill(dtst1, "Kullanici");

            textBox2.Clear();
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("text", dtst1, "Kullanici.adi");
            textBox3.Clear();
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("text", dtst1, "Kullanici.soyadi");
            textBox6.Clear();
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("text", dtst1, "Kullanici.tur");

            textBox7.Clear();
            textBox7.DataBindings.Clear();
            textBox7.DataBindings.Add("text", dtst1, "Kullanici.id");
          
            adtr1.Dispose();

            adtr1 = new SqlDataAdapter("select * From Eser  where kod =" + textBox4.Text + "", con);
            adtr1.Fill(dtst1, "Eser");
            textBox5.Clear();
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("text", dtst1, "Eser.eserAdi");

            textBox8.Clear();
            textBox8.DataBindings.Clear();
            textBox8.DataBindings.Add("text", dtst1, "Eser.durum");
        
            textBox9.Clear();
            textBox9.DataBindings.Clear();
            textBox9.DataBindings.Add("text", dtst1, "Eser.id");
    
            adtr1.Dispose();
            con.Close();

        } 
        private void kitapAl_Load(object sender, EventArgs e)
        {
            textBox1.Text = kimlikNo.ToString();
            textBox4.Text = kitapId.ToString();
            ara();



         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string islemTuru = "ALINDI";
            if (textBox8.Text == "0")
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                string tarih;
                tarih = DateTime.Now.ToShortDateString();
                MessageBox.Show("Connection opened");
                cmd.Connection = con;
                cmd.CommandText = "insert into Islemler(eserId,islemTuru,kullaniciId,tarih) values ('" + textBox9.Text + "','" + islemTuru +"' ,'" + textBox7.Text + "','" + tarih + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("işlem tamam");
            }
            else
            {
                if(textBox8.Text=="1")
                MessageBox.Show(textBox5.Text + " İsimli Eser Ayırtılmış");
                else if (textBox8.Text == "2")
                MessageBox.Show(textBox5.Text + " İsimli Eser Şuan Başkasında");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "0") { textBox6.Text = "ÖĞRENCİ"; }
            else if (textBox6.Text == "1") { textBox6.Text = "MEMUR"; }
            else if(textBox6.Text == "2") { textBox6.Text = "ÖĞRETİM GÖREVLİSİ"; }

        }
    }
    }

