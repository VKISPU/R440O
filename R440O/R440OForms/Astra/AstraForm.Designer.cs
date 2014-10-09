namespace R440O.R440OForms.Astra
{
    partial class AstraForm
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
            this.AstraPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AstraPanel
            // 
            this.AstraPanel.BackgroundImage = global::R440O.BackgroundImages.Astra;
            this.AstraPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AstraPanel.Location = new System.Drawing.Point(0, 0);
            this.AstraPanel.Name = "AstraPanel";
            this.AstraPanel.Size = new System.Drawing.Size(715, 480);
            this.AstraPanel.TabIndex = 1;
            // 
            // AstraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.AstraPanel);
            this.MaximizeBox = false;
            this.Name = "AstraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АСТРА";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AstraPanel;
    }
}