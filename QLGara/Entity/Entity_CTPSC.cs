using System;

namespace Entity
{
    public class Entity_CTPSC
    {
        #region Field
        private int maPsc, maVt, soLuong;
        private string noiDung;
        private Double donGia;
        #endregion

        #region Constructor

        public Entity_CTPSC(int maPsc, int maVt, int soLuong)
        {
            this.maPsc = maPsc;
            this.maVt = maVt;
            this.soLuong = soLuong;
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

        public int MaVt
        {
            get
            {
                return maVt;
            }

        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

        }

        public string NoiDung
        {
            get
            {
                return noiDung;
            }


        }

        public double DonGia
        {
            get
            {
                return donGia;
            }

        }
        #endregion

    }
}
