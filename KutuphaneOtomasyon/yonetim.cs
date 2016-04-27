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
        public anaSayfa ana;
        #region GLOBAL DEĞİŞKENLER
        const int yazarSayisi = 50;//25 adet yazar bilgisi tutar adı+soyadı
       
        //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");
        SqlConnection con = new SqlConnection();
        baglanti dataCon = new baglanti();

        TextBox[] textlist= new TextBox[yazarSayisi];
        Label[] labellist = new Label[yazarSayisi];
        int count = 1;
        int addButtonTop;//Yeni Eser Sahibi Eklediğimi Butonun başlangıç yeri.
        #endregion 

        #region ESER-ESERSAHİBİ EKLE
        /********************************************************************************************* 
         * Button 2 Yeni eser, eser sahibi eklemek için kullanılan buttondur                         *
         *********************************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
    
            con.Open(); //MessageBox.Show("Connection opened");
            int durum = 0;
            int cesitId = cmbCesit.SelectedIndex + 1;
            int adet = Convert.ToInt32(txtAdet.Text);

            for (int i = 0; i <= count; i = i + 2)
            {
            SqlCommand cmd = new SqlCommand();           
            cmd.Connection = con;
            cmd.CommandText = "insert into EserSahibi(adi,soyadi) values ('" + textlist[i].Text + "','" + textlist[i+1].Text + "')";
            cmd.ExecuteNonQuery();
            }

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "insert into Eser(eseradi,tur,durum,cesitId,kod,adet) values ('" + txtEserAdi.Text + "','" + txtTuru.Text + "',"+ durum +","+ cesitId + ",'"+txtKod.Text+"',"+adet+")";
            cmd1.ExecuteNonQuery();
            con.Close();



            createEserToEserSahibi();//EserToEserSahibi tablosunu doldurmak için kullanıclak kodların bulunduğu fonksiyon.



            MessageBox.Show("işlem tamam");
        }
       /*********************************************************************************************** 
        *creatEserToEserSahibi kitapları yazarlar ile eşleştiren eserToEserSahibi tablosunu oluşturur *
        ***********************************************************************************************/
        void createEserToEserSahibi()
        {
            int eserSahibiId, eserId;
            string temp = txtKod.Text;

            /// Aşağıdaki Kodlar EserToEser Sahibi Tablosunu Oluşturmak İçin
            /// Eserler İle Eser Sahipleri Arasındaki İlişkiyi sağlamak amacıyla Kullanılan kodlar
            /// 
           
            for (int i = 0; i <= count; i = i + 2)
            {
                con.Open();
                DataSet dtst1 = new DataSet();
                SqlDataAdapter adtr1 = new SqlDataAdapter("select * From EserSahibi  where adi ='" + textlist[i].Text + "'AND soyadi='" +textlist[i+1].Text + "'", con);
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
        }
   
      /*********************************************************************************************** 
       * Button 3 Yeni yazarlar için kullanılan button, eklenmek istenilen yazar kadar basıldığında  *
       * forma yeni textbox ve labeller ekleyecek ve bunları ilgili dizilerde tutucaktır.            *
       ***********************************************************************************************/     
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
            t1.Height = t3.Height;  //Yüksekliği
            t1.Width = t3.Width; //Eni
            tabPage2.Controls.Add(t1); //Butonu Forma Ekleme
            t2.Top = t1.Bottom + 5; //Yukarıdan bırakılacak mesafe
            t2.Left = t1.Left; //Soldan Bırakılacak mesafe
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

        /*********************************************************************************************
         *  Button4 eserEkle tabındaki temizlik işlerinin halledildiği button                        *         
         *********************************************************************************************/
        private void button4_Click(object sender, EventArgs e)
        {
            textlist[0].Text = "";
            textlist[1].Text = "";
            for (int i = 2; i <= count; i++)
            {
                //Dispose yok etme işlemi.
                textlist[i].Dispose();//textbox'ı formdan kaldırdık
                labellist[i].Dispose();// label'i formdan kaldırdık
            }
            button3.Top = addButtonTop;//button3'ü ilk konumuna getirdik
            count = 1;
            //foreach ile form üzerindeki tüm controlleri gezdik ve temizleme işlemi yaptık.
            foreach (Control c in tabPage2.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                 {
                    ((ComboBox)c).Text = "Çeşit Seçiniz";

                }
            }
        }
        #endregion




   /************************************************************************************************** 
    * yönetim sayfasında sayfa ilk yüklendiği anda çalışması gereken kodların yer aldığı load eventi *   
    **************************************************************************************************/
        private void yonetim_Load(object sender, EventArgs e)
        {
            con = dataCon.conn;//bağlantı sınıfından connnection cümleciğini get ettiğimiz yer.
            textlist[0] = txtEserSahibiAdi;
            textlist[1] = (txtEserSahibiSoyadi);
            labellist[0] = label6;
            labellist[1] = (label7);
            addButtonTop = button3.Top;//button 3'ü tekrar eski yerine getirmek için tuttuğumuz top değeri

        }

        void kullaniciGetir(int durum)
        {
            try
            {
                
                con.Close();
                con.Open();
                DataSet dtst1 = new DataSet();
               SqlDataAdapter adtr1 = new SqlDataAdapter("select id,adi,soyadi,tur,email,kartNo,durum From Kullanici  where durum="+durum+" ", con);
                adtr1.Fill(dtst1, "Kullanici");
                DGWKullanici.DataSource = dtst1.Tables["Kullanici"];
                adtr1.Dispose();
                con.Close();
            }

            catch
            {
                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void tumKullnicilar()
        {
            try
            {

                con.Close();
                con.Open();
                DataSet dtst1 = new DataSet();
                SqlDataAdapter adtr1 = new SqlDataAdapter("select id,adi,soyadi,tur,email,kartNo,durum From Kullanici", con);
                adtr1.Fill(dtst1, "Kullanici");
                DGWKullanici.DataSource = dtst1.Tables["Kullanici"];
                adtr1.Dispose();
                con.Close();
            }

            catch
            {
                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void temizle(Control cnt)
        {
            foreach (Control c in cnt.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            kullaniciGetir(0);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                kullaniciGetir(1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                kullaniciGetir(0);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                tumKullnicilar();
            }
        }

        private void DGWKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserId.Text= (DGWKullanici.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAd.Text = (DGWKullanici.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtSoyad.Text = (DGWKullanici.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtTur.Text = (DGWKullanici.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtMail.Text = (DGWKullanici.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtKimlik.Text = (DGWKullanici.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtDurum.Text = (DGWKullanici.Rows[e.RowIndex].Cells[6].Value.ToString());
           
           /* /*ÖĞRENCİ
                MEMUR
            ÖĞRETİM GÖREVLİSİ*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Close();
               
                SqlCommand gncl = new SqlCommand("update Kullanici set durum='" + txtDurum.Text + "'where kartNo='" + txtKimlik.Text + "'", con);
                gncl.Connection.Open();
                gncl.ExecuteNonQuery();
                con.Close();                
                MessageBox.Show("Güncelleme İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton3.Checked = true;
                temizle(groupBox1);
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Kullanici Bilgileri Silinecek \n\nSilmek İstediğinizden Eminmisiniz", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                
                 con.Close();
                    SqlCommand sil = new SqlCommand("delete from Kullanici where kartNo= '" + txtKimlik.Text + "' ", con);
                    sil.Connection.Open();
                    sil.ExecuteNonQuery();
                    con.Close();
                 radioButton3.Checked = true;
                    temizle(groupBox1);
                }                   
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu \n"+ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yonetim_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana.WindowState = FormWindowState.Maximized;
        }
    }
}
