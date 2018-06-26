namespace AdapterSwitcher
{
    partial class MainForm
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
            this.ChangeToWifiButton = new System.Windows.Forms.Button();
            this.ChangeToEthernetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeToWifiButton
            // 
            this.ChangeToWifiButton.Location = new System.Drawing.Point(12, 12);
            this.ChangeToWifiButton.Name = "ChangeToWifiButton";
            this.ChangeToWifiButton.Size = new System.Drawing.Size(286, 103);
            this.ChangeToWifiButton.TabIndex = 0;
            this.ChangeToWifiButton.Text = "Change to WIFI";
            this.ChangeToWifiButton.UseVisualStyleBackColor = true;
            this.ChangeToWifiButton.Click += new System.EventHandler(this.ChangeToWifiButton_Click);
            // 
            // ChangeToEthernetButton
            // 
            this.ChangeToEthernetButton.Location = new System.Drawing.Point(12, 121);
            this.ChangeToEthernetButton.Name = "ChangeToEthernetButton";
            this.ChangeToEthernetButton.Size = new System.Drawing.Size(286, 103);
            this.ChangeToEthernetButton.TabIndex = 1;
            this.ChangeToEthernetButton.Text = "Change to Ethernet";
            this.ChangeToEthernetButton.UseVisualStyleBackColor = true;
            this.ChangeToEthernetButton.Click += new System.EventHandler(this.ChangeToEthernetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 235);
            this.Controls.Add(this.ChangeToEthernetButton);
            this.Controls.Add(this.ChangeToWifiButton);
            this.Name = "Form1";
            this.Text = "Adapter Switcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeToWifiButton;
        private System.Windows.Forms.Button ChangeToEthernetButton;
    }
}

