//-----------------------------------------------------------------------
// <copyright file="WattmeterForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Wattmeter
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    using System.Reflection;

    /// <summary>
    /// Форма блока ватметр
    /// </summary>
    public partial class WattmeterForm : Form
    {
        private static bool isManipulation = false;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="WattmeterForm"/>
        /// </summary>
        public WattmeterForm()
        {
            this.InitializeComponent();
            InitializeTogglesPosition();
        }

        /// <summary>
        /// Установка переключателей в положение последней их установки
        /// </summary>
        private void InitializeTogglesPosition()
        {
            foreach (Control item in WattmeterPanel.Controls)
            {
                if (item.Name.Contains("РежимРаботы"))
                {
                    PropertyInfo[] fieldList = typeof(WattmeterParameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            var angle = System.Convert.ToInt32(property.GetValue(null)) * 30 - 105;
                            item.BackgroundImage = TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
                            break;
                        }
                    }
                }
                else
                    if (item.Name.Contains("Переключатель"))
                    {
                        PropertyInfo[] fieldList = typeof(WattmeterParameters).GetProperties();
                        foreach (PropertyInfo property in fieldList)
                        {
                            if (item.Name == property.Name)
                            {
                                item.BackgroundImage = TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, System.Convert.ToInt32(property.GetValue(null)));
                                break;
                            }
                        }
                    }
            }
        }

        private void ВаттметрПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WattmeterParameters.ВаттметрПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                WattmeterParameters.ВаттметрПереключательРежимРаботы -= 1;
            }

            var angle = WattmeterParameters.ВаттметрПереключательРежимРаботы * 30 - 105;
            ВаттметрПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        #region ВаттметрПереключательГрубо
        private void ВаттметрПереключательГрубо_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void ВаттметрПереключательГрубо_MouseUp(object sender, MouseEventArgs e)
        {
            isManipulation = false;
        }

        private void ВаттметрПереключательГрубо_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            WattmeterParameters.ВаттметрПереключательГрубо = angle;
            ВаттметрПереключательГрубо.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, WattmeterParameters.ВаттметрПереключательГрубо);
        }
        #endregion

        #region ВаттметрПереключательТочно
        private void ВаттметрПереключательТочно_MouseUp(object sender, MouseEventArgs e)
        {
            isManipulation = false;
        }

        private void ВаттметрПереключательТочно_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void ВаттметрПереключательТочно_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            WattmeterParameters.ВаттметрПереключательТочно = angle;
            ВаттметрПереключательТочно.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, WattmeterParameters.ВаттметрПереключательТочно);
        }
        #endregion

        #region ВаттметрПереключательКоррекция
        private void ВаттметрПереключательКоррекция_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void ВаттметрПереключательКоррекция_MouseUp(object sender, MouseEventArgs e)
        {
            isManipulation = false;
        }

        private void ВаттметрПереключательКоррекция_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            WattmeterParameters.ВаттметрПереключательКоррекция = angle;
            ВаттметрПереключательКоррекция.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, WattmeterParameters.ВаттметрПереключательКоррекция);
        }
        #endregion

    }
}