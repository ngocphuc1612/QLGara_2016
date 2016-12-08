using System;
using System.Data;

namespace QLGara
{
    class Utility
    {
        public static Utility Instance = new Utility();
        private Utility() { }

        public DataTable changeGender(DataTable dt, String gender)
        {
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[gender].DataType = typeof(String);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtCloned.ImportRow(dt.Rows[i]);
                dtCloned.Rows[i][gender] = ((bool)dt.Rows[i][gender]) ? "Nam" : "Nữ";
            }

            return dtCloned;
        }

    }
}
