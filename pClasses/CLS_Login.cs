using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final_IS.pClasses
{
    class CLS_Login
    {
        public DataTable Check_User(string U,string P)
        {
            SqlParameter[] param = new SqlParameter[2];
            DataTable da = new DataTable();
            DAL.Data Data = new DAL.Data();
            param[0] = new SqlParameter("@UserName",SqlDbType.VarChar,50);
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[0].Value = U;
            param[1].Value = P;
            da=Data.Query(param, "Check_User_Data");
            return da;
        }
        public void New_User(string U, string P)
        {
            SqlParameter[] param = new SqlParameter[2];
            DataTable da = new DataTable();
            DAL.Data Data = new DAL.Data();
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[0].Value = U;
            param[1].Value = P;
            da = Data.Query(param, "Insert_In_User_Data");
        }
    }
}
