using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Karyabi
{
    public class Function
    {
        public static DataTable DoQuery(string Query)
        {
            SqlConnection con=new SqlConnection();
            con.ConnectionString = Karyabi.Properties.Settings.Default.ConString;
            SqlDataAdapter da=new SqlDataAdapter(Query,con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void DoDml(string Query)
        {
            SqlConnection con=new SqlConnection();
            con.ConnectionString = Karyabi.Properties.Settings.Default.ConString;
            SqlCommand cmd=new SqlCommand(Query,con);
            if (con.State ==ConnectionState.Closed)
            con.Open();
            cmd.ExecuteNonQuery();
            con.Open();
        }

    }
}