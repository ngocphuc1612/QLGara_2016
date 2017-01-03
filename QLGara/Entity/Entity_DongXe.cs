using System;

namespace Entity
{
    public class Entity_DongXe
    {

        #region Fields
        private string dongXeId;
        private string hieuXe;
        private string tskt;
        #endregion

        #region Constructor
        public Entity_DongXe(string dongXeId, string hieuXe, string tskt)
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

        public string HieuXe
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
