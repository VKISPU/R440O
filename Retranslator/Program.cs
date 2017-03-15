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
            Server server = new Server("http://localhost:8080/");
            var serverForm = new ServerForm();
            server.StationListUpdateEvent += serverForm.DrawStantionList;
            Application.Run(serverForm);
        }
    }
}
