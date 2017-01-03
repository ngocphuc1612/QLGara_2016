using System;
using System.Data;
using System.Windows.Forms;

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

        public int autoKey(DataGridView gr)
        {
            if (gr.RowCount == 0) {
                return 1;
            } else
            {
                return Int32.Parse(gr.Rows[gr.RowCount - 1].Cells[0].Value.ToString()) + 1;
            }
        }

    }
}
