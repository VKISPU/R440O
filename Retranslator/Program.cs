using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Retranslator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Server ser = new Server("http://localhost:8080/");
            Application.Run(new ServerForm());
        }
    }
}
