namespace R440O.R440OForms.Stabilizator
{
    partial class StabilizatorForm
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
            this.StabilizatorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StabilizatorPanel
            // 
            this.StabilizatorPanel.BackgroundImage = global::R440O.BackgroundImages.Stabilizator;
            this.StabilizatorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StabilizatorPanel.Location = new System.Drawing.Point(0, 0);
            this.StabilizatorPanel.Name = "StabilizatorPanel";
            this.StabilizatorPanel.Size = new System.Drawing.Size(1092, 773);
            this.StabilizatorPanel.TabIndex = 0;
            // 
            // StabilizatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 741);
            this.Controls.Add(this.StabilizatorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StabilizatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТАБИЛИЗАТОР НАПРЯЖЕНИЯ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StabilizatorPanel;
    }
}