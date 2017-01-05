using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_CTPSC
    {
        private DAL_CTPSC psc = new DAL_CTPSC();
        public DataTable getData()
        {
            return psc.getData();
        }
        public DataTable getData(string val)
        {
            return psc.getData(val);
        }
        public bool insertCTPSC(Entity_CTPSC _ct)
        {
            return psc.insertCTPSC(_ct);
        }
    }
}
