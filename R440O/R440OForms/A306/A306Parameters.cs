using R440O.BaseClasses;
using R440O.InternalBlocks;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A306
{
    public static class A306Parameters
    {
        public static bool Включен
        {
            get
            {
                return (MSHUParameters.Включен && ТумблерДистанцМестн && N15Parameters.Включен)
                       || (MSHUParameters.Включен && !ТумблерДистанцМестн && ТумблерПитание && N15Parameters.Включен);
            }
        }

        #region Выход блока

        public static Signal ВыходнойСигнал1
        {
            get { return IsRightSet(0) ? MSHUParameters.ВыходнойСигнал : null; }
        }

        public static Signal ВыходнойСигнал2
        {
            get { return IsRightSet(1) ? MSHUParameters.ВыходнойСигнал : null; }
        }

        public static Signal ВыходнойСигнал3
        {
            get { return IsRightSet(2) ? MSHUParameters.ВыходнойСигнал : null; }
        }

        public static Signal ВыходнойСигнал4
        {
            get { return IsRightSet(3) ? MSHUParameters.ВыходнойСигнал : null; }
        }
        /// <summary>
        /// Проверка правильно ли подключён кабель к приемнику.
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        private static bool IsRightSet(int output)
        {
            if (MSHUParameters.ВыходнойСигнал != null)
            {
                var rightOutput = MSHUParameters.ВыходнойСигнал.Wave / 500;
                if (Выходы[rightOutput] == output) return true;
                if ((Выходы[11] == output || Выходы[12] == output || Выходы[13] == output || Выходы[14] == output) &&
                    Выходы[rightOutput] == 4) return true;
                if ((Выходы[15] == output || Выходы[16] == output || Выходы[17] == output || Выходы[18] == output) &&
                    Выходы[rightOutput] == 5) return true;
            }
            return false;
        }
        #endregion

        #region Лампочки
        public static bool ЛампочкаСетьВкл
        {
            get { return Включен; }
        }

        public static bool ЛампочкаНО1Вкл
        {
            get { return !КабелиВходы[4] && Включен; }
        }

        public static bool ЛампочкаНО2Вкл
        {
            get { return !КабелиВходы[5] && Включен; }
        }
        #endregion

        #region Тумблеры

        /// <summary>
        /// Положение переключателя  определяющее тип питания блока. true - дистанционное, false - местное
        /// </summary>
        public static bool ТумблерДистанцМестн
        {
            get { return _тумблерДистанцМестн; }
            set
            {
                _тумблерДистанцМестн = value;
                OnParameterChanged();
            }
        }
        private static bool _тумблерДистанцМестн;

        /// <summary>
        /// Положение переключателя  определяющее включен блок или нет. true - вкл, false - выкл
        /// </summary>
        public static bool ТумблерПитание
        {
            get { return _тумблерПитание; }
            set
            {
                _тумблерПитание = value;
                OnParameterChanged();
            }
        }
        private static bool _тумблерПитание;
        #endregion

        #region Коммутация

        private static int _активныйВход = -1;

        public static int АктивныйВход
        {
            get { return _активныйВход; }
            set { _активныйВход = value; }
        }

        /// <summary>
        /// Содержит информацию о выходах:
        /// Выходы каналов: с 0 элемента по 9;
        /// КВ: 10;
        /// Выходы НО-1: c 11 по 14;
        /// Выходы НО-2: с 15 по 18;
        /// Возможные значения: Входы 0, 1, 2, 3, НО-1:4, HO-2:5
        /// </summary>
        public static A306Outputs Выходы = new A306Outputs();

        /// <summary>
        /// с 0 по 3 - входы каналов, 4 - вход НО1, 5 - вход НО2
        /// true - кабель не воткнут, висит на планке
        /// </summary>
        public static A306InputsCables КабелиВходы = new A306InputsCables();

        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            OnParameterChanged();
        }
    }

    public class A306InputsCables
    {
        public static bool[] Inputs = { true, true, true, true, true, true };
        public bool this[int inputNumber]
        {
            get { return Inputs[inputNumber]; }
            set
            {
                Inputs[inputNumber] = value;
            }
        }
    }

    public class A306Outputs
    {
        public static int[] Outputs = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        public int this[int outputNumber]
        {
            get { return Outputs[outputNumber]; }
            set
            {
                if (Outputs[outputNumber] != -1 && value != -1) //что-то есть, и что-то втыкаем
                {
                    A306Parameters.КабелиВходы[Outputs[outputNumber]] = true;
                    Outputs[outputNumber] = value;
                    A306Parameters.КабелиВходы[value] = false;
                    A306Parameters.АктивныйВход = -1;
                }
                else if (Outputs[outputNumber] != -1) //если что-то воткнуто, надо выдернуть
                {
                    A306Parameters.АктивныйВход = Outputs[outputNumber];
                    A306Parameters.КабелиВходы[Outputs[outputNumber]] = true;
                    Outputs[outputNumber] = -1;
                }
                else if (Outputs[outputNumber] == -1 && value != -1) //ничего нет, просто втыкаем
                {
                    Outputs[outputNumber] = value; // value == A306Parameters.АктивныйВход 
                    A306Parameters.КабелиВходы[Outputs[outputNumber]] = false;
                    A306Parameters.АктивныйВход = -1;
                }

                A306Parameters.ResetParameters();
            }
        }
    }
}
