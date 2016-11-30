using System;

namespace Entity
{
    public class Entity_NhaCungCap
    {

        #region Fields
        private int nccId;
        private string ten, sdt, email, diaChi;
        #endregion

        #region Constructor
        public Entity_NhaCungCap(int id, string ten, string sdt, string email, string diaChi)
        {
            this.nccId = id;
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
        }
        #endregion

        #region Properties
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

        }

        public int NccId
        {
            get
            {
                return nccId;
            }

        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

        }

        public string Ten
        {
            get
            {
                return ten;
            }
        }
        #endregion
    }
}
