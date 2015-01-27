using System;
using System.Reflection;

namespace R440O.R440OForms.DAB_5
{
    using System.Windows.Forms;
    using Parameters;
    /// <summary>
    /// Форма блока ДАБ-5
    /// </summary>
    public partial class DAB_5Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DAB_5Form"/>
        /// </summary>
        public DAB_5Form()
        {
            this.InitializeComponent();
            this.InitializeLamps();
        }

        /// <summary>
        /// Инициализация лампочек
        /// </summary>
        private void InitializeLamps()
        {
            foreach (Control item in DAB_5Panel.Controls)
            {
                FieldInfo[] fieldList = typeof(DAB_5Parameters).GetFields();
                foreach (var property in fieldList)
                {
                    if (item.Name == property.Name)
                    {
                        if (item.Name == "DAB_5ЛампочкаОбход" || item.Name == "DAB_5ЛампочкаПитание")
                        {
                            item.BackgroundImage = (bool) property.GetValue(null)
                                ? ControlElementImages.lampType10OnGreen
                                : null;
                        }
                        else if (item.Name.Contains("DAB_5Лампочка"))
                        {
                            item.BackgroundImage = (bool)property.GetValue(null)
                                ? ControlElementImages.lampType5OnRed 
                                : null;
                        }
                    }
                }
            }
            DAB_5ТумблерПитание.BackgroundImage = DAB_5Parameters.DAB_5ТумблерПитание
                    ? ControlElementImages.tumblerType4Up
                    : ControlElementImages.tumblerType4Down; ;
        }

        #region Кнопки
        private void DAB_5Кнопка_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void DAB_5Кнопка_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = null;
            switch (button.Name)
            {
                case "DAB_5КнопкаОбходВкл":
                {
                    DAB_5Parameters.DAB_5ЛампочкаОбход = true;
                    DAB_5ЛампочкаОбход.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаОбход ? ControlElementImages.lampType10OnGreen : null;
                }
                    break;
                case "DAB_5КнопкаОбходВыкл":
                    {
                        DAB_5Parameters.DAB_5ЛампочкаОбход = false;
                        DAB_5ЛампочкаОбход.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаОбход ? ControlElementImages.lampType10OnGreen : null;
                    }
                    break;
                case "DAB_5КнопкаРежимЛевая":
                    {
                    }
                    break;
                case "DAB_5КнопкаРежимПравая":
                    {
                    }
                    break;

                ////Выбор комплекта
                case "DAB_5КнопкаВыборПрмПрд1":
                    {
                    }
                    break;
                case "DAB_5КнопкаВыборПрмПрд2":
                    {
                    }
                    break;
                case "DAB_5КнопкаВыборБП1":
                    {
                    }
                    break;
                case "DAB_5КнопкаВыборБП2":
                    {
                    }
                    break;

                ////Режим работы
                case "DAB_5КнопкаРежимВыкл1К":
                {
                    this.TurnLampsForComplect(1, 0);
                }
                    break;
                case "DAB_5КнопкаРежимРабота1К":
                    {
                        this.TurnLampsForComplect(1, 1);
                    }
                    break;
                case "DAB_5КнопкаРежимШлейф1К":
                    {
                        this.TurnLampsForComplect(1, 2);
                    }
                    break;
                case "DAB_5КнопкаРежимПрмПрд1К":
                    {
                        this.TurnLampsForComplect(1, 3);
                    }
                    break;
                case "DAB_5КнопкаРежимПрм1К":
                    {
                        this.TurnLampsForComplect(1, 4);
                    }
                    break;

                case "DAB_5КнопкаРежимВыкл2К":
                    {
                        this.TurnLampsForComplect(2, 0);
                    }
                    break;
                case "DAB_5КнопкаРежимРабота2К":
                    {
                        this.TurnLampsForComplect(2, 1);
                    }
                    break;
                case "DAB_5КнопкаРежимШлейф2К":
                    {
                        this.TurnLampsForComplect(2, 2);
                    }
                    break;
                case "DAB_5КнопкаРежимПрмПрд2К":
                    {
                        this.TurnLampsForComplect(2, 3);
                    }
                    break;
                case "DAB_5КнопкаРежимПрм2К":
                    {
                        this.TurnLampsForComplect(2, 4);
                    }
                    break;
            }
        }

        /// <summary>
        /// Переключение ламп соответствующих режиму работы заданного комплекта
        /// </summary>
        /// <param name="complect">Копмлект для которого задётся режим работы</param>
        /// <param name="lamp">Номер лампы по порядку</param>
        private void TurnLampsForComplect(int complect, int lamp)
        {
            if (complect == 1)
            {
                DAB_5Parameters.DAB_5ЛампочкаРежимРабота1К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимШлейф1К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд1К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимПрм1К = false;
                switch (lamp)
                {
                    case 1:
                        DAB_5Parameters.DAB_5ЛампочкаРежимРабота1К = true;
                        break;
                    case 2:
                        DAB_5Parameters.DAB_5ЛампочкаРежимШлейф1К = true;
                        break;
                    case 3:
                        DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд1К = true;
                        break;
                    case 4:
                        DAB_5Parameters.DAB_5ЛампочкаРежимПрм1К = true;
                        break;
                }
                DAB_5ЛампочкаРежимРабота1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимРабота1К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимШлейф1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимШлейф1К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимПрмПрд1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд1К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимПрм1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрм1К
                    ? ControlElementImages.lampType5OnRed
                    : null;
            }
            else
            {
                DAB_5Parameters.DAB_5ЛампочкаРежимРабота2К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимШлейф2К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд2К = false;
                DAB_5Parameters.DAB_5ЛампочкаРежимПрм2К = false;
                switch (lamp)
                {
                    case 1:
                        DAB_5Parameters.DAB_5ЛампочкаРежимРабота2К = true;
                        break;
                    case 2:
                        DAB_5Parameters.DAB_5ЛампочкаРежимШлейф2К = true;
                        break;
                    case 3:
                        DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд2К = true;
                        break;
                    case 4:
                        DAB_5Parameters.DAB_5ЛампочкаРежимПрм2К = true;
                        break;
                }
                DAB_5ЛампочкаРежимРабота2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимРабота2К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимШлейф2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимШлейф2К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимПрмПрд2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд2К
                    ? ControlElementImages.lampType5OnRed
                    : null;
                DAB_5ЛампочкаРежимПрм2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрм2К
                    ? ControlElementImages.lampType5OnRed
                    : null;
            }
        }
        #endregion

        /// <summary>
        /// Включение питания на блоке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DAB_5ТумблерПитание_Click(object sender, EventArgs e)
        {
            DAB_5Parameters.DAB_5ТумблерПитание = !DAB_5Parameters.DAB_5ТумблерПитание;
            DAB_5ТумблерПитание.BackgroundImage = DAB_5Parameters.DAB_5ТумблерПитание
                    ? ControlElementImages.tumblerType4Up
                    : ControlElementImages.tumblerType4Down;

            DAB_5Parameters.DAB_5ЛампочкаПитание = !DAB_5Parameters.DAB_5ЛампочкаПитание;
            DAB_5ЛампочкаПитание.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаПитание
                    ? ControlElementImages.lampType10OnGreen
                    : null;
        }
    }
}