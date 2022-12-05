using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final_IS.pClasses
{
    class CLS_Movies
    {
        DAL.Data Data = new DAL.Data();
        public DataTable Check_ID(string ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mov_ID", SqlDbType.Int);
            param[0].Value = ID;
            dt = Data.Query(param, "Check_Mov_ID");
            return dt;
        }
        public DataTable Add_Item(string Name,string desc,string actors,int duaration,int quant,int tID,int qID,int LanID,int time)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Mov_Name", SqlDbType.VarChar, 100);
            param[1] = new SqlParameter("@Mov_Description", SqlDbType.VarChar, 500);
            param[2] = new SqlParameter("@Mov_Actors", SqlDbType.VarChar, 200);
            param[3] = new SqlParameter("@Mov_Duration", SqlDbType.Int);
            param[4] = new SqlParameter("@Mov_Copies", SqlDbType.Int);
            param[5] = new SqlParameter("@Mov_Type_ID", SqlDbType.Int);
            param[6] = new SqlParameter("@Mov_Qut_ID", SqlDbType.Int);
            param[7] = new SqlParameter("@Mov_Lang_ID", SqlDbType.Int);
            param[8] = new SqlParameter("@Mov_Release_Date", SqlDbType.Int);
            param[0].Value = Name;
            param[1].Value = desc;
            param[2].Value = actors;
            param[3].Value = duaration;
            param[4].Value = quant;
            param[5].Value = tID;
            param[6].Value = qID;
            param[7].Value = LanID;
            param[8].Value = time;
            dt=Data.Query(param, "Insert_Movie");
            return dt;
        }
        public DataTable Search(string s)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.VarChar, 100);
            param[0].Value = s;
            dt = Data.Query(param, "SearchProduct");
            return dt;
        }
        public DataTable Delete(string ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mov_ID", SqlDbType.VarChar, 100);
            param[0].Value = "";
            param[0].Value = ID;
            DAL.Data Data = new DAL.Data();
            dt=Data.Query(param, "Delete_Movie");
            return dt;
        }
        public DataTable Edite_Movie(string ID, string Name, string desc, string actors, int duaration, int quant, int tID, int qID, int LanID,int time)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Mov_ID", SqlDbType.Int);
            param[1] = new SqlParameter("@Mov_Name", SqlDbType.VarChar, 100);
            param[2] = new SqlParameter("@Mov_Description", SqlDbType.VarChar, 500);
            param[3] = new SqlParameter("@Mov_Actors", SqlDbType.VarChar, 200);
            param[4] = new SqlParameter("@Mov_Duration", SqlDbType.Int);
            param[5] = new SqlParameter("@Mov_Copies", SqlDbType.Int);
            param[6] = new SqlParameter("@Mov_Type_ID", SqlDbType.Int);
            param[7] = new SqlParameter("@Mov_Qut_ID", SqlDbType.Int);
            param[8] = new SqlParameter("@Mov_Lang_ID", SqlDbType.Int);
            param[9] = new SqlParameter("@Mov_Release_Date", SqlDbType.Int);
            param[0].Value = ID;
            param[1].Value = Name;
            param[2].Value = desc;
            param[3].Value = actors;
            param[4].Value = duaration;
            param[5].Value = quant;
            param[6].Value = tID;
            param[7].Value = qID;
            param[8].Value = LanID;
            param[9].Value = time;
            dt=Data.Query(param, "Edite_Movie");
            return dt;
        }
        public void Borrow(string CID, string MID, string Sdate, string Edate, string US)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Cust_ID", SqlDbType.VarChar, 50);
            param[1] = new SqlParameter("@Mov_ID", SqlDbType.VarChar, 100);
            param[2] = new SqlParameter("@Sart_Time", SqlDbType.DateTime);
            param[3] = new SqlParameter("@End_Time", SqlDbType.DateTime);
            param[4] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = CID;
            param[1].Value = MID;
            param[2].Value = Sdate;
            param[3].Value = Edate;
            param[4].Value = US;
            Data.Non_Query(param, "Insert_Rent");
        }
    }
}
