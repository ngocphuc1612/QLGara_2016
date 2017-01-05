using System;

namespace Entity
{
    public class Entity_KhachHang
    {

        #region Fields
        private int khId;
        private string ten, sdt, email, diaChi;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private int role;
        private Double congNo;
        #endregion

        #region Constructor
        public Entity_KhachHang(int id, string ten, string sdt, string email, string diaChi, DateTime ns, bool gt, Double congNo)
        {
            this.khId = id;
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
            this.ngaySinh = ns;
            this.gioiTinh = gt;
            this.congNo = congNo;
        }
        #endregion

        #region Properties
        public int KhId
        {
            get
            {
                return khId;
            }

        }

        public string Ten
        {
            get
            {
                return ten;
            }

        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }

        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

        }

        public int Role
        {
            get
            {
                return role;
            }

        }

        public double CongNo
        {
            get
            {
                return congNo;
            }

        }
        #endregion

    }

}
