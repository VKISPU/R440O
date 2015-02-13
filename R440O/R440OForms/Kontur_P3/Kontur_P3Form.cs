//-----------------------------------------------------------------------
// <copyright file="Kontur_P3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Kontur_P3
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

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
            this.InitializeTogglesPosition();
            this.InitializeTumblersPosition();
        }

        #region Переключатели
        private void Kontur_P3ПереключательПриоритет_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Kontur_P3Parameters.Kontur_P3ПереключательПриоритет += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Kontur_P3Parameters.Kontur_P3ПереключательПриоритет -= 1;
            }

            var angle = Kontur_P3Parameters.Kontur_P3ПереключательПриоритет * 36 - 162;
            Kontur_P3ПереключательПриоритет.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void Kontur_P3ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Kontur_P3Parameters.Kontur_P3ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Kontur_P3Parameters.Kontur_P3ПереключательКонтроль -= 1;
            }

            var angle = Kontur_P3Parameters.Kontur_P3ПереключательКонтроль * 36 - 180;
            Kontur_P3ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }
        #endregion

        #region Тумблеры
        private void Kontur_P3ТумблерКонтроль_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерКонтроль == "Контроль1")
            {
                this.Kontur_P3ТумблерКонтроль.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерКонтроль = "Контроль2";
            }
            else
            {
                this.Kontur_P3ТумблерКонтроль.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерКонтроль = "Контроль1";
            }
        }

        private void Kontur_P3ТумблерМткПУ_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерМткПУ == "МТК")
            {
                this.Kontur_P3ТумблерМткПУ.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерМткПУ = "ПУ";
            }
            else
            {
                this.Kontur_P3ТумблерМткПУ.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерМткПУ = "МТК";
            }
        }

        private void Kontur_P3ТумблерДокументирование_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерДокументирование == "Откл")
            {
                this.Kontur_P3ТумблерДокументирование.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерДокументирование = "Вкл";
            }
            else
            {
                this.Kontur_P3ТумблерДокументирование.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерДокументирование = "Откл";
            }
        }

        private void Kontur_P3ТумблерАсинхрСинхр_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерАсинхрСинхр == "Синхр")
            {
                this.Kontur_P3ТумблерАсинхрСинхр.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерАсинхрСинхр = "Асинхр";
            }
            else
            {
                this.Kontur_P3ТумблерАсинхрСинхр.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерАсинхрСинхр = "Синхр";
            }
        }

        private void Kontur_P3ТумблерРежим_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерРежим == "Режим1")
            {
                this.Kontur_P3ТумблерРежим.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерРежим = "Режим2";
            }
            else
            {
                this.Kontur_P3ТумблерРежим.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерРежим = "Режим1";
            }
        }

        private void Kontur_P3ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (Kontur_P3Parameters.Kontur_P3ТумблерСеть == "Вкл")
            {
                this.Kontur_P3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType4Up;
                Kontur_P3Parameters.Kontur_P3ТумблерСеть = "Откл";
            }
            else
            {
                this.Kontur_P3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType4Down;
                Kontur_P3Parameters.Kontur_P3ТумблерСеть = "Вкл";
            }
        }
        #endregion

        #region Круглые кнопки
        private void Kontur_P3КнопкаСдвиг1_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаСдвиг1.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаСдвиг1_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаСдвиг1.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаСдвиг10_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаСдвиг10.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаСдвиг10_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаСдвиг10.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаНачИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаНачИнформ.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаНачИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаНачИнформ.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКП1Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКП1Контроль.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКП1Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКП1Контроль.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКан10_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан10.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан10_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан10.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКан11_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан11.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан11_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан11.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКан12_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан12.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан12_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКан12.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКП4Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКП4Контроль.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКП4Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКП4Контроль.BackgroundImage = ControlElementImages.buttonRoundType8;
        }


        private void Kontur_P3КнопкаПуск_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПуск.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаПуск_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПуск.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаАдресУСС_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаАдресУСС.BackgroundImage = null;
            Kontur_P3КнопкаАдресУСС.Text = null;
        }
        #endregion

        #region Квадратные кнопки
        private void Kontur_P3КнопкаАдресУСС_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаАдресУСС.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3КнопкаАдресУСС.Text = "УСС";
        }

        private void Kontur_P3КнопкаАдресК_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаАдресК.BackgroundImage = null;
            Kontur_P3КнопкаАдресК.Text = null;
        }

        private void Kontur_P3КнопкаАдресК_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаАдресК.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3КнопкаАдресК.Text = "К";
        }

        private void Kontur_P3КнопкаПодпись1_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись1.BackgroundImage = null;
            Kontur_P3КнопкаПодпись1.Text = null;
        }

        private void Kontur_P3КнопкаПодпись1_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись1.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаПодпись1.Text = "1";
        }

        private void Kontur_P3КнопкаПодпись2_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись2.BackgroundImage = null;
            Kontur_P3КнопкаПодпись2.Text = null;
        }

        private void Kontur_P3КнопкаПодпись2_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись2.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаПодпись2.Text = "2";
        }

        private void Kontur_P3КнопкаПодпись3_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись3.BackgroundImage = null;
            Kontur_P3КнопкаПодпись3.Text = null;
        }

        private void Kontur_P3КнопкаПодпись3_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаПодпись3.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаПодпись3.Text = "3";
        }

        private void Kontur_P3КнопкаГруппа_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаГруппа.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаГруппа_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаГруппа.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОбщийС_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОбщийС.BackgroundImage = null;
            Kontur_P3КнопкаОбщийС.Text = null;
        }

        private void Kontur_P3КнопкаОбщийС_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОбщийС.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаОбщийС.Text = "C";
        }

        private void Kontur_P3КнопкаВызов_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаВызов.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаВызов_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаВызов.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОтбой_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОтбой.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаОтбой_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОтбой.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформ.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформ.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаНаборКК_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаНаборКК.BackgroundImage = null;
            Kontur_P3КнопкаНаборКК.Text = null;
        }

        private void Kontur_P3КнопкаНаборКК_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаНаборКК.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3КнопкаНаборКК.Text = "ПРМ";
        }

        private void Kontur_P3КнопкаКонтрольЗанятости_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКонтрольЗанятости.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКонтрольЗанятости_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаКонтрольЗанятости.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОтклЗС_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОтклЗС.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаОтклЗС_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаОтклЗС.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3Кнопка7_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка7.BackgroundImage = null;
            Kontur_P3Кнопка7.Text = null;
        }

        private void Kontur_P3Кнопка7_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка7.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка7.Text = " 7";
        }

        private void Kontur_P3Кнопка8_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка8.BackgroundImage = null;
            Kontur_P3Кнопка8.Text = null;
        }

        private void Kontur_P3Кнопка8_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка8.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка8.Text = " 8";
        }

        private void Kontur_P3Кнопка9_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка9.BackgroundImage = null;
            Kontur_P3Кнопка9.Text = null;
        }

        private void Kontur_P3Кнопка9_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка9.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка9.Text = " 9";
        }

        private void Kontur_P3Кнопка4_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка4.BackgroundImage = null;
            Kontur_P3Кнопка4.Text = null;
        }

        private void Kontur_P3Кнопка4_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка4.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка4.Text = " 4";
        }

        private void Kontur_P3Кнопка5_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка5.BackgroundImage = null;
            Kontur_P3Кнопка5.Text = null;
        }

        private void Kontur_P3Кнопка5_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка5.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка5.Text = " 5";
        }

        private void Kontur_P3Кнопка6_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка6.BackgroundImage = null;
            Kontur_P3Кнопка6.Text = null;
        }

        private void Kontur_P3Кнопка6_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка6.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка6.Text = " 6";
        }

        private void Kontur_P3Кнопка1_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка1.BackgroundImage = null;
            Kontur_P3Кнопка1.Text = null;
        }

        private void Kontur_P3Кнопка1_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка1.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка1.Text = " 1";
        }

        private void Kontur_P3Кнопка2_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка2.BackgroundImage = null;
            Kontur_P3Кнопка2.Text = null;
        }

        private void Kontur_P3Кнопка2_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка2.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка2.Text = " 2";
        }

        private void Kontur_P3Кнопка3_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка3.BackgroundImage = null;
            Kontur_P3Кнопка3.Text = null;
        }

        private void Kontur_P3Кнопка3_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка3.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка3.Text = " 3";
        }

        private void Kontur_P3Кнопка0_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка0.BackgroundImage = null;
            Kontur_P3Кнопка0.Text = null;
        }

        private void Kontur_P3Кнопка0_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3Кнопка0.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Kontur_P3Кнопка0.Text = " 0";
        }

        private void Kontur_P3КнопкаИнформКОН_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформКОН.BackgroundImage = null;
            Kontur_P3КнопкаИнформКОН.Text = null;
        }

        private void Kontur_P3КнопкаИнформКОН_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформКОН.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаИнформКОН.Text = "КОН";
        }

        private void Kontur_P3КнопкаИнформС_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформС.BackgroundImage = null;
            Kontur_P3КнопкаИнформС.Text = null;
        }

        private void Kontur_P3КнопкаИнформС_MouseUp(object sender, MouseEventArgs e)
        {
            Kontur_P3КнопкаИнформС.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            Kontur_P3КнопкаИнформС.Text = "С";
        }
        #endregion

        private void InitializeTogglesPosition()
        {
            var angle = Kontur_P3Parameters.Kontur_P3ПереключательПриоритет * 36 - 162;
            Kontur_P3ПереключательПриоритет.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = Kontur_P3Parameters.Kontur_P3ПереключательКонтроль * 36 - 180;
            Kontur_P3ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

        }

        private void InitializeTumblersPosition()
        {
            this.Kontur_P3ТумблерКонтроль.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерКонтроль == "Контроль1"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.Kontur_P3ТумблерМткПУ.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерМткПУ == "МТК"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.Kontur_P3ТумблерДокументирование.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерДокументирование == "Откл"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.Kontur_P3ТумблерАсинхрСинхр.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерАсинхрСинхр == "Синхр"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.Kontur_P3ТумблерРежим.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерРежим == "Режим1"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.Kontur_P3ТумблерСеть.BackgroundImage = Kontur_P3Parameters.Kontur_P3ТумблерСеть == "Вкл"
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;
        }
    }
}