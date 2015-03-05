using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class N13_1Parameters
    {
        #region Лампочки
        public static bool N13_1ЛампочкаПерегрузкаИстКоллектора = false;
        public static bool N13_1ЛампочкаПерегрузкаИст3С = false;
        public static bool N13_1ЛампочкаАнодВключен = false;
        public static bool N13_1ЛампочкаПовторноеВкл = false;
        public static bool N13_1Лампочка115В = false;
        public static bool N13_1Лампочка27В = false;
        public static bool N13_1Лампочка3х200В1 = false;
        public static bool N13_1Лампочка3х200В2 = false;
        public static bool N13_1Лампочка3х200В3 = false;
        #endregion

        #region Индикаторы
        public static int N13_1ИндикаторТокЗамедлСист;
        public static int N13_1ИндикаторТокКоллектора;
        #endregion
    }
}
