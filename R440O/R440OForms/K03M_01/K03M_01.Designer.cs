namespace R440O.R440OForms.K03M_01
{
    partial class K03M_01Form
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
            this.K03M_01Panel = new System.Windows.Forms.Panel();
            this.K03M_01Cover = new System.Windows.Forms.PictureBox();
            this.K03M_01ButtonInside = new System.Windows.Forms.Button();
            this.K03M_01Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K03M_01Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // K03M_01Panel
            // 
            this.K03M_01Panel.BackgroundImage = global::R440O.BackgroundImages.K03M_01;
            this.K03M_01Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.K03M_01Panel.Controls.Add(this.K03M_01ButtonInside);
            this.K03M_01Panel.Controls.Add(this.K03M_01Cover);
            this.K03M_01Panel.Location = new System.Drawing.Point(0, 0);
            this.K03M_01Panel.Name = "K03M_01Panel";
            this.K03M_01Panel.Size = new System.Drawing.Size(496, 707);
            this.K03M_01Panel.TabIndex = 0;
            // 
            // K03M_01Cover
            // 
            this.K03M_01Cover.BackColor = System.Drawing.Color.Transparent;
            this.K03M_01Cover.BackgroundImage = global::R440O.ControlElementImages.kulonCover;
            this.K03M_01Cover.Location = new System.Drawing.Point(125, 95);
            this.K03M_01Cover.Name = "K03M_01Cover";
            this.K03M_01Cover.Size = new System.Drawing.Size(356, 559);
            this.K03M_01Cover.TabIndex = 0;
            this.K03M_01Cover.TabStop = false;
            this.K03M_01Cover.Click += new System.EventHandler(this.K03M_01Cover_Click);
            // 
            // K03M_01ButtonInside
            // 
            this.K03M_01ButtonInside.BackColor = System.Drawing.Color.Transparent;
            this.K03M_01ButtonInside.FlatAppearance.BorderSize = 0;
            this.K03M_01ButtonInside.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.K03M_01ButtonInside.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.K03M_01ButtonInside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K03M_01ButtonInside.Location = new System.Drawing.Point(37, 265);
            this.K03M_01ButtonInside.Name = "K03M_01ButtonInside";
            this.K03M_01ButtonInside.Size = new System.Drawing.Size(105, 140);
            this.K03M_01ButtonInside.TabIndex = 9;
            this.K03M_01ButtonInside.UseVisualStyleBackColor = false;
            this.K03M_01ButtonInside.Click += new System.EventHandler(this.K03M_01ButtonInside_Click);
            // 
            // K03M_01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 708);
            this.Controls.Add(this.K03M_01Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "K03M_01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K03M-1";
            this.K03M_01Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.K03M_01Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel K03M_01Panel;
        private System.Windows.Forms.PictureBox K03M_01Cover;
        private System.Windows.Forms.Button K03M_01ButtonInside;
    }
}