//-----------------------------------------------------------------------
// <copyright file="NKN_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.NKN_1
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока НКН-1
    /// </summary>
    public partial class NKN_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="NKN_1Form"/>
        /// </summary>
        public NKN_1Form()
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
            if (NKN_1Parameters.NKN_1ЛампочкаМУ)
            {
               NKN_1ЛампочкаФаза1.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[0]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_1ЛампочкаФаза2.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[1]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_1ЛампочкаФаза3.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[2]
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
            NKN_1Parameters.NKN_1ЛампочкаМУ = N502BParameters.N502BТумблерЭлектрооборуд && N502BParameters.N502BТумблерВыпрямитель27В;
            NKN_1ЛампочкаМУ.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкаМУ
                ? ControlElementImages.lampType9OnGreen
                : null;
        }

        public void TurnLamps(bool on)
        {
            if (NKN_1Parameters.NKN_1ЛампочкаМУ && (N15Parameters.Н15ЛампочкаППВВкл1 != "true") && (N15Parameters.Н15ЛампочкаППВРабота1 != "true"))
            {
                for (var i = 0; i < NKN_1Parameters.NKN_1ЛампочкиФаз.Length; i++)
                {
                    NKN_1Parameters.NKN_1ЛампочкиФаз[i] = on;
                }
                NKN_1ЛампочкаФаза1.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[0]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_1ЛампочкаФаза2.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[1]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
                NKN_1ЛампочкаФаза3.BackgroundImage = NKN_1Parameters.NKN_1ЛампочкиФаз[2]
                    ? ControlElementImages.lampType9OnGreen
                    : null;
            }
        } 
        #endregion

        #region Кнопки местного включения блока
        private void NKN_1Кнопка220Вкл_MouseDown(object sender, MouseEventArgs e)
        {
            NKN_1Кнопка220Вкл.BackgroundImage = ControlElementImages.buttonRoundWhite;
        }

        private void NKN_1Кнопка220Вкл_MouseUp(object sender, MouseEventArgs e)
        {
            NKN_1Кнопка220Вкл.BackgroundImage = null;
            TurnLamps(true);
        }

        private void NKN_1Кнопка220Откл_MouseDown(object sender, MouseEventArgs e)
        {
            NKN_1Кнопка220Откл.BackgroundImage = ControlElementImages.buttonRoundWhite;
        }

        private void NKN_1Кнопка220Откл_MouseUp(object sender, MouseEventArgs e)
        {
            NKN_1Кнопка220Откл.BackgroundImage = null;
            TurnLamps(false);
        } 
        #endregion
    }
}