﻿namespace R440O.R440OForms.PowerCabel
{
    using BaseClasses;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока кабель питания
    /// </summary>
    public partial class PowerCabelForm : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PowerCabelForm"/>
        /// </summary>
        public PowerCabelForm()
        {
            InitializeComponent();
            PowerCabelParameters.ParameterChanged += RefreshFormElements;
            PowerCabelParameters.СтанцияСгорела += ВыводСообщенияСтанцияСгорела;
            this.RefreshFormElements();
        }
        private void ВыводСообщенияСтанцияСгорела()
        {
            MessageBox.Show("Станция сгорела!", "ОШИБКА");
        }

        #region Кабель СЕТЬ
        private void КабельСеть_Click(object sender, EventArgs e)
        {
            PowerCabelParameters.КабельСеть = !PowerCabelParameters.КабельСеть;
        }
        #endregion

        #region Тумблер ОСВЕЩЕНИЕ
        private void ТумблерОсвещение_Click(object sender, EventArgs e)
        {
            PowerCabelParameters.ТумблерОсвещение = !PowerCabelParameters.ТумблерОсвещение;
        }
        #endregion

        #region Инициализация

        public void RefreshFormElements()
        {
            ТумблерОсвещение.BackgroundImage = (PowerCabelParameters.ТумблерОсвещение)
                ? ControlElementImages.tumblerType4Right
                : ControlElementImages.tumblerType4Left;

            КабельСеть.BackgroundImage = (PowerCabelParameters.КабельСеть)
                ? ControlElementImages.powerCabelEnter
                : null;
        }
        #endregion


    }
}