using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_final.Utilities
{
    internal class AppSetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        }
    }
}
