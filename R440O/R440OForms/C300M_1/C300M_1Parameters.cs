using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.R440OForms.C300M_1
{
    class C300M_1Parameters
    {
        #region Кнопки ВИД РАБОТЫ
        /// <summary>
        /// Названия кнопок:
        /// 0 - 0.025,
        /// 1 - 0.05,
        /// 2 - 0.1,
        /// 3 - 1.2,
        /// 4 - 2.4,
        /// 5 - 4.8,
        /// 6 - 48,
        /// 7 - 96/144,
        /// 8 - 240,
        /// 9 - 480.
        /// </summary>
        private static bool[] _кнопкиВидРаботы = { false, false, false, false, false, false, false, false, false, false};
        public static bool[] КнопкиВидРаботы { get { return _кнопкиВидРаботы; } set { _кнопкиВидРаботы = value; } }

        /// <summary>
        /// Кнопка Сброс, отжимает все кнопки Вида Работы
        /// </summary>
        private static bool _кнопкаВидРаботыСброс;
        public static bool КнопкаВидРаботыСброс
        {
            get { return _кнопкаВидРаботыСброс; }
            set { _кнопкаВидРаботыСброс = value; }
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        /// <summary>
        /// Названия кнопок:
        /// 0 - Уровень сигнала,
        /// 1 - Уровень шума,
        /// 2 - '0' АПЧ,
        /// 3 - Поиск,
        /// 4 - ГЕТ-2,
        /// 5 - +5,
        /// 6 - +6.3,
        /// 7 - +27,
        /// 8 - -5,
        /// 9 - -12.6.
        /// </summary>
        public static bool[] КнопкиКонтрольРежима { get { return _кнопкиКонтрольРежима; } set { _кнопкиКонтрольРежима = value; } }
        private static bool[] _кнопкиКонтрольРежима = { false, false, false, false, false, false, false, false, false, false };

        /// <summary>
        /// Кнопка -27, отжимает все кнопки Контроля Режима
        /// </summary>
        public static bool КнопкаКонтрольРежимаМинус27
        {
            get { return _кнопкаКонтрольРежимаМинус27; }
            set { _кнопкаКонтрольРежимаМинус27 = value; }
        }
        private static bool _кнопкаКонтрольРежимаМинус27;
        #endregion

        #region Кнопки ПИТАНИЕ
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПитаниеВкл 
        { 
            get { return _кнопкаПитаниеВкл; }
            set { _кнопкаПитаниеВкл = value; }
        }
        private static bool _кнопкаПитаниеВкл;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПитаниеВыкл 
        {
            get { return _кнопкаПитаниеВыкл; }
            set { _кнопкаПитаниеВыкл = value; }
        }
        private static bool _кнопкаПитаниеВыкл;
        #endregion

        #region Кнопки Поиск и Индикация волны
        public static bool КнопкаПоиск
        {
            get { return _кнопкаПоиск; }
            set { _кнопкаПоиск = value; }
        }
        private static bool _кнопкаПоиск;

        public static bool КнопкаИндикацияВолны
        {
            get { return _кнопкаИндикацияВолны; }
            set { _кнопкаИндикацияВолны = value; }
        }
        private static bool _кнопкаИндикацияВолны;
        #endregion

        #region Переключатели ВОЛНА
        /// <summary>
        /// 0 - 4
        /// </summary>
        public static int ПереключательВолна1000
        {
            get
            {
                return _переключательВолна1000;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1000 = value;
                }
            }
        }
        private static int _переключательВолна1000 = 0;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна100
        {
            get
            {
                return _переключательВолна100;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна100 = value;
                }
            }
        }
        private static int _переключательВолна100 = 0;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна10
        {
            get
            {
                return _переключательВолна10;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна10 = value;
                }
            }
        }
        private static int _переключательВолна10 = 0;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна1
        {
            get
            {
                return _переключательВолна1;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1 = value;
                }
            }
        }
        private static int _переключательВолна1 = 0;
        #endregion

        #region Тумблеры
        /// <summary>
        /// Возможные состояния: true - Дистанционное; false - Местное;
        /// </summary>
        public static bool ТумблерУправление { get { return _тумблерУправление; } set { _тумблерУправление = value; } }
        private static bool _тумблерУправление = false;


        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВведение { get { return _тумблерВведение; } set { _тумблерВведение = value; } }
        private static bool _тумблерВведение = false;

        /// <summary>
        /// Возможные состояния: true - Вкл, false - Откл
        /// </summary>
        public static bool ТумблерБлокировка { get { return _тумблерБлокировка; } set { _тумблерБлокировка = value; } }
        private static bool _тумблерБлокировка = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое, false - Ручное
        /// </summary>
        public static bool ТумблерВидВключения { get { return _тумблерВидВключения; } set { _тумблерВидВключения = value; } }
        private static bool _тумблерВидВключения = false;

        /// <summary>
        /// Возможные состояния: true - С анализом симметрии, false - Откл
        /// </summary>
        public static bool ТумблерАнализСимметрии { get { return _тумблерАнализСимметрии; } set { _тумблерАнализСимметрии = value; } }
        private static bool _тумблерАнализСимметрии = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое слежение частоты, false - Откл
        /// </summary>
        public static bool ТумблерАСЧ { get { return _тумблерАСЧ; } set { _тумблерАСЧ = value; } }
        private static bool _тумблерАСЧ = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическая регулировка уровня, false - Ручная регулировка уровня
        /// </summary>
        public static bool ТумблерРегулировкаУровня { get { return _тумблерРегулировкаУровня; } set { _тумблерРегулировкаУровня = value; } }
        private static bool _тумблерРегулировкаУровня = false;

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВидМодуляции { get { return _тумблерВидМодуляции; } set { _тумблерВидМодуляции = value; } }
        private static bool _тумблерВидМодуляции = false;

        /// <summary>
        /// Возможные состояния: true - +-60, false - +-300
        /// </summary>
        public static bool ТумблерПределы { get { return _тумблерПределы; } set { _тумблерПределы = value; } }
        private static bool _тумблерПределы = false;
        #endregion

        #region Лампочки
        public static bool ЛампочкаСигнал = false;
        public static bool ЛампочкаПитание = false;
        public static bool ЛампочкаПоиск = false;
        #endregion

    }
}
