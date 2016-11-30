using System;

namespace Entity
{
    public class Entity_CTPhieuNhap
    {

        #region Field
        private int maPn, maVt;
        private int slNhap;
        private Double tongTienNhap;
        #endregion

        #region Constructor
        public Entity_CTPhieuNhap(int maPn, int maVt, int slNhap, Double tongTn)
        {
            this.maPn = maPn;
            this.maVt = maVt;
            this.slNhap = slNhap;
            this.tongTienNhap = tongTn;
        }
        #endregion

        #region Properties
        public int MaPn
        {
            get
            {
                return maPn;
            }
        }

        public int MaVt
        {
            get
            {
                return maVt;
            }

        }

        public int SlNhap
        {
            get
            {
                return slNhap;
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
