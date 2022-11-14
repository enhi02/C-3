using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_QuanLY
    {
        public class DBConect
        {
            protected SqlConnection _conn = new SqlConnection(
                @"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = QuanLyThanhVien;
                                        integrated security=SSPI"
                );
        }
    }
}
