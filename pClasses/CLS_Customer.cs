using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final_IS.pClasses
{
    class CLS_Customer
    {
        DAL.Data Data = new DAL.Data();
        public DataTable Add_Customer(string name,int num,string adrreeds,string gander,string email)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Cust_Name", SqlDbType.VarChar, 100);
            param[1] = new SqlParameter("@Cust_Telphone_Number", SqlDbType.Int);
            param[2] = new SqlParameter("@Cust_Adreess", SqlDbType.VarChar, 100);
            param[3] = new SqlParameter("@Cust_Gender", SqlDbType.VarChar, 50);
            param[4] = new SqlParameter("@Cust_Email", SqlDbType.VarChar, 100);
            param[0].Value = name;
            param[1].Value = num;
            param[2].Value = adrreeds;
            param[3].Value = gander;
            param[4].Value = email;
            dt=Data.Query(param, "Add_Customer");
            return dt;
        }
        public DataTable Edite_Customer(int id, string name, int num, string adrreeds, string gander, string email)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[1] = new SqlParameter("@Cust_Name", SqlDbType.VarChar, 100);
            param[2] = new SqlParameter("@Cust_Telphone_Number", SqlDbType.Int);
            param[3] = new SqlParameter("@Cust_Adreess", SqlDbType.VarChar, 100);
            param[4] = new SqlParameter("@Cust_Gender", SqlDbType.VarChar, 50);
            param[5] = new SqlParameter("@Cust_Email", SqlDbType.VarChar, 100);
            param[0].Value = id;
            param[1].Value = name;
            param[2].Value = num;
            param[3].Value = adrreeds;
            param[4].Value = gander;
            param[5].Value = email;
            dt=Data.Query(param, "Edite_Customer");
            return dt;
        }
    }
}
