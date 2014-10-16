namespace R440O.R440OForms.K04M_02
{
    partial class K04M_02Form
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
            this.K04M_02Panel = new System.Windows.Forms.Panel();
            this.K04M_02Cover = new System.Windows.Forms.PictureBox();
            this.K04M_02Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K04M_02Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // K04M_02Panel
            // 
            this.K04M_02Panel.BackgroundImage = global::R440O.BackgroundImages.K04M_01;
            this.K04M_02Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.K04M_02Panel.Controls.Add(this.K04M_02Cover);
            this.K04M_02Panel.Location = new System.Drawing.Point(0, 0);
            this.K04M_02Panel.Name = "K04M_02Panel";
            this.K04M_02Panel.Size = new System.Drawing.Size(496, 707);
            this.K04M_02Panel.TabIndex = 0;
            // 
            // K04M_02Cover
            // 
            this.K04M_02Cover.BackColor = System.Drawing.Color.Transparent;
            this.K04M_02Cover.BackgroundImage = global::R440O.ControlElementImages.cover;
            this.K04M_02Cover.Location = new System.Drawing.Point(125, 95);
            this.K04M_02Cover.Name = "K04M_02Cover";
            this.K04M_02Cover.Size = new System.Drawing.Size(356, 559);
            this.K04M_02Cover.TabIndex = 2;
            this.K04M_02Cover.TabStop = false;
            this.K04M_02Cover.Click += new System.EventHandler(this.K04M_02Cover_Click);
            // 
            // K04M_02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 708);
            this.Controls.Add(this.K04M_02Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "K04M_02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K04M-2";
            this.K04M_02Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.K04M_02Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel K04M_02Panel;
        private System.Windows.Forms.PictureBox K04M_02Cover;
    }
}