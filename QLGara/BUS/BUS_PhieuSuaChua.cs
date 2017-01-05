using System;
using System.Data;
using DAL;
using Entity;

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

        public bool insertPSC(Entity_PhieuSuaChua _psc)
        {
            return psc.insertPSC(_psc);
        }
        public bool updatePSC(Entity_PhieuSuaChua _psc)
        {
            return psc.updatePSC(_psc);
        }

        public bool delPSC(int maPsc)
        {
            return psc.delPSC(maPsc);
        }

        public DataTable getPscByID(int maPsc)
        {
            return psc.get_Psc_by_id(maPsc);
        }
    }
}
