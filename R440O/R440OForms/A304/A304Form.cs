//-----------------------------------------------------------------------
// <copyright file="A304Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.A304
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока A304
    /// </summary>
    public partial class A304Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A304Form"/>.
        /// </summary>
        public A304Form()
        {
            this.InitializeComponent();
            A304Parameters.A304ТумблерМестноеДистанц_1 = "местное";
            A304Parameters.A304ТумблерМестноеДистанц_2 = "местное";
            A304Parameters.A304Тумблер1К2К = "1K";
        }

        #region Тумблеры
        private void A304ТумблерМестноеДистанц_1_Click(object sender, System.EventArgs e)
        {
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "дистанц")
            {
                this.A304ТумблерМестноеДистанц_1.BackgroundImage = ControlElementImages.tumblerVerticalType3Down;
                A304Parameters.A304ТумблерМестноеДистанц_1 = "местное";
            }
            else
            {
                this.A304ТумблерМестноеДистанц_1.BackgroundImage = ControlElementImages.tumblerVerticalType3Up;
                A304Parameters.A304ТумблерМестноеДистанц_1 = "дистанц";
            }
        }

        private void A304ТумблерМестноеДистанц_2_Click(object sender, System.EventArgs e)
        {
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "дистанц")
            {
                this.A304ТумблерМестноеДистанц_2.BackgroundImage = ControlElementImages.tumblerVerticalType3Down;
                A304Parameters.A304ТумблерМестноеДистанц_2 = "местное";
            }
            else
            {
                this.A304ТумблерМестноеДистанц_2.BackgroundImage = ControlElementImages.tumblerVerticalType3Up;
                A304Parameters.A304ТумблерМестноеДистанц_2 = "дистанц";
            }
        }

        private void A304Тумблер1К2К_Click(object sender, System.EventArgs e)
        {
            if (A304Parameters.A304Тумблер1К2К == "1K")
            {
                this.A304Тумблер1К2К.BackgroundImage = ControlElementImages.tumblerHorizontalType1Right;
                A304Parameters.A304Тумблер1К2К = "2K";
            }
            else
            {
                this.A304Тумблер1К2К.BackgroundImage = ControlElementImages.tumblerHorizontalType1Left;
                A304Parameters.A304Тумблер1К2К = "1K";
            }
        }
        #endregion

        #region Кнопки
        private void A304Кнопка2КОткл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КОткл.BackgroundImage = null;
            this.A304Кнопка2КОткл.Text = "";
        }

        private void A304Кнопка2КОткл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КОткл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка2КОткл.Text = "ОТКЛ";

        }

        private void A304Кнопка2КВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КВкл.BackgroundImage = null;
            this.A304Кнопка2КВкл.Text = "";

        }
        private void A304Кнопка2КВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КВкл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка2КВкл.Text = "ВКЛ";
        }

        private void A304Кнопка1КВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КВкл.BackgroundImage = null;
            this.A304Кнопка1КВкл.Text = "";
        }

        private void A304Кнопка1КВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КВкл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка1КВкл.Text = "ВКЛ";
        }

        private void A304Кнопка1КОткл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КОткл.BackgroundImage = null;
            this.A304Кнопка1КОткл.Text = "";
        }

        private void A304Кнопка1КОткл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КОткл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка1КОткл.Text = "ОТКЛ";
        }
        #endregion







    }
}