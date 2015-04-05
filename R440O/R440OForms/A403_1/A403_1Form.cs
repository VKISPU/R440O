//-----------------------------------------------------------------------
// <copyright file="A403_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Reflection;

namespace R440O.R440OForms.A403_1
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока А403-1
    /// </summary>
    public partial class A403_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A403_1Form"/>.
        /// </summary>
        public A403_1Form()
        {
            InitializeComponent();
            InitializeTumblersPosition();
            InitializeTogglesPosition();
            InitializeButtonsPosition();
        }

        #region Тумблеры
        private void ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерСеть = !A403_1Parameters.ТумблерСеть;
            ТумблерСеть.BackgroundImage = A403_1Parameters.ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }

        private void ТумблерКомплект_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерКомплект = !A403_1Parameters.ТумблерКомплект;
            ТумблерКомплект.BackgroundImage = A403_1Parameters.ТумблерКомплект
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;
        }

        private void ТумблерГотов_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерГотов = !A403_1Parameters.ТумблерГотов;
            ТумблерГотов.BackgroundImage = A403_1Parameters.ТумблерГотов
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void ТумблерГруппа_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерГруппа = !A403_1Parameters.ТумблерГруппа;
            A403_1ТумблерГруппа.BackgroundImage = A403_1Parameters.ТумблерГруппа
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void ТумблерАвтКоррекция_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерАвтКоррекция = !A403_1Parameters.ТумблерАвтКоррекция;
            ТумблерАвтКоррекция.BackgroundImage = A403_1Parameters.ТумблерАвтКоррекция
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }
        #endregion

        #region Кнопки

        #region Кнопки набора значений
        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки набора значений
        /// </summary>
        private void КнопкаНабора_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = null;
            button.Text = string.Empty;
        }

        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки набора значений
        /// </summary>
        private void КнопкаНабора_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            //Названия всех кнопок отличаются лишь на один 6 символ (Исключение КнопкаМинус)
            char number = button.Name[6];
            button.BackgroundImage = ControlElementImages.buttonSquareWhite;
            //Восстановление текста над кнопкой после отжатия (КнопкаМинус, как отдельный случай)
            button.Text = (number == 'М')
                        ? "-"
                        : Convert.ToString(number);

            //Отображение на дисплее
            bool minus = false;
            if (A403_1Parameters.Значение != "") 
                minus = A403_1Parameters.Значение[0] == '-';
            string displayString = (minus)
                ? A403_1Parameters.Значение.Remove(0, 1)
                : A403_1Parameters.Значение;

            //if (displayString.Length >= 6 && button.Text != "-") displayString = displayString.Remove(0, 1);
            if (displayString.Length >= 6 && button.Text != "-") return;

            if (button.Text == "-")
            {
                if (minus)
                {
                    A403M_1Дисплей.Text = FormatString(displayString);
                    A403_1Parameters.Значение = displayString;
                }
                else
                {
                    A403M_1Дисплей.Text = "*  " + FormatString(displayString);
                    A403_1Parameters.Значение = "-" + displayString;
                }
            }
            else
            {
                displayString += number;
                if (minus)
                {
                    A403M_1Дисплей.Text = "*  " + FormatString(displayString);
                    A403_1Parameters.Значение = "-" + displayString;
                }
                else
                {
                    A403M_1Дисплей.Text = FormatString(displayString);
                    A403_1Parameters.Значение = displayString;
                }
            }
        }
        #endregion

        #region Кнопки выбора параметров
        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки параметров
        /// </summary>
        private void КнопкаПараметры_Click(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            //Названия всех кнопок отличаются лишь на один 15 символ
            int number = (int)Char.GetNumericValue(button.Name[15]);

            //Обнуляем все параметры и выставляем true у той кнопки которую нажали
            for (int i = 0; i < A403_1Parameters.КнопкиПараметры.Length; i++)
                A403_1Parameters.КнопкиПараметры[i] = false;
            A403_1Parameters.КнопкиПараметры[number] = true;

            //Идём по всем кнопкам параметров, чтобы выполнить анимацию
            foreach (Control item in A403_1Panel.Controls)
            {
                if (item.Name.Contains("КнопкаПараметры") && !item.Name.Contains("Сброс"))
                    item.Visible = !(A403_1Parameters.КнопкиПараметры[(int)Char.GetNumericValue(item.Name[15])]);
            }
        }

        private void A403_1КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаПараметрыСброс.BackgroundImage = null;
        }

        private void A403_1КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаПараметрыСброс.BackgroundImage = ControlElementImages.buttonSquareLightBlue;

            //Сброс параметров и отжатие всех кнопок
            for (int i = 0; i < A403_1Parameters.КнопкиПараметры.Length; i++)
                A403_1Parameters.КнопкиПараметры[i] = false;

            foreach (Control item in A403_1Panel.Controls)
            {
                if (item.Name.Contains("КнопкаПараметры") && !item.Name.Contains("Сброс"))
                {
                    //И запоминаем значения с табло
                    if (item.Visible == false)
                    {
                        A403_1Parameters.ДисплейЗначения[(A403_1Parameters.ТумблерГруппа) ? 0 : 1,
                            int.Parse(item.Name[15].ToString())] = A403_1Parameters.Значение;
                        A403_1Parameters.Значение = "";
                    }

                    item.Visible = true;
                }
            }

        }
        #endregion

        private void A403_1КнопкаУстВремени_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаУстВремени.BackgroundImage = ControlElementImages.buttonSquareLightBlue;
        }

        private void A403_1КнопкаУстВремени_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаУстВремени.BackgroundImage = null;
        }
        #endregion

        #region Переключатели
        private void ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A403_1Parameters.ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A403_1Parameters.ПереключательРежимРаботы -= 1;
            }

            var angle = A403_1Parameters.ПереключательРежимРаботы * 34 - 165;
            ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void ПереключательПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A403_1Parameters.ПереключательПроверка += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A403_1Parameters.ПереключательПроверка -= 1;
            }

            var angle = A403_1Parameters.ПереключательПроверка * 32 - 185;
            ////Смещение т.к форма не хорошо нарисована
            if (A403_1Parameters.ПереключательПроверка <= 6)
            {
                angle -= 6;
            }

            if (A403_1Parameters.ПереключательПроверка == 4 || A403_1Parameters.ПереключательПроверка == 5)
            {
                angle -= 6;
            }

            ПереключательПроверка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Инициализация
        private void InitializeTumblersPosition()
        {
            ТумблерСеть.BackgroundImage = A403_1Parameters.ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;

            ТумблерКомплект.BackgroundImage = A403_1Parameters.ТумблерКомплект
                 ? ControlElementImages.tumblerType5Left
                 : ControlElementImages.tumblerType5Right;

            ТумблерГотов.BackgroundImage = A403_1Parameters.ТумблерГотов
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            A403_1ТумблерГруппа.BackgroundImage = A403_1Parameters.ТумблерГруппа
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            ТумблерАвтКоррекция.BackgroundImage = A403_1Parameters.ТумблерАвтКоррекция
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void InitializeTogglesPosition()
        {
            var angle = A403_1Parameters.ПереключательРежимРаботы * 34 - 165;
            ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = A403_1Parameters.ПереключательПроверка * 32 - 185;
            ПереключательПроверка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeButtonsPosition()
        {
            foreach (Control item in A403_1Panel.Controls)
            {
                if (item.Name.Contains("КнопкаПараметры") && !item.Name.Contains("Сброс"))
                    item.Visible = !(A403_1Parameters.КнопкиПараметры[(int)Char.GetNumericValue(item.Name[15])]);
            }

        }
        #endregion

        /// <summary>
        /// функция форматирования для табло
        /// </summary>
        private string FormatString(string inputStr)
        {
            switch (inputStr.Length)
            {
                case 1: 
                    return ("_  _  _  _  _  " + inputStr);
                case 2: 
                    return ("_  _  _  _  " + inputStr[0] + "  " + inputStr[1]);
                case 3:
                    return ("_  _  _  " + inputStr[0] + "  " + inputStr[1] + "  " + inputStr[2]);
                case 4:
                    return ("_  _  " + inputStr[0] + "  " + inputStr[1] + "  " + inputStr[2] + "  " + inputStr[3]);
                case 5:
                    return ("_  " + inputStr[0] + "  " + inputStr[1] + "  " + inputStr[2] +
                        "  " + inputStr[3] + "  " + inputStr[4] );
                case 6:
                    return (inputStr[0] + "  " + inputStr[1] + "  " + inputStr[2] + "  " + 
                        inputStr[3] + "  " + inputStr[4] + "  " + inputStr[5]);
            } 
            return "";
        }
        
    }
}