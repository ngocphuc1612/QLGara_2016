using System;
using System.Data;

namespace DAL
{
    public class DAL_TienCong
    {
        public DataTable GetData()
        {
            return GetAllInfor.GetData("TIENCONG");
        }
    }
}
