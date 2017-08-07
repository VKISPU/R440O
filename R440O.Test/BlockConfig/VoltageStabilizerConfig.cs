using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;

using R440O.R440OForms.PowerCabel;

namespace R440O.Test.BlockConfig
{
    class VoltageStabilizerConfig : BaseBlockConfig
    {
        private static string R440OButtonVoltageStabilizer = "R440OButtonVoltageStabilizer";
        private static string VoltageStabilizerForm = "VoltageStabilizerForm";

        private static string КабельВход1 = "КабельВход1";
        private static string КабельВход2 = "КабельВход2";

        public override string OpenFormButtonName
        {
            get { return R440OButtonVoltageStabilizer; }
        }

        public override string FormName
        {
            get { return VoltageStabilizerForm; }
        }

        private bool кабель220Подключен = false;
        public void ПодлючитьКабель220()
        {
            if (!кабель220Подключен)
            {
                var buttonTester = new ButtonTester(КабельВход1, FormName);
                buttonTester.FireEvent("Click");
                кабель220Подключен = true;
            }
        }

        private bool кабель380Подключен = false;
        public void ПодлючитьКабель380()
        {
            if (!кабель380Подключен)
            {
                var buttonTester = new ButtonTester(КабельВход2, FormName);
                buttonTester.FireEvent("Click");
                кабель380Подключен = true;
            }
        }

        public void ПодлючитьКабельВСоотвествииСНапряжением()
        {
            if (PowerCabelParameters.Напряжение == 220)
            {
                ПодлючитьКабель220();
            }
            else
            {
                ПодлючитьКабель380();
            }
        }

    }
}
