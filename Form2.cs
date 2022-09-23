using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace Alpays_Radio
{
    public partial class OfflineWindow : Form
    {
        public string[] fileNames;
        private bool InitialStart = false;
        private bool IsPaused = true;
        private OfflineSong CurrentSong = new OfflineSong();
        private MediaPlayer Player = new MediaPlayer();
        private double Volume;

        public OfflineWindow()
        {
            InitializeComponent();
            Player.MediaEnded += Player_MediaEnded;
            Volume = Player.Volume;
        }

        private void Player_MediaEnded(object sender, EventArgs e)
        {
            ChangeSong();
        }

        private void OfflineWindow_Close(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void OfflinePlayPause_Click(object sender, EventArgs e)
        {
            bool wasNotJustStarted = InitialStart;
            if (InitialStart != true) InitialStart = true;
            IsPaused = IsPaused == true ? false : true;

            if (!wasNotJustStarted) ChangeSong();

            PlayPause();
        }

        private void OfflineNext_Click(object sender, EventArgs e)
        {
            if (InitialStart == false) return;
            CurrentSong.Index = CurrentSong.Index == fileNames.Length - 1 ? 0 : CurrentSong.Index+=1;
            ChangeSong(true);
        }

        private void OfflinePrevious_Click(object sender, EventArgs e)
        {
            if (InitialStart == false) return;
            CurrentSong.Index = CurrentSong.Index == 0 ? fileNames.Length - 1 : CurrentSong.Index-=1;
            ChangeSong(true);
        }

        /// <summary>
        /// Change current offline song and its info..
        /// </summary>
        private void ChangeSong(bool changedManually = false) 
        {
            if (CurrentSong.Index.HasValue) CurrentSong.PreviousIndex = CurrentSong.Index.Value;

            // If random and has previously played a song, find a new random song that is NOT the same.
            if (CheckBoxRandom.Checked && CurrentSong.PreviousIndex.HasValue && fileNames.Length > 1) 
            {
                int tempIndex = CurrentSong.Index.Value;
                while(CurrentSong.Index.Value == tempIndex) tempIndex = new Random().Next(0, fileNames.Length);
                CurrentSong.Index = tempIndex;
            }
            else if (CheckBoxRandom.Checked) CurrentSong.Index = new Random().Next(0, fileNames.Length);
            else if (!CheckBoxRandom.Checked && !changedManually) CurrentSong.Index = CurrentSong.Index == null || CurrentSong.Index == fileNames.Length - 1 ? 0 : CurrentSong.Index += 1;
            else CurrentSong.Index = CurrentSong.Index.HasValue ? CurrentSong.Index.Value : 0;
            
            CurrentSong.FullPath = fileNames[CurrentSong.Index.Value];
            CurrentSong.Name = CurrentSong.FullPath.Remove(CurrentSong.FullPath.Length - 4).Substring(CurrentSong.FullPath.LastIndexOf(@"\") + 1);

            OfflineNowPlayingLabel.Text = $"{CurrentSong.Name}";

            if (Player.HasAudio) Player.Close();
            Player.Open(new Uri(CurrentSong.FullPath));
            
            PlayPause();
        }

        private void PlayPause() 
        {
            if (IsPaused) Player.Pause();
            else 
            {
                Player.Play();
                Player.Volume = Volume;
            }
        }

        private void OfflineVolUp_Click(object sender, EventArgs e)
        {
            if (InitialStart == false) return;
            
            if (Player.Volume < 1.0) 
            {
                Player.Volume += 0.05;
                Volume += 0.05;
            }
        }

        private void OfflineVolDown_Click(object sender, EventArgs e)
        {
            if (InitialStart == false) return;
            
            if (Player.Volume > 0.0) 
            {
                Player.Volume -= 0.05;
                Volume -= 0.05;
            }
        }

        private void OfflineReturnButton_Click(object sender, EventArgs e)
        {
            if (Player.HasAudio) Player.Close();

            FirstWindow FW = new FirstWindow();
            FW.Show();
            this.Hide();
        }
    }
}
