﻿using System.Linq;
using R440O.BaseClasses;

namespace R440O.R440OForms.A1
{
    using System.Windows.Forms;

    public partial class A1Form : Form, IRefreshableForm
    {
        public A1Form()
        {
            this.InitializeComponent();
            A1Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        #region Обработка действий пользователя

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            A1Parameters.КнопкаСкоростьАб_1ТЛФК = !A1Parameters.КнопкаСкоростьАб_1ТЛФК;
        }

        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            A1Parameters.КнопкаСкоростьГр = !A1Parameters.КнопкаСкоростьГр;
        }

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            A1Parameters.ТумблерМуДу = !A1Parameters.ТумблерМуДу;
        }

        #endregion

        #region Инициализация

        public void RefreshFormElements()
        {
            this.ТумблерМуДу.BackgroundImage = A1Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            this.КнопкаСкоростьГР.BackgroundImage = A1Parameters.КнопкаСкоростьГр
                ? null
                : ControlElementImages.buttonRectType1;

            this.КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = A1Parameters.КнопкаСкоростьАб_1ТЛФК
                ? null
                : ControlElementImages.buttonRectType1;

            foreach (Control itemIn in Panel.Controls)
            {
                var item = itemIn;
                if (!item.Name.Contains("Лампочка")) continue;
                var fieldList = typeof(A1Parameters).GetFields();
                foreach (var field in fieldList.Where(field => item.Name == field.Name))
                {
                    if (item.Name.Contains("ЛампочкаФСПК") ||
                        item.Name.Contains("ЛампочкаПУЛ1_2") ||
                        item.Name.Contains("ЛампочкаПУЛ2_2") ||
                        item.Name.Contains("ЛампочкаПУЛ3_2") ||
                        item.Name.Contains("ЛампочкаПитание"))
                        item.BackgroundImage = (bool)field.GetValue(null)
                            ? ControlElementImages.lampType3OnRed
                            : null;
                    else
                        item.BackgroundImage = (bool)field.GetValue(null)
                            ? ControlElementImages.lampType2OnRed
                            : null;
                    break;
                }
            }
        }

        #endregion
    }
}