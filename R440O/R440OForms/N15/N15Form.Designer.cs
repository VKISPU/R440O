namespace R440O.R440OForms.N15
{
    partial class N15Form
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
            this.N15Panel = new System.Windows.Forms.Panel();
            this.Н15КнопкаСтанцияВыкл = new System.Windows.Forms.Button();
            this.Н15КнопкаСтанцияВкл = new System.Windows.Forms.Button();
            this.N15Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // N15Panel
            // 
            this.N15Panel.BackgroundImage = global::R440O.BackgroundImages.N15;
            this.N15Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.N15Panel.Controls.Add(this.Н15КнопкаСтанцияВыкл);
            this.N15Panel.Controls.Add(this.Н15КнопкаСтанцияВкл);
            this.N15Panel.Location = new System.Drawing.Point(0, 0);
            this.N15Panel.Name = "N15Panel";
            this.N15Panel.Size = new System.Drawing.Size(1042, 503);
            this.N15Panel.TabIndex = 2;
            // 
            // Н15КнопкаСтанцияВыкл
            // 
            this.Н15КнопкаСтанцияВыкл.BackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = global::R440O.ControlElementImages.buttonOffUpRed;
            this.Н15КнопкаСтанцияВыкл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Н15КнопкаСтанцияВыкл.FlatAppearance.BorderSize = 0;
            this.Н15КнопкаСтанцияВыкл.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВыкл.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВыкл.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Н15КнопкаСтанцияВыкл.Location = new System.Drawing.Point(791, 111);
            this.Н15КнопкаСтанцияВыкл.Name = "Н15КнопкаСтанцияВыкл";
            this.Н15КнопкаСтанцияВыкл.Size = new System.Drawing.Size(89, 48);
            this.Н15КнопкаСтанцияВыкл.TabIndex = 1;
            this.Н15КнопкаСтанцияВыкл.UseVisualStyleBackColor = false;
            this.Н15КнопкаСтанцияВыкл.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Н15КнопкаСтанцияВыкл_MouseDown);
            this.Н15КнопкаСтанцияВыкл.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Н15КнопкаСтанцияВыкл_MouseUp);
            // 
            // Н15КнопкаСтанцияВкл
            // 
            this.Н15КнопкаСтанцияВкл.BackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВкл.BackgroundImage = global::R440O.ControlElementImages.buttonOnUpBlack;
            this.Н15КнопкаСтанцияВкл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Н15КнопкаСтанцияВкл.FlatAppearance.BorderSize = 0;
            this.Н15КнопкаСтанцияВкл.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВкл.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Н15КнопкаСтанцияВкл.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Н15КнопкаСтанцияВкл.Location = new System.Drawing.Point(788, 42);
            this.Н15КнопкаСтанцияВкл.Name = "Н15КнопкаСтанцияВкл";
            this.Н15КнопкаСтанцияВкл.Size = new System.Drawing.Size(89, 61);
            this.Н15КнопкаСтанцияВкл.TabIndex = 0;
            this.Н15КнопкаСтанцияВкл.UseVisualStyleBackColor = false;
            this.Н15КнопкаСтанцияВкл.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Н15КнопкаСтанцияВкл_MouseDown);
            this.Н15КнопкаСтанцияВкл.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Н15КнопкаСтанцияВкл_MouseUp);
            // 
            // N15Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 501);
            this.Controls.Add(this.N15Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "N15Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Н15";
            this.Load += new System.EventHandler(this.N15Form_Load);
            this.N15Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel N15Panel;
        private System.Windows.Forms.Button Н15КнопкаСтанцияВкл;
        private System.Windows.Forms.Button Н15КнопкаСтанцияВыкл;
    }
}