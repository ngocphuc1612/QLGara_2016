using System;
using System.Data;

namespace DAL
{
    public class DAL_DongXe
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "CACLOAIXE";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("CACLOAIXE");
        }
    }
}
