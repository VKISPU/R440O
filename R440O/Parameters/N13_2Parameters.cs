using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class N13_2Parameters
    {
        #region Лампочки
        public static bool N13_2ЛампочкаПерегрузкаИстКоллектора = false;
        public static bool N13_2ЛампочкаПерегрузкаИст3С = false;
        public static bool N13_2ЛампочкаАнодВключен = false;
        public static bool N13_2ЛампочкаПовторноеВкл = false;
        public static bool N13_2Лампочка115В = false;
        public static bool N13_2Лампочка27В = false;
        public static bool N13_2Лампочка3х200В1 = false;
        public static bool N13_2Лампочка3х200В2 = false;
        public static bool N13_2Лампочка3х200В3 = false;
        #endregion

        #region Индикаторы
        public static int N13_2ИндикаторТокЗамедлСист;
        public static int N13_2ИндикаторТокКоллектора;
        #endregion
    }
}
