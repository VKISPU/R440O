namespace R440O.R440OForms.NO
{
    partial class NOForm
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
            this.NOPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NOPanel
            // 
            this.NOPanel.BackgroundImage = global::R440O.BackgroundImages.NO;
            this.NOPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NOPanel.Location = new System.Drawing.Point(0, 0);
            this.NOPanel.Name = "NOPanel";
            this.NOPanel.Size = new System.Drawing.Size(989, 745);
            this.NOPanel.TabIndex = 2;
            // 
            // NOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 741);
            this.Controls.Add(this.NOPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "НО";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NOPanel;
    }
}