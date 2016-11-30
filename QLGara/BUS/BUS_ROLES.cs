using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ROLES
    {
        DAL_ROLES rl = new DAL_ROLES();
        public DataTable GetData()
        {
            return rl.GetData();
        }
    }
}
