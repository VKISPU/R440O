﻿using R440O.R440OForms.N502B;

namespace R440O.R440OForms.PowerCabel
{
    public class PowerCabelParameters
    {
        public static bool ТумблерОсвещение;

        private static bool _кабельСеть;
        public static bool КабельСеть {
            get
            {
                return _кабельСеть;
            }
            set
            {
                _кабельСеть = value;
                N502BParameters.Нагрузка = false;
            }
        }
    }
}
