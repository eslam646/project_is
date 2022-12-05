using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final_IS.DAL
{
    class Data
    {
        SqlCommand cmd=new SqlCommand();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlConnection cn;
        public Data()
        {
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=Project_IS;Integrated Security=True");
        } 
        public void Open()
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();
        }
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        public void Non_Query(SqlParameter[]param,string proc)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;
            cmd.Parameters.Clear();
            if (param != null)
                cmd.Parameters.AddRange(param);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable Query(SqlParameter[] param, string proc)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;
            cmd.Parameters.Clear();
            if (param != null)
                cmd.Parameters.AddRange(param);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
