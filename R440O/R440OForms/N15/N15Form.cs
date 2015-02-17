//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Threading.Tasks;
using R440O.R440OForms.N15Inside;

namespace R440O.R440OForms.N15
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using Parameters;
    using System.Reflection;

    /// <summary>
    /// Форма блока Н-15
    /// </summary>
    public partial class N15Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N15Form"/>
        /// </summary>
        public N15Form()
        {
            this.InitializeComponent();
        }

        #region Локальные свойства
        ////Тумблеры
        private static string локН15ТумблерЦ300М1 { get; set; }
        private static string локН15ТумблерЦ300М2 { get; set; }
        private static string локН15ТумблерЦ300М3 { get; set; }
        private static string локН15ТумблерЦ300М4 { get; set; }
        private static string локН15ТумблерН12С { get; set; }
        private static string локН15ТумблерМШУ { get; set; }
        private static string локН15ТумблерБМА_1 { get; set; }
        private static string локН15ТумблерБМА_2 { get; set; }
        private static string локН15ТумблерА205 { get; set; }
        private static string локН15ТумблерА20512 { get; set; }
        private static string локН15ТумблерАФСС { get; set; }
        private static string локН15ТумблерА1 { get; set; }
        private static string локН15ТумблерА403 { get; set; }
        private static string локН15ТумблерК1_1 { get; set; }
        private static string локН15ТумблерК1_2 { get; set; }
        private static string локН15ТумблерБ1_1 { get; set; }
        private static string локН15ТумблерБ1_2 { get; set; }
        private static string локН15ТумблерБ2_1 { get; set; }
        private static string локН15ТумблерБ2_2 { get; set; }
        private static string локН15ТумблерБ3_1 { get; set; }
        private static string локН15ТумблерБ3_2 { get; set; }
        private static string локН15ТумблерДАБ_5 { get; set; }
        private static string локН15ТумблерР_Н { get; set; }
        private static string локН15ТумблерАнтЭкв { get; set; }
        private static string локН15ТумблерТлфТлгПрм { get; set; }
        private static string локН15ТумблерТлфТлгПрд { get; set; }
        ////Кнопки
        private static string локН15КнопкаН13_1 { get; set; }
        private static string локН15КнопкаН13_2 { get; set; }
        private static string локН15КнопкаН13_12 { get; set; }
        #endregion

        private void Н15КнопкаСтанцияВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = ControlElementImages.buttonN15On;

            #region Н15ТумблерЦ300М1
            N15Parameters.Н15ТумблерЦ300М1 = локН15ТумблерЦ300М1;
            if (N15Parameters.Н15ТумблерЦ300М1 == "true")
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл1 = "true";
                this.Н15ЛампочкаЦ300МВкл1.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл1 = "false";
                this.Н15ЛампочкаЦ300МВкл1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерЦ300М2
            N15Parameters.Н15ТумблерЦ300М2 = локН15ТумблерЦ300М2;
            if (N15Parameters.Н15ТумблерЦ300М2 == "true")
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл2 = "true";
                this.Н15ЛампочкаЦ300МВкл2.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл2 = "false";
                this.Н15ЛампочкаЦ300МВкл2.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерЦ300М3
            N15Parameters.Н15ТумблерЦ300М3 = локН15ТумблерЦ300М3;
            if (N15Parameters.Н15ТумблерЦ300М3 == "true")
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл3 = "true";
                this.Н15ЛампочкаЦ300МВкл3.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл3 = "false";
                this.Н15ЛампочкаЦ300МВкл3.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерЦ300М4
            N15Parameters.Н15ТумблерЦ300М4 = локН15ТумблерЦ300М4;
            if (N15Parameters.Н15ТумблерЦ300М4 == "true")
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл4 = "true";
                this.Н15ЛампочкаЦ300МВкл4.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаЦ300МВкл4 = "false";
                this.Н15ЛампочкаЦ300МВкл4.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерН12С
            N15Parameters.Н15ТумблерН12С = локН15ТумблерН12С;
            if (N15Parameters.Н15ТумблерН12С == "true")
            {
                N15Parameters.Н15ЛампочкаН12С = "true";
                this.Н15ЛампочкаН12С.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаН12С = "false";
                this.Н15ЛампочкаН12С.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерМШУ
            N15Parameters.Н15ТумблерМШУ = локН15ТумблерМШУ;
            
            if (N15Parameters.Н15ТумблерМШУ == "true")
            {
                N15Parameters.Н15ЛампочкаА306 = "true";
                this.Н15ЛампочкаА306.BackgroundImage = ControlElementImages.lampType5OnRed;

                N15Parameters.Н15ЛампочкаМШУ = "true";
                this.Н15ЛампочкаМШУ.BackgroundImage = ControlElementImages.lampType5OnRed;

                if (N15Parameters.Н15ТумблерА30412 == "1")
                {
                    N15Parameters.Н15ЛампочкаА3041 = "true";
                    this.Н15ЛампочкаА3041.BackgroundImage = ControlElementImages.lampType5OnRed;
                }
                else
                    if (N15Parameters.Н15ТумблерА30412 == "2")
                    {
                        N15Parameters.Н15ЛампочкаА3042 = "true";
                        this.Н15ЛампочкаА3042.BackgroundImage = ControlElementImages.lampType5OnRed;
                    }
            }
            else
            {
                N15Parameters.Н15ЛампочкаМШУ = "false";
                this.Н15ЛампочкаМШУ.BackgroundImage = null;

                N15Parameters.Н15ЛампочкаА306 = "false";
                this.Н15ЛампочкаА306.BackgroundImage = null;

                if (N15Parameters.Н15ЛампочкаА3041 == "true")
                {
                    N15Parameters.Н15ЛампочкаА3041 = "false";
                    this.Н15ЛампочкаА3041.BackgroundImage = null;
                }
                else
                    if (N15Parameters.Н15ЛампочкаА3042 == "true")
                    {
                        N15Parameters.Н15ЛампочкаА3042 = "false";
                        this.Н15ЛампочкаА3042.BackgroundImage = null;
                    }
            }

            if (this.A30412StateChange != null)
            {
                this.A30412StateChange();
            }
            #endregion

            #region Н15ТумблерБМА_1
            N15Parameters.Н15ТумблерБМА_1 = локН15ТумблерБМА_1;
            if (N15Parameters.Н15ТумблерБМА_1 == "true")
            {
                N15Parameters.Н15ЛампочкаБМА_1 = "true";
                this.Н15ЛампочкаБМА_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБМА_1 = "false";
                this.Н15ЛампочкаБМА_1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБМА_2
            N15Parameters.Н15ТумблерБМА_2 = локН15ТумблерБМА_2;
            if (N15Parameters.Н15ТумблерБМА_2 == "true")
            {
                N15Parameters.Н15ЛампочкаБМА_2 = "true";
                this.Н15ЛампочкаБМА_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБМА_2 = "false";
                this.Н15ЛампочкаБМА_2.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерА205 and Н15ТумблерА20512
            N15Parameters.Н15ТумблерА205 = локН15ТумблерА205;
            N15Parameters.Н15ТумблерА20512 = локН15ТумблерА20512;
            if (N15Parameters.Н15ТумблерА205 == "true")
            {
                if (N15Parameters.Н15ТумблерА20512 == "1")
                {
                    N15Parameters.Н15ЛампочкаППВВкл1 = "true";
                    this.Н15ЛампочкаППВВкл1.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.Н15ЛампочкаППВРабота1 = "true";
                    this.Н15ЛампочкаППВРабота1.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.Н15ЛампочкаУМ1Работа1 = "true";
                    this.Н15ЛампочкаУМ1Работа1.BackgroundImage = ControlElementImages.lampType8OnRed;

                    N15Parameters.Н15ЛампочкаППВВкл2 = "false";
                    this.Н15ЛампочкаППВВкл2.BackgroundImage = null;
                    N15Parameters.Н15ЛампочкаППВРабота2 = "false";
                    this.Н15ЛампочкаППВРабота2.BackgroundImage = null;
                    N15Parameters.Н15ЛампочкаУМ1Работа2 = "false";
                    this.Н15ЛампочкаУМ1Работа2.BackgroundImage = null;
                }
                else
                {
                    N15Parameters.Н15ЛампочкаППВВкл2 = "true";
                    this.Н15ЛампочкаППВВкл2.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.Н15ЛампочкаППВРабота2 = "true";
                    this.Н15ЛампочкаППВРабота2.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.Н15ЛампочкаУМ1Работа2 = "true";
                    this.Н15ЛампочкаУМ1Работа2.BackgroundImage = ControlElementImages.lampType8OnRed;

                    N15Parameters.Н15ЛампочкаППВВкл1 = "false";
                    this.Н15ЛампочкаППВВкл1.BackgroundImage = null;
                    N15Parameters.Н15ЛампочкаППВРабота1 = "false";
                    this.Н15ЛампочкаППВРабота1.BackgroundImage = null;
                    N15Parameters.Н15ЛампочкаУМ1Работа1 = "false";
                    this.Н15ЛампочкаУМ1Работа1.BackgroundImage = null;
                }
            }
            else
            {
                N15Parameters.Н15ЛампочкаППВВкл2 = "false";
                this.Н15ЛампочкаППВВкл2.BackgroundImage = null;
                N15Parameters.Н15ЛампочкаППВРабота2 = "false";
                this.Н15ЛампочкаППВРабота2.BackgroundImage = null;
                N15Parameters.Н15ЛампочкаУМ1Работа2 = "false";
                this.Н15ЛампочкаУМ1Работа2.BackgroundImage = null;

                N15Parameters.Н15ЛампочкаППВВкл1 = "false";
                this.Н15ЛампочкаППВВкл1.BackgroundImage = null;
                N15Parameters.Н15ЛампочкаППВРабота1 = "false";
                this.Н15ЛампочкаППВРабота1.BackgroundImage = null;
                N15Parameters.Н15ЛампочкаУМ1Работа1 = "false";
                this.Н15ЛампочкаУМ1Работа1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерАФСС
            N15Parameters.Н15ТумблерАФСС = локН15ТумблерАФСС;
            if (N15Parameters.Н15ТумблерАФСС == "true")
            {
                N15Parameters.Н15ЛампочкаАФСС = "true";
                this.Н15ЛампочкаАФСС.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаАФСС = "false";
                this.Н15ЛампочкаАФСС.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерА1
            N15Parameters.Н15ТумблерА1 = локН15ТумблерА1;
            if (N15Parameters.Н15ТумблерА1 == "true")
            {
                N15Parameters.Н15ЛампочкаА1 = "true";
                this.Н15ЛампочкаА1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаА1 = "false";
                this.Н15ЛампочкаА1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерА403
            N15Parameters.Н15ТумблерА403 = локН15ТумблерА403;
            if (N15Parameters.Н15ТумблерА403 == "true")
            {
                N15Parameters.Н15ЛампочкаА403Вкл = "true";
                this.Н15ЛампочкаА403Вкл.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаА403Вкл = "false";
                this.Н15ЛампочкаА403Вкл.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерК1_1
            N15Parameters.Н15ТумблерК1_1 = локН15ТумблерК1_1;
            #endregion

            #region Н15ТумблерК1_2
            N15Parameters.Н15ТумблерК1_2 = локН15ТумблерК1_2;
            #endregion

            #region Н15ТумблерБ1_1
            N15Parameters.Н15ТумблерБ1_1 = локН15ТумблерБ1_1;
            if (N15Parameters.Н15ТумблерБ1_1 == "true")
            {
                N15Parameters.Н15ЛампочкаБ1_1 = "true";
                this.Н15ЛампочкаБ1_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ1_1 = "false";
                this.Н15ЛампочкаБ1_1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБ1_2
            N15Parameters.Н15ТумблерБ1_2 = локН15ТумблерБ1_2;
            if (N15Parameters.Н15ТумблерБ1_2 == "true")
            {
                N15Parameters.Н15ЛампочкаБ1_2 = "true";
                this.Н15ЛампочкаБ1_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ1_2 = "false";
                this.Н15ЛампочкаБ1_2.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБ2_1
            N15Parameters.Н15ТумблерБ2_1 = локН15ТумблерБ2_1;
            if (N15Parameters.Н15ТумблерБ2_1 == "true")
            {
                N15Parameters.Н15ЛампочкаБ2_1 = "true";
                this.Н15ЛампочкаБ2_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ2_1 = "false";
                this.Н15ЛампочкаБ2_1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБ2_2
            N15Parameters.Н15ТумблерБ2_2 = локН15ТумблерБ2_2;
            if (N15Parameters.Н15ТумблерБ2_2 == "true")
            {
                N15Parameters.Н15ЛампочкаБ2_2 = "true";
                this.Н15ЛампочкаБ2_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ2_2 = "false";
                this.Н15ЛампочкаБ2_2.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБ3_1
            N15Parameters.Н15ТумблерБ3_1 = локН15ТумблерБ3_1;
            if (N15Parameters.Н15ТумблерБ3_1 == "true")
            {
                N15Parameters.Н15ЛампочкаБ3_1 = "true";
                this.Н15ЛампочкаБ3_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ3_1 = "false";
                this.Н15ЛампочкаБ3_1.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерБ3_2
            N15Parameters.Н15ТумблерБ3_2 = локН15ТумблерБ3_2;
            if (N15Parameters.Н15ТумблерБ3_2 == "true")
            {
                N15Parameters.Н15ЛампочкаБ3_2 = "true";
                this.Н15ЛампочкаБ3_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаБ3_2 = "false";
                this.Н15ЛампочкаБ3_2.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерДАБ_5
            N15Parameters.Н15ТумблерДАБ_5 = локН15ТумблерДАБ_5;
            if (N15Parameters.Н15ТумблерДАБ_5 == "true")
            {
                N15Parameters.Н15ЛампочкаДАБ_5 = "true";
                this.Н15ЛампочкаДАБ_5.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаДАБ_5 = "false";
                this.Н15ЛампочкаДАБ_5.BackgroundImage = null;
            }
            #endregion

            #region Н15ТумблерР_Н
            N15Parameters.Н15ТумблерР_Н = локН15ТумблерР_Н;
            if (N15Parameters.Н15ТумблерР_Н == "true")
            {
                N15Parameters.Н15ЛампочкаР_Н = "true";
                this.Н15ЛампочкаР_Н.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.Н15ЛампочкаР_Н = "false";
                this.Н15ЛампочкаР_Н.BackgroundImage = null;
            }
            #endregion

            N15Parameters.Н15ТумблерАнтЭкв = локН15ТумблерАнтЭкв;
            N15Parameters.Н15ТумблерТлфТлгПрм = локН15ТумблерТлфТлгПрм;
            N15Parameters.Н15ТумблерТлфТлгПрд = локН15ТумблерТлфТлгПрд;
            
            N15Parameters.Н15КнопкаН13_1 = локН15КнопкаН13_1;
            N15Parameters.Н15КнопкаН13_2 = локН15КнопкаН13_2;
            N15Parameters.Н15КнопкаН13_12 = локН15КнопкаН13_12;
        }

        #region Кнопка Выкл
        private void Н15КнопкаСтанцияВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = ControlElementImages.buttonN15Off;
            N15Parameters.Н15КнопкаСтанцияВыкл = "true";
        }
        #endregion

        #region Кнопки ПРМ НАВЕДЕНИЕ/Ц300М 1 2 3 4 и МОЩНОСТЬ Н16 АНТ Сброс
        private void Н15КнопкаПРМНаведениеЦ300М1_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М2_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М3_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М4_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаМощностьН16_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаМощностьН16.Visible = false;
            N15Parameters.Н15КнопкаМощностьН16 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаМощностьАнт_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаМощностьАнт.Visible = false;
            N15Parameters.Н15КнопкаМощностьАнт = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
        }

        private void Н15КнопкаМощностьСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаМощностьСброс.BackgroundImage = null;
            this.Н15КнопкаМощностьСброс.Text = string.Empty;
        }

        private void Н15КнопкаМощностьСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаМощностьСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Н15КнопкаМощностьСброс.Text = "СБРОС";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }
        #endregion

        #region Кнопки Н13-1 Н13-2 Н13-1,2 СБРОС
        private async void Н15КнопкаН13_1_Click(object sender, EventArgs e)
        {
            
            this.Н15КнопкаН13_1.Visible = false;
            this.Н15КнопкаН13_2.Visible = true;
            this.Н15КнопкаН13_12.Visible = true;

            if (локН15КнопкаН13_2 == "false" && локН15КнопкаН13_12 == "false")
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_2.BackgroundImage = null;

                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_12.BackgroundImage = null;
            }

            локН15КнопкаН13_1 = "true";            
            локН15КнопкаН13_2 = "false";            
            локН15КнопкаН13_12 = "false";

            N15Parameters.Н15ЛампочкаН16Н13_1 = "true";
            N15Parameters.Н15ЛампочкаН16Н13_2 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_12 = "false";

        }

        private async void Н15КнопкаН13_2_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаН13_2.Visible = false;
            this.Н15КнопкаН13_1.Visible = true;
            this.Н15КнопкаН13_12.Visible = true;

            if (локН15КнопкаН13_1 == "false" && локН15КнопкаН13_12 == "false")
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_12.BackgroundImage = null;

                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_1.BackgroundImage = null;
            }      
      
            локН15КнопкаН13_2 = "true";            
            локН15КнопкаН13_1 = "false";            
            локН15КнопкаН13_12 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_1 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_2 = "true";
            N15Parameters.Н15ЛампочкаН16Н13_12 = "false";

        }

        private async void Н15КнопкаН13_12_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаН13_12.Visible = false;
            this.Н15КнопкаН13_1.Visible = true;
            this.Н15КнопкаН13_2.Visible = true;

            if (локН15КнопкаН13_1 == "false" && локН15КнопкаН13_2 == "false")
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_1.BackgroundImage = null;

                await Task.Delay(200);
                this.Н15ЛампочкаН16Н13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.Н15ЛампочкаН16Н13_2.BackgroundImage = null;
            }
            
            локН15КнопкаН13_12 = "true";            
            локН15КнопкаН13_1 = "false";            
            локН15КнопкаН13_2 = "false";

            N15Parameters.Н15ЛампочкаН16Н13_1 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_2 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_12 = "true";

        }

        private async void Н15КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Н15КнопкаСброс.Text = "СБРОС";

            this.Н15КнопкаН13_1.Visible = true;
            this.Н15КнопкаН13_2.Visible = true;
            this.Н15КнопкаН13_12.Visible = true;

            await Task.Delay(200);
            this.Н15ЛампочкаН16Н13_1.BackgroundImage = null;
            this.Н15ЛампочкаН16Н13_2.BackgroundImage = null;
            this.Н15ЛампочкаН16Н13_12.BackgroundImage = null;

            локН15КнопкаН13_1 = "false";
            локН15КнопкаН13_2 = "false";
            локН15КнопкаН13_12 = "false";

            N15Parameters.Н15ЛампочкаН16Н13_1 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_2 = "false";
            N15Parameters.Н15ЛампочкаН16Н13_12 = "false";

        }

        private void Н15КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСброс.BackgroundImage = null;
            this.Н15КнопкаСброс.Text = string.Empty;
        }
        #endregion

        private void N15Form_Load(object sender, EventArgs e)
        {
            #region Присвоение значений локальным параметрам
            локН15ТумблерЦ300М1 = N15Parameters.Н15ТумблерЦ300М1;
            локН15ТумблерЦ300М2 = N15Parameters.Н15ТумблерЦ300М2;
            локН15ТумблерЦ300М3 = N15Parameters.Н15ТумблерЦ300М3;
            локН15ТумблерЦ300М4 = N15Parameters.Н15ТумблерЦ300М4;
            локН15ТумблерН12С = N15Parameters.Н15ТумблерН12С;
            локН15ТумблерМШУ = N15Parameters.Н15ТумблерМШУ;
            локН15ТумблерБМА_1 = N15Parameters.Н15ТумблерБМА_1;
            локН15ТумблерБМА_2 = N15Parameters.Н15ТумблерБМА_2;
            локН15ТумблерА205 = N15Parameters.Н15ТумблерА205;
            локН15ТумблерА20512 = N15Parameters.Н15ТумблерА20512;
            локН15ТумблерАФСС = N15Parameters.Н15ТумблерАФСС;
            локН15ТумблерА1 = N15Parameters.Н15ТумблерА1;
            локН15ТумблерА403 = N15Parameters.Н15ТумблерА403;
            локН15ТумблерК1_1 = N15Parameters.Н15ТумблерК1_1;
            локН15ТумблерК1_2 = N15Parameters.Н15ТумблерК1_2;
            локН15ТумблерБ1_1 = N15Parameters.Н15ТумблерБ1_1;
            локН15ТумблерБ1_2 = N15Parameters.Н15ТумблерБ1_2;
            локН15ТумблерБ2_1 = N15Parameters.Н15ТумблерБ2_1;
            локН15ТумблерБ2_2 = N15Parameters.Н15ТумблерБ2_2;
            локН15ТумблерБ3_1 = N15Parameters.Н15ТумблерБ3_1;
            локН15ТумблерБ3_2 = N15Parameters.Н15ТумблерБ3_2;
            локН15ТумблерДАБ_5 = N15Parameters.Н15ТумблерДАБ_5;
            локН15ТумблерР_Н = N15Parameters.Н15ТумблерР_Н;
            локН15ТумблерАнтЭкв = N15Parameters.Н15ТумблерАнтЭкв;
            локН15ТумблерТлфТлгПрм = N15Parameters.Н15ТумблерТлфТлгПрм;
            локН15ТумблерТлфТлгПрд = N15Parameters.Н15ТумблерТлфТлгПрд;
            локН15КнопкаН13_1 = N15Parameters.Н15КнопкаН13_1;
            локН15КнопкаН13_2 = N15Parameters.Н15КнопкаН13_2;
            локН15КнопкаН13_12 = N15Parameters.Н15КнопкаН13_12;
            #endregion
            InitializeButtons();
            InitializeTumblers();
            InitializeLamps();
        }

        /// <summary>
        /// Установка кнопок в положение последней их установки
        /// </summary>
        private void InitializeButtons()
        {
            foreach (Control item in N15Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    PropertyInfo[] fieldList = typeof(N15Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            string value = System.Convert.ToString(property.GetValue(null));
                            item.Visible = (value != "true") ? true : false;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Установка тумблеров в положение последней их установки
        /// </summary>
        private void InitializeTumblers()
        {
            foreach (Control item in N15Panel.Controls)
            {
                if (item.Name.Contains("Тумблер"))
                {
                    PropertyInfo[] fieldList = typeof(N15Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            string value = System.Convert.ToString(property.GetValue(null));
                            if (value == "true")
                            {
                                item.BackgroundImage = ControlElementImages.tumblerType3Up;
                            }
                            else
                                if (value == "false")
                                {
                                    item.BackgroundImage = ControlElementImages.tumblerType3Down;
                                }
                            if (value == "1" && item.Name.Contains("А20512"))
                            {
                                item.BackgroundImage = ControlElementImages.tumblerType4Up;
                            }
                            else
                                if (value == "2" && item.Name.Contains("А20512"))
                                {
                                    item.BackgroundImage = ControlElementImages.tumblerType4Down;
                                }
                            if (value == "1" && item.Name.Contains("А30412"))
                            {
                                item.BackgroundImage = ControlElementImages.tumblerType3Up;
                            }
                            else
                                if (value == "2" && item.Name.Contains("А30412"))
                                {
                                    item.BackgroundImage = ControlElementImages.tumblerType3Down;
                                }
                            if (value == "ТЛФ")
                            {
                                item.BackgroundImage = ControlElementImages.tumblerType4Up;
                            }
                            else
                                if (value == "ТЛГ")
                                {
                                    item.BackgroundImage = ControlElementImages.tumblerType4Down;
                                }
                            if (value == "АНТ")
                            {
                                item.BackgroundImage = ControlElementImages.tumblerType4Up;
                            }
                            else
                                if (value == "ЭКВ")
                                {
                                    item.BackgroundImage = ControlElementImages.tumblerType4Down;
                                }
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Установка лампочек в положение последней их установки
        /// </summary>
        private void InitializeLamps()
        {
            foreach (Control item in N15Panel.Controls)
            {
                if (item.Name.Contains("Лампочка"))
                {
                    PropertyInfo[] fieldList = typeof(N15Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            string value = System.Convert.ToString(property.GetValue(null));
                            if ((value == "true" && (item.Name.Contains("Ц300М") || item.Name.Contains("ППВ") || item.Name.Contains("А205") || item.Name.Contains("УМ1"))))
                            {
                                item.BackgroundImage = ControlElementImages.lampType8OnRed;
                            }
                            else
                                if (value == "true")
                                {
                                    item.BackgroundImage = ControlElementImages.lampType5OnRed;
                                }
                                else
                                {
                                    item.BackgroundImage = null;
                                }
                            break;
                        }
                    }
                }
            }
        }

        private void Н15ТумблерЦ300М1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерЦ300М1 == "true")
            {
                this.Н15ТумблерЦ300М1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерЦ300М1 = "false";
            }
            else
            {
                this.Н15ТумблерЦ300М1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерЦ300М1 = "true";
            }
        }

        private void Н15ТумблерЦ300М2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерЦ300М2 == "true")
            {
                this.Н15ТумблерЦ300М2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерЦ300М2 = "false";
            }
            else
            {
                this.Н15ТумблерЦ300М2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерЦ300М2 = "true";
            }
        }

        private void Н15ТумблерЦ300М3_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерЦ300М3 == "true")
            {
                this.Н15ТумблерЦ300М3.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерЦ300М3 = "false";
            }
            else
            {
                this.Н15ТумблерЦ300М3.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерЦ300М3 = "true";
            }
        }

        private void Н15ТумблерЦ300М4_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерЦ300М4 == "true")
            {
                this.Н15ТумблерЦ300М4.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерЦ300М4 = "false";
            }
            else
            {
                this.Н15ТумблерЦ300М4.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерЦ300М4 = "true";
            }
        }

        private void Н15ТумблерН12С_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерН12С == "true")
            {
                this.Н15ТумблерН12С.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерН12С = "false";
            }
            else
            {
                this.Н15ТумблерН12С.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерН12С = "true";
            }
        }

        private void Н15ТумблерМШУ_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерМШУ == "true")
            {
                this.Н15ТумблерМШУ.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерМШУ = "false";
            }
            else
            {
                this.Н15ТумблерМШУ.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерМШУ = "true";
            }
        }

        private void Н15ТумблерБМА_1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБМА_1 == "true")
            {
                this.Н15ТумблерБМА_1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБМА_1 = "false";
            }
            else
            {
                this.Н15ТумблерБМА_1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБМА_1 = "true";
            }
        }

        private void Н15ТумблерБМА_2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБМА_2 == "true")
            {
                this.Н15ТумблерБМА_2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБМА_2 = "false";
            }
            else
            {
                this.Н15ТумблерБМА_2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБМА_2 = "true";
            }
        }

        private void Н15ТумблерА205_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерА205 == "true")
            {
                this.Н15ТумблерА205.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерА205 = "false";
            }
            else
            {
                this.Н15ТумблерА205.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерА205 = "true";
            }
        }

        private void Н15ТумблерК1_1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерК1_1 == "true")
            {
                this.Н15ТумблерК1_1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерК1_1 = "false";
            }
            else
            {
                this.Н15ТумблерК1_1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерК1_1 = "true";
            }
        }

        private void Н15ТумблерК1_2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерК1_2 == "true")
            {
                this.Н15ТумблерК1_2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерК1_2 = "false";
            }
            else
            {
                this.Н15ТумблерК1_2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерК1_2 = "true";
            }
        }

        private void Н15ТумблерАФСС_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерАФСС == "true")
            {
                this.Н15ТумблерАФСС.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерАФСС = "false";
            }
            else
            {
                this.Н15ТумблерАФСС.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерАФСС = "true";
            }
        }

        private void Н15ТумблерА1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерА1 == "true")
            {
                this.Н15ТумблерА1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерА1 = "false";
            }
            else
            {
                this.Н15ТумблерА1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерА1 = "true";
            }
        }

        private void Н15ТумблерА403_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерА403 == "true")
            {
                this.Н15ТумблерА403.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерА403 = "false";
            }
            else
            {
                this.Н15ТумблерА403.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерА403 = "true";
            }
        }

        private void Н15ТумблерБ1_1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ1_1 == "true")
            {
                this.Н15ТумблерБ1_1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ1_1 = "false";
            }
            else
            {
                this.Н15ТумблерБ1_1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ1_1 = "true";
            }
        }

        private void Н15ТумблерБ1_2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ1_2 == "true")
            {
                this.Н15ТумблерБ1_2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ1_2 = "false";
            }
            else
            {
                this.Н15ТумблерБ1_2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ1_2 = "true";
            }
        }

        private void Н15ТумблерБ2_1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ2_1 == "true")
            {
                this.Н15ТумблерБ2_1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ2_1 = "false";
            }
            else
            {
                this.Н15ТумблерБ2_1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ2_1 = "true";
            }
        }

        private void Н15ТумблерБ2_2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ2_2 == "true")
            {
                this.Н15ТумблерБ2_2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ2_2 = "false";
            }
            else
            {
                this.Н15ТумблерБ2_2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ2_2 = "true";
            }
        }

        private void Н15ТумблерБ3_1_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ3_1 == "true")
            {
                this.Н15ТумблерБ3_1.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ3_1 = "false";
            }
            else
            {
                this.Н15ТумблерБ3_1.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ3_1 = "true";
            }
        }

        private void Н15ТумблерБ3_2_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерБ3_2 == "true")
            {
                this.Н15ТумблерБ3_2.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерБ3_2 = "false";
            }
            else
            {
                this.Н15ТумблерБ3_2.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерБ3_2 = "true";
            }
        }

        private void Н15ТумблерДАБ_5_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерДАБ_5 == "true")
            {
                this.Н15ТумблерДАБ_5.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерДАБ_5 = "false";
            }
            else
            {
                this.Н15ТумблерДАБ_5.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерДАБ_5 = "true";
            }
        }

        private void Н15ТумблерР_Н_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерР_Н == "true")
            {
                this.Н15ТумблерР_Н.BackgroundImage = ControlElementImages.tumblerType3Down;
                локН15ТумблерР_Н = "false";
            }
            else
            {
                this.Н15ТумблерР_Н.BackgroundImage = ControlElementImages.tumblerType3Up;
                локН15ТумблерР_Н = "true";
            }
        }

        private void Н15ТумблерА20512_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерА20512 == "1")
            {
                this.Н15ТумблерА20512.BackgroundImage = ControlElementImages.tumblerType4Down;
                локН15ТумблерА20512 = "2";
            }
            else
            {
                this.Н15ТумблерА20512.BackgroundImage = ControlElementImages.tumblerType4Up;
                локН15ТумблерА20512 = "1";
            }
        }

        private void Н15ТумблерА30412_Click(object sender, EventArgs e)
        {
            if (N15Parameters.Н15ТумблерА30412 == "1")
            {
                this.Н15ТумблерА30412.BackgroundImage = ControlElementImages.tumblerType3Down;
                N15Parameters.Н15ТумблерА30412 = "2";
                if (N15Parameters.Н15ЛампочкаМШУ == "true")
                {
                    N15Parameters.Н15ЛампочкаА3042 = "true";
                    this.Н15ЛампочкаА3042.BackgroundImage = ControlElementImages.lampType5OnRed;

                    N15Parameters.Н15ЛампочкаА3041 = "false";
                    this.Н15ЛампочкаА3041.BackgroundImage = null;
                    if (this.A30412StateChange != null)
                    {
                        this.A30412StateChange();
                    }
                }
            }
            else
            {
                this.Н15ТумблерА30412.BackgroundImage = ControlElementImages.tumblerType3Up;
                N15Parameters.Н15ТумблерА30412 = "1";
                if (N15Parameters.Н15ЛампочкаМШУ == "true")
                {
                    N15Parameters.Н15ЛампочкаА3041 = "true";
                    this.Н15ЛампочкаА3041.BackgroundImage = ControlElementImages.lampType5OnRed;

                    N15Parameters.Н15ЛампочкаА3042 = "false";
                    this.Н15ЛампочкаА3042.BackgroundImage = null;
                    if (this.A30412StateChange != null)
                    {
                        this.A30412StateChange();
                    }
                }
            }
        }

        private void Н15ТумблерАнтЭкв_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерАнтЭкв == "АНТ")
            {
                this.Н15ТумблерАнтЭкв.BackgroundImage = ControlElementImages.tumblerType4Down;
                локН15ТумблерАнтЭкв = "ЭКВ";
            }
            else
            {
                this.Н15ТумблерАнтЭкв.BackgroundImage = ControlElementImages.tumblerType4Up;
                локН15ТумблерАнтЭкв = "АНТ";
            }
        }

        #region События
        /// <summary>
        /// Сигнатура void(void) для событий данной формы
        /// </summary>
        public delegate void VoidVoidSignature();

        /// <summary>
        /// Изменилось состояние блока A304
        /// </summary>
        public event VoidVoidSignature A30412StateChange; 
        #endregion

        private void Н15ТумблерТлфТлгПрм_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерТлфТлгПрм == "ТЛФ")
            {
                this.Н15ТумблерТлфТлгПрм.BackgroundImage = ControlElementImages.tumblerType4Down;
                локН15ТумблерТлфТлгПрм = "ТЛГ";
            }
            else
            {
                this.Н15ТумблерТлфТлгПрм.BackgroundImage = ControlElementImages.tumblerType4Up;
                локН15ТумблерТлфТлгПрм = "ТЛФ";
            }
        }

        private void Н15ТумблерТлфТлгПрд_Click(object sender, EventArgs e)
        {
            if (локН15ТумблерТлфТлгПрд == "ТЛФ")
            {
                this.Н15ТумблерТлфТлгПрд.BackgroundImage = ControlElementImages.tumblerType4Down;
                локН15ТумблерТлфТлгПрд = "ТЛГ";
            }
            else
            {
                this.Н15ТумблерТлфТлгПрд.BackgroundImage = ControlElementImages.tumblerType4Up;
                локН15ТумблерТлфТлгПрд = "ТЛФ";
            }
        }

        private void N15ButtonInside1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form thisForm = new N15InsideForm();
            thisForm.Show(this);
        }

        private void N15ButtonInside2_Click(object sender, EventArgs e)
        {
            N15ButtonInside1_Click(sender, e);
        }
    }
}