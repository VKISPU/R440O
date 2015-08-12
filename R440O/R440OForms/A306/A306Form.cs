namespace R440O.R440OForms.A306
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока А306
    /// </summary>
    public partial class A306Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A306Form"/>.
        /// </summary>
        public A306Form()
        {

            InitializeComponent();
            A306Parameters.RefreshForm += RefreshForm;
        }

        #region Инициализация
        /// <summary>
        /// Задает начальные полочения переключателей на блоке A306.
        /// </summary>
        private void RefreshForm()
        {
            //Лампочки
            ЛампочкаСетьВкл.BackgroundImage = A306Parameters.ЛампочкаСетьВкл
                ? ControlElementImages.lampType5OnRed
                : null;

            ЛампочкаНО1Вкл.BackgroundImage = A306Parameters.ЛампочкаНО1Вкл
                ? ControlElementImages.lampType5OnRed
                : null;

            ЛампочкаНО2Вкл.BackgroundImage = A306Parameters.ЛампочкаНО2Вкл
                ? ControlElementImages.lampType5OnRed
                : null;

            //Тумблер
            ТумблерДистанцМестн.BackgroundImage = A306Parameters.ТумблерДистанцМестн
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            ТумблерВклВыкл.BackgroundImage = A306Parameters.ТумблерВклВыкл
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            //ВходыКаналов
            foreach (Control item in A306Panel.Controls)
            {
                if (item.Name.Contains("ВходКанала"))
                {
                    if (A306Parameters.Входы[(int)Char.GetNumericValue(item.Name[10])])
                    {
                        item.Visible = true;
                        item.BackgroundImage = ControlElementImages.A306Input;
                        item.Text = (char.GetNumericValue(item.Name[10]) + 1).ToString();
                    }
                    else
                    {
                        item.Visible = false;
                        item.BackgroundImage = ControlElementImages.A306Cabel;
                        item.Text = "";
                    }
                }
                else
                    if (item.Name.Contains("ВходNO"))
                    {
                        if (A306Parameters.Входы[(int)Char.GetNumericValue(item.Name[7]) + 3])
                        {
                            item.Visible = true;
                            item.BackgroundImage = ControlElementImages.A306Input;
                            item.Text = "" + char.GetNumericValue(item.Name[7]);
                        }
                        else
                        {
                            item.Visible = false;
                            item.BackgroundImage = null;
                            item.Text = "";
                        }
                    }
            }

            //ВыходыКаналов
            foreach (Control item in A306Panel.Controls)
            {
                if (item.Name.Contains("Выход"))
                {
                    int index =
                        int.Parse(Convert.ToString(Convert.ToString(item.Name[5]) + Convert.ToString(item.Name[6])));
                    if (A306Parameters.Выходы[index] != -1)
                    {
                        item.BackgroundImage = ControlElementImages.A306Input;
                        if (A306Parameters.Выходы[index] <= 3)
                            item.Text = (A306Parameters.Выходы[index] + 1).ToString();
                        else
                            item.Text = "NO" + (A306Parameters.Выходы[index] - 3).ToString();
                    }
                    else
                    {
                        item.BackgroundImage = null;
                        item.Text = "";
                    }
                }
            }
            A306Panel.Refresh();

        } 
        #endregion

        #region Тумблеры
        private void ТумблерДистанцМестн_Click(object sender, System.EventArgs e)
        {
            A306Parameters.ТумблерДистанцМестн = !A306Parameters.ТумблерДистанцМестн;
        }

        private void ТумблерВклВыкл_Click(object sender, System.EventArgs e)
        {
            A306Parameters.ТумблерВклВыкл = !A306Parameters.ТумблерВклВыкл;
        }
        #endregion

        #region Коммутация

        private void Выходы_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //названия кнопок отличются на 5й и 6й символ
            if (button.Name.Length >= 6)
            {
                //получаем номер кнопки (string - чтобы 00 не преобразовалось в 0 и потом в цикле смогли найти нужную кнопку)
                string numberOfButton =
                    Convert.ToString(Convert.ToString(button.Name[5]) + Convert.ToString(button.Name[6]));

                foreach (Control item in A306Panel.Controls)
                {
                    //выбрали нужную кнопку
                    if (item.Name.Contains("Выход" + numberOfButton))
                    {
                        A306Parameters.ЦелевойВыход = int.Parse(numberOfButton);
                    }
                }
            }
        }

        private void ВходыКаналов_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //названия кнопок отличются на 11й символ
            if (button.Name.Length >= 10)
            {
                //получаем номер кнопки
                int numberOfButton = (int)Char.GetNumericValue(button.Name[10]);

                foreach (Control item in A306Panel.Controls)
                {
                    //выбрали нужную кнопку
                    if (item.Name.Contains("ВходКанала" + numberOfButton))
                    {
                        //выделим визуально
                        FontChange(button, "ВходNO", "ВходКанала");
                        A306Parameters.АктивныйВход = numberOfButton;
                    }
                }
            }
        }

        private void ВходNO_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //выделим визуально
            FontChange(button, "ВходNO_2", "ВходКанала");
            A306Parameters.АктивныйВход = 4;
        }

        private void ВходNO_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //выделим визуально
            FontChange(button, "ВходNO_1", "ВходКанала");
            A306Parameters.АктивныйВход = 5;
        } 
        #endregion

        #region Графика

        private void FontChange(Button button, string controlName1, string controlName2)
        {
            if (!button.Font.Bold)
            {
                foreach (Control item2 in A306Panel.Controls)
                {
                    if (item2.Name.Contains(controlName1) || item2.Name.Contains(controlName2))
                    {
                        item2.Font = new Font("Microsoft Sans Serif", 8.25F, (FontStyle.Regular));
                        item2.ForeColor = Color.Black;
                    }
                }
                button.Font = new Font("Microsoft Sans Serif", 10.25F, (FontStyle.Bold));
                button.ForeColor = Color.Blue;
            }
            else
            {
                button.Font = new Font("Microsoft Sans Serif", 8.25F, (FontStyle.Regular));
                button.ForeColor = Color.Black;
            }
        }


        private void DrawLine(Point onePoint, Point twoPoint, PaintEventArgs e)
        {
            var myPen = new Pen(Color.Gray, 1);
            e.Graphics.DrawLine(myPen, onePoint, twoPoint);
            myPen.Dispose();
        }

        private void A306Panel_Paint(object sender, PaintEventArgs e)
        {
            НО1.Visible = false;
            НО1Своб.Visible = true;
            НО1Своб.BackgroundImage = ControlElementImages.A306CabelNO;
            НО2.Visible = false;
            НО2Своб.Visible = true;
            НО2Своб.BackgroundImage = ControlElementImages.A306CabelNO;

            foreach (Control item in A306Panel.Controls)
            {
                if (item.Name.Contains("ВходКанала"))
                {
                    //если кабели висят на планке
                    if (A306Parameters.Входы[(int)char.GetNumericValue(item.Name[10])])
                    {
                        var onePoint = new Point(A306Panel.Left + 55 * (int)char.GetNumericValue(item.Name[10]) + 138,
                            A306Panel.Bottom - 85);
                        var twoPoint = new Point(item.Left + 15, item.Top + 107);
                        for (int i = 0; i < 10; i++)
                        {
                            onePoint.X++;
                            twoPoint.X++;
                            DrawLine(onePoint, twoPoint, e);
                        }
                        continue;
                    }
                }
                //если воткнуты куда-нибудь
                if (item.Name.Contains("Выход"))
                {
                    int index =
                        int.Parse(Convert.ToString(Convert.ToString(item.Name[5]) + Convert.ToString(item.Name[6])));
                    if (A306Parameters.Выходы[index] != -1 && A306Parameters.Выходы[index] <= 3)
                    {
                        var onePoint = new Point(A306Panel.Left + 55 * A306Parameters.Выходы[index] + 138,
                            A306Panel.Bottom - 85);

                        var twoPoint = new Point(item.Left + 10, item.Bottom);

                        for (int i = 0; i < 10; i++)
                        {
                            onePoint.X++;
                            twoPoint.X++;
                            DrawLine(onePoint, twoPoint, e);
                        }
                    }
                    else   //для NO
                    {
                        if (A306Parameters.Выходы[index] == 4)
                        {
                            НО1.Visible = true;
                            НО1.BackgroundImage = ControlElementImages.A306Input;
                            НО1Своб.Visible = false;
                            var Point0 = new Point(НО1.Left + 10, НО1.Bottom);
                            var Point1 = new Point(НО1.Left + 10, НО1.Bottom + 50);
                            var Point1_1 = ((index >= 11 && index <= 14) || index <= 5)
                                ? new Point(НО1.Left + 20, НО1.Bottom + 50)
                                : new Point(НО1.Left + 11, НО1.Bottom + 50);
                            var Point2 = new Point(item.Left + 11, НО1.Bottom + 50);
                            var Point3 = new Point(item.Left + 11, item.Bottom);
                            for (int i = 0; i < 10; i++)
                            {
                                Point0.X++;
                                Point1.X++;
                                DrawLine(Point0, Point1, e);
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                Point1_1.Y++;
                                Point2.Y++;
                                DrawLine(Point1_1, Point2, e);
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                Point2.X++;
                                Point3.X++;
                                DrawLine(Point2, Point3, e);
                            }
                        }
                        else if (A306Parameters.Выходы[index] == 5)
                        {
                            НО2.Visible = true;
                            НО2.BackgroundImage = ControlElementImages.A306Input;
                            НО2Своб.Visible = false;
                            var Point0 = new Point(НО2.Left + 10, НО2.Bottom);
                            var Point1 = new Point(НО2.Left + 10, НО2.Bottom + 70);
                            var Point1_1 = ((index >= 6 && index <= 10) || index >= 15)
                                ? new Point(НО2.Left + 10, НО2.Bottom + 70)
                                : new Point(НО2.Left + 20, НО2.Bottom + 70);

                            var Point2 = new Point(item.Left + 11, НО2.Bottom + 70);
                            var Point3 = new Point(item.Left + 11, item.Bottom);
                            for (int i = 0; i < 10; i++)
                            {
                                Point0.X++;
                                Point1.X++;
                                DrawLine(Point0, Point1, e);
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                Point1_1.Y++;
                                Point2.Y++;
                                DrawLine(Point1_1, Point2, e);
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                Point2.X++;
                                Point3.X++;
                                DrawLine(Point2, Point3, e);
                            }
                        }
                    }
                }


            }
        } 
        #endregion

        /// <summary>
        /// Для запуска refreshForm после того как вся форма загрузилась
        /// </summary>
        private void A306Form_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}