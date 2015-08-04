namespace R440O.R440OForms.PowerCabel
{
    partial class PowerCabelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PowerCabelPanel = new System.Windows.Forms.Panel();
            this.КабельСеть = new System.Windows.Forms.Button();
            this.ТумблерОсвещение = new System.Windows.Forms.Button();
            this.PowerCabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerCabelPanel
            // 
            this.PowerCabelPanel.BackgroundImage = global::R440O.BackgroundImages.PowerCabel;
            this.PowerCabelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerCabelPanel.Controls.Add(this.КабельСеть);
            this.PowerCabelPanel.Controls.Add(this.ТумблерОсвещение);
            this.PowerCabelPanel.Location = new System.Drawing.Point(0, 0);
            this.PowerCabelPanel.Name = "PowerCabelPanel";
            this.PowerCabelPanel.Size = new System.Drawing.Size(862, 648);
            this.PowerCabelPanel.TabIndex = 4;
            // 
            // КабельСеть
            // 
            this.КабельСеть.BackColor = System.Drawing.Color.Transparent;
            this.КабельСеть.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.КабельСеть.FlatAppearance.BorderSize = 0;
            this.КабельСеть.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.КабельСеть.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.КабельСеть.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.КабельСеть.Location = new System.Drawing.Point(322, 156);
            this.КабельСеть.Name = "КабельСеть";
            this.КабельСеть.Size = new System.Drawing.Size(235, 489);
            this.КабельСеть.TabIndex = 28;
            this.КабельСеть.UseVisualStyleBackColor = false;
            this.КабельСеть.Click += new System.EventHandler(this.КабельСеть_Click);
            // 
            // ТумблерОсвещение
            // 
            this.ТумблерОсвещение.BackColor = System.Drawing.Color.Transparent;
            this.ТумблерОсвещение.BackgroundImage = global::R440O.ControlElementImages.tumblerType4Left;
            this.ТумблерОсвещение.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ТумблерОсвещение.FlatAppearance.BorderSize = 0;
            this.ТумблерОсвещение.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ТумблерОсвещение.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ТумблерОсвещение.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ТумблерОсвещение.Location = new System.Drawing.Point(668, 66);
            this.ТумблерОсвещение.Name = "ТумблерОсвещение";
            this.ТумблерОсвещение.Size = new System.Drawing.Size(61, 38);
            this.ТумблерОсвещение.TabIndex = 27;
            this.ТумблерОсвещение.UseVisualStyleBackColor = false;
            this.ТумблерОсвещение.Click += new System.EventHandler(this.ТумблерОсвещение_Click);
            // 
            // PowerCabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 648);
            this.Controls.Add(this.PowerCabelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PowerCabelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КАБЕЛЬ ЭЛЕКТРОПИТАНИЯ";
            this.PowerCabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PowerCabelPanel;
        private System.Windows.Forms.Button ТумблерОсвещение;
        private System.Windows.Forms.Button КабельСеть;
    }
}