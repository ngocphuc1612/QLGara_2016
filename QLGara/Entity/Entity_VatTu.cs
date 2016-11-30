using System;

namespace Entity
{
    public class Entity_VatTu
    {

        #region Field
        private int maVt;
        private string tenVt;
        private Double donGia;
        private int soLuong;
        #endregion

        #region
        public Entity_VatTu(int maVt, string tenVt, Double donGia, int soLuong)
        {
            this.maVt = maVt;
            this.tenVt = tenVt;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }
        #endregion

        #region Properties
        public int MaVt
        {
            get
            {
                return maVt;
            }

        }

        public string TenVt
        {
            get
            {
                return tenVt;
            }

        }

        public double DonGia
        {
            get
            {
                return donGia;
            }

        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

        }
        #endregion
    }
}
