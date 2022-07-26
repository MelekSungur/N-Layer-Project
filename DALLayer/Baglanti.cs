using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALLayer
{
    public class Baglanti
    {
       public static  SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-D0LP1EG;Initial Catalog=DBPersonel;Integrated Security=True");

    }
}
