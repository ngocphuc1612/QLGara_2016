using System;
using System.Data;
using Entity;

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

        public bool insertKhachHang(Entity_KhachHang _kh)
        {
            try
            {
                const string strSQL = "SP_INSERT_KHACHHANG";
                string[] pNames = { "@id", "@ten", "@sdt", "@email", "@diaChi", "@ngaySinh", "@gender", "@congNo" };
                object[] pValues = { _kh.KhId, _kh.Ten, _kh.Sdt, _kh.Email, _kh.DiaChi, _kh.NgaySinh, _kh.GioiTinh, _kh.CongNo };
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
