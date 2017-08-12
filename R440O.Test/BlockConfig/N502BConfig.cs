using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;

using R440O.R440OForms.N502B;

namespace R440O.Test.BlockConfig
{
    class N502BConfig : BaseBlockConfig
    {
        private static string R440OButtonN502B = "R440OButtonN502B";
        private static string N502BForm = "N502BForm";

        private static string ТумблерЭлектрооборудование = "ТумблерЭлектрооборудование";
        private static string ТумблерВыпрямитель27В = "ТумблерВыпрямитель27В";
        private static string ТумблерОсвещение = "ТумблерОсвещение";
        private static string ТумблерН13_1 = "ТумблерН13_1";
        private static string ТумблерН13_2 = "ТумблерН13_2";
        private static string ТумблерН15 = "ТумблерН15";
        private static string ПереключательСеть = "ПереключательСеть";
        private static string ПереключательФазировка = "ПереключательФазировка";
        private static string КнопкаВклНагрузки = "КнопкаВклНагрузки";


        public override string OpenFormButtonName
        {
            get { return R440OButtonN502B; }
        }

        public override string FormName
        {
            get { return N502BForm; }
        }

        private bool электрооборудованиеВключено = false;
        public void ВключитьЭлектрооборудование()
        {
            if (!электрооборудованиеВключено)
            {
                var buttonTester = new ButtonTester(ТумблерЭлектрооборудование, FormName);
                buttonTester.FireEvent("Click");
                электрооборудованиеВключено = true;
            }
        }

        private bool выпрямитель27ВВключен = false;
        public void ВключитьВыпрямитель27В()
        {
            if (!выпрямитель27ВВключен)
            {
                var buttonTester = new ButtonTester(ТумблерВыпрямитель27В, FormName);
                buttonTester.FireEvent("Click");
                выпрямитель27ВВключен = true;
            }
        }

        private bool тумблерОсвещениеВключен = false;
        public void ВключитьТумблерОсвещение()
        {
            if (!тумблерОсвещениеВключен)
            {
                var buttonTester = new ButtonTester(ТумблерОсвещение, FormName);
                buttonTester.FireEvent("Click");
                тумблерОсвещениеВключен = true;
            }
        }

        private bool Н13_1Включен = false;
        public void ВключитьН13_1()
        {
            if (!Н13_1Включен)
            {
                var buttonTester = new ButtonTester(ТумблерН13_1, FormName);
                buttonTester.FireEvent("Click");
                Н13_1Включен = true;
            }
        }

        private bool Н13_2Включен = false;
        public void ВключитьН13_2()
        {
            if (!Н13_2Включен)
            {
                var buttonTester = new ButtonTester(ТумблерН13_2, FormName);
                buttonTester.FireEvent("Click");
                Н13_2Включен = true;
            }
        }

        private bool Н15Включен = false;
        public void ВключитьН15()
        {
            if (!Н15Включен)
            {
                var buttonTester = new ButtonTester(ТумблерН15, FormName);
                buttonTester.FireEvent("Click");
                Н15Включен = true;
            }
        }

        public void ВключитьВсеТумблеры()
        {
            ВключитьЭлектрооборудование();
            ВключитьВыпрямитель27В();
            ВключитьТумблерОсвещение();
            ВключитьН13_1();
            ВключитьН13_2();
            ВключитьН15();
        }

        private bool сетьВключена = false;
        public void ВключитьСеть()
        {
            if (!сетьВключена)
            {
                var buttonTester = new ButtonTester(ПереключательСеть, FormName);
                buttonTester.FireEvent("Click");
                сетьВключена = true;
            }
        }

        private bool сфазированно = false;
        public void Сфазировать()
        {
            if (!сфазированно)
            {
                var buttonTester1 = new ButtonTester(ПереключательФазировка, FormName);
                buttonTester1.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                if (N502BParameters.Фазировка == 4)
                {
                    buttonTester1.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                    buttonTester1.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                }
                var buttonTester2 = new ButtonTester(КнопкаВклНагрузки, FormName);
                buttonTester2.FireEvent("MouseDown", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                buttonTester2.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                сфазированно = true;
            }
        }
    }
}
