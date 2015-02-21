//-----------------------------------------------------------------------
// <copyright file="B2_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;

namespace R440O.R440OForms.B2_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Б2-1
    /// </summary>
    public partial class B2_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B2_2Form"/>.
        /// </summary>
        public B2_2Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeButtonsPosition();
        }

        private void B2_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2ТумблерМуДу == "Му")
            {
                this.B2_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B2_2Parameters.B2_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B2_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B2_2Parameters.B2_2ТумблерМуДу = "Му";
            }
        }

        #region Кнопки
        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки данного блока
        /// </summary>
        private void B2_2КнопкаБК_Click(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            //Т.к имена кнопок практически одинаковы, получим 2 числа которые меняются в названиях
            char numberOfComplect = button.Name[12];
            char numberOfButton = button.Name[14];

            //Получим список get set полей из класса параметров
            PropertyInfo[] PropertyList = typeof(B2_2Parameters).GetProperties();

            //Переберём список контролов
            foreach (Control item in B2_2Panel.Controls)
            {
                //С помощью условия отсеем все контролы кроме тех, которые являются кнопками и содержат в имени один из номеров(1-2 столбик) 
                if (item.Name.Contains("B2_2КнопкаБК" + numberOfComplect))
                {
                    //Отжимаем кнопку если она нажата
                    if (item.Visible == false) item.Visible = true;
                    //Остановимся на контроле, который отвечает за кнопку которую мы нажали
                    if (item.Name.Contains("B2_2КнопкаБК" + numberOfComplect + "_" + numberOfButton))
                    {
                        //Пройдемся лишь по тем полям класса параметров, которые относятся к нужной категории
                        foreach (PropertyInfo Property in
                            PropertyList.Where(Property => Property.Name.Contains("B2_2КнопкаБК" + numberOfComplect)))
                        {
                            //Если параметр и нажатая нами клавиша совпадают, то делаем анимацию нажатия, 
                            //и присваиваем полю значение true/ Иначе присваиваем значение false.
                            if (Property.Name == item.Name)
                            {
                                item.Visible = false;
                                Property.SetValue(null, true);
                            }
                            else Property.SetValue(null, false);
                        }
                    }
                }
            }
        }
        #endregion Кнопки

        #region Колодки
        private void B2_2КолодкаТЛГпр_1_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТЛГпр_1 == false)
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_2.Visible = false;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = true;
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = false;
            }
            else
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = false;
                this.B2_2КолодкаТЛГпр_2.Visible = true;
            }
        }

        private void B2_2КолодкаТЛГпр_2_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТЛГпр_2 == false)
            {
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_1.Visible = false;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = true;
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = false;
            }
            else
            {
                this.B2_2КолодкаТЛГпр_1.Visible = true;
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = false;
            }
        }


        private void B2_2КолодкаТКСпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТКСпр2_1 == false)
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_2.Visible = false;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = true;
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = false;
            }
            else
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = false;
                this.B2_2КолодкаТКСпр2_2.Visible = true;
            }
        }

        private void B2_2КолодкаТКСпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТКСпр2_2 == false)
            {
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_1.Visible = false;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = true;
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = false;
            }
            else
            {
                this.B2_2КолодкаТКСпр2_1.Visible = true;
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = false;
            }
        }
        #endregion

        #region Инициализация
        private void InitializeTumblersPosition()
        {
            this.B2_2ТумблерМуДу.BackgroundImage = B2_2Parameters.B2_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }

        private void InitializeButtonsPosition()
        {
            foreach (Control item in B2_2Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    PropertyInfo[] fieldList = typeof(B2_2Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            bool value = Convert.ToBoolean(property.GetValue(null));
                            item.Visible = !value;
                            break;
                        }
                    }
                }
            }

            if (B2_2Parameters.B2_2КолодкаТЛГпр_1 == true)
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_2.Visible = false;
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
            }
            else if (B2_2Parameters.B2_2КолодкаТЛГпр_2 == true)
            {
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_1.Visible = false;
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
            }


            if (B2_2Parameters.B2_2КолодкаТКСпр2_1 == true)
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_2.Visible = false;
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
            }
            else if (B2_2Parameters.B2_2КолодкаТКСпр2_2 == true)
            {
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_1.Visible = false;
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
            }

        }
        #endregion
    }
}