﻿namespace R440O.R440OForms.A205M_1
{
    using System.Windows.Forms;
    using ThirdParty;

    /// <summary>
    /// Форма блока А205М-1
    /// </summary>
    public partial class A205M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A205M_1Form"/>.
        /// </summary>
        public A205M_1Form()
        {
            this.InitializeComponent();
            A205M_1Parameters.RefreshForm += RefreshFrom;
            RefreshFrom();
        }

        private void RefreshFrom()
        {
            ИндикаторКонтроль.Invalidate();

            ТумблерКЭД.BackgroundImage = A205M_1Parameters.ТумблерКЭД
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
            
            var angle = A205M_1Parameters.ПереключательВолнаX10000 * 35 - 90;
            ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВолнаX1000 * 35 - 160;
            ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВолнаX100 * 35 - 160;
            ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВолнаX10 * 35 - 160;
            ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВолнаX1 * 35 - 160;
            ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательКонтроль * 30 - 180;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВидРаботы * 30 - 75;
            ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.ПереключательВходЧТ * 30 - 60;
            ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            ЛампочкаНормРаб.BackgroundImage = A205M_1Parameters.ЛампочкаНормРаб
                ? ControlElementImages.lampType13OnGreen
                : null;
        }

        private void A205M_1ПереключательКЭД_Click(object sender, System.EventArgs e)
        {
            A205M_1Parameters.ТумблерКЭД = ! A205M_1Parameters.ТумблерКЭД;
        }

        #region Отображение на дисплее текущей выбранной волны
        private void A205M_1КнопкаОтсчет_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаОтсчет.BackgroundImage = null;
            Дисплей.Text = A205M_1Parameters.ПереключательВолнаX10000 + "  " +
                                  A205M_1Parameters.ПереключательВолнаX1000 + "  " +
                                  A205M_1Parameters.ПереключательВолнаX100 + "  " +
                                  A205M_1Parameters.ПереключательВолнаX10 + "  " +
                                  A205M_1Parameters.ПереключательВолнаX1;

        }

        private void A205M_1КнопкаОтсчет_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаОтсчет.BackgroundImage = ControlElementImages.buttonRoundType6;
            Дисплей.Text = string.Empty;
        } 
        #endregion

        #region Установка переключателей волны
        private void A205M_1ПереключательВолнаX10000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВолнаX10000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВолнаX10000 -= 1;
            }
        }

        private void A205M_1ПереключательВолнаX1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВолнаX1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВолнаX1000 -= 1;
            }
        }

        private void A205M_1ПереключательВолнаX100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВолнаX100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВолнаX100 -= 1;
            }
        }

        private void A205M_1ПереключательВолнаX10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВолнаX10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВолнаX10 -= 1;
            }
        }

        private void A205M_1ПереключательВолнаX1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВолнаX1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВолнаX1 -= 1;
            }
        } 
        #endregion

        #region Переключатели контроля, вида работы, входы чт
        private void A205M_1ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательКонтроль -= 1;
            }
        }

        private void A205M_1ПереключательВидРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВидРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВидРаботы -= 1;
            }
        }

        private void A205M_1ПереключательВходЧТ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.ПереключательВходЧТ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.ПереключательВходЧТ -= 1;
            }
        } 
        #endregion

        private void ИндикаторКонтроль_Paint(object sender, PaintEventArgs e)
        {
            switch (A205M_1Parameters.ИндикаторКонтроль)
            {
                case 0:
                    TransformImageHelper.DrawLine(e.Graphics, 10, 40, 60, 80);
                    break;
                case 27:
                    TransformImageHelper.DrawLine(e.Graphics, 65, 20, 60, 80);
                    break;
            }
        }
    }
}