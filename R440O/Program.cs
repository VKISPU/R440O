﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O
{
    using System;
    using System.Windows.Forms;

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
            //ParametersConfig.SetParameters();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new R440OForms.R440O.R440OForm());
        }
    }
}