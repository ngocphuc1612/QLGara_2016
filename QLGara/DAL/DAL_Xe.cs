using System;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_Xe
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            return GetAllInfor.GetData("XE");
        }

        public bool insertXe(Entity_Xe _xe)
        {
            try
            {
                const string strSQL = "SP_INSERT_XE";
                string[] pNames = { "@bs", "@userId", "@ngayTN", "@dongXeId", "@mau", "@mota", "@mauTrong", "@namXX", "@xuatXu" };
                object[] pValues = { _xe.BienSo, _xe.User_id, _xe.NgayTn, _xe.DongXeId, _xe.MauXe, _xe.MoTa, _xe.MauNoiThat, _xe.NamSx, _xe.XuatSu };
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

        public bool updateXe(Entity_Xe _xe)
        {
            try
            {
                const string strSQL = "SP_UPDATE_XE";
                string[] pNames = { "@bs", "@userId", "@ngayTN", "@dongXeId", "@mau", "@mota", "@mauTrong", "@namXX", "@xuatXu" };
                object[] pValues = { _xe.BienSo, _xe.User_id, _xe.NgayTn, _xe.DongXeId, _xe.MauXe, _xe.MoTa, _xe.MauNoiThat, _xe.NamSx, _xe.XuatSu };
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

        public bool DelXe(string bienSo)
        {
            try
            {
                const string strSQL = "SP_DEL_XE";
                string[] pNames = { "@bs" };
                object[] pValues = { bienSo };
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

        public DataTable searchXe(string content)
        {
            try
            {
                const string strSQL = "SP_SEARCH_XE";
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
