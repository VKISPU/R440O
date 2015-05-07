//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using R440O.R440OForms.N15Inside;

namespace R440O.R440OForms.N15
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-15
    /// </summary>
    public partial class N15Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N15Form"/>
        /// </summary>
        public N15Form()
        {
            this.InitializeComponent();
            N15Parameters.RefreshForm += InitializeForm;
            N15LocalParameters.RefreshFormElement += RefreshFormElement;
            InitializeForm();
        }

        #region Инициализация элементов управления

        private void InitializeForm()
        {
            InitializeButtons();
            InitializeTumblers();
            InitializeLamps();
        }

        /// <summary>
        /// Установка кнопок в положение последней их установки
        /// </summary>
        private void InitializeButtons()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("Кнопка")) continue;
                var fieldList = typeof(N15Parameters).GetProperties();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    var val = !(bool)property.GetValue(null);
                    item.Visible = val;
                    break;
                }
            }

            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("Кнопка")) continue;
                var fieldList = typeof(N15LocalParameters).GetProperties();
                foreach (var property in fieldList.Where(property => property.Name.Contains(item.Name)))
                {
                    var val = !(bool)property.GetValue(null);
                    item.Visible = val;
                    break;
                }
            }
        }

        /// <summary>
        /// Установка тумблеров в положение последней их установки
        /// </summary>
        private void InitializeTumblers()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("Тумблер")) continue;
                var propertyList = typeof(N15LocalParameters).GetProperties();
                foreach (var property in propertyList.Where(property => ("лок" + item.Name) == property.Name))
                {
                    if (item.Name.Contains("ТумблерА20512") ||
                        item.Name.Contains("ТумблерАнтЭкв") ||
                        item.Name.Contains("ТумблерТлфТлгПрм") ||
                        item.Name.Contains("ТумблерТлфТлгПрд"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;
                    }
                    else
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.tumblerType3Up
                            : ControlElementImages.tumblerType3Down;
                    }
                }
            }
        }

        /// <summary>
        /// Установка лампочек в положение последней их установки
        /// </summary>
        private void InitializeLamps()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("Лампочка")) continue;
                var fieldList = typeof(N15Parameters).GetProperties();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    if (item.Name.Contains("Ц300М") || item.Name.Contains("ППВ") || item.Name.Contains("А205") ||
                        item.Name.Contains("УМ1") || item.Name.Contains("A205"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.lampType8OnRed
                            : null;
                    }
                    else
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.lampType5OnRed
                            : null;
                    }
                    break;
                }
            }
        }
        #endregion

        #region Обновление элементов управления

        private void RefreshFormElement(string parameterName)
        {
            var item = Panel.Controls.Find(parameterName, false)[0];
            if (item == null) return;
            if (!item.Name.Contains("Тумблер")) return;

            var propertyList = typeof (N15LocalParameters).GetProperties();
            foreach (var property in propertyList.Where(property => ("лок" + item.Name) == property.Name))
            {
                if (item.Name.Contains("ТумблерА20512") ||
                    item.Name.Contains("ТумблерАнтЭкв") ||
                    item.Name.Contains("ТумблерТлфТлгПрм") ||
                    item.Name.Contains("ТумблерТлфТлгПрд"))
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType4Up
                        : ControlElementImages.tumblerType4Down;
                }
                else
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }
        }
        

        /// <summary>
        /// Уставнавливает настоящие настройки станции в соответствии с включенными тумблерами
        /// </summary>
        private void ResetCurrentParameters()
        {
            var parametersList = typeof(N15Parameters).GetProperties();
            var localParametersList = typeof(N15LocalParameters).GetProperties();
            foreach (var localProperty in localParametersList)
            {
                foreach (var property in parametersList.Where(property => localProperty.Name.Contains(property.Name)))
                {
                    property.SetValue(this, localProperty.GetValue(this));
                }
            }
        }

        #endregion

        #region Включение и выключение блоков станции, открытие блока

        private void КнопкаСтанцияВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаСтанцияВкл.BackgroundImage = null;
        }

        private void КнопкаСтанцияВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаСтанцияВкл.BackgroundImage = ControlElementImages.buttonN15On;
            ResetCurrentParameters();
            N15Parameters.ResetParameters();
        }

        private void Н15КнопкаСтанцияВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаСтанцияВыкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаСтанцияВыкл.BackgroundImage = ControlElementImages.buttonN15Off;
        }

        private void N15ButtonInside1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form thisForm = new N15InsideForm();
            thisForm.Show(this);
        }

        private void N15ButtonInside2_Click(object sender, EventArgs e)
        {
            N15ButtonInside1_Click(sender, e);
        }

        #endregion

        #region Кнопки ПРМ НАВЕДЕНИЕ/Ц300М 1 2 3 4 и МОЩНОСТЬ Н16 АНТ Сброс

        private void Н15КнопкаПРМНаведениеЦ300М1_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = true;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        private void Н15КнопкаПРМНаведениеЦ300М2_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = true;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        private void Н15КнопкаПРМНаведениеЦ300М3_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = true;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        private void Н15КнопкаПРМНаведениеЦ300М4_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = true;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        private void Н15КнопкаМощностьН16_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = true;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        private void Н15КнопкаМощностьАнт_Click(object sender, EventArgs e)
        {
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = true;
        }

        private void Н15КнопкаМощностьСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаМощностьСброс.BackgroundImage = null;
            this.КнопкаМощностьСброс.Text = string.Empty;
        }

        private void Н15КнопкаМощностьСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаМощностьСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.КнопкаМощностьСброс.Text = "СБРОС";
            N15Parameters.КнопкаПРМНаведениеЦ300М1 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М2 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М3 = false;
            N15Parameters.КнопкаПРМНаведениеЦ300М4 = false;
            N15Parameters.КнопкаМощностьН16 = false;
            N15Parameters.КнопкаМощностьАнт = false;
        }

        #endregion

        #region Кнопки Н13-1 Н13-2 Н13-1,2 СБРОС
        private async void Н15КнопкаН13_1_Click(object sender, EventArgs e)
        {

            this.КнопкаН13_1.Visible = false;
            this.КнопкаН13_2.Visible = true;
            this.КнопкаН13_12.Visible = true;

            if (N15Parameters.КнопкаН13_2 == false && N15Parameters.КнопкаН13_12 == false)
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_2.BackgroundImage = null;

                await Task.Delay(300);
                this.ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_12.BackgroundImage = null;
            }

            N15Parameters.КнопкаН13_1 = true;
            N15Parameters.КнопкаН13_2 = false;
            N15Parameters.КнопкаН13_12 = false;

            N15Parameters.ЛампочкаН16Н13_1 = true;
            N15Parameters.ЛампочкаН16Н13_2 = false;
            N15Parameters.ЛампочкаН16Н13_12 = false;

        }

        private async void Н15КнопкаН13_2_Click(object sender, EventArgs e)
        {
            this.КнопкаН13_2.Visible = false;
            this.КнопкаН13_1.Visible = true;
            this.КнопкаН13_12.Visible = true;

            if (N15Parameters.КнопкаН13_1 == false && N15Parameters.КнопкаН13_12 == false)
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_12.BackgroundImage = null;

                await Task.Delay(300);
                this.ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_1.BackgroundImage = null;
            }

            N15Parameters.КнопкаН13_1 = false;
            N15Parameters.КнопкаН13_2 = true;
            N15Parameters.КнопкаН13_12 = false;

            N15Parameters.ЛампочкаН16Н13_1 = false;
            N15Parameters.ЛампочкаН16Н13_2 = true;
            N15Parameters.ЛампочкаН16Н13_12 = false;

        }

        private async void Н15КнопкаН13_12_Click(object sender, EventArgs e)
        {
            this.КнопкаН13_12.Visible = false;
            this.КнопкаН13_1.Visible = true;
            this.КнопкаН13_2.Visible = true;

            if (N15Parameters.КнопкаН13_1 == false && N15Parameters.КнопкаН13_2 == false)
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(300);
                this.ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_1.BackgroundImage = null;

                await Task.Delay(300);
                this.ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.ЛампочкаН16Н13_2.BackgroundImage = null;
            }

            N15Parameters.КнопкаН13_1 = false;
            N15Parameters.КнопкаН13_2 = false;
            N15Parameters.КнопкаН13_12 = true;

            N15Parameters.ЛампочкаН16Н13_1 = false;
            N15Parameters.ЛампочкаН16Н13_2 = false;
            N15Parameters.ЛампочкаН16Н13_12 = true;

        }

        private async void Н15КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.КнопкаСброс.Text = "СБРОС";

            this.КнопкаН13_1.Visible = true;
            this.КнопкаН13_2.Visible = true;
            this.КнопкаН13_12.Visible = true;

            await Task.Delay(300);
            this.ЛампочкаН16Н13_1.BackgroundImage = null;
            this.ЛампочкаН16Н13_2.BackgroundImage = null;
            this.ЛампочкаН16Н13_12.BackgroundImage = null;

            N15Parameters.КнопкаН13_1 = false;
            N15Parameters.КнопкаН13_2 = false;
            N15Parameters.КнопкаН13_12 = false;

            N15Parameters.ЛампочкаН16Н13_1 = false;
            N15Parameters.ЛампочкаН16Н13_2 = false;
            N15Parameters.ЛампочкаН16Н13_12 = false;

        }

        private void Н15КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаСброс.BackgroundImage = null;
            this.КнопкаСброс.Text = string.Empty;
        }
        #endregion

        private void Тумблер_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var localParameter = typeof(N15LocalParameters).GetProperty("лок" + button.Name);
            var newValue = !(bool)localParameter.GetValue(null);
            localParameter.SetValue(null, newValue);
        }
    }
}