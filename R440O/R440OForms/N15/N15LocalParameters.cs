﻿using System;
using System.Security.Cryptography;

namespace R440O.R440OForms.N15
{
    public static class N15LocalParameters
    {
        static N15LocalParameters()
        {
            var generator = new Random();

            int rnd = generator.Next(1);
            _локТумблерАнтЭкв = rnd == 1;

            rnd = generator.Next(1);
            _локТумблер5Мгц = rnd == 1;
        }

        #region Тумблеры левая часть
        private static bool _локТумблерЦ300М1;
        private static bool _локТумблерЦ300М2;
        private static bool _локТумблерЦ300М3;
        private static bool _локТумблерЦ300М4;
        private static bool _локТумблерН12С;
        private static bool _локТумблерМшу;
        private static bool _локТумблерБМА1;
        private static bool _локТумблерБМА2;
        private static bool _локТумблерА205Base; //чтобы при записи локальных параметров в него не записывалось значение _локТумблерА20512
        private static bool _локТумблерА20512;
        private static bool _локТумблерАФСС;
        private static bool _локТумблерА1;
        private static bool _локТумблерА403;
        private static bool _локТумблерК1_1;
        private static bool _локТумблерК1_2;
        private static bool _локТумблерА30412;
        private static bool _локТумблерБ1_1;
        private static bool _локТумблерБ1_2;
        private static bool _локТумблерБ2_1;
        private static bool _локТумблерБ2_2;
        private static bool _локТумблерБ3_1;
        private static bool _локТумблерБ3_2;
        private static bool _локТумблерДАБ_5;
        private static bool _локТумблерР_Н;

        public static bool локТумблерЦ300М1
        {
            get { return _локТумблерЦ300М1; }
            set { _локТумблерЦ300М1 = value; }
        }

        public static bool локТумблерЦ300М2
        {
            get { return _локТумблерЦ300М2; }
            set { _локТумблерЦ300М2 = value; }
        }

        public static bool локТумблерЦ300М3
        {
            get { return _локТумблерЦ300М3; }
            set { _локТумблерЦ300М3 = value; }
        }

        public static bool локТумблерЦ300М4
        {
            get { return _локТумблерЦ300М4; }
            set { _локТумблерЦ300М4 = value; }
        }

        public static bool локТумблерН12С
        {
            get { return _локТумблерН12С; }
            set { _локТумблерН12С = value; }
        }

        public static bool локТумблерМШУ
        {
            get { return _локТумблерМшу; }
            set { _локТумблерМшу = value; }
        }

        public static bool локТумблерБМА_1
        {
            get { return _локТумблерБМА1; }
            set { _локТумблерБМА1 = value; }
        }

        public static bool локТумблерБМА_2
        {
            get { return _локТумблерБМА2; }
            set { _локТумблерБМА2 = value; }
        }

        public static bool локТумблерА205Base
        {
            get { return _локТумблерА205Base; }
            set { _локТумблерА205Base = value; }
        }

        public static bool локТумблерА20512
        {
            get { return _локТумблерА20512; }
            set { _локТумблерА20512 = value; }
        }

        public static bool локТумблерАФСС
        {
            get { return _локТумблерАФСС; }
            set { _локТумблерАФСС = value; }
        }

        public static bool локТумблерА1
        {
            get { return _локТумблерА1; }
            set { _локТумблерА1 = value; }
        }

        public static bool локТумблерА403
        {
            get { return _локТумблерА403; }
            set { _локТумблерА403 = value; }
        }

        public static bool локТумблерК1_1
        {
            get { return _локТумблерК1_1; }
            set { _локТумблерК1_1 = value; }
        }

        public static bool локТумблерК1_2
        {
            get { return _локТумблерК1_2; }
            set { _локТумблерК1_2 = value; }
        }

        public static bool локТумблерА30412
        {
            get { return _локТумблерА30412; }
            set
            {
                _локТумблерА30412 = value;
                N15Parameters.ResetParameters();
                A304.A304Parameters.ResetParameters();
            }
        }

        public static bool локТумблерБ1_1
        {
            get { return _локТумблерБ1_1; }
            set { _локТумблерБ1_1 = value; }
        }

        public static bool локТумблерБ1_2
        {
            get { return _локТумблерБ1_2; }
            set { _локТумблерБ1_2 = value; }
        }

        public static bool локТумблерБ2_1
        {
            get { return _локТумблерБ2_1; }
            set { _локТумблерБ2_1 = value; }
        }

        public static bool локТумблерБ2_2
        {
            get { return _локТумблерБ2_2; }
            set { _локТумблерБ2_2 = value; }
        }

        public static bool локТумблерБ3_1
        {
            get { return _локТумблерБ3_1; }
            set { _локТумблерБ3_1 = value; }
        }

        public static bool локТумблерБ3_2
        {
            get { return _локТумблерБ3_2; }
            set { _локТумблерБ3_2 = value; }
        }

        public static bool локТумблерДАБ_5
        {
            get { return _локТумблерДАБ_5; }
            set { _локТумблерДАБ_5 = value; }
        }

        public static bool локТумблерР_Н
        {
            get { return _локТумблерР_Н; }
            set { _локТумблерР_Н = value; }
        }
        #endregion

        #region Кнопки и Тумблеры правая часть (Значения в памяти блока)
        private static bool _локТумблер5Мгц ;
        private static bool _локТумблерАнтЭкв;
        private static int _локКнопкаН13;

        /// <summary>
        /// Значение, хранимое в памяти блока для тумблера 5Мгц
        /// true - 2, false - 3
        /// </summary>
        public static bool локТумблер5Мгц
        {
            get { return _локТумблер5Мгц; }
            set { _локТумблер5Мгц = value; }
        }

        /// <summary>
        /// Значение, хранимое в памяти блока для тумблера Антенна/Эквивалент
        /// true - Антенна, false - Эквивалент
        /// </summary>
        public static bool локТумблерАнтЭкв
        {
            get { return _локТумблерАнтЭкв; }
            set { _локТумблерАнтЭкв = value; }
        }

        /// <summary>
        /// Значение, хранимое в памяти блока для комплектов Н13
        /// 0 - Комплекты не включены (Последняя нажатая клавиша - Сброс)
        /// 1 - КнопкаН13_1 (Последняя нажатая клавиша - Н13_1)
        /// 2 - КнопкаН13_2 (Последняя нажатая клавиша - Н13_2)
        /// 3 - КнопкаН13_12 (Последняя нажатая клавиша - Н13_12)
        /// </summary>
        public static int локКнопкаН13
        {
            get { return _локКнопкаН13; }
            set { _локКнопкаН13 = value; }
        }
        #endregion

    }
}
