
namespace Alpays_Radio
{
    partial class OfflineWindow
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
            this.CheckBoxRandom = new System.Windows.Forms.CheckBox();
            this.OfflinePlayPause = new System.Windows.Forms.Button();
            this.OfflineNext = new System.Windows.Forms.Button();
            this.OfflinePrevious = new System.Windows.Forms.Button();
            this.OfflineNowPlayingLabel = new System.Windows.Forms.Label();
            this.OfflineVolUp = new System.Windows.Forms.Button();
            this.OfflineVolDown = new System.Windows.Forms.Button();
            this.OfflineReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxRandom
            // 
            this.CheckBoxRandom.AutoSize = true;
            this.CheckBoxRandom.Location = new System.Drawing.Point(127, 150);
            this.CheckBoxRandom.Name = "CheckBoxRandom";
            this.CheckBoxRandom.Size = new System.Drawing.Size(71, 19);
            this.CheckBoxRandom.TabIndex = 0;
            this.CheckBoxRandom.Text = "Random";
            this.CheckBoxRandom.UseVisualStyleBackColor = true;
            // 
            // OfflinePlayPause
            // 
            this.OfflinePlayPause.Location = new System.Drawing.Point(93, 60);
            this.OfflinePlayPause.Name = "OfflinePlayPause";
            this.OfflinePlayPause.Size = new System.Drawing.Size(139, 74);
            this.OfflinePlayPause.TabIndex = 2;
            this.OfflinePlayPause.Text = "Play / Pause";
            this.OfflinePlayPause.UseVisualStyleBackColor = true;
            this.OfflinePlayPause.Click += new System.EventHandler(this.OfflinePlayPause_Click);
            // 
            // OfflineNext
            // 
            this.OfflineNext.Location = new System.Drawing.Point(238, 86);
            this.OfflineNext.Name = "OfflineNext";
            this.OfflineNext.Size = new System.Drawing.Size(75, 23);
            this.OfflineNext.TabIndex = 3;
            this.OfflineNext.Text = "Next";
            this.OfflineNext.UseVisualStyleBackColor = true;
            this.OfflineNext.Click += new System.EventHandler(this.OfflineNext_Click);
            // 
            // OfflinePrevious
            // 
            this.OfflinePrevious.Location = new System.Drawing.Point(12, 86);
            this.OfflinePrevious.Name = "OfflinePrevious";
            this.OfflinePrevious.Size = new System.Drawing.Size(75, 23);
            this.OfflinePrevious.TabIndex = 4;
            this.OfflinePrevious.Text = "Previous";
            this.OfflinePrevious.UseVisualStyleBackColor = true;
            this.OfflinePrevious.Click += new System.EventHandler(this.OfflinePrevious_Click);
            // 
            // OfflineNowPlayingLabel
            // 
            this.OfflineNowPlayingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OfflineNowPlayingLabel.Location = new System.Drawing.Point(20, 9);
            this.OfflineNowPlayingLabel.Name = "OfflineNowPlayingLabel";
            this.OfflineNowPlayingLabel.Size = new System.Drawing.Size(286, 15);
            this.OfflineNowPlayingLabel.TabIndex = 5;
            this.OfflineNowPlayingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OfflineVolUp
            // 
            this.OfflineVolUp.Location = new System.Drawing.Point(178, 34);
            this.OfflineVolUp.Name = "OfflineVolUp";
            this.OfflineVolUp.Size = new System.Drawing.Size(20, 20);
            this.OfflineVolUp.TabIndex = 6;
            this.OfflineVolUp.Text = "+";
            this.OfflineVolUp.UseVisualStyleBackColor = true;
            this.OfflineVolUp.Click += new System.EventHandler(this.OfflineVolUp_Click);
            // 
            // OfflineVolDown
            // 
            this.OfflineVolDown.Location = new System.Drawing.Point(127, 34);
            this.OfflineVolDown.Name = "OfflineVolDown";
            this.OfflineVolDown.Size = new System.Drawing.Size(20, 20);
            this.OfflineVolDown.TabIndex = 7;
            this.OfflineVolDown.Text = "-";
            this.OfflineVolDown.UseVisualStyleBackColor = true;
            this.OfflineVolDown.Click += new System.EventHandler(this.OfflineVolDown_Click);
            // 
            // OfflineReturnButton
            // 
            this.OfflineReturnButton.Location = new System.Drawing.Point(12, 166);
            this.OfflineReturnButton.Name = "OfflineReturnButton";
            this.OfflineReturnButton.Size = new System.Drawing.Size(75, 23);
            this.OfflineReturnButton.TabIndex = 8;
            this.OfflineReturnButton.Text = "Back";
            this.OfflineReturnButton.UseVisualStyleBackColor = true;
            this.OfflineReturnButton.Click += new System.EventHandler(this.OfflineReturnButton_Click);
            // 
            // OfflineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.OfflineReturnButton);
            this.Controls.Add(this.OfflineVolDown);
            this.Controls.Add(this.OfflineVolUp);
            this.Controls.Add(this.OfflineNowPlayingLabel);
            this.Controls.Add(this.OfflinePrevious);
            this.Controls.Add(this.OfflineNext);
            this.Controls.Add(this.OfflinePlayPause);
            this.Controls.Add(this.CheckBoxRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OfflineWindow";
            this.Text = "Music Player (Offline)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfflineWindow_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxRandom;
        private System.Windows.Forms.Button OfflinePlayPause;
        private System.Windows.Forms.Button OfflineNext;
        private System.Windows.Forms.Button OfflinePrevious;
        private System.Windows.Forms.Label OfflineNowPlayingLabel;
        private System.Windows.Forms.Button OfflineVolUp;
        private System.Windows.Forms.Button OfflineVolDown;
        private System.Windows.Forms.Button OfflineReturnButton;
    }
}