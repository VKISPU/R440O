namespace Retranslator
{
    partial class ServerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StantionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StantionListBox
            // 
            this.StantionListBox.FormattingEnabled = true;
            this.StantionListBox.Location = new System.Drawing.Point(25, 12);
            this.StantionListBox.Name = "StantionListBox";
            this.StantionListBox.Size = new System.Drawing.Size(428, 303);
            this.StantionListBox.TabIndex = 0;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 330);
            this.Controls.Add(this.StantionListBox);
            this.Name = "ServerForm";
            this.Text = "Ретранслятор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StantionListBox;
    }
}

