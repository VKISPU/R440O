using System;
using System.Drawing;
using System.Reflection;
using System.Linq;

namespace R440O.R440OForms.A306
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока А306
    /// </summary>
    public partial class A306Form : Form
    {

        private int Выход = 0;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A306Form"/>.
        /// </summary>
        public A306Form()
        {
            this.InitializeComponent();
            this.InitializeTumblers();
        }

        /// <summary>
        /// Задает начальные полочения переключателей на блоке A306.
        /// </summary>
        private void InitializeTumblers()
        {
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерДистанцМестн_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерДистанцМестн = !A306Parameters.A306ТумблерДистанцМестн;
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерВклВыкл_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерВклВыкл = !A306Parameters.A306ТумблерВклВыкл;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
        }

        private void DrawLine(Point onePoint, Point twoPoint)
        {
            var myPen = new Pen(Color.Gray, 10);
            var panelGraphics = A306Panel.CreateGraphics();
            panelGraphics.DrawLine(myPen, onePoint, twoPoint);
            myPen.Dispose();
            panelGraphics.Dispose();
        }

        private void RefreshCabels()
        {
            foreach (Control item in A306Panel.Controls)
            {
                if (item.Name.Contains("A306ВыходКаналов"))
                {
                    if (A306Parameters.A306ВыходыКаналов[
                        int.Parse(Convert.ToString(Convert.ToString(item.Name[16]) + Convert.ToString(item.Name[17]))) -
                        1] != 0)
                        {
                            foreach (Control item2 in A306Panel.Controls)
                            {
                                if (item2.Name.Contains("A306Выход" + A306Parameters.A306ВыходыКаналов
                                    [int.Parse(Convert.ToString(Convert.ToString(item.Name[16]) + 
                                    Convert.ToString(item.Name[17]))) - 1]))
                                {
                                    var onePoint = new Point(item.Left + item.Width/2, item.Top + item.Height - 5);
                                    var twoPoint = new Point(item2.Left + item2.Width/2, item2.Top + 5);
                                    DrawLine(onePoint, twoPoint);
                                }

                                else if (item2.Name.Contains("A306ВходNO_" + (A306Parameters.A306ВыходыКаналов
                                    [int.Parse(Convert.ToString(Convert.ToString(item.Name[16]) +
                                    Convert.ToString(item.Name[17])))-1] - 10) ))
                                {
                                    var onePoint = new Point(item.Left + item.Width / 2, item.Bottom - 5);
                                    var twoPoint = new Point(item2.Left + item2.Width / 2, item.Bottom+10);
                                    var threePoint = new Point(item.Left + item.Width / 2, item.Bottom + 11); 
                                    DrawLine(onePoint, threePoint);
                                    DrawLine(threePoint, twoPoint);
                                    DrawLine(new Point(item.Left + item.Width / 2 + 5, item.Bottom + 11), 
                                        new Point(item.Left + item.Width / 2 - 5, item.Bottom + 11));
                                    DrawLine(new Point(item2.Left + item2.Width / 2 - 5, item2.Bottom + 5),
                                        new Point(item2.Left + item2.Width / 2 + 5,item2.Bottom + 5));
                                }
                            }
                        }
                }
                else if (item.Name.Contains("A306ВыходNO"))
                {
                    if (A306Parameters.A306ВыходыNO[
                         int.Parse(Convert.ToString(item.Name[11])) - 1] != 0)
                    {
                        foreach (Control item2 in A306Panel.Controls)
                        {
                            if (item2.Name.Contains("A306Выход" + A306Parameters.A306ВыходыNO
                                [int.Parse(Convert.ToString(item.Name[11])) - 1]))
                            {
                                var onePoint = new Point(item.Left + item.Width / 2, item.Top + item.Height - 5);
                                var twoPoint = new Point(item2.Left + item2.Width / 2, item2.Top + 5);
                                DrawLine(onePoint, twoPoint);
                            }

                            else if (item2.Name.Contains("A306ВходNO_" + (A306Parameters.A306ВыходыNO
                                [int.Parse(Convert.ToString(item.Name[11])) - 1] - 10)))
                            {
                                var onePoint = new Point(item.Left + item.Width / 2, item.Bottom - 5);
                                var twoPoint = new Point(item2.Left + item2.Width / 2, item.Bottom + 10);
                                var threePoint = new Point(item.Left + item.Width / 2, item.Bottom + 11);
                                DrawLine(onePoint, threePoint);
                                DrawLine(threePoint, twoPoint);
                                DrawLine(new Point(item.Left + item.Width / 2 + 5, item.Bottom + 11),
                                    new Point(item.Left + item.Width / 2 - 5, item.Bottom + 11));
                                DrawLine(new Point(item2.Left + item2.Width / 2 - 5, item2.Bottom + 5),
                                    new Point(item2.Left + item2.Width / 2 + 5, item2.Bottom + 5));
                            }
                        }
                    } 
                }
            }
        }

        /// <summary>
        /// Универсальный метод обработки нажатий на выходы каналов
        /// </summary>
        private void A306ВыходыКаналов_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Name.Length >= 16)
            {
                int numberOfButton =
                    int.Parse(Convert.ToString(Convert.ToString(button.Name[16]) + Convert.ToString(button.Name[17])));

                foreach (Control item in A306Panel.Controls)
                {
                    if (item.Name.Contains("A306ВыходКаналов" + Char.GetNumericValue(button.Name[16])
                                           + Char.GetNumericValue(button.Name[17])))
                    {
                        if (A306Parameters.A306ВыходыКаналов[numberOfButton - 1] == 0 && Выход > 0)
                        {
                            button.BackgroundImage = ControlElementImages.A306CabelInput;
                            A306Parameters.A306ВыходыКаналов[numberOfButton - 1] = Выход;
                            button.Text = (Выход > 10)
                                ? Convert.ToString("NO" + Выход%10)
                                : Convert.ToString(Выход);

                            RefreshCabels();

                            Выход = 0;
                            break;
                        }
                        else
                        {
                            button.BackgroundImage = null;
                            button.Text = "";
                            Выход = A306Parameters.A306ВыходыКаналов[numberOfButton - 1];
                            A306Parameters.A306ВыходыКаналов[numberOfButton - 1] = 0;

                            A306Panel.Refresh();
                            RefreshCabels();
                            break;
                        }
                    }
                }
            }
        }

        private void A306Выходы_Click(object sender, EventArgs e)
        {

            var button = sender as Button;
            if (button.Name.Length >= 9)
            {
                char numberOfButton = button.Name[9];
                foreach (Control item in A306Panel.Controls)
                {
                    if (item.Name.Contains("A306Выход" + numberOfButton))
                    {
                        A306Parameters.A306Выходы[numberOfButton - 49] = !A306Parameters.A306Выходы[numberOfButton - 49];

                        if (A306Parameters.A306Выходы[numberOfButton - 49])
                        {
                            button.BackgroundImage = ControlElementImages.A306CabelOutput;
                            Выход = numberOfButton - 48;
                            button.Text = Convert.ToString(numberOfButton - 48);
                        }
                        else
                        {
                            button.BackgroundImage = null;
                            Выход = 0;
                            button.Text = "";

                            for (int i = 0; i < A306Parameters.A306ВыходыКаналов.Length; i++)
                            {
                                if (A306Parameters.A306ВыходыКаналов[i] == numberOfButton - 48)
                                {
                                    A306Parameters.A306ВыходыКаналов[i] = 0;
                                    A306Panel.Refresh();
                                    RefreshCabels();

                                    foreach (Control item3 in A306Panel.Controls)
                                    {
                                        string s=Convert.ToString(i+1);
                                        if (i < 10) s = "0" + (i+1);
                                        if (item3.Name.Contains("A306ВыходКаналов" + s))
                                        {
                                            item3.BackgroundImage = null;
                                            item3.Text = "";
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < A306Parameters.A306ВыходыNO.Length; i++)
                            {
                                if (A306Parameters.A306ВыходыNO[i] == numberOfButton - 48)
                                {
                                    A306Parameters.A306ВыходыNO[i] = 0;
                                    A306Panel.Refresh();
                                    RefreshCabels();

                                    foreach (Control item3 in A306Panel.Controls)
                                    {
                                        if (item3.Name.Contains("A306ВыходNO" + (i + 1)))
                                        {
                                            item3.BackgroundImage = null;
                                            item3.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void A306ВыходыNO_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Name.Length >= 11)
            {
                int numberOfButton =
                    int.Parse(Convert.ToString(button.Name[11]));

                foreach (Control item in A306Panel.Controls)
                {
                    if (item.Name.Contains("A306ВыходNO" + Char.GetNumericValue(button.Name[11])))
                    {
                        if (A306Parameters.A306ВыходыNO[numberOfButton - 1] == 0 && Выход > 0)
                        {
                            if ((numberOfButton > 4 && Выход == 12)) break;
                            if (numberOfButton <= 4 && Выход == 11) break;

                                button.BackgroundImage = ControlElementImages.A306CabelInput;
                                A306Parameters.A306ВыходыNO[numberOfButton - 1] = Выход;
                                button.Text = (Выход > 10)
                                    ? Convert.ToString("NO" + Выход % 10)
                                    : Convert.ToString(Выход);

                                RefreshCabels();

                                Выход = 0;
                                break;
                        }
                        else
                        {
                            button.BackgroundImage = null;
                            button.Text = "";
                            Выход = A306Parameters.A306ВыходыNO[numberOfButton - 1];
                            A306Parameters.A306ВыходыNO[numberOfButton - 1] = 0;

                            A306Panel.Refresh();
                            RefreshCabels();
                            break;
                        }
                    }
                }
            }
        }

        private void A306ВходNO_1_Click(object sender, EventArgs e)
        {
            A306Parameters.A306ВходNO_1 = !A306Parameters.A306ВходNO_1;
            if (A306Parameters.A306ВходNO_1)
            {
                A306ВходNO_1.BackgroundImage = ControlElementImages.A306CabelInput;
                Выход = 11;
                A306ВходNO_1.Text = "NO1";
            }
            else
            {
                A306ВходNO_1.BackgroundImage = null;
                Выход = 0;
                A306ВходNO_1.Text = "";
            }
        }

        private void A306ВходNO_2_Click(object sender, EventArgs e)
        {
            A306Parameters.A306ВходNO_2 = !A306Parameters.A306ВходNO_2;
            if (A306Parameters.A306ВходNO_2)
            {
                A306ВходNO_2.BackgroundImage = ControlElementImages.A306CabelInput;
                Выход = 12;
                A306ВходNO_2.Text = "NO2";
            }
            else
            {
                A306ВходNO_2.BackgroundImage = null; 
                Выход = 0;
                A306ВходNO_2.Text = "";
            }
        }
    }
}