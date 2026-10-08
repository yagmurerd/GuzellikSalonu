using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace güzellikSalonu
{
    internal class Db
    {
        public static MySqlConnection Baglanti = new MySqlConnection("Server=127.0.0.1;Database=güzelliksalonu;Uid=root;Pwd=Yagmur123.;");
    }
}
