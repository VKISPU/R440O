using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;

namespace R440O.Test.BlockConfig
{
    abstract class BaseBlockConfig
    {
        public abstract string OpenFormButtonName
        {
            get;
        }

        public abstract string FormName
        {
            get;
        }

        protected bool формаОткрыта = false;
        public virtual void ОткрытьФорму()
        {
            if (!формаОткрыта)
            {
                var buttonTester = new ButtonTester(OpenFormButtonName, BaseConstants.R440OForm);
                buttonTester.FireEvent("Click");
                формаОткрыта = true;
            }
        }

        public virtual void ЗакрытьФорму()
        {
            if (формаОткрыта)
            {
                var formTester = new FormTester(FormName);
                formTester.Close();
                формаОткрыта = false;
            }
        }
    }
}
