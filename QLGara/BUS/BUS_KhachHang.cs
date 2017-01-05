using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang kh = new DAL_KhachHang();
        public DataTable getData()
        {
            return kh.GetData();
        }
        public DataTable findByID(string id)
        {
            return kh.findByID(id);
        }

        public bool delKhachHang(string khachhang)
        {
            return kh.delKhachHang(khachhang);
        }
        public DataTable searchKH(string content)
        {
            return kh.searchKH(content);
        }

        public bool insertKhachHang(Entity_KhachHang _kh)
        {
            return kh.insertKhachHang(_kh);
        }
    }
}
