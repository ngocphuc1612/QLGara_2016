using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang kh = new DAL_KhachHang();
        public DataTable getData()
        {
            return kh.GetData();
        }
    }
}
