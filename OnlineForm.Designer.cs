
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
            this.OnlinePlayPause = new System.Windows.Forms.Button();
            this.OnlineReturnButton = new System.Windows.Forms.Button();
            this.OnlineVolDown = new System.Windows.Forms.Button();
            this.OnlineVolUp = new System.Windows.Forms.Button();
            this.OnlineRadioTrackText = new System.Windows.Forms.TextBox();
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
            // OnlineRadioTrackText
            // 
            this.OnlineRadioTrackText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OnlineRadioTrackText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnlineRadioTrackText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineRadioTrackText.Location = new System.Drawing.Point(22, 9);
            this.OnlineRadioTrackText.Name = "OnlineRadioTrackText";
            this.OnlineRadioTrackText.ReadOnly = true;
            this.OnlineRadioTrackText.Size = new System.Drawing.Size(295, 15);
            this.OnlineRadioTrackText.TabIndex = 12;
            this.OnlineRadioTrackText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OnlineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.OnlineRadioTrackText);
            this.Controls.Add(this.OnlineVolUp);
            this.Controls.Add(this.OnlineVolDown);
            this.Controls.Add(this.OnlineReturnButton);
            this.Controls.Add(this.OnlinePlayPause);
            this.Controls.Add(this.StreamsDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OnlineWindow";
            this.Text = "Music Player (Online)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnlineWindow_Close);
            this.Load += new System.EventHandler(this.OnlineWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StreamsDropDown;
        private System.Windows.Forms.Button OnlinePlayPause;
        private System.Windows.Forms.Button OnlineReturnButton;
        private System.Windows.Forms.Button OnlineVolDown;
        private System.Windows.Forms.Button OnlineVolUp;
        public System.Windows.Forms.TextBox OnlineRadioTrackText;
    }
}