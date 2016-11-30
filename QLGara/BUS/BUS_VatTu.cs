using System;
using System.Data;
using Entity;
using DAL;

namespace BUS
{
    public class BUS_VatTu
    {
        private DAL_VatTu vt = new DAL_VatTu();
        public DataTable GetData()
        {
            return vt.GetData();
        }
    }
}
