using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;

using R440O.R440OForms.R440O;

namespace R440O.Test.BlockConfig
{
    class R440OConfig : BaseBlockConfig
    {
        private static string R440OForm = "R440OForm";

        private R440OForm r440o = null;

        public override string OpenFormButtonName
        {
            get { return string.Empty; }
        }

        public override string FormName
        {
            get { return R440OForm; }
        }

        public virtual void ОткрытьФорму()
        {
            if (!формаОткрыта)
            {
                r440o = new R440OForm();
                r440o.Show();
            }
        }

        public virtual void ЗакрытьФорму()
        {
            if (формаОткрыта)
            {
                r440o.Close();
                формаОткрыта = false;
            }
        }
    }
}
