using System;

namespace R440O.R440OForms.PowerCabel
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока кабель питания
    /// </summary>
    public partial class PowerCabelForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PowerCabelForm"/>
        /// </summary>
        public PowerCabelForm()
        {
            InitializeComponent();
            InitializeTumblersPosition();
            InitializeCabelPosition();
        }

        #region Кабель СЕТЬ
        private void КабельСеть_Click(object sender, EventArgs e)
        {
            КабельСеть.BackgroundImage = (PowerCabelParameters.КабельСеть)
                ? null
                : ControlElementImages.powerCabelEnter;

            PowerCabelParameters.КабельСеть = !PowerCabelParameters.КабельСеть;
        }
        #endregion

        #region Тумблер ОСВЕЩЕНИЕ
        private void ТумблерОсвещение_Click(object sender, EventArgs e)
        {
            ТумблерОсвещение.BackgroundImage = (PowerCabelParameters.ТумблерОсвещение)
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            PowerCabelParameters.ТумблерОсвещение = !PowerCabelParameters.ТумблерОсвещение;
        }
        #endregion

        #region Инициализация
        private void InitializeTumblersPosition()
        {
            ТумблерОсвещение.BackgroundImage = (PowerCabelParameters.ТумблерОсвещение)
                ? ControlElementImages.tumblerType4Right
                : ControlElementImages.tumblerType4Left;
        }

        private void InitializeCabelPosition()
        {
            КабельСеть.BackgroundImage = (PowerCabelParameters.КабельСеть)
                ? ControlElementImages.powerCabelEnter
                : null;
        }
        #endregion

    }
}