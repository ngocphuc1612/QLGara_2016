using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_HieuXe
    {

        private DAL_HieuXe hx = new DAL_HieuXe();
        public DataTable getData()
        {
            return hx.GetData();
        }

    }
}
