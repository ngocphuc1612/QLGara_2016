using System;
using System.Data;

namespace DAL
{
    public static class GetAllInfor
    {
        static DataProvider con = new DataProvider();
        public static DataTable GetData(string tableName)
        {
            const string strSQL = "SP_GETDATA";
            const string pNames = "@tableName";
            string pValues = tableName;
            return con.GetData(strSQL, pNames, pValues);
        }
    }
}
