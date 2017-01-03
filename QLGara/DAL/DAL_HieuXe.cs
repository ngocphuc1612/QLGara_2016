using System;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_HieuXe
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "HIEUXE";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("HIEUXE");
        }

        public bool insertHieuXe(Entity_HieuXe _hx)
        {
            try
            {
                string strSQL = "SP_INSERT_HIEUXE";
                string[] pNames = { "@maHx", "@tenHx" };
                object[] pValues = { _hx.MaHx, _hx.TenHx };
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

        public bool updateHieuXe(Entity_HieuXe _hx)
        {
            try
            {
                string strSQL = "SP_UPDATE_HIEUXE";
                string[] pNames = { "@maHx", "@tenHx" };
                object[] pValues = { _hx.MaHx, _hx.TenHx };
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

        public bool delHieuXe(String maHx)
        {
            try
            {
                string strSQL = "SP_DEL_HIEUXE";
                string[] pNames = { "@maHx" };
                object[] pValues = { maHx };
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
