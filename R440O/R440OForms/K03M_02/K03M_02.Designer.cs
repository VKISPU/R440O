namespace R440O.R440OForms.K03M_02
{
    partial class K03M_02Form
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
            this.K03M_02Panel = new System.Windows.Forms.Panel();
            this.K03M_02Cover = new System.Windows.Forms.PictureBox();
            this.K03M_02ButtonInside = new System.Windows.Forms.Button();
            this.K03M_02Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K03M_02Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // K03M_02Panel
            // 
            this.K03M_02Panel.BackgroundImage = global::R440O.BackgroundImages.K03M_01;
            this.K03M_02Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.K03M_02Panel.Controls.Add(this.K03M_02ButtonInside);
            this.K03M_02Panel.Controls.Add(this.K03M_02Cover);
            this.K03M_02Panel.Location = new System.Drawing.Point(0, 0);
            this.K03M_02Panel.Name = "K03M_02Panel";
            this.K03M_02Panel.Size = new System.Drawing.Size(496, 707);
            this.K03M_02Panel.TabIndex = 0;
            // 
            // K03M_02Cover
            // 
            this.K03M_02Cover.BackColor = System.Drawing.Color.Transparent;
            this.K03M_02Cover.BackgroundImage = global::R440O.ControlElementImages.kulonCover;
            this.K03M_02Cover.Location = new System.Drawing.Point(125, 95);
            this.K03M_02Cover.Name = "K03M_02Cover";
            this.K03M_02Cover.Size = new System.Drawing.Size(356, 559);
            this.K03M_02Cover.TabIndex = 1;
            this.K03M_02Cover.TabStop = false;
            this.K03M_02Cover.Click += new System.EventHandler(this.K03M_02Cover_Click);
            // 
            // K03M_02ButtonInside
            // 
            this.K03M_02ButtonInside.BackColor = System.Drawing.Color.Transparent;
            this.K03M_02ButtonInside.FlatAppearance.BorderSize = 0;
            this.K03M_02ButtonInside.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.K03M_02ButtonInside.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.K03M_02ButtonInside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K03M_02ButtonInside.Location = new System.Drawing.Point(37, 265);
            this.K03M_02ButtonInside.Name = "K03M_02ButtonInside";
            this.K03M_02ButtonInside.Size = new System.Drawing.Size(105, 140);
            this.K03M_02ButtonInside.TabIndex = 9;
            this.K03M_02ButtonInside.UseVisualStyleBackColor = false;
            this.K03M_02ButtonInside.Click += new System.EventHandler(this.K03M_02ButtonInside_Click);
            // 
            // K03M_02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 708);
            this.Controls.Add(this.K03M_02Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "K03M_02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K03M-2";
            this.K03M_02Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.K03M_02Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel K03M_02Panel;
        private System.Windows.Forms.PictureBox K03M_02Cover;
        private System.Windows.Forms.Button K03M_02ButtonInside;
    }
}