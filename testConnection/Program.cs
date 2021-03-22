using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().koneksi();
        }
        public void koneksi()
        {
            using (
                //membuat koneksi
                SqlConnection conn = new SqlConnection("data source=DESKTOP-GVR4E5T\\INAYAH;"
                + "database=ProdiTI;user ID=sa;password=123"))
            {
                conn.Open();
                Console.Write("Koneksi Sukses");
                Console.Read();
            }
        }
    }
}
