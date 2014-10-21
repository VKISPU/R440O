namespace R440O.R440OForms.BMB
{
    partial class BMBForm
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
            this.BMBPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BMBPanel
            // 
            this.BMBPanel.BackgroundImage = global::R440O.BackgroundImages.BMB;
            this.BMBPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BMBPanel.Location = new System.Drawing.Point(0, 0);
            this.BMBPanel.Name = "BMBPanel";
            this.BMBPanel.Size = new System.Drawing.Size(954, 458);
            this.BMBPanel.TabIndex = 1;
            // 
            // BMBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 455);
            this.Controls.Add(this.BMBPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БМБ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BMBPanel;
    }
}