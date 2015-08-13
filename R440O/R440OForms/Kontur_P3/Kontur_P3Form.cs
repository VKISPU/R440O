//-----------------------------------------------------------------------
// <copyright file="Kontur_P3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Kontur_P3
{
    using System.Windows.Forms;
    using BaseClasses;
    using ThirdParty;
    using СостоянияЭлементов.Контур_П;
    using Параметры;

    /// <summary>
    /// Форма блока Контур-П3
    /// </summary>
    public partial class Kontur_P3Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Kontur_P3Form"/>
        /// </summary>
        public Kontur_P3Form()
        {
            this.InitializeComponent();
            Kontur_P3Parameters.RefreshForm += RefreshElements;
            RefreshElements();
        }

        #region Переключатели
        private void Kontur_P3ПереключательПриоритет_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Kontur_P3Parameters.ПереключательПриоритет += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Kontur_P3Parameters.ПереключательПриоритет -= 1;
            }
        }

        private void Kontur_P3ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Kontur_P3Parameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Kontur_P3Parameters.ПереключательКонтроль -= 1;
            }
        }
        #endregion

        #region Тумблеры

        private void Kontur_P3ТумблерКонтроль_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерКонтроль = Kontur_P3Parameters.ТумблерКонтроль == EТумблерКонтроль.КОНТРОЛЬ_1
                ? EТумблерКонтроль.КОНТРОЛЬ_2
                : EТумблерКонтроль.КОНТРОЛЬ_1;
        }

        private void Kontur_P3ТумблерМткПУ_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерМткПУ = Kontur_P3Parameters.ТумблерМткПУ == EТумблерМткПУ.МТК
                ? EТумблерМткПУ.ПУ
                : EТумблерМткПУ.МТК;
        }

        private void Kontur_P3ТумблерДокументирование_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерДокументирование = Kontur_P3Parameters.ТумблерДокументирование ==
                                                          EТумблерДокументирование.ОТКЛ
                ? EТумблерДокументирование.ВКЛ
                : EТумблерДокументирование.ОТКЛ;
        }

        private void Kontur_P3ТумблерАсинхрСинхр_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерАсинхрСинхр = Kontur_P3Parameters.ТумблерАсинхрСинхр == EТумблерАсинхрСинхр.СИНХР
                ? EТумблерАсинхрСинхр.АСИНХР
                : EТумблерАсинхрСинхр.СИНХР;
        }

        private void Kontur_P3ТумблерРежим_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерРежим = Kontur_P3Parameters.ТумблерРежим == EТумблерРежим.РЕЖИМ_1
                ? EТумблерРежим.РЕЖИМ_2
                : EТумблерРежим.РЕЖИМ_1;
        }

        private void Kontur_P3ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            Kontur_P3Parameters.ТумблерСеть = Kontur_P3Parameters.ТумблерСеть == EТумблерСеть.ОТКЛ
                ? EТумблерСеть.ВКЛ
                : EТумблерСеть.ОТКЛ;
        }

        #endregion

        #region Круглые кнопки

        private void Kontur_P3КнопкаКП1Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКП1Контроль.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКП1Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКП1Контроль.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        #region КП2
        private void Kontur_P3КнопкаСдвиг1_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаСдвиг1.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаСдвиг1_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаСдвиг1.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаСдвиг10_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаСдвиг10.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаСдвиг10_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаСдвиг10.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаНачИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНачИнформ.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаНачИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНачИнформ.BackgroundImage = ControlElementImages.buttonRoundType8;
        } 
        #endregion

        #region КП3
        private void Kontur_P3КнопкаКан10_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКан10.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан10_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКан10.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКан11_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКан11.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан11_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКан11.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void Kontur_P3КнопкаКан12_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКан12.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКан12_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКан12.BackgroundImage = ControlElementImages.buttonRoundType8;
        } 
        #endregion

        private void Kontur_P3КнопкаКП4Контроль_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКП4Контроль.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКП4Контроль_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКП4Контроль.BackgroundImage = ControlElementImages.buttonRoundType8;
        }


        private void Kontur_P3КнопкаПуск_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаПуск.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаПуск_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаПуск.BackgroundImage = ControlElementImages.buttonRoundType8;
        }
        #endregion

        #region Квадратные кнопки

        #region Адрес
        private void Kontur_P3КнопкаАдресУСС_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаАдресУСС.BackgroundImage = null;
            КнопкаАдресУСС.Text = null;
        }

        private void Kontur_P3КнопкаАдресУСС_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаАдресУСС.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            КнопкаАдресУСС.Text = "УСС";
        }

        private void Kontur_P3КнопкаАдресК_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Parameters.КнопкаАдресК = !Kontur_P3Parameters.КнопкаАдресК;
        }

        private void Kontur_P3КнопкаАдресК_MouseUp(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region Подпись
        private void Kontur_P3КнопкаПодпись1_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Parameters.КнопкаПодпись1 = !Kontur_P3Parameters.КнопкаПодпись1;
        }

        private void Kontur_P3КнопкаПодпись1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Kontur_P3КнопкаПодпись2_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Parameters.КнопкаПодпись2 = !Kontur_P3Parameters.КнопкаПодпись2;
        }

        private void Kontur_P3КнопкаПодпись2_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Kontur_P3КнопкаПодпись3_MouseDown(object sender, MouseEventArgs e)
        {
            Kontur_P3Parameters.КнопкаПодпись3 = !Kontur_P3Parameters.КнопкаПодпись3;
        }

        private void Kontur_P3КнопкаПодпись3_MouseUp(object sender, MouseEventArgs e)
        {
        }  
        #endregion

        #region Группа
        private void Kontur_P3КнопкаГруппа_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаГруппа.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаГруппа_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаГруппа.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОбщийС_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаОбщийС.BackgroundImage = null;
            КнопкаОбщийС.Text = null;
        }

        private void Kontur_P3КнопкаОбщийС_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаОбщийС.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            КнопкаОбщийС.Text = "C";
        } 
        #endregion

        #region Передача
        private void Kontur_P3КнопкаВызов_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВызов.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаВызов_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВызов.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОтбой_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаОтбой.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаОтбой_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаОтбой.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаИнформ_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаИнформ.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаИнформ_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаИнформ.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаНаборКК_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКК.BackgroundImage = null;
            КнопкаНаборКК.Text = null;
        }

        private void Kontur_P3КнопкаНаборКК_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКК.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            КнопкаНаборКК.Text = "ПРМ";
        }

        private void Kontur_P3КнопкаКонтрольЗанятости_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаКонтрольЗанятости.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаКонтрольЗанятости_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаКонтрольЗанятости.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        }

        private void Kontur_P3КнопкаОтклЗС_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаОтклЗС.BackgroundImage = null;
        }

        private void Kontur_P3КнопкаОтклЗС_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаОтклЗС.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
        } 
        #endregion

        #region от 0 до 9
        private void Kontur_P3Кнопка7_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка7.BackgroundImage = null;
            Кнопка7.Text = null;
        }

        private void Kontur_P3Кнопка7_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка7.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка7.Text = " 7";
        }

        private void Kontur_P3Кнопка8_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка8.BackgroundImage = null;
            Кнопка8.Text = null;
        }

        private void Kontur_P3Кнопка8_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка8.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка8.Text = " 8";
        }

        private void Kontur_P3Кнопка9_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка9.BackgroundImage = null;
            Кнопка9.Text = null;
        }

        private void Kontur_P3Кнопка9_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка9.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка9.Text = " 9";
        }

        private void Kontur_P3Кнопка4_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка4.BackgroundImage = null;
            Кнопка4.Text = null;
        }

        private void Kontur_P3Кнопка4_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка4.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка4.Text = " 4";
        }

        private void Kontur_P3Кнопка5_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка5.BackgroundImage = null;
            Кнопка5.Text = null;
        }

        private void Kontur_P3Кнопка5_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка5.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка5.Text = " 5";
        }

        private void Kontur_P3Кнопка6_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка6.BackgroundImage = null;
            Кнопка6.Text = null;
        }

        private void Kontur_P3Кнопка6_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка6.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка6.Text = " 6";
        }

        private void Kontur_P3Кнопка1_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка1.BackgroundImage = null;
            Кнопка1.Text = null;
        }

        private void Kontur_P3Кнопка1_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка1.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка1.Text = " 1";
        }

        private void Kontur_P3Кнопка2_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка2.BackgroundImage = null;
            Кнопка2.Text = null;
        }

        private void Kontur_P3Кнопка2_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка2.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка2.Text = " 2";
        }

        private void Kontur_P3Кнопка3_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка3.BackgroundImage = null;
            Кнопка3.Text = null;
        }

        private void Kontur_P3Кнопка3_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка3.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка3.Text = " 3";
        }

        private void Kontur_P3Кнопка0_MouseDown(object sender, MouseEventArgs e)
        {
            Кнопка0.BackgroundImage = null;
            Кнопка0.Text = null;
        }

        private void Kontur_P3Кнопка0_MouseUp(object sender, MouseEventArgs e)
        {
            Кнопка0.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
            Кнопка0.Text = " 0";
        }

        private void Kontur_P3КнопкаИнформКОН_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаИнформКОН.BackgroundImage = null;
            КнопкаИнформКОН.Text = null;
        }

        private void Kontur_P3КнопкаИнформКОН_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаИнформКОН.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            КнопкаИнформКОН.Text = "КОН";
        }

        private void Kontur_P3КнопкаИнформС_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаИнформС.BackgroundImage = null;
            КнопкаИнформС.Text = null;
        }

        private void Kontur_P3КнопкаИнформС_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаИнформС.BackgroundImage = ControlElementImages.buttonSquareRed_small;
            КнопкаИнформС.Text = "С";
        } 
        #endregion

        #endregion

        #region Обновление формы
        private void InitializeButtonsPosition()
        {
            if (Kontur_P3Parameters.КнопкаАдресК)
            {
                КнопкаАдресК.BackgroundImage = null;
                КнопкаАдресК.Text = null;
            }
            else
            {
                КнопкаАдресК.BackgroundImage = ControlElementImages.buttonSquareBlack_small;
                КнопкаАдресК.Text = "К";
            }
            if (Kontur_P3Parameters.КнопкаПодпись1)
            {
                КнопкаПодпись1.BackgroundImage = null;
                КнопкаПодпись1.Text = null;
            }
            else
            {

                КнопкаПодпись1.BackgroundImage = ControlElementImages.buttonSquareRed_small;
                КнопкаПодпись1.Text = "1";
            }
            if (Kontur_P3Parameters.КнопкаПодпись2)
            {
                КнопкаПодпись2.BackgroundImage = null;
                КнопкаПодпись2.Text = null;
            }
            else
            {

                КнопкаПодпись2.BackgroundImage = ControlElementImages.buttonSquareRed_small;
                КнопкаПодпись2.Text = "2";
            }
            if (Kontur_P3Parameters.КнопкаПодпись3)
            {
                КнопкаПодпись3.BackgroundImage = null;
                КнопкаПодпись3.Text = null;
            }
            else
            {

                КнопкаПодпись3.BackgroundImage = ControlElementImages.buttonSquareRed_small;
                КнопкаПодпись3.Text = "3";
            }
        }

        private void InitializeTogglesPosition()
        {
            var angle = (int)Kontur_P3Parameters.ПереключательПриоритет * 36 - 162;
            ПереключательПриоритет.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = (int)Kontur_P3Parameters.ПереключательКонтроль * 36 - 180;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

        }

        private void InitializeTumblersPosition()
        {
            this.ТумблерКонтроль.BackgroundImage = Kontur_P3Parameters.ТумблерКонтроль == EТумблерКонтроль.КОНТРОЛЬ_1
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.ТумблерМткПУ.BackgroundImage = Kontur_P3Parameters.ТумблерМткПУ == EТумблерМткПУ.МТК
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;

            this.ТумблерДокументирование.BackgroundImage = Kontur_P3Parameters.ТумблерДокументирование == EТумблерДокументирование.ОТКЛ
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.ТумблерАсинхрСинхр.BackgroundImage = Kontur_P3Parameters.ТумблерАсинхрСинхр == EТумблерАсинхрСинхр.СИНХР
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.ТумблерРежим.BackgroundImage = Kontur_P3Parameters.ТумблерРежим == EТумблерРежим.РЕЖИМ_1
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;

            this.ТумблерСеть.BackgroundImage = Kontur_P3Parameters.ТумблерСеть == EТумблерСеть.ОТКЛ
               ? ControlElementImages.tumblerType4Down
               : ControlElementImages.tumblerType4Up;
        }

        public void RefreshElements()
        {
            InitializeButtonsPosition();
            InitializeTogglesPosition();
            InitializeTumblersPosition();

            var angle = (int)Kontur_P3Parameters.ПереключательПриоритет * 36 - 162;
            ПереключательПриоритет.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = (int)Kontur_P3Parameters.ПереключательКонтроль * 36 - 180;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }
        #endregion
    }
}