﻿//-----------------------------------------------------------------------
// <copyright file="K05M_01Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.K05M_01Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Внутренняя часть блока К05-М-1
    /// </summary>
    public partial class K05M_01InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K05M_01InsideForm"/>
        /// </summary>
        public K05M_01InsideForm()
        {
            this.InitializeComponent();
            this.InitializeTumblers();
        }

        /// <summary>
        /// Закрытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K05M_01InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void InitializeTumblers()
        {
            foreach (Control item in K05M_01InsidePanel.Controls)
            {
                if (item.Name.Contains("K05M_01InsideПереключатель"))
                {
                    var index = Convert.ToInt32(item.Name.Substring(item.Name.IndexOf("K05M_01InsideПереключатель") +
                                                                    "K05M_01InsideПереключатель".Length));
                    var angle = K05M_01InsideParameters.K05M_01InsideПереключатель[index] * 30 - 10;
                    item.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                        ControlElementImages.toggleType2, angle);
                }
                if (item.Name.Contains("K05M_01InsideТумблер"))
                {
                    var index = Convert.ToInt32(item.Name.Substring(item.Name.IndexOf("K05M_01InsideТумблер") +
                                                                    "K05M_01InsideТумблер".Length));
                    item.BackgroundImage = (K05M_01InsideParameters.K05M_01InsideПереключатель[index] == 0)
                        ? ControlElementImages.tumblerType3Left
                        : ControlElementImages.tumblerType3Right;
                }
            }
        }

        private void K05M_01InsideПереключатель_MouseDown(object sender, MouseEventArgs e)
        {
            var item = sender as Button;
            var index = Convert.ToInt32(item.Name.Substring(item.Name.IndexOf("K05M_01InsideПереключатель") +
                                                            "K05M_01InsideПереключатель".Length));
            var property = typeof(K05M_01Parameters).GetProperty(item.Name);
            if (e.Button == MouseButtons.Left)
            {
                K05M_01InsideParameters.K05M_01InsideПереключатель[index] += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                K05M_01InsideParameters.K05M_01InsideПереключатель[index] -= 1;
            }

            var angle = K05M_01InsideParameters.K05M_01InsideПереключатель[index] * 30 - 10;
            item.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                ControlElementImages.toggleType2, angle);
        }

        private void K05M_01InsideТумблер_MouseDown(object sender, MouseEventArgs e)
        {
            var item = sender as Button;
            var index = Convert.ToInt32(item.Name.Substring(item.Name.IndexOf("K05M_01InsideТумблер") +
                                                            "K05M_01InsideТумблер".Length));
            if (e.Button == MouseButtons.Left)
            {
                if (K05M_01InsideParameters.K05M_01InsideПереключатель[index] == 0)
                    K05M_01InsideParameters.K05M_01InsideПереключатель[index] = 1;
                else K05M_01InsideParameters.K05M_01InsideПереключатель[index] = 0;
            }
            if (item.Name.Contains("K05M_01InsideТумблер"))
            {
                item.BackgroundImage = (K05M_01InsideParameters.K05M_01InsideПереключатель[index] == 0)
                    ? ControlElementImages.tumblerType3Left
                    : ControlElementImages.tumblerType3Right;
            }
        }
    }
}