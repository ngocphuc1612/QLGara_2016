using System;

namespace Entity
{
    public class Entity_PhieuThanhToan
    {
        #region Field
        private int maPtt, maPsc;
        private DateTime ngayTt;
        private Double tongTt;
        #endregion

        #region Constructor
        public Entity_PhieuThanhToan(int maPtt, int maPsc)
        {
            this.maPtt = maPtt;
            this.maPsc = maPsc;
        }
        #endregion

        #region Properties
        public int MaPsc
        {
            get
            {
                return maPsc;
            }

        }

        public int MaPtt
        {
            get
            {
                return maPtt;
            }

        }

        public DateTime NgayTt
        {
            get
            {
                return ngayTt;
            }

        }

        public double TongTt
        {
            get
            {
                return tongTt;
            }

        }

        #endregion
    }
}
