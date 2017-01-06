using System;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_CTPSC
    {
        DataProvider con = new DataProvider();
        public DataTable getData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "CT_PHIEUSUACHUA";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("CT_PHIEUSUACHUA");
        }
        public DataTable getData(string val)
        {
            try
            {
                const string strSQL = "SP_SELECT_CTPSC";
                string pNames = "@content";
                object[] pValues = { val };

                return con.GetData(strSQL, pNames, pValues);

            }
            catch
            {

                return null;
            }
        }
        public bool insertCTPSC(Entity_CTPSC _ct)
        {
            try
            {
                const string strSQL = "SP_INSERT_CTPSC";
                 string[] pNames = { "@maPsc", "@maVt", "@sl" };
                object[] pValues = { _ct.MaPsc, _ct.MaVt, _ct.SoLuong };
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

        public bool deleteCTPSC(Entity_CTPSC _ct)
        {
            try
            {
                const string strSQL = "SP_DEL_CTPSC";
                string[] pNames = { "@maPsc", "@maVt" };
                object[] pValues = { _ct.MaPsc, _ct.MaVt };
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
