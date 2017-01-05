using System;
using System.Data;
using Entity;

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

        public bool insertHoaDon(Entity_PhieuThanhToan _ptt)
        {
            try
            {
                const string strSQL = "SP_INSERT_HOADON";
                string[] pNames = { "@maPtt", "@maPsc" };
                object[] pValues = { _ptt.MaPtt, _ptt.MaPsc };
                int count = con.ExecuteStoredProcedure(strSQL, pNames, pValues);
                if (count >= 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable searchHoaDon (string content)
        {
            try
            {
                const string strSQL = "SP_SEARCH_HOADON";
                string[] pNames = { "@content" };
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
