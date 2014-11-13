//-----------------------------------------------------------------------
// <copyright file="A304Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;
using R440O.ThirdParty;

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
            InitializeTogglePosition();
        }

        #region Тумблеры
        /// <summary>
        /// Перключение типа подачи питания для первого комплекта оборудования
        /// </summary>
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
            TurnLights(1, A304Parameters.A304ТумблерМестноеДистанц_1);
        }

        /// <summary>
        /// Перключение типа подачи питания для второго комплекта оборудования
        /// </summary>
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
            TurnLights(2, A304Parameters.A304ТумблерМестноеДистанц_2);
        }

        /// <summary>
        /// Перключение между комплектами оборудования
        /// </summary>
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

        #region Кнопки включения питания
        //// Включение местного питания 1 комплекта
        private void A304Кнопка1КВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КВкл.BackgroundImage = null;
            this.A304Кнопка1КВкл.Text = "";
        }

        private void A304Кнопка1КВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КВкл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка1КВкл.Text = "ВКЛ";
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "местное")
            {
                A304Parameters.A304Комплект1 = "true";
                TurnLights();
            }
        }

        //// Включение местного питания 2 комплекта
        private void A304Кнопка2КВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КВкл.BackgroundImage = null;
            this.A304Кнопка2КВкл.Text = "";

        }
        private void A304Кнопка2КВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КВкл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка2КВкл.Text = "ВКЛ";
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "местное")
            {
                A304Parameters.A304Комплект2 = "true";
                TurnLights();
            }
        }

        //// Выключение местного питания 1 комплекта
        private void A304Кнопка1КОткл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КОткл.BackgroundImage = null;
            this.A304Кнопка1КОткл.Text = "";
        }

        private void A304Кнопка1КОткл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка1КОткл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка1КОткл.Text = "ОТКЛ";
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "местное")
            {
                A304Parameters.A304Комплект1 = "false";
                TurnLights();
            }
        }

        //// Выключение местного питания 2 комплекта
        private void A304Кнопка2КОткл_MouseDown(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КОткл.BackgroundImage = null;
            this.A304Кнопка2КОткл.Text = "";
        }
        
        private void A304Кнопка2КОткл_MouseUp(object sender, MouseEventArgs e)
        {
            this.A304Кнопка2КОткл.BackgroundImage = ControlElementImages.ButtonGreyUp;
            this.A304Кнопка2КОткл.Text = "ОТКЛ";
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "местное")
            {
                A304Parameters.A304Комплект2 = "false";
                TurnLights();
            }
        }
        #endregion

        #region Контроль за включенным комплектом оборудования
        /// <summary>
        /// Переключает лампочки в соотвествии с нажатыми кнопками, когда способ упрваления питанием - местный
        /// </summary>
        private void TurnLights()
        {
            A304Лампочка1К.BackgroundImage = A304Parameters.A304Комплект1 == "true" ? ControlElementImages.lampType10OnGreen : null;
            A304Лампочка2К.BackgroundImage = A304Parameters.A304Комплект2 == "true" ? ControlElementImages.lampType10OnGreen : null;
        }

        /// <summary>
        /// Переключает лампочки при изменении положения тумблеров
        /// Если тип управления питанием - дистанционный, лампочки включаются в соответствии с комплектом выбранным на блоке Н-15
        /// </summary>
        /// <param name="numberOfKit">Номер комплекта в котором для которого переключается тумблер управления питанием</param>
        /// <param name="type">Тип на который переключилось питание</param>
        private void TurnLights(int numberOfKit, string type)
        {
            var N15A304 = "1"; //HARDCODE DETECTED
            switch (numberOfKit)
            {
                case 1:
                    {
                        A304Parameters.A304Комплект1 = N15A304 == "1" ? "true" : "false";
                        if (type == "местное")
                        {
                            A304Лампочка1К.BackgroundImage = A304Parameters.A304Комплект1 == "true"
                                ? ControlElementImages.lampType10OnGreen
                                : null;
                        }
                        else A304Лампочка1К.BackgroundImage = N15A304 == "1" ? ControlElementImages.lampType10OnGreen : null;
                    }
                    break;
                case 2:
                    {
                        A304Parameters.A304Комплект2 = N15A304 == "2" ? "true" : "false";
                        if (type == "местное")
                        {
                            A304Лампочка2К.BackgroundImage = A304Parameters.A304Комплект2 == "true"
                                ? ControlElementImages.lampType10OnGreen
                                : null;
                        }
                        else
                            A304Лампочка2К.BackgroundImage = N15A304 == "2" ? ControlElementImages.lampType10OnGreen : null;
                    }
                    break;
            }
        }
        #endregion

        #region Изменение положения переключателей
        /// <summary>
        /// Выбор ствола
        /// </summary>
        private void A304ПереключательВыборСтвола_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A304Parameters.A304ПереключательВыборСтвола += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A304Parameters.A304ПереключательВыборСтвола -= 1;
            }

            var angle = A304Parameters.A304ПереключательВыборСтвола * 26 - 145;
            A304ПереключательВыборСтвола.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        /// <summary>
        /// Выбор питающего напряжения для контроля
        /// </summary>
        private void A304ПереключательКонтрольButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A304Parameters.A304ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A304Parameters.A304ПереключательКонтроль -= 1;
            }

            var angle = A304Parameters.A304ПереключательКонтроль * 30 - 150;
            A304ПереключательКонтрольButton.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        /// <summary>
        /// Задание начальных положений переключателей
        /// </summary>
        private void InitializeTogglePosition()
        {
            var angle = A304Parameters.A304ПереключательВыборСтвола * 26 - 145;
            A304ПереключательВыборСтвола.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);

            angle = A304Parameters.A304ПереключательКонтроль * 30 - 150;
            A304ПереключательКонтрольButton.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        } 

        #endregion
        
    }
}