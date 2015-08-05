using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.Parameters
{
    public class A306Parameters
    {
        ////Лампочки
        private static bool _лампочкаСетьВкл = false;
        public static bool ЛампочкаСетьВкл
        {
            get { return _лампочкаСетьВкл; }
            set
            {
                _лампочкаСетьВкл = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаНО1Вкл = false;
        public static bool ЛампочкаНО1Вкл
        {
            get { return _лампочкаНО1Вкл; }
            set
            {
                _лампочкаНО1Вкл = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаНО2Вкл = false;
        public static bool ЛампочкаНО2Вкл
        {
            get { return _лампочкаНО2Вкл; }
            set
            {
                _лампочкаНО2Вкл = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        ////Тумблеры
        /// <summary>
        /// Положение переключателя  определяющее тип питания блока. true - дистанционное, false - местное
        /// </summary>
        public static bool ТумблерДистанцМестн
        {
            get { return _тумблерДистанцМестн; }
            set
            {
                _тумблерДистанцМестн = value;
                ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }
        private static bool _тумблерДистанцМестн;

        /// <summary>
        /// Положение переключателя  определяющее включен блок или нет. true - вкл, false - выкл
        /// </summary>
        public static bool ТумблерВклВыкл
        {
            get { return _тумблерВклВыкл; }
            set
            {
                _тумблерВклВыкл = value;
                ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }
        private static bool _тумблерВклВыкл;

        public static bool ВходNO_1 = false;
        public static bool ВходNO_2 = false;

        /// <summary>
        /// Содержит информацию о выходах:
        /// Выходы каналов: с 0 элемента по 9
        /// КВ: 10
        /// Выходы НО-1: c 11 по 14
        /// Выходы НО-2: с 15 по 18
        /// Возможные значения: Входы 0, 1, 2, 3, НО-1:4, HO-2:5
        /// </summary>
        public static int[] Выходы = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        private static int _целевойВыход = -1;
        public static int ЦелевойВыход
        {
            get { return _целевойВыход; }
            set
            {
                _целевойВыход = value;

                //если кабель идет от НО1, то его нельзя воткнуть в выходы НО1
                if (АктивныйВход == 4 && _целевойВыход >= 11 && _целевойВыход <= 14) return;

                //если кабель идет от НО2, то его нельзя воткнуть в выходы НО2
                else if (АктивныйВход == 5 && _целевойВыход >= 15 && _целевойВыход <= 18) return;

                //если выбран кабель и этот кабель никуда не подключен
                else if (АктивныйВход != -1 && Array.IndexOf(Выходы, АктивныйВход) == -1)
                {
                    //в массив заносим информацию с каким входом соединять,
                    //но если там уже есть, то надо его сначала вынуть
                    if (Выходы[_целевойВыход] != -1)
                    {
                        Входы[Выходы[_целевойВыход]] = true;
                    }
                    Выходы[_целевойВыход] = АктивныйВход;
                    Входы[АктивныйВход] = false;
                    АктивныйВход = -1;
                    if (RefreshForm != null) RefreshForm();
                }
                else
                //иначе отсоединяем кабель
                {
                    if (Выходы[_целевойВыход] != -1)
                    {
                        Входы[Выходы[_целевойВыход]] = true;
                        Выходы[_целевойВыход] = -1;
                        if (RefreshForm != null) RefreshForm();
                    }
                }
                ResetParameters();
            }
        }

        /// <summary>
        /// с 0 по 3 - входы каналов, 5 - вход НО1, 6 - вход НО2
        /// true - кабель не воткнут, висит на планке
        /// </summary>
        public static bool[] Входы = { true, true, true, true, true, true };

        private static int _активныйВход = -1;
        public static int АктивныйВход
        {
            get { return _активныйВход; }
            set
            {
                if (Array.IndexOf(Выходы, value) == -1 || _активныйВход == 4 || _активныйВход == 5)
                {
                    _активныйВход = value;
                    ResetParameters();
                }
            }
        }

        public delegate void VoidVoidSignature();

        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаСетьВкл = ((!ТумблерДистанцМестн && ТумблерВклВыкл && N502BParameters.ТумблерЭлектрооборудование
                                && N502BParameters.ТумблерВыпрямитель27В) ||
                               (ТумблерДистанцМестн && N15Parameters.ЛампочкаМШУ))
                              && N502BParameters.ЛампочкаСфазировано;

            ЛампочкаНО1Вкл = !Входы[4] && ЛампочкаСетьВкл;
            ЛампочкаНО2Вкл = !Входы[5] && ЛампочкаСетьВкл;

        }
    }
}
