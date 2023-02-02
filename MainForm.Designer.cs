
namespace Alpays_Radio
{
    partial class FirstWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OnlineButton = new System.Windows.Forms.Button();
            this.OfflineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OnlineButton
            // 
            this.OnlineButton.Location = new System.Drawing.Point(65, 31);
            this.OnlineButton.Name = "OnlineButton";
            this.OnlineButton.Size = new System.Drawing.Size(191, 63);
            this.OnlineButton.TabIndex = 0;
            this.OnlineButton.Text = "Online";
            this.OnlineButton.UseVisualStyleBackColor = true;
            this.OnlineButton.Click += new System.EventHandler(this.OnlineButton_Click);
            // 
            // OfflineButton
            // 
            this.OfflineButton.Location = new System.Drawing.Point(65, 100);
            this.OfflineButton.Name = "OfflineButton";
            this.OfflineButton.Size = new System.Drawing.Size(191, 63);
            this.OfflineButton.TabIndex = 1;
            this.OfflineButton.Text = "Offline";
            this.OfflineButton.UseVisualStyleBackColor = true;
            this.OfflineButton.Click += new System.EventHandler(this.OfflineButton_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.OfflineButton);
            this.Controls.Add(this.OnlineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstWindow";
            this.Text = "Music Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OnlineButton;
        private System.Windows.Forms.Button OfflineButton;
    }
}

