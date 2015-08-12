namespace R440O.BaseClasses
{
    partial class MessageBox
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
            this.Message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.Enabled = false;
            this.Message.FlatAppearance.BorderSize = 0;
            this.Message.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Message.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(12, 12);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(741, 255);
            this.Message.TabIndex = 0;
            this.Message.Text = "Message";
            this.Message.UseVisualStyleBackColor = true;
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 279);
            this.Controls.Add(this.Message);
            this.Name = "MessageBox";
            this.Text = "Title";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Message;

    }
}