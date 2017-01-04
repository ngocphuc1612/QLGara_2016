using System;

namespace Entity
{
    public class Entity_Xe
    {
        #region Fields
        private string bienSo;
        private string dongXeId;
        private int user_id;
        private DateTime ngayTn;
        private string mauXe, moTa, mauNoiThat, namSx, xuatSu;
        #endregion

        #region Constructor
        public Entity_Xe(string bienSo, int user_id, string dongXeId, string mauXe = "Đen", string mota = "", string mauNoiThat = "Xám", string namSx = "2000", string xuatSu = "Việt Nam")
        {
            this.bienSo = bienSo;
            this.dongXeId = dongXeId;
            this.mauXe = mauXe;
            this.moTa = mota;
            this.mauNoiThat = mauNoiThat;
            this.namSx = namSx;
            this.xuatSu = xuatSu;
            this.ngayTn = DateTime.Now;

        }
        #endregion

        #region Properties
        public string BienSo
        {
            get
            {
                return bienSo;
            }
        }

        public string DongXeId
        {
            get
            {
                return dongXeId;
            }

        }

        public DateTime NgayTn
        {
            get
            {
                return ngayTn;
            }

        }

        public string MauXe
        {
            get
            {
                return mauXe;
            }

        }

        public string MoTa
        {
            get
            {
                return moTa;
            }

        }

        public string MauNoiThat
        {
            get
            {
                return mauNoiThat;
            }

        }

        public string NamSx
        {
            get
            {
                return namSx;
            }

        }

        public string XuatSu
        {
            get
            {
                return xuatSu;
            }

        }

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }
        #endregion
    }

}
