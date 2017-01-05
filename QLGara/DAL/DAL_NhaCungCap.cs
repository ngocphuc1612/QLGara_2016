using System;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_NhaCungCap
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "NHACUNGCAP";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("NHACUNGCAP");
        }
        
        public bool delObject(string obj)
        {
            try
            {
                const string strSQL = "SP_DEL_NHACUNGCAP";
                string[] pNames = { "@id" };
                object[] pValues = { obj };
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

        public bool insertNCC(Entity_NhaCungCap _ncc)
        {
            try
            {
                const string strSQL = "SP_INSERT_NCC";
                string[] pNames = { "@id", "@ten", "@email", "@sdt", "@diaChi" };
                object[] pValues = { _ncc.NccId, _ncc.Ten, _ncc.Email, _ncc.Sdt, _ncc.DiaChi };
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

        public DataTable searchObject(string content)
        {
            try
            {
                const string strSQL = "SP_SEARCH_NHACUNGCAP";
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
