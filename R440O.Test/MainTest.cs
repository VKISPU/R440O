using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Extensions.Forms;

using R440O.R440OForms.R440O;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.N502B;
using R440O.Test.BlockConfig;

namespace R440O.Test.MainTest
{
    [TestFixture]
    class MainTest
    {
        //[Test]
        //public void MainTest1()
        //{
        //    ParametersConfig.SetParameters();
        //    var r440o = new R440OForm();
        //    r440o.Show();
        //    var buttonN15Tester = new ButtonTester("R440OButtonN15", "R440OForm");
        //    buttonN15Tester.FireEvent("Click");
        //    var button = new ButtonTester("КнопкаСтанцияВкл", "N15Form");
        //    button.FireEvent("MouseDown", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
        //    button.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
        //    C300M_1Parameters.ЗначениеПоиска = 0;
        //    Application.DoEvents();
        //    Assert.IsTrue(C300M_1Parameters.СигналПойман);
        //    var formTester = new FormTester("R440OForm");
        //    formTester.Close();
        //}

        [Test]
        public void MainTest2()
        {
            var r440oConfig = new R440OConfig();
            var powerCabelConfig = new PowerCabelConfig();
            var voltageStabilizerConfig = new VoltageStabilizerConfig();
            var n502BConfig = new N502BConfig();

            r440oConfig.ОткрытьФорму();

            powerCabelConfig.ОткрытьФорму();
            powerCabelConfig.ПодключитьКабель();
            powerCabelConfig.ЗакрытьФорму();
            
            voltageStabilizerConfig.ОткрытьФорму();
            voltageStabilizerConfig.ПодлючитьКабельВСоотвествииСНапряжением();
            voltageStabilizerConfig.ЗакрытьФорму();
                                  
            n502BConfig.ОткрытьФорму();
            n502BConfig.ВключитьВсеТумблеры();
            n502BConfig.ВключитьСеть();
            n502BConfig.Сфазировать();
            n502BConfig.ЗакрытьФорму();
            
            Application.DoEvents();
            Assert.IsTrue(N502BParameters.ЛампочкаСфазировано);

            r440oConfig.ЗакрытьФорму();
        }
    }
}
