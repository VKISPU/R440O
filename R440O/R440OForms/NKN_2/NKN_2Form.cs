//-----------------------------------------------------------------------
// <copyright file="NKN_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.R440OForms.N502B;

namespace R440O.R440OForms.NKN_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока НКН-2
    /// </summary>
    public partial class NKN_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="NKN_2Form"/>
        /// </summary>
        public NKN_2Form()
        {
            this.InitializeComponent();
            this.InitializeLamps();
        }

        /// <summary>
        /// Инициализация начальных положений - сейчас не учтено дистанционное включение
        /// </summary>
        private void InitializeLamps()
        {
            this.TurnLamps();
            if (NKN_2Parameters.NKN_2ЛампочкаМУ)
            {
                NKN_2ЛампочкаФаза1.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[0]
                     ? ControlElementImages.lampType9OnGreen
                     : null;
                NKN_2ЛампочкаФаза2.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[1]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_2ЛампочкаФаза3.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[2]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
            }
        }

        #region Переключение состояния ламп
        /// <summary>
        /// Включает или выключает блок - отображается состоянием лампочки
        /// </summary>
        public void TurnLamps()
        {
            NKN_2Parameters.NKN_2ЛампочкаМУ = N502BParameters.ТумблерЭлектрооборудование && N502BParameters.ТумблерВыпрямитель27В;
            NKN_2ЛампочкаМУ.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкаМУ
                ? ControlElementImages.lampType9OnGreen
                : null;
        }

        public void TurnLamps(bool on)
        {
            if (NKN_2Parameters.NKN_2ЛампочкаМУ && (N15Parameters.Н15ЛампочкаППВВкл1 != "true") && (N15Parameters.Н15ЛампочкаППВРабота1 != "true"))
            {
                for (var i = 0; i < NKN_2Parameters.NKN_2ЛампочкиФаз.Length; i++)
                {
                    NKN_2Parameters.NKN_2ЛампочкиФаз[i] = on;
                }

                NKN_2ЛампочкаФаза1.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[0]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_2ЛампочкаФаза2.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[1]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_2ЛампочкаФаза3.BackgroundImage = NKN_2Parameters.NKN_2ЛампочкиФаз[2]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
            }
        }
        #endregion

        #region Кнопки местного включения блока
        private void NKN_2Кнопка220Вкл_MouseDown(object sender, MouseEventArgs e)
        {
            NKN_2Кнопка220Вкл.BackgroundImage = ControlElementImages.buttonRoundType4;
        }

        private void NKN_2Кнопка220Вкл_MouseUp(object sender, MouseEventArgs e)
        {
            NKN_2Кнопка220Вкл.BackgroundImage = null;
            this.TurnLamps(true);
        }

        private void NKN_2Кнопка220Откл_MouseDown(object sender, MouseEventArgs e)
        {
            NKN_2Кнопка220Откл.BackgroundImage = ControlElementImages.buttonRoundType4;
        }

        private void NKN_2Кнопка220Откл_MouseUp(object sender, MouseEventArgs e)
        {
            NKN_2Кнопка220Откл.BackgroundImage = null;
            this.TurnLamps(false);
        }
        #endregion
    }
}