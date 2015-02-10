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

        #region Контур_П3КнопкаКП5АдресУСС
        private void Контур_П3КнопкаКП5АдресУСС_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5АдресУСС.BackgroundImage = null;
            this.Контур_П3КнопкаКП5АдресУСС.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5АдресУСС = "true";
        }
        private void Контур_П3КнопкаКП5АдресУСС_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5АдресУСС.BackgroundImage = ControlElementImages.buttonSquareBlack;
            this.Контур_П3КнопкаКП5АдресУСС.Text = "УСС";
            Kontur_P3Parameters.Контур_П3КнопкаКП5АдресУСС = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5АдресК
        private void Контур_П3КнопкаКП5АдресК_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5АдресК.BackgroundImage = null;
            this.Контур_П3КнопкаКП5АдресК.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5АдресК = "true";
        }

        private void Контур_П3КнопкаКП5АдресК_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5АдресК.BackgroundImage = ControlElementImages.buttonSquareBlack;
            this.Контур_П3КнопкаКП5АдресК.Text = "К";
            Kontur_P3Parameters.Контур_П3КнопкаКП5АдресК = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5Подпись1
        private void Контур_П3КнопкаКП5Подпись1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись1.BackgroundImage = null;
            this.Контур_П3КнопкаКП5Подпись1.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись1 = "true";
        }

        private void Контур_П3КнопкаКП5Подпись1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись1.BackgroundImage = ControlElementImages.buttonSquareRed;
            this.Контур_П3КнопкаКП5Подпись1.Text = "1";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись1 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5Подпись2
        private void Контур_П3КнопкаКП5Подпись2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись2.BackgroundImage = null;
            this.Контур_П3КнопкаКП5Подпись2.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись2 = "true";
        }

        private void Контур_П3КнопкаКП5Подпись2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись2.BackgroundImage = ControlElementImages.buttonSquareRed;
            this.Контур_П3КнопкаКП5Подпись2.Text = "2";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись2 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5Подпись3
        private void Контур_П3КнопкаКП5Подпись3_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись3.BackgroundImage = null;
            this.Контур_П3КнопкаКП5Подпись3.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись3 = "true";
        }

        private void Контур_П3КнопкаКП5Подпись3_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Подпись3.BackgroundImage = ControlElementImages.buttonSquareRed;
            this.Контур_П3КнопкаКП5Подпись3.Text = "3";
            Kontur_P3Parameters.Контур_П3КнопкаКП5Подпись3 = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5Группа
        private void Контур_П3КнопкаКП5Группа_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Группа.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП5Группа = "true";
        }

        private void Контур_П3КнопкаКП5Группа_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5Группа.BackgroundImage = ControlElementImages.buttonSquareBlack;
            Kontur_P3Parameters.Контур_П3КнопкаКП5Группа = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5ОбщийС
        private void Контур_П3КнопкаКП5ОбщийС_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ОбщийС.BackgroundImage = null;
            this.Контур_П3КнопкаКП5ОбщийС.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5ОбщийС = "true";
        }

        private void Контур_П3КнопкаКП5ОбщийС_MouseUp(object sender, MouseEventArgs e)
        {            
            this.Контур_П3КнопкаКП5ОбщийС.BackgroundImage = ControlElementImages.buttonSquareRed;
            this.Контур_П3КнопкаКП5ОбщийС.Text = "C";
            Kontur_P3Parameters.Контур_П3КнопкаКП5ОбщийС = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5ПередачаВызов
        private void Контур_П3КнопкаКП5ПередачаВызов_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаВызов.BackgroundImage =null;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаВызов = "true";
        }

        private void Контур_П3КнопкаКП5ПередачаВызов_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаВызов.BackgroundImage = ControlElementImages.buttonSquareBlack;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаВызов = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5ПередачаПУОтбой
        private void Контур_П3КнопкаКП5ПередачаПУОтбой_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаПУОтбой.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаПУОтбой = "true";
        }

        private void Контур_П3КнопкаКП5ПередачаПУОтбой_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаПУОтбой.BackgroundImage = ControlElementImages.buttonSquareBlack;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаПУОтбой = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5ПередачаИнформ
        private void Контур_П3КнопкаКП5ПередачаИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаИнформ.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаИнформ = "true";
        }

        private void Контур_П3КнопкаКП5ПередачаИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаИнформ.BackgroundImage = ControlElementImages.buttonSquareBlack;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаИнформ = "false";
        }
        #endregion

        #region Контур_П3КнопкаКП5ПередачаНаборККПРМ
        private void Контур_П3КнопкаКП5ПередачаНаборККПРМ_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаНаборККПРМ.BackgroundImage = null;
            this.Контур_П3КнопкаКП5ПередачаНаборККПРМ.Text = "";
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаНаборККПРМ = "true";
        }

        private void Контур_П3КнопкаКП5ПередачаНаборККПРМ_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаНаборККПРМ.BackgroundImage = ControlElementImages.buttonSquareBlack;
            this.Контур_П3КнопкаКП5ПередачаНаборККПРМ.Text = "ПРМ";
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаНаборККПРМ = "false";
        }
        #endregion

        private void Контур_П3КнопкаКП5ПередачаКонтрольЗанятости_MouseDown(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаКонтрольЗанятости.BackgroundImage = null;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаКонтрольЗанятости = "true";
        }

        private void Контур_П3КнопкаКП5ПередачаКонтрольЗанятости_MouseUp(object sender, MouseEventArgs e)
        {
            this.Контур_П3КнопкаКП5ПередачаКонтрольЗанятости.BackgroundImage = ControlElementImages.buttonSquareBlack;
            Kontur_P3Parameters.Контур_П3КнопкаКП5ПередачаКонтрольЗанятости = "false";
        }

    }
}