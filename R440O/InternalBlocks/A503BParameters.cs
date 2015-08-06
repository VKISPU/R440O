using System;
using R440O.BaseClasses;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.N15;

namespace R440O.InternalBlocks
{
    public static class A503BParameters
    {
        private const int WaveShift = 1500;

        public static bool Включен
        {
            get { return N15Parameters.ЛампочкаА503Б; }
        }

        public static SignalArgs ВыходнойСигнал
        {
            get
            {
                if (A205M_1Parameters.ЛампочкаНормРаб && Включен)
                {
                    var signal = new SignalArgs();
                    switch (A205M_1Parameters.ПереключательВидРаботы)
                    {
                        case 1:
                        {
                            signal.Modulation = "ЧТ";
                            signal.Speed = 200;
                        }
                            break;
                        case 2:
                        {
                            signal.Modulation = "ЧТ";
                            signal.Speed = 20;
                        }
                            break;
                        case 3:
                        {
                            signal.Modulation = "ОФТ";
                            signal.Speed = 5.2;
                        }
                            break;
                        case 4:
                        {
                            signal.Modulation = "ОФТ";
                            signal.Speed = 48;
                        }
                            break;
                    }
                    signal.Wave = A205M_1Parameters.ПереключательВолнаX10000*10000 +
                                  A205M_1Parameters.ПереключательВолнаX1000*1000 +
                                  A205M_1Parameters.ПереключательВолнаX100*100 +
                                  A205M_1Parameters.ПереключательВолнаX10*10 +
                                  A205M_1Parameters.ПереключательВолнаX1 - WaveShift;
                    signal.Level = (50*(N15Parameters.РегуляторУровень + 120)/240);
                    return signal;

                }
                return null;
            }
        }
    }
}
