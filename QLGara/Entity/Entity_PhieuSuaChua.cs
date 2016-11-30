using System;

namespace Entity
{
    public class Entity_PhieuSuaChua
    {

        #region Field
        private int maPsc;
        private string bienSo;
        private int user_id;
        private DateTime ngaySc;
        private int maTc;
        private Double tongTt;
        #endregion

        #region Constructor
        public Entity_PhieuSuaChua(int maPsc, string bienSo, int user_id, int maTc, Double tongTt)
        {
            this.maPsc = maPsc;
            this.bienSo = bienSo;
            this.user_id = user_id;
            this.maTc = maTc;
            this.tongTt = tongTt;
            this.ngaySc = DateTime.Now;
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

        public string BienSo
        {
            get
            {
                return bienSo;
            }

        }

        public int User_id
        {
            get
            {
                return user_id;
            }

        }

        public DateTime NgaySc
        {
            get
            {
                return ngaySc;
            }

        }

        public int MaTc
        {
            get
            {
                return maTc;
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
