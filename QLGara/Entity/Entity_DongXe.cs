using System;

namespace Entity
{
    public class Entity_DongXe
    {

        #region Fields
        private int dongXeId;
        private int hieuXe;
        private int soCua, soGhe;
        private string hopSo, danDong, nguyenLieu, kieuDang;
        #endregion

        #region Constructor
        public Entity_DongXe(int dongXeId, int hieuXe, string hopSo, string danDong, string nguyenLieu, string kieuDang, int soCua = 2, int soGhe = 4)
        {
            this.dongXeId = dongXeId;
            this.hieuXe = hieuXe;
            this.soCua = soCua;
            this.soGhe = soGhe;
            this.hopSo = hopSo;
            this.danDong = danDong;
            this.nguyenLieu = nguyenLieu;
            this.kieuDang = kieuDang;
        }
        #endregion

        #region Properties
        public int DongXeId
        {
            get
            {
                return dongXeId;
            }

        }

        public int HieuXe
        {
            get
            {
                return hieuXe;
            }
        }

        public int SoCua
        {
            get
            {
                return soCua;
            }
        }

        public int SoGhe
        {
            get
            {
                return soGhe;
            }
        }

        public string HopSo
        {
            get
            {
                return hopSo;
            }
        }

        public string DanDong
        {
            get
            {
                return danDong;
            }
        }

        public string NguyenLieu
        {
            get
            {
                return nguyenLieu;
            }
        }

        public string KieuDang
        {
            get
            {
                return kieuDang;
            }
        }
        #endregion

    }

}
