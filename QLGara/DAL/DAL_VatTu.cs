using System;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_VatTu
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            return GetAllInfor.GetData("VATTU");
        }

        public bool insertVatTu(Entity_VatTu _vt)
        {
            try
            {
                const string strSQL = "SP_INSERT_VATTU";
                string[] pNames = { "@maVt", "@tenVt", "@donGia", "@sl" };
                object[] pValues = { _vt.MaVt, _vt.TenVt, _vt.DonGia, _vt.SoLuong };
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

        public bool updateVatTu(Entity_VatTu _vt)
        {
            try
            {
                const string strSQL = "SP_UPDATE_VATTU";
                string[] pNames = { "@maVt", "@tenVt", "@donGia", "@sl" };
                object[] pValues = { _vt.MaVt, _vt.TenVt, _vt.DonGia, _vt.SoLuong };
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

        public bool delVatTu(int maVt)
        {
            try
            {
                const string strSQL = "SP_DEL_VATTU";
                string[] pNames = { "@maVt" };
                object[] pValues = { maVt };
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

    }
}
