﻿namespace R440O.R440OForms.B2_1
{
    using System;
    using System.Windows.Forms;
    using BaseClasses;

    /// <summary>
    /// Форма блока Б2-1
    /// </summary>
    public partial class B2_1Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B2_1Form"/>.
        /// </summary>
        public B2_1Form()
        {
            this.InitializeComponent();
            B2_1Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        #region Кнопки

        private void ТумблерМуДу_Click(object sender, EventArgs e)
        {
            B2_1Parameters.ТумблерМуДу = !B2_1Parameters.ТумблерМуДу;
        }

        /// <summary>
        /// Универсальный метод обработки нажатий на кнопки данного блока
        /// </summary>
        private void КнопкаБК_Click(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            var numberOfComplect = Convert.ToInt32(button.Name[8].ToString());
            var numberOfButton = Convert.ToInt32(button.Name[9].ToString());

            if (numberOfComplect == 1) B2_1Parameters.КнопкаБК1 = numberOfButton;
            else B2_1Parameters.КнопкаБК2 = numberOfButton;

        }
        #endregion Кнопки

        #region Колодки
        private void КолодкаТЛГпр_1_Click(object sender,  EventArgs e)
        {                                                     
            if (B2_1Parameters.КолодкаТЛГпр1 == false)        
            {                                                 
                B2_1Parameters.КолодкаТЛГпр1 = true;          
                B2_1Parameters.КолодкаТЛГпр2 = false;         
            }                                                 
            else                                              
            {                                                 
                B2_1Parameters.КолодкаТЛГпр1 = false;         
            }                                                 
        }                                                     
                                                              
        private void КолодкаТЛГпр_2_Click(object sender,  EventArgs e)
        {                                                     
            if (B2_1Parameters.КолодкаТЛГпр2 == false)        
            {                                                 
                B2_1Parameters.КолодкаТЛГпр2 = true;          
                B2_1Parameters.КолодкаТЛГпр1 = false;         
            }                                                 
            else                                              
            {                                                 
                B2_1Parameters.КолодкаТЛГпр2 = false;         
            }                                                 
        }                                                     
                                                              
                                                              
        private void КолодкаТКСпр2_1_Click(object sender, EventArgs e)
        {                                                     
            if (B2_1Parameters.КолодкаТКСпр21 == false)       
            {                                                 
                B2_1Parameters.КолодкаТКСпр21 = true;         
                B2_1Parameters.КолодкаТКСпр22 = false;        
            }                                                 
            else                                              
            {                                                 
                B2_1Parameters.КолодкаТКСпр21 = false;        
            }                                                 
        }                                                     
                                                              
        private void КолодкаТКСпр2_2_Click(object sender, EventArgs e)
        {
            if (B2_1Parameters.КолодкаТКСпр22 == false)
            {
                B2_1Parameters.КолодкаТКСпр22 = true;
                B2_1Parameters.КолодкаТКСпр21 = false;
            }
            else
            {
                B2_1Parameters.КолодкаТКСпр22 = false;
            }
        }
        #endregion

        #region Инициализация
        public void RefreshFormElements()
        {

            this.ТумблерМуДу.BackgroundImage = B2_1Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            foreach (Control item in Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    if (!item.Name.Contains("Кнопка")) continue;
                    item.BackgroundImage = ControlElementImages.buttonRectType1;
                    var button = item as Button;
                    var numberOfComplect = Convert.ToInt32(button.Name[8].ToString());
                    var numberOfButton = Convert.ToInt32(button.Name[9].ToString());
                    if (numberOfComplect == 1 && B2_1Parameters.КнопкаБК1 == numberOfButton ||
                        numberOfComplect == 2 && B2_1Parameters.КнопкаБК2 == numberOfButton)
                    {
                        item.BackgroundImage = null;
                    }
                }
            }

            КолодкаТЛГпр_1.BackgroundImage = B2_1Parameters.КолодкаТЛГпр1 ? ControlElementImages.jumperType1 : null;
            КолодкаТЛГпр_2.BackgroundImage = B2_1Parameters.КолодкаТЛГпр2 ? ControlElementImages.jumperType1 : null;
            КолодкаТКСпр2_1.BackgroundImage = B2_1Parameters.КолодкаТКСпр21 ? ControlElementImages.jumperType1 : null;
            КолодкаТКСпр2_2.BackgroundImage = B2_1Parameters.КолодкаТКСпр22 ? ControlElementImages.jumperType1 : null;
            
            КолодкаТЛГпр_1.Visible = !B2_1Parameters.КолодкаТЛГпр2;
            КолодкаТЛГпр_2.Visible = !B2_1Parameters.КолодкаТЛГпр1;
            КолодкаТКСпр2_1.Visible = !B2_1Parameters.КолодкаТКСпр22;
            КолодкаТКСпр2_2.Visible = !B2_1Parameters.КолодкаТКСпр21;
        }
        #endregion
    }
}