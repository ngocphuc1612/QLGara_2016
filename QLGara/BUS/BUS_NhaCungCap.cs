using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        private DAL_NhaCungCap ncc = new DAL_NhaCungCap();
        public DataTable getData()
        {
            return ncc.GetData();
        }
    }
}
