using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_CTPhieuNhap
    {
        private DAL_CTPhieuNhap pn = new DAL_CTPhieuNhap();
        public DataTable getData()
        {
            return pn.GetData();
        }
    }
}
