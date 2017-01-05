using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_PhieuThanhToan
    {
        private DAL_PhieuThanhToan ptt = new DAL_PhieuThanhToan();
        public DataTable getData()
        {
            return ptt.GetData();
        }

        public DataTable getHoaDon()
        {
            return ptt.getHoaDon();
        }
        
        public DataTable searchHoaDon(string content)
        {
            return ptt.searchHoaDon(content);
        }

        public bool insertHoaDon(Entity_PhieuThanhToan _ptt)
        {
            return ptt.insertHoaDon(_ptt);
        }
    }
}
