using System;

namespace Entity
{
    public class Entity_Xe
    {
        #region Fields
        private string bienSo;
        private int user_id, dongXeId;
        private DateTime ngayTn;
        private string mauXe, moTa, mauNoiThat, namSx, xuatSu;
        #endregion

        #region Constructor
        public Entity_Xe(string bienSo, int userId, int dongXeId, string mauXe = "Đen", string mota = "", string mauNoiThat = "Xám", string namSx = "2000", string xuatSu = "Việt Nam")
        {
            this.bienSo = bienSo;
            this.user_id = userId;
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

        public int User_id
        {
            get
            {
                return user_id;
            }

        }

        public int DongXeId
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
        #endregion
    }

}
