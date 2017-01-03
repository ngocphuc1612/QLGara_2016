using System;

namespace Entity
{
    public class Entity_HieuXe
    {
        #region Fields
        private int maHx;
        private string tenHx;
        #endregion

        #region Constructor
        public Entity_HieuXe(int maHx, string tenHx)
        {
            this.maHx = maHx;
            this.tenHx = tenHx;
        }
        #endregion

        #region Properties
        public int MaHx
        {
            get
            {
                return maHx;
            }

        }

        public string TenHx
        {
            get
            {
                return tenHx;
            }

        }
        #endregion
    }

}
