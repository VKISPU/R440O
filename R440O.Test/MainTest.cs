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
        [Test]
        public void MainTest1()
        {
            ParametersConfig.SetParameters();
            var r440o = new R440OForm();
            r440o.Show();
            var buttonN15Tester = new ButtonTester("R440OButtonN15", "R440OForm");
            buttonN15Tester.FireEvent("Click");
            var button = new ButtonTester("КнопкаСтанцияВкл", "N15Form");
            button.FireEvent("MouseDown", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            button.FireEvent("MouseUp", new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            C300M_1Parameters.ЗначениеПоиска = 0;
            Application.DoEvents();
            Assert.IsTrue(C300M_1Parameters.СигналПойман);
            var formTester = new FormTester("R440OForm");
            formTester.Close();
        }
    }
}
