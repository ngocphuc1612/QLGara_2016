using System;
using System.Data;

namespace DAL
{
    public class DAL_PhieuSuaChua
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "PHIEUSUACHUA";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("PHIEUSUACHUA");
        }

        public DataTable findByID(string content)
        {
            try
            {
                const string strSQL = "SP_SELECT_PHIEUSUACHUA";
                string[] pNames = { "@id" };
                object[] pValues = { content };

                return con.GetValue(strSQL, pNames, pValues);
            }
            catch
            {
                return null;
            }
        }
    }
}
