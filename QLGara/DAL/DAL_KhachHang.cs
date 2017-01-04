using System;
using System.Data;

namespace DAL
{
    public class DAL_KhachHang
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "KHACHHANG";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("KHACHHANG");
        }

        public DataTable findByID(string content)
        {
            try
            {
                const string strSQL = "SP_SELECT_KHACHHANG";
                string[] pNames = { "@id" };
                object[] pValues = { content };

                return con.GetValue(strSQL, pNames, pValues);
            }
            catch
            {
                return null;
            }
        }

        public bool delKhachHang(string khachhang)
        {
            try
            {
                const string strSQL = "SP_DEL_KHACHHANG";
                string[] pNames = { "@id" };
                object[] pValues = { khachhang };
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

        public DataTable searchKH(string content)
        {
            try
            {
                const string strSQL = "SP_SEARCH_KHACHHANG";
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
