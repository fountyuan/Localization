using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fountain.WinForm.App
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LocalInfo localInfo = new LocalInfo();
            localInfo.Loading();
            Application.Run(new LoginForm());
        }
    }
}
