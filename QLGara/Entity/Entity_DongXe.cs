using System;

namespace Entity
{
    public class Entity_DongXe
    {

        #region Fields
        private string dongXeId;
        private int hieuXe;
        private string tskt;
        #endregion

        #region Constructor
        public Entity_DongXe(string dongXeId, int hieuXe, string tskt)
        {
            this.dongXeId = dongXeId;
            this.hieuXe = hieuXe;
            this.tskt = tskt;
        }
        #endregion

        #region Properties
        public string DongXeId
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

        public string Tskt
        {
            get
            {
                return tskt;
            }

        }
        #endregion

    }

}
