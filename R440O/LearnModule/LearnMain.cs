using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.R440O;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.LearnModule
{
    static class LearnMain
    {
        public static bool isMainWindow = true;
        static IntentionEnum intent = IntentionEnum.openN502BtoPower;
        static GlobalIntentEnum globalIntent = GlobalIntentEnum.power;
        static String helpText { get; set; }
        static List<HighLightModule> modules = new List<HighLightModule>();
        static R440OForm mainForm; 
        static public Form form { get; set; }
        static Button curButton { get; set; }

        public static void setIntent(IntentionEnum intention)
        {
            
            intent = intention;
            Action();
        }

        public static IntentionEnum getIntent()
        {    
            return intent;
        }


        public static void setMainForm(R440OForm main_Form)
        {
            mainForm = main_Form;
        }

        public static void StartHighLight()
        {
            foreach (HighLightModule module in modules)
                module.HighLighting();
        }

        public static void StopHighLight()
        {
            foreach(HighLightModule module in modules)
            module.StopHighLight();
        }

        private static void Output(bool isHighLight)
        {
            if (isHighLight)
            {
                StartHighLight();
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
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }

                    helpText = "Выберите блок питания (N502B)";
                    curButton = mainForm.R440OButtonN502B;
                    HighLightModule moduleN502B = new HighLightModule(curButton);
                    modules.Add(moduleN502B);
                    Output(true);
                    break;

                case IntentionEnum.openPowerCabeltoPower:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Выберите блок кабеля";
                    curButton = mainForm.R440OButtonPowerCabel;
                    HighLightModule moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;

                case IntentionEnum.openN15AB:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Выберите блок Н15АБ (H15)";
                    curButton = mainForm.R440OButtonN15;
                    moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;

                case IntentionEnum.openBMB:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Выберите блок БМБ";
                    curButton = mainForm.R440OButtonBMB;
                    moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;

                case IntentionEnum.openC1_67:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Выберите блок C1-67";
                    curButton = mainForm.R440OButtonC1_67;
                    moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;

                case IntentionEnum.openYA2M_66:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Выберите блок Я2М-66";
                    curButton = mainForm.R440OButtonWattmeter;
                    moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;


                case IntentionEnum.N502Power:
                    if (modules != null)
                    {
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();

                        }
                        modules.Clear();
                    }
            

                    helpText = "Включите выделенные тумблеры (Вверх включено, вниз выключено)";

                    if ((N502BForm)form != null)
                    {
                        curButton = ((N502BForm)form).ТумблерН13_2;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);

                        curButton = ((N502BForm)form).ТумблерН13_1;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);


                        curButton = ((N502BForm)form).ТумблерН15;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);

                        curButton = ((N502BForm)form).ТумблерВыпрямитель27В;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);

                        curButton = ((N502BForm)form).ТумблерЭлектрооборудование;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);

                        curButton = ((N502BForm)form).ПереключательКонтрольНапряжения;
                        moduleHs = new HighLightModule(curButton);
                        modules.Add(moduleHs);
                    }
                    Output(true);
                    break;

              

                case IntentionEnum.PowerCabelConnect:
                    if (modules != null)
                        foreach (HighLightModule module in modules.ToArray())
                        {
                            module.StopHighLight();
                            modules.Clear();
                        }
                    helpText = "Включите кабель питания (по центру)";
                    moduleHs = new HighLightModule(curButton);
                    modules.Add(moduleHs);
                    Output(true);
                    break;

                default: break;

            }
        }

        public static async Task Run(CancellationToken ct)
        { 
           
            try
            {
                while (true)
                {
                    // 2 раза по 0.2 секунды
                    await AsyncCheck(TimeSpan.FromSeconds(1), ct);             
                    ct.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException ex)
            {
                throw;
            }
        }

        static async Task AsyncCheck(TimeSpan on, CancellationToken ct)
        {
            await Task.Delay(on, ct);
            CheckParameters();
            
        }

        static void CheckParameters()
        {
            if (globalIntent==GlobalIntentEnum.power)
            {
                if ((!N502BCheck(true)&&(intent!=IntentionEnum.openN502BtoPower)))
                {
                    if (isMainWindow)
                    {
                        setIntent(IntentionEnum.openN502BtoPower);
                    }
                }
                return;
               
            }
            if (globalIntent == GlobalIntentEnum.powerOff)
            {
                if (!N502BCheck(false))
                {
                    setIntent(IntentionEnum.N502PowerOff);
                }
                return;
            }
               
        }

        static bool N502BCheck(bool power)
        {
            if (!N502BParameters.ПереключательСеть == power) return false;
            if (!N502BParameters.ТумблерЭлектрооборудование == power) return false;
            if (!(N502BParameters.ПереключательФазировка != N502BParameters.Фазировка) == power) return false;
            if (!N502BParameters.Нагрузка == power) return false;
            if (!N502BParameters.ТумблерН13_1 == power) return false;
            if (!N502BParameters.ТумблерН13_2 == power) return false;
            if (!N502BParameters.ТумблерН15 == power) return false;
            return true;
        }
    }

       
}



