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
        const int yazarSayisi = 50;//25 adet yazar bilgisi tutar adı+soyadı
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");
        TextBox[] textlist= new TextBox[yazarSayisi];
        Label[] labellist = new Label[yazarSayisi];
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
            textlist[0]=txtEserSahibiAdi;
            textlist[1]=(txtEserSahibiSoyadi);
            labellist[0] = label6;
            labellist[1] = (label7);
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

        int count = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(count.ToString());
            TextBox t3 = textlist[count];
            Label l3 = labellist[count];

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            Label l1 = new Label();
            Label l2 = new Label();

            t1.Top = t3.Bottom + 5; //Yukarıdan bırakılacak mesafe
            t1.Left = t3.Left; //Soldan Bırakılacak mesafe
            t1.Text = "";
            t1.Height = t3.Height;  //Yüksekliği
            t1.Width = t3.Width; //Eni
            tabPage2.Controls.Add(t1); //Butonu Forma Ekleme

            t2.Top = t1.Bottom + 5; //Yukarıdan bırakılacak mesafe
            t2.Left = t1.Left; //Soldan Bırakılacak mesafe
            t2.Text = "";
            t2.Height = t1.Height;  //Yüksekliği
            t2.Width = t1.Width; //Eni
            tabPage2.Controls.Add(t2); //Butonu Forma Ekleme 



            l1.Top = l3.Bottom + 12; //Yukarıdan bırakılacak mesafe
            l1.Left = labellist[0].Left; //Soldan Bırakılacak mesafe
            l1.Text = labellist[0].Text;
            l1.Height = l3.Height;  //Yüksekliği
            l1.Width = l3.Width; //Eni
            tabPage2.Controls.Add(l1); //Butonu Forma Ekleme

            l2.Top = l1.Bottom + 12; //Yukarıdan bırakılacak mesafe
            l2.Left = labellist[1].Left; //Soldan Bırakılacak mesafe
            l2.Text = labellist[1].Text;
            l2.Height = l1.Height;  //Yüksekliği
            l2.Width = l1.Width; //Eni
            tabPage2.Controls.Add(l2); //Butonu Forma Ekleme 


            count++;
            textlist[count] = t1;
            labellist[count] = l1;
            count++;
            textlist[count] = (t2);
            labellist[count] = l2;
            button3.Top = t2.Bottom + 3;
            //MessageBox.Show(count.ToString());

        }
    }
}
