using System;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_PhieuSuaChua
    {
        private DAL_PhieuSuaChua psc = new DAL_PhieuSuaChua();
        public DataTable getData()
        {
            return psc.GetData();
        }

        public DataTable findByID(string id)
        {
            return psc.findByID(id);
        }
    }
}
