//-----------------------------------------------------------------------
// <copyright file="A403_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Reflection;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.R440O;

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
            RefreshForm();
            A403_1Parameters.RefreshForm += RefreshForm;

            A403_1Parameters.timer.Enabled = true;
            A403_1Parameters.timer.Tick += A403_1Parameters.timer_Tick;
            A403_1Parameters.timer.Interval = 1000;
            A403_1Parameters.timer.Start();
        }

        #region Тумблеры
        private void ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерСеть = !A403_1Parameters.ТумблерСеть;
        }

        private void ТумблерКомплект_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерКомплект = !A403_1Parameters.ТумблерКомплект;
        }

        private void ТумблерГотов_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерГотов = !A403_1Parameters.ТумблерГотов;
        }

        private void ТумблерГруппа_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерГруппа = !A403_1Parameters.ТумблерГруппа;
            //отобразим значения
            if (Array.IndexOf(A403_1Parameters.КнопкиПараметры, true) != -1 && A403_1Parameters.ТумблерСеть)
                Дисплей.Text = FormatString(A403_1Parameters.ДисплейЗначения[(A403_1Parameters.ТумблерГруппа) ? 0 : 1,
                    Array.IndexOf(A403_1Parameters.КнопкиПараметры, true)]);
        }

        private void ТумблерАвтКоррекция_Click(object sender, System.EventArgs e)
        {
            A403_1Parameters.ТумблерАвтКоррекция = !A403_1Parameters.ТумблерАвтКоррекция;
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

            //Записываем значение
            if (number == 'М')
            {
                if (A403_1Parameters.Значение.Length > 0)
                    if (A403_1Parameters.Значение[0] != '-')
                        A403_1Parameters.Значение = "-" + A403_1Parameters.Значение;
                    else
                        A403_1Parameters.Значение = A403_1Parameters.Значение.Substring(1);
                else
                    A403_1Parameters.Значение = "-" + A403_1Parameters.Значение;
            }
            else
                A403_1Parameters.Значение += Convert.ToString(number);
        }
        #endregion

        #region Кнопки выбора параметров
        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки параметров
        /// </summary>
        private void КнопкаПараметры_Click(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            A403_1Parameters.КнопкаПараметр = (int)Char.GetNumericValue(button.Name[15]);

            //очистим время
            A403_1Parameters.Значение = "";

            //отобразим значение
            if (Array.IndexOf(A403_1Parameters.КнопкиПараметры, true) != -1 && A403_1Parameters.ТумблерСеть)
                Дисплей.Text = FormatString(A403_1Parameters.ДисплейЗначения[(A403_1Parameters.ТумблерГруппа) ? 0 : 1,
                    Array.IndexOf(A403_1Parameters.КнопкиПараметры, true)]);
        }

        private void A403_1КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаПараметрыСброс.BackgroundImage = null;
        }

        private void A403_1КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаПараметрыСброс.BackgroundImage = ControlElementImages.buttonSquareLightBlue;
            A403_1Parameters.КнопкаПараметр = 9;

        }
        #endregion

        private void A403_1КнопкаУстВремени_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаУстВремени.BackgroundImage = ControlElementImages.buttonSquareLightBlue;
        }

        private void A403_1КнопкаУстВремени_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаУстВремени.BackgroundImage = null;
        }
        #endregion

        #region Переключатели
        private void ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                A403_1Parameters.ПереключательРежимРаботы += 1;

            if (e.Button == MouseButtons.Right)
                A403_1Parameters.ПереключательРежимРаботы -= 1;
        }

        private void ПереключательПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                A403_1Parameters.ПереключательПроверка += 1;

            if (e.Button == MouseButtons.Right)
                A403_1Parameters.ПереключательПроверка -= 1;
        }
        #endregion

        /// <summary>
        /// функция форматирования для табло
        /// </summary>
        private string FormatString(string inputStr)
        {
            string minus = "  ";
            if (inputStr.Length > 0)
                if (inputStr[0] == '-')
                {
                    minus = "* ";
                    inputStr = inputStr.Substring(1);
                }
            switch (inputStr.Length)
            {
                case 0:
                    return (minus + inputStr + "_ _ _ _ _ _");
                case 1:
                    return (minus + inputStr + " _ _ _ _ _");
                case 2:
                    return (minus + inputStr[0] + " " + inputStr[1] + " _ _ _ _");
                case 3:
                    return (minus + inputStr[0] + " " + inputStr[1] + " " + inputStr[2] + " _ _ _");
                case 4:
                    return (minus + inputStr[0] + " " + inputStr[1] + " " + inputStr[2] + " " + inputStr[3] + " _ _");
                case 5:
                    return (minus + inputStr[0] + " " + inputStr[1] + " " + inputStr[2] +
                        " " + inputStr[3] + " " + inputStr[4] + " _");
                case 6:
                    return (minus + inputStr[0] + " " + inputStr[1] + " " + inputStr[2] + " " +
                        inputStr[3] + " " + inputStr[4] + " " + inputStr[5]);
            }
            return "";
        }

        /// <summary>
        /// обновление формы
        /// </summary>
        private void RefreshForm()
        {
            //для разного отображения пустой строки при выключенном и включенном питании
            if (A403_1Parameters.ТумблерСеть)
                Дисплей.Text = FormatString(A403_1Parameters.Значение);
            else
                Дисплей.Text = "";

            ЛампочкаКомплект1.BackgroundImage = A403_1Parameters.ЛампочкаКомплект1
                ? ControlElementImages.lampType12OnRed
                : null;

            ЛампочкаКомплект2.BackgroundImage = A403_1Parameters.ЛампочкаКомплект2
                ? ControlElementImages.lampType12OnRed
                : null;

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

            var angle = A403_1Parameters.ПереключательРежимРаботы * 34 - 165;
            ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);


            angle = A403_1Parameters.ПереключательПроверка * 32 - 185;
            ////Смещение т.к форма не хорошо нарисована
            if (A403_1Parameters.ПереключательПроверка <= 6) angle -= 6;
            if (A403_1Parameters.ПереключательПроверка == 4 || A403_1Parameters.ПереключательПроверка == 5) angle -= 6;
            ПереключательПроверка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);


            foreach (Control item in A403_1Panel.Controls)
            {
                if (item.Name.Contains("КнопкаПараметры") && !item.Name.Contains("Сброс"))
                    item.Visible = !(A403_1Parameters.КнопкиПараметры[(int)Char.GetNumericValue(item.Name[15])]);
            }

        }
    }
}