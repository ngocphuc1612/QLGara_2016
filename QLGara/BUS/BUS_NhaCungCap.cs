using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        private DAL_NhaCungCap ncc = new DAL_NhaCungCap();
        public DataTable getData()
        {
            return ncc.GetData();
        }

        public bool delNCC(string content)
        {
            return ncc.delObject(content);
        }

        public DataTable searchNCC(string content)
        {
            return ncc.searchObject(content);
        }

        public bool insertNCC(Entity_NhaCungCap _ncc)
        {
            return ncc.insertNCC(_ncc);
        }
    }
}
