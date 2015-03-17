using System.Linq;

namespace R440O.R440OForms.A1
{
    using System.Windows.Forms;

    public partial class A1Form : Form
    {
        public A1Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeButtonsPosition();
            this.InitializeLamps();
        }

        #region Обработка действий пользователя

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            if (A1Parameters.КнопкаСкоростьАБ_1ТЛФ_К == false)
            {
                this.КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = null;
                A1Parameters.КнопкаСкоростьАБ_1ТЛФ_К = true;
            }
            else
            {
                this.КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = ControlElementImages.buttonRectType1;
                A1Parameters.КнопкаСкоростьАБ_1ТЛФ_К = false;
            }
        }

        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            if (A1Parameters.КнопкаСкоростьГР == false)
            {
                this.КнопкаСкоростьГР.BackgroundImage = null;
                A1Parameters.КнопкаСкоростьГР = true;
            }
            else
            {
                this.КнопкаСкоростьГР.BackgroundImage = ControlElementImages.buttonRectType1;
                A1Parameters.КнопкаСкоростьГР = false;
            }
        }

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            A1Parameters.ТумблерМуДу = !A1Parameters.ТумблерМуДу;
            this.ТумблерМуДу.BackgroundImage = A1Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        #endregion

        #region Инициализация

        private void InitializeTumblersPosition()
        {
            this.ТумблерМуДу.BackgroundImage = A1Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void InitializeButtonsPosition()
        {
            this.КнопкаСкоростьГР.BackgroundImage = A1Parameters.КнопкаСкоростьГР
                ? null
                : ControlElementImages.buttonRectType1;

            this.КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = A1Parameters.КнопкаСкоростьАБ_1ТЛФ_К
                ? null
                : ControlElementImages.buttonRectType1;
        }

        private void InitializeLamps()
        {
            foreach (Control itemIn in Panel.Controls)
            {
                var item = itemIn;
                if (!item.Name.Contains("Лампочка")) continue;
                var fieldList = typeof (A1Parameters).GetFields();
                foreach (var field in fieldList.Where(field => item.Name == field.Name))
                {
                    if (item.Name.Contains("ЛампочкаФСПК") ||
                        item.Name.Contains("ЛампочкаПУЛ1_2") ||
                        item.Name.Contains("ЛампочкаПУЛ2_2") ||
                        item.Name.Contains("ЛампочкаПУЛ3_2") ||
                        item.Name.Contains("ЛампочкаПитание"))
                        item.BackgroundImage = (bool) field.GetValue(null)
                            ? ControlElementImages.lampType3OnRed
                            : null;
                    else
                        item.BackgroundImage = (bool) field.GetValue(null)
                            ? ControlElementImages.lampType2OnRed
                            : null;
                    break;
                }
            }
        }

        #endregion
    }
}