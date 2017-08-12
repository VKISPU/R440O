using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;

namespace R440O.Test.BlockConfig
{
    class PowerCabelConfig : BaseBlockConfig
    {
        private static string R440OButtonPowerCabel = "R440OButtonPowerCabel";
        private static string PowerCabelForm = "PowerCabelForm";

        private static string КабельСеть = "КабельСеть";

        public override string OpenFormButtonName
        {
            get { return R440OButtonPowerCabel; }
        }

        public override string FormName
        {
            get { return PowerCabelForm; }
        }

        private bool кабельПодключен = false;
        public void ПодключитьКабель()
        {
            if (!кабельПодключен)
            {
                var buttonTester = new ButtonTester(КабельСеть, FormName);
                buttonTester.FireEvent("Click");
                кабельПодключен = true;
            }
        }
    }
}
