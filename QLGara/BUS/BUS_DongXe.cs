using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_DongXe
    {
        private DAL_DongXe dx = new DAL_DongXe();
        
        public DataTable getData()
        {
            return dx.GetData();
        }
       
    }
}
