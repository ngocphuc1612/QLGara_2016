using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_DongXe
    {
        private DAL_DongXe dx = new DAL_DongXe();
        
        public DataTable getData()
        {
            return dx.GetData();
        }

        public bool delDongXe(string khachhang)
        {
            return dx.delObject(khachhang);
        }

        public DataTable searchKH(string content)
        {
            return dx.searchObject(content);
        }

        public bool insertDongXe(Entity_DongXe _dx)
        {
            return dx.insertDongXe(_dx);
        }
        public bool updateDongXe(Entity_DongXe _dx)
        {
            return dx.updateDongXe(_dx);
        }

    }
}
