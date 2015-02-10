//-----------------------------------------------------------------------
// <copyright file="Kontur_P3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Kontur_P3
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Контур-П3
    /// </summary>
    public partial class Kontur_P3Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Kontur_P3Form"/>
        /// </summary>
        public Kontur_P3Form()
        {
            this.InitializeComponent();
        }

        #region КП1
        #region Контур_П3КнопкаКП1Контроль
        private void Контур_П3КнопкаКП1Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП1Контроль.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП1Контроль = "true";
        }

        private void Контур_П3КнопкаКП1Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП1Контроль.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП1Контроль = "false";
        }
        #endregion

        
        #endregion

        #region КП2
        #region Контур_П3КнопкаКП2Сдвиг1
        private void Контур_П3КнопкаКП2Сдвиг1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2Сдвиг1.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП2Сдвиг1 = "true";
        }

        private void Контур_П3КнопкаКП2Сдвиг1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2Сдвиг1.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП2Сдвиг1 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП2Сдвиг10
        private void Контур_П3КнопкаКП2Сдвиг10_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2Сдвиг10.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП2Сдвиг10 = "true";
        }

        private void Контур_П3КнопкаКП2Сдвиг10_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2Сдвиг10.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП2Сдвиг10 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП2НачИнформ
        private void Контур_П3КнопкаКП2НачИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2НачИнформ.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП2НачИнформ = "true";
        }

        private void Контур_П3КнопкаКП2НачИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП2НачИнформ.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП2НачИнформ = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП3КонтрольКанал10
        private void Контур_П3КнопкаКП3КонтрольКанал10_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал10.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал10 = "true";
        }

        private void Контур_П3КнопкаКП3КонтрольКанал10_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал10.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал10 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП3КонтрольКанал11
        private void Контур_П3КнопкаКП3КонтрольКанал11_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал11.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал11 = "true";
        }

        private void Контур_П3КнопкаКП3КонтрольКанал11_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал11.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал11 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП3КонтрольКанал12
        private void Контур_П3КнопкаКП3КонтрольКанал12_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал12.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал12 = "true";
        }

        private void Контур_П3КнопкаКП3КонтрольКанал12_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП3КонтрольКанал12.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП3КонтрольКанал12 = "false";
        }
        #endregion
        #endregion

        #region КП4
        #region Контур_П3КнопкаКП4Контроль
        private void Контур_П3КнопкаКП4Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП4Контроль.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП4Контроль = "true";
        }

        private void Контур_П3КнопкаКП4Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП4Контроль.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП4Контроль = "false";
        }
        #endregion
        #endregion

        #region КП6
        #region Контур_П3КнопкаКП6Пуск
        private void Контур_П3КнопкаКП6Пуск_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП6Пуск.BackgroundImage = ControlElementImages.buttonRoundType4;
            Kontur_P3Parameters.Контур_П3КнопкаКП6Пуск = "true";
        }

        private void Контур_П3КнопкаКП6Пуск_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП6Пуск.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП6Пуск = "false";
        }
        #endregion
        #endregion

    }
}