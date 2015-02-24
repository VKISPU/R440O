using System.Drawing;

namespace R440O.R440OForms.A306
{
    using System.Windows.Forms;
    using Parameters;
    /// <summary>
    /// Форма блока А306
    /// </summary>
    public partial class A306Form : Form
    {
        #region Specific Grid
        private int[,] A306ExitsNo =
        {
            { 130, 210 }, { 180, 210 }, { 235, 210 }, { 290, 210 },
            { 345, 210 }, { 400, 210 }, { 455, 210 }, { 510, 210 },
            { 565, 210 }, { 615, 210 }
        };

        private int[,] A306Exits =
        {
            { 105, 250 }, { 157, 250 }, { 210, 250 }, { 265, 250 },
            { 317, 250 }, { 373, 250 }, { 430, 250 }, { 480, 250 },
            { 537, 250 }, { 587, 250 }, { 636, 250 }
        }; 
        #endregion
        
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
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерДистанцМестн_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерДистанцМестн = !A306Parameters.A306ТумблерДистанцМестн;
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерВклВыкл_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерВклВыкл = !A306Parameters.A306ТумблерВклВыкл;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        #region Drag&Drop for PictureBox
        private int _xPos;
        private int _yPos;
        private bool _dragging;

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
           if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            var pBox = sender as PictureBox;
            if (!_dragging || null == pBox) return;
            pBox.Top = e.Y + pBox.Top - _yPos;
            pBox.Left = e.X + pBox.Left - _xPos;
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            var pBox = sender as PictureBox;
            if (null == pBox) return;
            _dragging = false;
            if (pBox.Name.Contains("cabelOutput"))
            {
                var cell = SnapToGrid(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2, A306ExitsNo);
                if (cell != -1)
                {
                    pBox.Left = A306ExitsNo[cell, 0];
                    pBox.Top = A306ExitsNo[cell, 1];
                }

                cell = SnapToGrid(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2, A306Exits);
                if (cell != -1)
                {
                    pBox.Left = A306Exits[cell, 0];
                    pBox.Top = A306Exits[cell, 1];
                }
                
                this.RefreshCabels(1);
            }
        }

        private int SnapToGrid(int x, int y, int[,] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                if (array[i, 0] < x && x < array[i, 0] + 50
                    && array[i, 1] < y && y < array[i, 1] + 50)
                {
                    return i;
                }
            }
            return -1;
        } 
        
        private void RefreshCabels(int cabelNumber)
        {
            var onePoint = new Point(0,0);
            var twoPoint = new Point(0,0);
            switch(cabelNumber)
            {
                case 1:
                {
                    onePoint = new Point((cabelOutput.Left + cabelOutput.Right) / 2, (cabelOutput.Top + cabelOutput.Bottom) / 2);
                    twoPoint = new Point((cabelOutput2.Left + cabelOutput2.Right) / 2, (cabelOutput2.Top + cabelOutput2.Bottom) / 2);}
                    break;
            }
            
            A306Panel.BackgroundImage = BackgroundImages.A306;
            Application.DoEvents();
            DrawLine(onePoint, twoPoint);
        }

        private void DrawLine(Point onePoint, Point twoPoint)
        {
            var myPen = new Pen(Color.DarkKhaki, 5);
            var panelGraphics = A306Panel.CreateGraphics();
            panelGraphics.DrawLine(myPen, onePoint, twoPoint);
            myPen.Dispose();
            panelGraphics.Dispose();
        }
        #endregion
    }
}