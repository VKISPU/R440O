using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class WattmeterParameters
    {
        /// <summary>
        /// 1 - 6
        /// </summary>
        public static int ВаттметрПереключательРежимРаботы
        {
            get { return _ВаттметрПереключательРежимРаботы; }
            set { if (value >= 1 && value <= 6) _ВаттметрПереключательРежимРаботы = value; }
        }
        public static int _ВаттметрПереключательРежимРаботы = 1;

        /// <summary>
        /// -120 - 120
        /// </summary>
        public static int ВаттметрПереключательГрубо
        {
            get { return _ВаттметрПереключательГрубо; }
            set { if (value <= 120 && value >= -120) _ВаттметрПереключательГрубо = value; }
        }
        public static int _ВаттметрПереключательГрубо = -120;

        /// <summary>
        /// -120 - 120
        /// </summary>
        public static int ВаттметрПереключательТочно
        {
            get { return _ВаттметрПереключательТочно; }
            set { if (value <= 120 && value >= -120) _ВаттметрПереключательТочно = value; }
        }
        public static int _ВаттметрПереключательТочно = -120;

        /// <summary>
        /// -120 - 120
        /// </summary>
        public static int ВаттметрПереключательКоррекция
        {
            get { return _ВаттметрПереключательКоррекция; }
            set { if (value <= 120 && value >= -120) _ВаттметрПереключательКоррекция = value; }
        }
        public static int _ВаттметрПереключательКоррекция = -120;
    }
}
