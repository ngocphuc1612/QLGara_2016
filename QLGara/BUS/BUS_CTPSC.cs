using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_CTPSC
    {
        private DAL_CTPSC psc = new DAL_CTPSC();
        public DataTable getData()
        {
            return psc.GetData();
        }
    }
}
