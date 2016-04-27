using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace KutuphaneOtomasyon
{
    class baglanti
    {
        //const string git add --all
        private SqlConnection con;

        public baglanti()
        {
            //this.con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=kutuphane;Data Source=SAMIR");
            //this.con = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=kutuphane;Trusted_Connection=yes");
            this.con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=kutuphane;Data Source=WIN_8\SQLEXPRESS");
        }



        public SqlConnection conn
        {
            get
            {
                return this.con;
            }
            set
            {
                this.con = value;
            }
        }


    }
}
