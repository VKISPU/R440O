namespace R440O.R440OForms.PowerShield
{
    partial class PowerShieldForm
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
            this.PowerShieldPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PowerShieldPanel
            // 
            this.PowerShieldPanel.BackgroundImage = global::R440O.BackgroundImages.PowerShield;
            this.PowerShieldPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerShieldPanel.Location = new System.Drawing.Point(0, 0);
            this.PowerShieldPanel.Name = "PowerShieldPanel";
            this.PowerShieldPanel.Size = new System.Drawing.Size(970, 749);
            this.PowerShieldPanel.TabIndex = 4;
            // 
            // PowerShieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 733);
            this.Controls.Add(this.PowerShieldPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PowerShieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КАБЕЛЬНЫЙ ВВОД";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PowerShieldPanel;
    }
}