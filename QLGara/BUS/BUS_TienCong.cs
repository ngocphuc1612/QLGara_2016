using System;
using System.Data;
//using Entity;
using DAL;

namespace BUS
{
    public class BUS_TienCong
    {
        private DAL_TienCong tc = new DAL_TienCong();

        public DataTable getData()
        {
            return tc.GetData();
        }
    }
}
