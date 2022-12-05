using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final_IS.pClasses
{
    class CLS_Delivired
    {
        public DataTable Delivired(string s)
        {
            DAL.Data Data = new DAL.Data();
            SqlParameter[] param = new SqlParameter[1];
            DataTable da = new DataTable();
            param[0] = new SqlParameter("@Rent_End_Date", SqlDbType.DateTime);
            param[0].Value = s;
            da = Data.Query(param, "Delevired");
            return da;
        }
    }
}
