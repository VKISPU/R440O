//-----------------------------------------------------------------------
// <copyright file="A304Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.A304
{
    using Parameters;
    using System.Windows.Forms;
    using Properties;
    using ThirdParty;

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
            this.InitializeTogglePosition();
            this.InitializeTumblers();
            this.InitializeLamps();
            this.InitializeControl();
        }

        #region Инициализация состояний элементов управления
        /// <summary>
        /// Инициализировать положения тумблеров
        /// </summary>
        private void InitializeTumblers()
        {
            this.A304ТумблерМестноеДистанц_1.BackgroundImage = A304Parameters.A304ТумблерМестноеДистанц_1 == "местное" ? ControlElementImages.tumblerVerticalType3Down : ControlElementImages.tumblerVerticalType3Up;
            this.A304ТумблерМестноеДистанц_2.BackgroundImage = A304Parameters.A304ТумблерМестноеДистанц_2 == "местное" ? ControlElementImages.tumblerVerticalType3Down : ControlElementImages.tumblerVerticalType3Up;
            this.A304Тумблер1К2К.BackgroundImage = A304Parameters.A304Тумблер1К2К == 1 ? ControlElementImages.tumblerHorizontalType1Left : ControlElementImages.tumblerHorizontalType1Right;
        }

        /// <summary>
        /// Инициализировать состояния тумблеров
        /// </summary>
        private void InitializeLamps()
        {
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "местное")
            {
                A304Лампочка1К.BackgroundImage = A304Parameters.A304Комплект1
                    ? ControlElementImages.lampType10OnGreen
                    : null;
            }
            else
            {
                if (isEnablePowerOfМШУ())
                {
                    A304Parameters.A304Комплект1 = N15Parameters.Н15ТумблерА30412 == "1";

                    A304Лампочка1К.BackgroundImage = N15Parameters.Н15ТумблерА30412 == "1"
                        ? ControlElementImages.lampType10OnGreen
                        : null;
                }
            }

            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "местное")
            {
                A304Лампочка2К.BackgroundImage = A304Parameters.A304Комплект2
                    ? ControlElementImages.lampType10OnGreen
                    : null;
            }
            else
            {
                if (isEnablePowerOfМШУ())
                {
                    A304Parameters.A304Комплект2 = N15Parameters.Н15ТумблерА30412 == "2";
                    A304Лампочка2К.BackgroundImage = N15Parameters.Н15ТумблерА30412 == "2"
                        ? ControlElementImages.lampType10OnGreen
                        : null;
                }
            }
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

        /// <summary>
        /// Установка стрелки в нужное положение
        /// </summary>
        private void InitializeControl()
        {
            int isEnableKit;
            if ((A304Parameters.A304Тумблер1К2К == 1 && A304Parameters.A304Комплект1) ||
                (A304Parameters.A304Тумблер1К2К == 2 && A304Parameters.A304Комплект2) && isEnablePowerOfМШУ())
            {
                isEnableKit = 1;
            }
            else
            {
                isEnableKit = 2;
            }

            switch (A304Parameters.A304ЗначенияПереключательКонтроль[A304Parameters.A304ПереключательКонтроль - 1, isEnableKit])
            {
                case "-1":
                    {
                        A304СтрелкаКонтроляНапряжения.BackgroundImage = ControlElementImages.arrowLeft;
                    }
                    break;
                case "0":
                    {
                        A304СтрелкаКонтроляНапряжения.BackgroundImage = ControlElementImages.arrowNormal;
                    }
                    break;
                case "1":
                    {
                        A304СтрелкаКонтроляНапряжения.BackgroundImage = ControlElementImages.arrowRight;
                    }
                    break;
            }
        }
        #endregion

        #region Тумблеры управления типом подачи питания
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
            TurnLamps(1, A304Parameters.A304ТумблерМестноеДистанц_1);
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
            TurnLamps(2, A304Parameters.A304ТумблерМестноеДистанц_2);
        }

        /// <summary>
        /// Перключение между комплектами оборудования
        /// </summary>
        private void A304Тумблер1К2К_Click(object sender, System.EventArgs e)
        {
            if (A304Parameters.A304Тумблер1К2К == 1)
            {
                this.A304Тумблер1К2К.BackgroundImage = ControlElementImages.tumblerHorizontalType1Right;
                A304Parameters.A304Тумблер1К2К = 2;
            }
            else
            {
                this.A304Тумблер1К2К.BackgroundImage = ControlElementImages.tumblerHorizontalType1Left;
                A304Parameters.A304Тумблер1К2К = 1;
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
            this.A304Кнопка1КВкл.Text = Resources.stringВКЛ;
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "местное")
            {
                A304Parameters.A304Комплект1 = true;
                TurnLamps();
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
            this.A304Кнопка2КВкл.Text = Resources.stringВКЛ;
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "местное")
            {
                A304Parameters.A304Комплект2 = true;
                TurnLamps();
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
            this.A304Кнопка1КОткл.Text = Resources.stringОТКЛ;
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "местное")
            {
                A304Parameters.A304Комплект1 = false;
                TurnLamps();
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
            this.A304Кнопка2КОткл.Text = Resources.stringОТКЛ;
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "местное")
            {
                A304Parameters.A304Комплект2 = false;
                TurnLamps();
            }
        }
        #endregion

        #region Контроль за включенным комплектом оборудования(Лампочки)

        /// <summary>
        /// Дистанционное переключение комплектов
        /// </summary>
        public void TurnLampsEvent()
        {
            if (A304Parameters.A304ТумблерМестноеДистанц_1 == "дистанц")
                TurnLamps(1, A304Parameters.A304ТумблерМестноеДистанц_1);
            if (A304Parameters.A304ТумблерМестноеДистанц_2 == "дистанц")
                TurnLamps(2, A304Parameters.A304ТумблерМестноеДистанц_2);
        }

        /// <summary>
        /// Переключает комплекты(лампочки) в соотвествии с нажатыми кнопками, когда способ упрваления питанием - местный
        /// </summary>
        private void TurnLamps()
        {
            A304Лампочка1К.BackgroundImage = A304Parameters.A304Комплект1 ? ControlElementImages.lampType10OnGreen : null;
            A304Лампочка2К.BackgroundImage = A304Parameters.A304Комплект2 ? ControlElementImages.lampType10OnGreen : null;
        }

        /// <summary>
        /// Переключает комплекты(лампочки) при изменении положения тумблеров
        /// Если тип управления питанием - дистанционный, комплекты(лампочки) включаются в соответствии с выбранным на блоке Н-15
        /// </summary>
        /// <param name="numberOfKit">Номер комплекта в котором для которого переключается тумблер управления питанием</param>
        /// <param name="type">Тип на который переключилось питание</param>
        private void TurnLamps(int numberOfKit, string type)
        {
            switch (numberOfKit)
            {
                case 1:
                    {
                        A304Parameters.A304Комплект1 = N15Parameters.Н15ТумблерА30412 == "1";
                        if (type == "местное")
                        {
                            A304Лампочка1К.BackgroundImage = A304Parameters.A304Комплект1
                                ? ControlElementImages.lampType10OnGreen
                                : null;
                        }
                        else A304Лампочка1К.BackgroundImage = N15Parameters.Н15ТумблерА30412 == "1" ? ControlElementImages.lampType10OnGreen : null;
                    }
                    break;
                case 2:
                    {
                        A304Parameters.A304Комплект2 = N15Parameters.Н15ТумблерА30412 == "2";
                        if (type == "местное")
                        {
                            A304Лампочка2К.BackgroundImage = A304Parameters.A304Комплект2
                                ? ControlElementImages.lampType10OnGreen
                                : null;
                        }
                        else
                            A304Лампочка2К.BackgroundImage = N15Parameters.Н15ТумблерА30412 == "2" ? ControlElementImages.lampType10OnGreen : null;
                    }
                    break;
            }
        }
        #endregion

        #region Изменение положения переключателей выбора ствола и контроля
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

            var angle = A304Parameters.A304ПереключательКонтроль*30 - 150;
            A304ПереключательКонтрольButton.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);

           this.InitializeControl();
        }

        /// <summary>
        /// Выбор питающего напряжения для контроля
        /// </summary>
        private void A304ПереключательКонтрольButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && A304Parameters.A304ПереключательКонтроль < 9)
            {
                A304СтрелкаКонтроляНапряжения.BackgroundImage = ControlElementImages.arrowNormal;
            }

            if (e.Button == MouseButtons.Right && A304Parameters.A304ПереключательКонтроль > 1)
            {
                A304СтрелкаКонтроляНапряжения.BackgroundImage = ControlElementImages.arrowNormal;
            }
        }
        #endregion

        private bool isEnablePowerOfМШУ()
        {
            return N15Parameters.Н15ТумблерМШУ == "true";
        }
    }
}