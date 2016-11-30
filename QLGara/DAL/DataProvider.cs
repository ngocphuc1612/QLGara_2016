using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataProvider
    {
        public static SqlConnection connect;
        public static SqlCommand cmd;
        DataTable dt;
        public static void Open()
        {
            if (DataProvider.connect == null)
                DataProvider.connect = new SqlConnection("Data Source=(local);Initial Catalog=QLGara;Integrated Security=SSPI;");
            if (DataProvider.connect.State != ConnectionState.Open)
                DataProvider.connect.Open();
        }
        public void Close()
        {
            if (DataProvider.connect != null)
            {
                if (DataProvider.connect.State == ConnectionState.Open)
                    DataProvider.connect.Close();
            }
        }

        public DataTable GetData(string strSQL, string pNames, object pValues)
        {
            try
            {
                Open();
                cmd = new SqlCommand(strSQL, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(pNames, SqlDbType.VarChar).Value = pValues;
                var da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                Close();
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public int ExecuteStoredProcedure(string spName, string[] pNames, object[] pValues)
        {
            Open();
            cmd = new SqlCommand(spName, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p;
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            //Added 19/11
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            int query = (int)returnParameter.Value;
            Close();
            return query;
        }
        public DataTable GetValue(string strSQL, string[] pNames, object[] pValues)
        {
            try
            {
                Open();
                cmd = new SqlCommand(strSQL, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                for (int i = 0; i < pNames.Length; i++)
                {
                    cmd.Parameters.Add(pNames[i], SqlDbType.VarChar).Value = pValues[i];
                    da = new SqlDataAdapter(cmd);
                }
                dt = new DataTable();
                da.Fill(dt);
                Close();
                return dt;
            }
            catch
            {
                return null;
            }

        }
    }
}
