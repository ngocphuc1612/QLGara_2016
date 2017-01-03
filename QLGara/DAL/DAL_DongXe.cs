using System;
using System.Data;
using Entity;

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

        public bool insertDongXe(Entity_DongXe _dx)
        {
            try
            {
                const string strSQL = "SP_INSERT_DONGXE";
                string[] pNames = { "@id", "@hieuXe", "@tskt" };
                object[] pValues = { _dx.DongXeId, _dx.HieuXe, _dx.Tskt };
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

        public bool updateDongXe(Entity_DongXe _dx)
        {
            try
            {
                const string strSQL = "SP_UPDATE_DONGXE";
                string[] pNames = { "@id", "@hieuXe", "@tskt" };
                object[] pValues = { _dx.DongXeId, _dx.HieuXe, _dx.Tskt };
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

        public bool delDongXe(string dongXe)
        {
            try
            {
                const string strSQL = "SP_DEL_DONGXE";
                string[] pNames = { "@id" };
                object[] pValues = { dongXe };
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
