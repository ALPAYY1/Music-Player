
namespace Alpays_Radio
{
    partial class OnlineWindow
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
            this.StreamsDropDown = new System.Windows.Forms.ComboBox();
            this.OnlineNowPlayingLabel = new System.Windows.Forms.Label();
            this.OnlinePlayPause = new System.Windows.Forms.Button();
            this.OnlineReturnButton = new System.Windows.Forms.Button();
            this.OnlineVolDown = new System.Windows.Forms.Button();
            this.OnlineVolUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StreamsDropDown
            // 
            this.StreamsDropDown.DropDownHeight = 100;
            this.StreamsDropDown.DropDownWidth = 200;
            this.StreamsDropDown.FormattingEnabled = true;
            this.StreamsDropDown.IntegralHeight = false;
            this.StreamsDropDown.Location = new System.Drawing.Point(93, 140);
            this.StreamsDropDown.Name = "StreamsDropDown";
            this.StreamsDropDown.Size = new System.Drawing.Size(139, 23);
            this.StreamsDropDown.TabIndex = 0;
            this.StreamsDropDown.Text = "           Select radio";
            this.StreamsDropDown.SelectedIndexChanged += new System.EventHandler(this.StreamIndexChanged);
            // 
            // OnlineNowPlayingLabel
            // 
            this.OnlineNowPlayingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OnlineNowPlayingLabel.Location = new System.Drawing.Point(20, 9);
            this.OnlineNowPlayingLabel.Name = "OnlineNowPlayingLabel";
            this.OnlineNowPlayingLabel.Size = new System.Drawing.Size(286, 15);
            this.OnlineNowPlayingLabel.TabIndex = 6;
            this.OnlineNowPlayingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OnlinePlayPause
            // 
            this.OnlinePlayPause.Location = new System.Drawing.Point(93, 60);
            this.OnlinePlayPause.Name = "OnlinePlayPause";
            this.OnlinePlayPause.Size = new System.Drawing.Size(139, 74);
            this.OnlinePlayPause.TabIndex = 7;
            this.OnlinePlayPause.Text = "Play / Pause";
            this.OnlinePlayPause.UseVisualStyleBackColor = true;
            this.OnlinePlayPause.Click += new System.EventHandler(this.OnlinePlayPause_Click);
            // 
            // OnlineReturnButton
            // 
            this.OnlineReturnButton.Location = new System.Drawing.Point(12, 166);
            this.OnlineReturnButton.Name = "OnlineReturnButton";
            this.OnlineReturnButton.Size = new System.Drawing.Size(75, 23);
            this.OnlineReturnButton.TabIndex = 9;
            this.OnlineReturnButton.Text = "Back";
            this.OnlineReturnButton.UseVisualStyleBackColor = true;
            this.OnlineReturnButton.Click += new System.EventHandler(this.OnlineReturnButton_Click);
            // 
            // OnlineVolDown
            // 
            this.OnlineVolDown.Location = new System.Drawing.Point(127, 34);
            this.OnlineVolDown.Name = "OnlineVolDown";
            this.OnlineVolDown.Size = new System.Drawing.Size(20, 20);
            this.OnlineVolDown.TabIndex = 10;
            this.OnlineVolDown.Text = "-";
            this.OnlineVolDown.UseVisualStyleBackColor = true;
            this.OnlineVolDown.Click += new System.EventHandler(this.OnlineVolDown_Click);
            // 
            // OnlineVolUp
            // 
            this.OnlineVolUp.Location = new System.Drawing.Point(178, 34);
            this.OnlineVolUp.Name = "OnlineVolUp";
            this.OnlineVolUp.Size = new System.Drawing.Size(20, 20);
            this.OnlineVolUp.TabIndex = 11;
            this.OnlineVolUp.Text = "+";
            this.OnlineVolUp.UseVisualStyleBackColor = true;
            this.OnlineVolUp.Click += new System.EventHandler(this.OnlineVolUp_Click);
            // 
            // OnlineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.OnlineVolUp);
            this.Controls.Add(this.OnlineVolDown);
            this.Controls.Add(this.OnlineReturnButton);
            this.Controls.Add(this.OnlinePlayPause);
            this.Controls.Add(this.OnlineNowPlayingLabel);
            this.Controls.Add(this.StreamsDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlineWindow";
            this.Text = "Music Player (Online)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnlineWindow_Close);
            this.Load += new System.EventHandler(this.OnlineWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StreamsDropDown;
        private System.Windows.Forms.Label OnlineNowPlayingLabel;
        private System.Windows.Forms.Button OnlinePlayPause;
        private System.Windows.Forms.Button OnlineReturnButton;
        private System.Windows.Forms.Button OnlineVolDown;
        private System.Windows.Forms.Button OnlineVolUp;
    }
}