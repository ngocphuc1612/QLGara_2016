using System;
using System.Data;

namespace DAL
{
    public class DAL_Xe
    {
        public DataTable GetData()
        {
            return GetAllInfor.GetData("XE");
        }
    }
}
