using System;
using R440O.R440OForms.VoltageStabilizer;

namespace R440O.R440OForms.PowerCabel
{

    using N502B;

    public static class PowerCabelParameters
    {
        static PowerCabelParameters()
        {
            var generator = new Random();
            var zeroToOne = generator.NextDouble();
            Напряжение = zeroToOne > 0.5F ? 380 : 220;
        }

        private static bool _тумблерОсвещение;

        public static bool ТумблерОсвещение
        {
            get { return _тумблерОсвещение; }
            set
            {
                _тумблерОсвещение = value;
                OnParameterChanged();
            }
        }

        private static bool _кабельСеть;

        public static bool КабельСеть
        {
            get { return _кабельСеть; }
            set
            {
                _кабельСеть = value;
                OnParameterChanged();

                if (N502BParameters.ПереключательСеть) СтанцияСгорела();

                N502BParameters.Нагрузка = false;

                N502BParameters.ResetParameters();
                VoltageStabilizerParameters.ResetParameters();
            }
        }

        public static int Напряжение;

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

        /// <summary>
        /// Вызывается, если пользователь совершил неправильные действия по обесточиванию станции.
        /// </summary>
        public static event ParameterChangedHandler СтанцияСгорела;
    }
}
