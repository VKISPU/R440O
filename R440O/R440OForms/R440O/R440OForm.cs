//-----------------------------------------------------------------------
// <copyright file="R440OForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.R440O
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using InternalBlocks;

    /// <summary>
    /// Форма станции Р440-О
    /// </summary>
    public partial class R440OForm : Form
    {
        public event Action FormClosedEvent;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="R440OForm"/>
        /// </summary>
        public R440OForm()
        {
            this.InitializeComponent();
            Antenna.StartServerPing();
            Antenna.ErrorEvent += ServerError;
        }

        private bool serverErrorFlag = false;
        private void ServerError()
        {
            if (!serverErrorFlag)
            {
                serverErrorFlag = true;
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Возникла проблема с сервером!");
                    this.Close();
                }));
            }
        }

        /// <summary>
        /// Открытие формы блока в соотвествии с нажатой кнопкой
        /// </summary>
        /// <param name="sender">Нажатая кнопка</param>
        /// <param name="e">Событие нажатия</param>
        private void R440OButtonCommon_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            const string buttonStrings = "Button";
            var blockName =
                button.Name.Substring(button.Name.IndexOf(buttonStrings, StringComparison.Ordinal) + buttonStrings.Length);
            var formName = blockName + "Form";

            // Активация формы соответствующей нажатой кнопке
            foreach (var form in OwnedForms.Where(form => form.Name == formName))
            {
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                return;
            }

            // Открытие новой формы соответствующей нажатой кнопке
            try
            {
                const string r440OFormsString = "R440O.R440OForms.";
                var typeName = r440OFormsString + blockName + "." + formName;
                // ReSharper disable once AssignNullToNotNullAttribute by trycatch
                var thisForm = Activator.CreateInstance(Type.GetType(typeName));
                var newForm = (Form)thisForm;
                newForm.Show(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void R440OForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Antenna.StopServerPing();
            FormClosedEvent();
        }

        private void R440OForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Antenna.StopServerPing();
        }
    }
}