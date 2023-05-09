using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    class VeriTabaniIslemleri
    {
        string BaglantiCumlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;

        public MySqlConnection baglan()
        {
            MySqlConnection baglantı = new MySqlConnection(BaglantiCumlesi);
            MySqlConnection.ClearPool(baglantı);
            return baglantı;
        
        
        
        }
    }
}
