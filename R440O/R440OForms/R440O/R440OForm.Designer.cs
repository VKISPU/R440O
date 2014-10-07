namespace R440O.R440OForms.R440O
{
    partial class R440OForm
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
            this.R440OPanel = new System.Windows.Forms.Panel();
            this.R440ObuttonA205M_1 = new System.Windows.Forms.Button();
            this.R440OPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // R440OPanel
            // 
            this.R440OPanel.BackgroundImage = global::R440O.BackgroundImages.R440O;
            this.R440OPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.R440OPanel.Controls.Add(this.R440ObuttonA205M_1);
            this.R440OPanel.Location = new System.Drawing.Point(0, 0);
            this.R440OPanel.Name = "R440OPanel";
            this.R440OPanel.Size = new System.Drawing.Size(1101, 391);
            this.R440OPanel.TabIndex = 0;
            // 
            // R440ObuttonA205M_1
            // 
            this.R440ObuttonA205M_1.BackColor = System.Drawing.Color.Transparent;
            this.R440ObuttonA205M_1.FlatAppearance.BorderSize = 0;
            this.R440ObuttonA205M_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.R440ObuttonA205M_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.R440ObuttonA205M_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R440ObuttonA205M_1.Location = new System.Drawing.Point(391, 112);
            this.R440ObuttonA205M_1.Name = "R440ObuttonA205M_1";
            this.R440ObuttonA205M_1.Size = new System.Drawing.Size(137, 55);
            this.R440ObuttonA205M_1.TabIndex = 0;
            this.R440ObuttonA205M_1.UseVisualStyleBackColor = false;
            this.R440ObuttonA205M_1.Click += new System.EventHandler(this.buttonA205M_1_Click);
            // 
            // R440OForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 389);
            this.Controls.Add(this.R440OPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "R440OForm";
            this.Text = "P-440-O";
            this.R440OPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel R440OPanel;
        private System.Windows.Forms.Button R440ObuttonA205M_1;
    }
}

