namespace R440O.R440OForms.OrderScheme
{
    partial class OrderSchemeForm
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
            this.OrderSchemePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OrderSchemePanel
            // 
            this.OrderSchemePanel.BackgroundImage = global::R440O.BackgroundImages.OrderScheme;
            this.OrderSchemePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderSchemePanel.Location = new System.Drawing.Point(0, 0);
            this.OrderSchemePanel.Name = "OrderSchemePanel";
            this.OrderSchemePanel.Size = new System.Drawing.Size(1089, 749);
            this.OrderSchemePanel.TabIndex = 4;
            // 
            // OrderSchemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 751);
            this.Controls.Add(this.OrderSchemePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderSchemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СХЕМА-ПРИКАЗ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderSchemePanel;
    }
}