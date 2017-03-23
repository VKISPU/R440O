//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O
{
    using System;
    using System.Windows.Forms;
    using R440O.InternalBlocks;

    /// <summary>
    /// Класс инициализации программы
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Antenna.findRetranslator();
            ParametersConfig.SetParameters();
            Antenna.StartServerPing();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new R440OForms.R440O.R440OForm());
        }
    }
}