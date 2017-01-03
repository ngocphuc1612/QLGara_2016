using System;
using System.Data;
using Entity;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_VatTu
    {
        private DAL_VatTu vt = new DAL_VatTu();
        public DataTable GetData()
        {
            return vt.GetData();
        }

        public bool insertVatTu(Entity_VatTu _vt)
        {
            return vt.insertVatTu(_vt);
        }

        public bool updateVatTu(Entity_VatTu _vt)
        {
            return vt.updateVatTu(_vt);
        }

        public bool delVatTu(int maVt)
        {
            return vt.delVatTu(maVt);
        }
    }
}
