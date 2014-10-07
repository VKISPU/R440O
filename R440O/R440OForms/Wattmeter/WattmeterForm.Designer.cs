namespace R440O.R440OForms.Wattmeter
{
    partial class WattmeterForm
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
            this.WattmeterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // WattmeterPanel
            // 
            this.WattmeterPanel.BackgroundImage = global::R440O.BackgroundImages.Wattmeter;
            this.WattmeterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WattmeterPanel.Location = new System.Drawing.Point(0, 0);
            this.WattmeterPanel.Name = "WattmeterPanel";
            this.WattmeterPanel.Size = new System.Drawing.Size(707, 544);
            this.WattmeterPanel.TabIndex = 0;
            // 
            // WattmeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 542);
            this.Controls.Add(this.WattmeterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WattmeterForm";
            this.Text = "БЛОК ВАТТМЕТРА ИЗМЕРИТЕЛЬНЫЙ Я2М-66";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WattmeterPanel;
    }
}