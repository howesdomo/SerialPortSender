using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SerialPortSender
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Util.DBHelper.SQLiteFactory = System.Data.SQLite.SQLiteFactory.Instance;           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSerialPortSender());
        }
    }
}
