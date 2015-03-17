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
            this.Panel = new System.Windows.Forms.Panel();
            this.ЛампочкаАвария = new System.Windows.Forms.PictureBox();
            this.ЛампочкаСетьВкл = new System.Windows.Forms.PictureBox();
            this.ПереключательКонтрольНапр = new System.Windows.Forms.Button();
            this.КабельВход2 = new System.Windows.Forms.Button();
            this.КабельВход1 = new System.Windows.Forms.Button();
            this.ИндикаторНапряжение = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ЛампочкаАвария)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЛампочкаСетьВкл)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИндикаторНапряжение)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackgroundImage = global::R440O.BackgroundImages.VoltageStabilizer;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel.Controls.Add(this.ИндикаторНапряжение);
            this.Panel.Controls.Add(this.ЛампочкаАвария);
            this.Panel.Controls.Add(this.ЛампочкаСетьВкл);
            this.Panel.Controls.Add(this.ПереключательКонтрольНапр);
            this.Panel.Controls.Add(this.КабельВход2);
            this.Panel.Controls.Add(this.КабельВход1);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "VoltageStabilizerPanel";
            this.Panel.Size = new System.Drawing.Size(1092, 773);
            this.Panel.TabIndex = 0;
            // 
            // ЛампочкаАвария
            // 
            this.ЛампочкаАвария.BackColor = System.Drawing.Color.Transparent;
            this.ЛампочкаАвария.BackgroundImage = global::R440O.ControlElementImages.lampType6OnRed;
            this.ЛампочкаАвария.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ЛампочкаАвария.Location = new System.Drawing.Point(646, 10);
            this.ЛампочкаАвария.Name = "VoltageStabilizerЛампочкаАвария";
            this.ЛампочкаАвария.Size = new System.Drawing.Size(51, 45);
            this.ЛампочкаАвария.TabIndex = 36;
            this.ЛампочкаАвария.TabStop = false;
            // 
            // ЛампочкаСетьВкл
            // 
            this.ЛампочкаСетьВкл.BackColor = System.Drawing.Color.Transparent;
            this.ЛампочкаСетьВкл.BackgroundImage = global::R440O.ControlElementImages.lampType10OnGreen;
            this.ЛампочкаСетьВкл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ЛампочкаСетьВкл.Location = new System.Drawing.Point(582, 14);
            this.ЛампочкаСетьВкл.Name = "VoltageStabilizerЛампочкаСетьВкл";
            this.ЛампочкаСетьВкл.Size = new System.Drawing.Size(51, 45);
            this.ЛампочкаСетьВкл.TabIndex = 35;
            this.ЛампочкаСетьВкл.TabStop = false;
            // 
            // ПереключательКонтрольНапр
            // 
            this.ПереключательКонтрольНапр.BackColor = System.Drawing.Color.Transparent;
            this.ПереключательКонтрольНапр.BackgroundImage = global::R440O.ControlElementImages.toggleType3;
            this.ПереключательКонтрольНапр.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ПереключательКонтрольНапр.FlatAppearance.BorderSize = 0;
            this.ПереключательКонтрольНапр.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ПереключательКонтрольНапр.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ПереключательКонтрольНапр.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ПереключательКонтрольНапр.Location = new System.Drawing.Point(796, 63);
            this.ПереключательКонтрольНапр.Name = "VoltageStabilizerПереключательКонтрольНапр";
            this.ПереключательКонтрольНапр.Size = new System.Drawing.Size(81, 82);
            this.ПереключательКонтрольНапр.TabIndex = 34;
            this.ПереключательКонтрольНапр.UseVisualStyleBackColor = false;
            this.ПереключательКонтрольНапр.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ПереключательКонтрольНапр_MouseUp);
            // 
            // КабельВход2
            // 
            this.КабельВход2.BackColor = System.Drawing.Color.Transparent;
            this.КабельВход2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.КабельВход2.FlatAppearance.BorderSize = 0;
            this.КабельВход2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.КабельВход2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.КабельВход2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.КабельВход2.Location = new System.Drawing.Point(-12, 410);
            this.КабельВход2.Name = "VoltageStabilizerКабельВход2";
            this.КабельВход2.Size = new System.Drawing.Size(107, 99);
            this.КабельВход2.TabIndex = 33;
            this.КабельВход2.UseVisualStyleBackColor = false;
            this.КабельВход2.Click += new System.EventHandler(this.КабельВход2_Click);
            // 
            // VoltageStabilizerКабельВход1
            // 
            this.КабельВход1.BackColor = System.Drawing.Color.Transparent;
            this.КабельВход1.BackgroundImage = global::R440O.ControlElementImages.voltageStabilizerInput;
            this.КабельВход1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.КабельВход1.FlatAppearance.BorderSize = 0;
            this.КабельВход1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.КабельВход1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.КабельВход1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.КабельВход1.Location = new System.Drawing.Point(-12, 306);
            this.КабельВход1.Name = "VoltageStabilizerКабельВход1";
            this.КабельВход1.Size = new System.Drawing.Size(107, 99);
            this.КабельВход1.TabIndex = 32;
            this.КабельВход1.UseVisualStyleBackColor = false;
            this.КабельВход1.Click += new System.EventHandler(this.КабельВход1_Click);
            // 
            // VoltageStabilizerИндикаторНапряжение
            // 
            this.ИндикаторНапряжение.BackColor = System.Drawing.Color.Transparent;
            this.ИндикаторНапряжение.BackgroundImage = global::R440O.ControlElementImages.arrowNormal;
            this.ИндикаторНапряжение.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ИндикаторНапряжение.Location = new System.Drawing.Point(370, 41);
            this.ИндикаторНапряжение.Name = "VoltageStabilizerИндикаторНапряжение";
            this.ИндикаторНапряжение.Size = new System.Drawing.Size(64, 81);
            this.ИндикаторНапряжение.TabIndex = 66;
            this.ИндикаторНапряжение.TabStop = false;
            // 
            // VoltageStabilizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 741);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VoltageStabilizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТАБИЛИЗАТОР НАПРЯЖЕНИЯ";
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ЛампочкаАвария)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЛампочкаСетьВкл)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИндикаторНапряжение)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button КабельВход2;
        private System.Windows.Forms.Button КабельВход1;
        private System.Windows.Forms.Button ПереключательКонтрольНапр;
        private System.Windows.Forms.PictureBox ЛампочкаСетьВкл;
        private System.Windows.Forms.PictureBox ЛампочкаАвария;
        private System.Windows.Forms.PictureBox ИндикаторНапряжение;
    }
}