using System;

namespace Entity
{
    public class Entity_TienCong
    {
        #region Field
        private int maTc;
        private string tenTc;
        private Double giaTien;
        #endregion

        #region Constructor
        public Entity_TienCong(int maTc, string tenTc, Double giaTien)
        {
            this.maTc = maTc;
            this.tenTc = tenTc;
            this.giaTien = giaTien;
        }
        #endregion

        #region Properties
        public int MaTc
        {
            get
            {
                return maTc;
            }

        }

        public string TenTc
        {
            get
            {
                return tenTc;
            }
        }

        public double GiaTien
        {
            get
            {
                return giaTien;
            }

        }
        #endregion
    }
}
