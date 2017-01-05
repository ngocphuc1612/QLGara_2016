using System;
using System.Data;
using Entity;


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
        public bool insertPSC(Entity_PhieuSuaChua _psc)
        {
            try
            {
                const string strSQL = "SP_INSERT_PSC";
                string[] pNames = { "@maPsc", "@bs", "@uid" };
                object[] pValues = { _psc.MaPsc, _psc.BienSo, _psc.User_id };
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
        public bool updatePSC(Entity_PhieuSuaChua _psc)
        {
            try
            {
                const string strSQL = "SP_UPDATE_PSC";
                string[] pNames = { "@maPsc" };
                object[] pValues = { _psc.MaPsc, _psc.User_id };
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

        public bool delPSC(int maPsc)
        {
            try
            {
                const string strSQL = "SP_DEL_PSC";
                string[] pNames = { "@maPsc" };
                object[] pValues = { maPsc };
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
