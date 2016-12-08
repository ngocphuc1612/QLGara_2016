using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_PhieuNhap
    {
        private DAL_PhieuNhap pn = new DAL_PhieuNhap();
        public DataTable getData()
        {
            return pn.GetData();
        }
    }
}
