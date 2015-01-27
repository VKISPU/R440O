//-----------------------------------------------------------------------
// <copyright file="K03M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.K03M_01
{
    using System.Windows.Forms;
    using K03M_01Inside;

    /// <summary>
    /// Форма блока К03-М-1
    /// </summary>
    public partial class K03M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K03M_01Form"/>
        /// </summary>
        public K03M_01Form()
        {
            this.InitializeComponent();
            this.InitializeLamps();
            this.InitializeTumblers();
        }

        #region Инициализация
        private void InitializeTumblers()
        {
            foreach (Control item in K03M_01Panel.Controls)
            {
                var fieldList = typeof(K03M_01Parameters).GetFields();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    if (item.Name.Contains("K03M_01Переключатель"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.tumblerType3Up
                            : ControlElementImages.tumblerType3Down;
                    }
                }
            }
            var angle = K03M_01Parameters.K03M_01ПереключательНапряжение * 30 - 75;
            K03M_01ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeLamps()
        {
            foreach (Control item in K03M_01Panel.Controls)
            {
                var fieldList = typeof(K03M_01Parameters).GetFields();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    if (item.Name.Contains("K03M_01Лампочка"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.lampType9OnGreen
                            : null;
                    }
                }
            }
        } 
        #endregion

        #region Крышки
        /// <summary>
        /// Снятие крышки на форме блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_01Крышка_Click(object sender, System.EventArgs e)
        {
            K03M_01Крышка.Visible = false;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K03M_01InsideForm();
            thisForm.Show(this);
        } 
        #endregion

        #region Переключатели
        /// <summary>
        /// Для переключателей ввода данных с АПН
        /// </summary>
        private void K03M_01Переключатель0_Click(object sender, System.EventArgs e)
        {
            var item = sender as Button;
            var fieldList = typeof(K03M_01Parameters).GetFields();
            foreach (var property in fieldList.Where(property => item.Name == property.Name))
            {
                property.SetValue(null, !(bool)property.GetValue(null));
                if (item.Name.Contains("K03M_01Переключатель"))
                {
                    item.BackgroundImage = (bool)property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }
        } 
        #endregion

        #region Кнопки
        private void K03M_01Кнопка_MouseDown(object sender, MouseEventArgs e)
        {
            var item = sender as Button;
            item.BackgroundImage = null;
        }

        private void K03M_01Кнопка_MouseUp(object sender, MouseEventArgs e)
        {
            var item = sender as Button;
            item.BackgroundImage = ControlElementImages.buttonRoundType5;
        }
        #endregion

        private void K03M_01ПереключательНапряжение_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                K03M_01Parameters.K03M_01ПереключательНапряжение += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                K03M_01Parameters.K03M_01ПереключательНапряжение -= 1;
            }
            var angle = K03M_01Parameters.K03M_01ПереключательНапряжение * 30 - 75;
            K03M_01ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
    }
}