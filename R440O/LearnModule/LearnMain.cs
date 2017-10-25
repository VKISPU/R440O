using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.R440O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.LearnModule
{
    static class LearnMain
    {
        static IntentionEnum intent = IntentionEnum.openN502BtoPower;
        static String helpText { get; set; }
        static HighLightModule module { get; set; }
        static R440OForm mainForm; 
        static public Form form { get; set; }
        static Button curButton { get; set; }

        public static void setIntent(IntentionEnum intention)
        {
            intent = intention;
        }

        public static IntentionEnum getIntent()
        {
            return intent;
        }

        public static void setMainForm(R440OForm main_Form)
        {
            mainForm = main_Form;
        }
     


        public static void StopHighLight()
        {
            module.StopHighLight();
        }

        private static void Output(bool isHighLight)
        {
            if (isHighLight)
            {
                module = new HighLightModule(curButton);
                module.HighLighting();
            }
            mainForm.HelpTextbox.Text = helpText;
        }

        public static void End()
        {

        }

        public static void Action()
        {
            switch (intent)
            {
                case IntentionEnum.openN502BtoPower:
                    if (module!=null)
                        module.StopHighLight();
                    helpText = "Выберите блок питания (N502B)";
                    curButton = mainForm.R440OButtonN502B;
                    module = new HighLightModule(curButton);
                    Output(true);
                    break;


                case IntentionEnum.N502Power:
                    if (module != null)
                        module.StopHighLight();
                    helpText = "Включите выделенные тумблеры (Вверх включено, вниз выключено)";

                    curButton = ((N502BForm)form).ТумблерН13_2;
                    module = new HighLightModule(curButton);
                    module.HighLighting();

                    curButton = ((N502BForm)form).ТумблерН13_1;
                    module = new HighLightModule(curButton);
                    module.HighLighting();

                    curButton = ((N502BForm)form).ТумблерН15;
                    module = new HighLightModule(curButton);
                    module.HighLighting();

                    curButton = ((N502BForm)form).ТумблерВыпрямитель27В;
                    module = new HighLightModule(curButton);
                    module.HighLighting();

                    Output(false);
                    break;

                case IntentionEnum.openPowerCabeltoPower:
                    if (module != null)
                        module.StopHighLight();
                    helpText = "Выберите блок кабеля";
                    curButton = mainForm.R440OButtonPowerCabel;
                    module = new HighLightModule(curButton);
                    Output(true);
                    break;

                case IntentionEnum.PowerCabelConnect:
                    if (module != null)
                        module.StopHighLight();
                    helpText = "Включите кабель питания (по центру)";
                    curButton = ((PowerCabelForm)form).КабельСеть;
                    module = new HighLightModule(curButton);
                    Output(true);
                    break;

                default: break;

            }
        }
    }

}

