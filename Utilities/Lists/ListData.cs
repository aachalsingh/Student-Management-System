using JIDBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_final.Utilities.Lists
{
    public class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dgv, string storedProcedureName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

            dgv.DataSource = db.GetDataList(storedProcedureName);
        }
    }
}
