using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_HieuXe
    {

        private DAL_HieuXe hx = new DAL_HieuXe();
        public DataTable getData()
        {
            return hx.GetData();
        }

        public bool insertHieuXe(Entity_HieuXe _hx)
        {
            return hx.insertHieuXe(_hx);
        }

        public bool delHieuXe(String maHx)
        {
            return hx.delHieuXe(maHx);
        }

        public bool updateHieuXe(Entity_HieuXe _hx)
        {
            return hx.updateHieuXe(_hx);
        }

    }
}
