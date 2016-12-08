using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_PhieuThanhToan
    {
        private DAL_PhieuThanhToan ptt = new DAL_PhieuThanhToan();
        public DataTable getData()
        {
            return ptt.GetData();
        }
    }
}
