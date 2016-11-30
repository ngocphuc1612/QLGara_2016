using System;

namespace Entity
{
    public class Entity_PhieuNhap
    {
        #region Field
        private int maPhieuNhap;
        private DateTime ngayNhap;
        private Double tongTienNhap;
        #endregion

        #region Constructor
        public Entity_PhieuNhap(int maPn, Double tongTienNhap)
        {
            this.maPhieuNhap = maPn;
            this.tongTienNhap = tongTienNhap;
            this.ngayNhap = DateTime.Now;
        }
        #endregion

        #region Properties
        public int MaPhieuNhap
        {
            get
            {
                return maPhieuNhap;
            }

        }

        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

        }

        public double TongTienNhap
        {
            get
            {
                return tongTienNhap;
            }

        }
        #endregion
    }
}
