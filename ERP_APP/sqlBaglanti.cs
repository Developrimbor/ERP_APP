using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP_APP
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CDM_ERP;Integrated Security=True;TrustServerCertificate=True");

            //  SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-RSDLUJ4;Initial Catalog=CDM;Integrated Security=True;TrustServerCertificate=True"); 

            baglan.Open();
            return baglan;
        }
    }
}
