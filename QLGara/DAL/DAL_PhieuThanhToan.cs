using System;
using System.Data;

namespace DAL
{
    public class DAL_PhieuThanhToan
    {

        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "PHIEUTHANHTOAN";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("PHIEUTHANHTOAN");
        }

        public DataTable getHoaDon()
        {
            try
            {
                const string strSQL = "SP_GETALL_PHIEUTT";
                string[] pNames = { "@content" };
                object[] pValues = { "2" };

                return con.GetValue(strSQL, pNames, pValues);
            }
            catch
            {
                return null;
            }
        }

    }
}
