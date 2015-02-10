//-----------------------------------------------------------------------
// <copyright file="N16Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.IO;
using R440O.Parameters;

namespace R440O.R440OForms.N16
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-16
    /// </summary>
    public partial class N16Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N16Form"/>
        /// </summary>
        public N16Form()
        {
            this.InitializeComponent();
            this.InitializeButtons();
        }

        private void InitializeButtons()
        {
            N16КнопкаВкл.BackgroundImage = !N16Parameters.N16КнопкаВкл
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
            N16КнопкаН12.BackgroundImage = !N16Parameters.N16КнопкаН12
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
            N16КнопкаН1.BackgroundImage = !N16Parameters.N16КнопкаН1
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
            N16КнопкаН2.BackgroundImage = !N16Parameters.N16КнопкаН2
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
            N16КнопкаАнтенна.BackgroundImage = !N16Parameters.N16КнопкаАнтенна
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
            N16КнопкаЭквивалент.BackgroundImage = !N16Parameters.N16КнопкаЭквивалент
                ? ControlElementImages.buttonSquareBlackLarge
                : null;
        }

        #region Тумблеры
        private void N16Тумблер_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (e.Button == MouseButtons.Left)
            {
                switch (button.Name)
                {
                    case "N16ТумблерУровень1":
                        {
                            N16Parameters.N16ТумблерУровень1++;
                            N16ТумблерУровень1.BackgroundImage = ControlElementImages.tumblerType6Up;
                        }
                        break;
                    case "N16ТумблерФаза":
                        {
                            N16Parameters.N16ТумблерФаза++;
                            N16ТумблерФаза.BackgroundImage = ControlElementImages.tumblerType6Up;
                        }
                        break;
                    case "N16ТумблерУровень2":
                        {
                            N16Parameters.N16ТумблерУровень2++;
                            N16ТумблерУровень2.BackgroundImage = ControlElementImages.tumblerType6Up;
                        }
                        break;
                }
                
            }
            if (e.Button == MouseButtons.Right)
            {
                switch (button.Name)
                {
                    case "N16ТумблерУровень1":
                        {
                            N16Parameters.N16ТумблерУровень1--;
                            N16ТумблерУровень1.BackgroundImage = ControlElementImages.tumblerType6Down;
                        }
                        break;
                    case "N16ТумблерФаза":
                        {
                            N16Parameters.N16ТумблерФаза--;
                            N16ТумблерФаза.BackgroundImage = ControlElementImages.tumblerType6Down;
                        }
                        break;
                    case "N16ТумблерУровень2":
                        {
                            N16Parameters.N16ТумблерУровень2--;
                            N16ТумблерУровень2.BackgroundImage = ControlElementImages.tumblerType6Down;
                        }
                        break;
                }
            }
        }

        private void N16Тумблер_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "N16ТумблерУровень1":
                    {
                        N16Parameters.N16ТумблерУровень1 = 0;
                        N16ТумблерУровень1.BackgroundImage = null;
                    }
                    break;
                case "N16ТумблерФаза":
                    {
                        N16Parameters.N16ТумблерФаза = 0;
                        N16ТумблерФаза.BackgroundImage = null;
                    }
                    break;
                case "N16ТумблерУровень2":
                    {
                        N16Parameters.N16ТумблерУровень2 = 0;
                        N16ТумблерУровень2.BackgroundImage = null;
                    }
                    break;
            }
        } 
        #endregion

        #region Кнопки ВклОткл
        private void N16КнопкаВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            N16Parameters.N16КнопкаВкл = false;
            N16КнопкаВыкл.BackgroundImage = null;
            N16КнопкаВкл.BackgroundImage = ControlElementImages.buttonSquareBlackLarge;
        }

        private void N16КнопкаВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            N16КнопкаВыкл.BackgroundImage = ControlElementImages.buttonSquareRedLarge;
        }

        private void N16КнопкаВкл_MouseDown(object sender, MouseEventArgs e)
        {
            N16КнопкаВкл.BackgroundImage = null;
            N16Parameters.N16КнопкаВкл = true;
        }
        #endregion

        private void N16Кнопка_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "N16КнопкаН12":
                {
                    N16Parameters.N16КнопкаН12 = !N16Parameters.N16КнопкаН12;
                    N16КнопкаН12.BackgroundImage = !N16Parameters.N16КнопкаН12
                        ? ControlElementImages.buttonSquareBlackLarge
                        : null;
                }
                    break;
                case "N16КнопкаН1":
                {
                    N16Parameters.N16КнопкаН1 = !N16Parameters.N16КнопкаН1;
                    N16КнопкаН1.BackgroundImage = !N16Parameters.N16КнопкаН1
                        ? ControlElementImages.buttonSquareBlackLarge
                        : null;
                }
                    break;
                case "N16КнопкаН2":
                {
                    N16Parameters.N16КнопкаН2 = !N16Parameters.N16КнопкаН2;
                    N16КнопкаН2.BackgroundImage = !N16Parameters.N16КнопкаН2
                        ? ControlElementImages.buttonSquareBlackLarge
                        : null;
                }
                    break;
                case "N16КнопкаАнтенна":
                {
                    N16Parameters.N16КнопкаАнтенна = !N16Parameters.N16КнопкаАнтенна;
                    N16КнопкаАнтенна.BackgroundImage = !N16Parameters.N16КнопкаАнтенна
                        ? ControlElementImages.buttonSquareBlackLarge
                        : null;
                }
                    break;
                case "N16КнопкаЭквивалент":
                {
                    N16Parameters.N16КнопкаЭквивалент = !N16Parameters.N16КнопкаЭквивалент;
                    N16КнопкаЭквивалент.BackgroundImage = !N16Parameters.N16КнопкаЭквивалент
                        ? ControlElementImages.buttonSquareBlackLarge
                        : null;
                }
                    break;
            }
        }
    }
}