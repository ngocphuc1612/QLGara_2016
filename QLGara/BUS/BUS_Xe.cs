using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Xe
    {
        private DAL_Xe xe = new DAL_Xe();
        public DataTable getData()
        {
            return xe.GetData();
        }
    }
}
