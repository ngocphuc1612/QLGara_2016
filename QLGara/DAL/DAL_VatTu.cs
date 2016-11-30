using System;
using System.Data;

namespace DAL
{
    public class DAL_VatTu
    {
        public DataTable GetData()
        {
            return GetAllInfor.GetData("VATTU");
        }
    }
}
