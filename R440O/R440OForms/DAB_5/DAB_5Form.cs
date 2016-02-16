using System;
using System.Reflection;

namespace R440O.R440OForms.DAB_5
{
    using System.Windows.Forms;
    using Parameters;
    using СостоянияЭлементов.ДАБ5;
    /// <summary>
    /// Форма блока ДАБ-5
    /// </summary>
    public partial class DAB_5Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DAB_5Form"/>
        /// </summary>
        public DAB_5Form()
        {
            this.InitializeComponent();
            DAB_5Parameters.RefreshForm += RefreshForm;
            RefreshForm();
        }

        private void ТумблерПитание_MouseClick(object sender, MouseEventArgs e)
        {
            DAB_5Parameters.ТумблерПитание = DAB_5Parameters.ТумблерПитание == EТумблерПитание.ВКЛ
                ? EТумблерПитание.ВЫКЛ
                : EТумблерПитание.ВКЛ;
            ТумблерПитание.BackgroundImage = DAB_5Parameters.ТумблерПитание == EТумблерПитание.ВКЛ
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        #region Кнопки РЕЖИМЫ
        private void КнопкаРежимРучн_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимРучн.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимРучн();
        }

        private void КнопкаРежимРучн_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимРучн.BackgroundImage = null;
        }

        private void КнопкаРежимАвтом_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимАвтом.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимАвтом();
        }

        private void КнопкаРежимАвтом_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимАвтом.BackgroundImage = null;
        }
        #endregion

        #region Кнопки ВЫБОР КОМПЛЕКТА
        private void КнопкаВыборПрмПрд1_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВыборПрмПрд1.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуВыборПрмПрд1();
        }

        private void КнопкаВыборПрмПрд1_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВыборПрмПрд1.BackgroundImage = null;
        }

        private void КнопкаВыборПрмПрд2_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВыборПрмПрд2.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуВыборПрмПрд2();
        }

        private void КнопкаВыборПрмПрд2_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВыборПрмПрд2.BackgroundImage = null;
        }

        private void КнопкаВыборБП1_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВыборБП1.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуВыборБП1();
        }

        private void КнопкаВыборБП1_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВыборБП1.BackgroundImage = null;
        }

        private void КнопкаВыборБП2_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВыборБП2.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуВыборБП2();
        }

        private void КнопкаВыборБП2_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВыборБП2.BackgroundImage = null;
        }
        #endregion

        #region Кнопки РЕЖИМ РАБОТЫ 1K
        private void КнопкаРежимВыкл1К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимВыкл1К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимВыкл1К();
        }

        private void КнопкаРежимВыкл1К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимВыкл1К.BackgroundImage = null;
        }

        private void КнопкаРежимРабота1К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимРабота1К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимРабота1К();
        }

        private void КнопкаРежимРабота1К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимРабота1К.BackgroundImage = null;
        }

        private void КнопкаРежимШлейф1К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимШлейф1К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимШлейф1К();
        }

        private void КнопкаРежимШлейф1К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимШлейф1К.BackgroundImage = null;
        }

        private void КнопкаРежимПрмПрд1К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрмПрд1К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимПрмПрд1К();
        }

        private void КнопкаРежимПрмПрд1К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрмПрд1К.BackgroundImage = null;
        }

        private void КнопкаРежимПрм1К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрм1К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимПрм1К();
        }

        private void КнопкаРежимПрм1К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрм1К.BackgroundImage = null;
        }
        #endregion

        #region Кнопки РЕЖИМ РАБОТЫ 2К
        private void КнопкаРежимВыкл2К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимВыкл2К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимВыкл2К();
        }

        private void КнопкаРежимВыкл2К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимВыкл2К.BackgroundImage = null;
        }

        private void КнопкаРежимРабота2К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимРабота2К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимРабота2К();
        }

        private void КнопкаРежимРабота2К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимРабота2К.BackgroundImage = null;
        }

        private void КнопкаРежимШлейф2К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимШлейф2К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимШлейф2К();
        }

        private void КнопкаРежимШлейф2К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимШлейф2К.BackgroundImage = null;
        }

        private void КнопкаРежимПрмПрд2К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрмПрд2К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимПрмПрд2К();
        }

        private void КнопкаРежимПрмПрд2К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрмПрд2К.BackgroundImage = null;
        }

        private void КнопкаРежимПрм2К_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрм2К.BackgroundImage = ControlElementImages.buttonRoundType3;
            DAB_5Parameters.НажатьКнопкуРежимПрм2К();
        }

        private void КнопкаРежимПрм2К_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаРежимПрм2К.BackgroundImage = null;
        }

        #endregion

        private void RefreshForm()
        {     
            foreach (Control controlElement in Panel.Controls)
            {
                if (controlElement.Name.Contains("Лампочка"))
                {
                    PropertyInfo[] propertyList = typeof(DAB_5Parameters).GetProperties();
                    foreach (PropertyInfo property in propertyList)
                    {
                        if (controlElement.Name == property.Name)
                        {
                            controlElement.BackgroundImage = Convert.ToBoolean(property.GetValue(null))
                            ? ControlElementImages.lampType5OnRed
                            : null;
                        }
                    }
                }
            }
            ЛампочкаПитание.BackgroundImage = DAB_5Parameters.ЛампочкаПитание
                ? ControlElementImages.lampType10OnGreen
                : null;
            ТумблерПитание.BackgroundImage = DAB_5Parameters.ТумблерПитание == EТумблерПитание.ВКЛ
               ? ControlElementImages.tumblerType4Up
               : ControlElementImages.tumblerType4Down;
        }

    }
}