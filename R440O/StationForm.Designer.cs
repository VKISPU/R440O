namespace R440O
{
    partial class StationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.OfflineWorkButton = new System.Windows.Forms.Button();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.LastByteIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подождите, идет поиск сервера....";
            this.label1.Visible = false;
            // 
            // OfflineWorkButton
            // 
            this.OfflineWorkButton.Location = new System.Drawing.Point(192, 39);
            this.OfflineWorkButton.Name = "OfflineWorkButton";
            this.OfflineWorkButton.Size = new System.Drawing.Size(134, 58);
            this.OfflineWorkButton.TabIndex = 1;
            this.OfflineWorkButton.Text = "Работать оффлайн";
            this.OfflineWorkButton.UseVisualStyleBackColor = true;
            this.OfflineWorkButton.Click += new System.EventHandler(this.OfflineWorkButton_Click);
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.Enabled = false;
            this.StartSearchButton.Location = new System.Drawing.Point(15, 71);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(136, 26);
            this.StartSearchButton.TabIndex = 2;
            this.StartSearchButton.Text = "Начать поиск";
            this.StartSearchButton.UseVisualStyleBackColor = true;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            // 
            // LastByteIP
            // 
            this.LastByteIP.Location = new System.Drawing.Point(36, 39);
            this.LastByteIP.Name = "LastByteIP";
            this.LastByteIP.Size = new System.Drawing.Size(115, 20);
            this.LastByteIP.TabIndex = 3;
            this.LastByteIP.TextChanged += new System.EventHandler(this.LastByteIP_TextChanged);
            this.LastByteIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastByteIP_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "id:";
            // 
            // pcNumber
            // 
            this.pcNumber.AutoSize = true;
            this.pcNumber.Location = new System.Drawing.Point(12, 9);
            this.pcNumber.Name = "pcNumber";
            this.pcNumber.Size = new System.Drawing.Size(91, 13);
            this.pcNumber.TabIndex = 5;
            this.pcNumber.Text = "Номер станции: ";
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 142);
            this.Controls.Add(this.pcNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastByteIP);
            this.Controls.Add(this.StartSearchButton);
            this.Controls.Add(this.OfflineWorkButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StationForm";
            this.Text = "Поиск сервера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OfflineWorkButton;
        private System.Windows.Forms.Button StartSearchButton;
        private System.Windows.Forms.TextBox LastByteIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pcNumber;
    }
}