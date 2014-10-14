namespace R440O.R440OForms.VoltageStabilizer
{
    partial class VoltageStabilizerForm
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
            this.VoltageStabilizerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // VoltageStabilizerPanel
            // 
            this.VoltageStabilizerPanel.BackgroundImage = global::R440O.BackgroundImages.VoltageStabilizer;
            this.VoltageStabilizerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VoltageStabilizerPanel.Location = new System.Drawing.Point(0, 0);
            this.VoltageStabilizerPanel.Name = "VoltageStabilizerPanel";
            this.VoltageStabilizerPanel.Size = new System.Drawing.Size(1092, 773);
            this.VoltageStabilizerPanel.TabIndex = 0;
            // 
            // VoltageStabilizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 741);
            this.Controls.Add(this.VoltageStabilizerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VoltageStabilizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТАБИЛИЗАТОР НАПРЯЖЕНИЯ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VoltageStabilizerPanel;
    }
}