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
using System.Security.Cryptography;
using System.IO;
namespace KutuphaneOtomasyon
{
    public partial class ziyaretciKayit : Form
    {
        public ziyaretciKayit()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");
        public anaSayfa ana;
        SqlConnection con = new SqlConnection();
        baglanti dataCon = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            int durum=0;
            string sifre;
            if (txtSifre1.Text == txtSifre2.Text)
            {
             sifre = passwordEncrypt(txtSifre1.Text, txtSifre2.Text);
                cmd.Connection = con;
                cmd.CommandText = "insert into Kullanici(adi,soyadi,tur,email,kartNo,sifre,durum) values ('" + txtAd.Text + "','" + txtSoyad.Text + "' ," + cmbTur.SelectedIndex + ",'" + txtMail.Text + "','" + txtKimlik.Text + "','" +sifre + "'," + durum + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("işlem tamam");
            }
            else
            {
                txtSifre1.Clear(); txtSifre2.Clear();
                txtSifre1.Focus();
                MessageBox.Show("Şifrenizi Kontrol Edip Tekrar Giriniz");
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
                else if(c is ComboBox)
                {
                    ((ComboBox)c).Text="Tür Seçiniz";
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle(panel1);
           }

        public static string passwordEncrypt(string inText, string key)
        {
            byte[] bytesBuff = Encoding.Unicode.GetBytes(inText);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    inText = Convert.ToBase64String(mStream.ToArray());
                }
            }
            return inText;
        }
        //Decrypting a string
        public static string passwordDecrypt(string cryptTxt, string key)
        {
            cryptTxt = cryptTxt.Replace(" ", "+");
            byte[] bytesBuff = Convert.FromBase64String(cryptTxt);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    cryptTxt = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            return cryptTxt;
        }

        private void ziyaretciKayit_Load(object sender, EventArgs e)
        {
            con = dataCon.conn;
        }

        private void ziyaretciKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana.WindowState = FormWindowState.Maximized;
        }
    }
}
