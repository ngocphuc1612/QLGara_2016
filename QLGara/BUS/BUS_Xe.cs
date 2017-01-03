using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_Xe
    {
        private DAL_Xe xe = new DAL_Xe();
        public DataTable getData()
        {
            return xe.GetData();
        }
        public bool insertXe(Entity_Xe _xe)
        {
            return xe.insertXe(_xe);
        }

        public bool updateXe(Entity_Xe _xe)
        {
            return xe.updateXe(_xe);
        }

        public bool delXe(string bienSo)
        {
            return xe.DelXe(bienSo);
        }

    }
}
