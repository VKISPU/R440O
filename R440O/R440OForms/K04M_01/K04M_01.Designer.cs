namespace R440O.R440OForms.K04M_01
{
    partial class K04M_01Form
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
            this.K04M_01Panel = new System.Windows.Forms.Panel();
            this.K04M_01Cover = new System.Windows.Forms.PictureBox();
            this.K04M_01Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K04M_01Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // K04M_01Panel
            // 
            this.K04M_01Panel.BackgroundImage = global::R440O.BackgroundImages.K04M_01;
            this.K04M_01Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.K04M_01Panel.Controls.Add(this.K04M_01Cover);
            this.K04M_01Panel.Location = new System.Drawing.Point(0, 0);
            this.K04M_01Panel.Name = "K04M_01Panel";
            this.K04M_01Panel.Size = new System.Drawing.Size(496, 707);
            this.K04M_01Panel.TabIndex = 0;
            // 
            // K04M_01Cover
            // 
            this.K04M_01Cover.BackColor = System.Drawing.Color.Transparent;
            this.K04M_01Cover.BackgroundImage = global::R440O.ControlElementImages.cover;
            this.K04M_01Cover.Location = new System.Drawing.Point(125, 95);
            this.K04M_01Cover.Name = "K04M_01Cover";
            this.K04M_01Cover.Size = new System.Drawing.Size(356, 559);
            this.K04M_01Cover.TabIndex = 2;
            this.K04M_01Cover.TabStop = false;
            this.K04M_01Cover.Click += new System.EventHandler(this.K04M_01Cover_Click);
            // 
            // K04M_01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 708);
            this.Controls.Add(this.K04M_01Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "K04M_01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K04M-1";
            this.K04M_01Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.K04M_01Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel K04M_01Panel;
        private System.Windows.Forms.PictureBox K04M_01Cover;
    }
}