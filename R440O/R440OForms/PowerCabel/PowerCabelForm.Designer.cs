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
            this.PowerCabelВход = new System.Windows.Forms.Button();
            this.PowerCabelТумблерОсвещение = new System.Windows.Forms.Button();
            this.PowerCabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerCabelPanel
            // 
            this.PowerCabelPanel.BackgroundImage = global::R440O.BackgroundImages.PowerCabel;
            this.PowerCabelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerCabelPanel.Controls.Add(this.PowerCabelВход);
            this.PowerCabelPanel.Controls.Add(this.PowerCabelТумблерОсвещение);
            this.PowerCabelPanel.Location = new System.Drawing.Point(0, 0);
            this.PowerCabelPanel.Name = "PowerCabelPanel";
            this.PowerCabelPanel.Size = new System.Drawing.Size(862, 648);
            this.PowerCabelPanel.TabIndex = 4;
            // 
            // PowerCabelВход
            // 
            this.PowerCabelВход.BackColor = System.Drawing.Color.Transparent;
            this.PowerCabelВход.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerCabelВход.FlatAppearance.BorderSize = 0;
            this.PowerCabelВход.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PowerCabelВход.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PowerCabelВход.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerCabelВход.Location = new System.Drawing.Point(322, 156);
            this.PowerCabelВход.Name = "PowerCabelВход";
            this.PowerCabelВход.Size = new System.Drawing.Size(235, 489);
            this.PowerCabelВход.TabIndex = 28;
            this.PowerCabelВход.UseVisualStyleBackColor = false;
            this.PowerCabelВход.Click += new System.EventHandler(this.PowerCabelВход_Click);
            // 
            // PowerCabelТумблерОсвещение
            // 
            this.PowerCabelТумблерОсвещение.BackColor = System.Drawing.Color.Transparent;
            this.PowerCabelТумблерОсвещение.BackgroundImage = global::R440O.ControlElementImages.tumblerHorizontalType4Left;
            this.PowerCabelТумблерОсвещение.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerCabelТумблерОсвещение.FlatAppearance.BorderSize = 0;
            this.PowerCabelТумблерОсвещение.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PowerCabelТумблерОсвещение.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PowerCabelТумблерОсвещение.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerCabelТумблерОсвещение.Location = new System.Drawing.Point(668, 66);
            this.PowerCabelТумблерОсвещение.Name = "PowerCabelТумблерОсвещение";
            this.PowerCabelТумблерОсвещение.Size = new System.Drawing.Size(61, 38);
            this.PowerCabelТумблерОсвещение.TabIndex = 27;
            this.PowerCabelТумблерОсвещение.UseVisualStyleBackColor = false;
            this.PowerCabelТумблерОсвещение.Click += new System.EventHandler(this.PowerCabelТумблерОсвещение_Click);
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
            this.Text = "ЩИТ ЭЛЕКТРОПИТАНИЯ";
            this.PowerCabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PowerCabelPanel;
        private System.Windows.Forms.Button PowerCabelТумблерОсвещение;
        private System.Windows.Forms.Button PowerCabelВход;
    }
}