using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Alpays_Radio
{
    public partial class OnlineWindow : Form
    {
        private delegate void UpdateTrackName(string trackname);
        private List<OnlineSong> AllStreams = new List<OnlineSong>();
        private int SelectedIndex;
        private OnlineSong currentStation;
        private bool IsPlaying = false;
        private int Volume = 50;
        private WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

        public OnlineWindow()
        {
            InitializeComponent();
        }

        private void OnlineWindow_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnlineWindow_Load(object sender, EventArgs e)
        {
            XDocument xDoc = GetStreamingFeeds("https://raw.githubusercontent.com/ALPAYY1/Music-Player/master/audiofeeds");

            foreach (XElement node in xDoc.Descendants("url"))
            {
                AllStreams.Add(new OnlineSong()
                {
                    StationName = node.FirstAttribute.Value,
                    AudioFeedUrl = node.Value
                });
            }

            for (int i = 0; i < AllStreams.Count; i++) this.StreamsDropDown.Items.Insert(i, AllStreams.ElementAt(i).StationName);

            // Keep update loop.
            Task trackUpdaterTask = new Task(KeepUpdatingTrackInfo);
            trackUpdaterTask.Start();
        }

        private void StreamIndexChanged(object sender, EventArgs e) 
        {
            var propertyInfo = sender.GetType().GetProperty("SelectedIndex");
            SelectedIndex = (int)propertyInfo.GetValue(sender, null);
            currentStation = AllStreams.ElementAt(SelectedIndex);
            OnlineRadioTrackText.Text = string.Empty;
            PlayPause(true);
        }

        private void PlayPause(bool changedManually) 
        {
            if (string.IsNullOrEmpty(currentStation.AudioFeedUrl)) return;

            if (IsPlaying && !changedManually) 
            {
                Player.controls.stop();
                Player.close();
                IsPlaying = false;
            }
            else if (IsPlaying && changedManually) 
            {
                Player.controls.stop();
                Player.close();
                Player.URL = currentStation.AudioFeedUrl;
                Player.controls.play();
                IsPlaying = true;
            }
            else
            {
                Player.URL = currentStation.AudioFeedUrl;
                Player.controls.play();
                IsPlaying = true;
            }
        }

        private void OnlinePlayPause_Click(object sender, EventArgs e)
        {
            PlayPause(false);
        }

        private void OnlineReturnButton_Click(object sender, EventArgs e)
        {
            if (IsPlaying) 
            {
                Player.controls.stop();
                Player.close();
                IsPlaying = false;
            }

            FirstWindow FW = new FirstWindow();
            FW.Show();
            this.Hide();
        }

        private void OnlineVolDown_Click(object sender, EventArgs e)
        {
            if (IsPlaying && Player.settings.volume > 0) 
            {
                Volume -= 5;
                Player.settings.volume = Volume;
            }
        }

        private void OnlineVolUp_Click(object sender, EventArgs e)
        {
            if (IsPlaying && Player.settings.volume < 100)
            {
                Volume += 5;
                Player.settings.volume = Volume;
            }
        }

        /// <summary>
        /// A function that will keep updating and keeping track of the current track that is being played and update global currentstation object.
        /// </summary>
        /// <param name="os"></param>
        /// <returns></returns>
        private void UpdateCurrentTrack() 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(currentStation.AudioFeedUrl);

            request.Headers.Clear();

            request.Headers.Add("GET", " HTTP/1.0");
            request.UserAgent = "WinampMPEG/5.09";

            request.Headers.Add("Icy-MetaData", "1");
            request.KeepAlive = true;

            HttpWebResponse response = null;

            try { response = (HttpWebResponse)request.GetResponse(); }
            catch { }

            if (response == null) return;

            currentStation.Genre = response.Headers.Get("icy-genre");
            if (response.Headers.Get("icy-metaint") != null) currentStation.MetaDataChunkSize = int.Parse(response.Headers.Get("icy-metaint"));
            currentStation.OfficialStreamName = response.Headers.Get("icy-name");
            currentStation.OfficialPageUrl = response.Headers.Get("icy-url");
            currentStation.OfficialDescription = response.Headers.Get("icy-description");

            byte[] buffer = new byte[512];
            Stream responseStream = response.GetResponseStream();
            bool songNameFound = false;

            while (!songNameFound)
            {
                // read byteblock
                int bytes = responseStream.Read(buffer, 0, buffer.Length);
                if (bytes < 0) return;

                for (int i = 0; i < bytes; i++)
                {
                    // if there is a header, the 'metadataLength' would be set to a value != 0. Then we save the header to a string.
                    if (currentStation.MetaDataLength != 0)
                    {
                        currentStation.MetaDataHeader += Convert.ToChar(buffer[i]);
                        currentStation.MetaDataLength--;
                        // all metadata information was written to the 'metadataHeader' string
                        if (currentStation.MetaDataLength == 0 && !currentStation.MetaDataHeader.Equals(currentStation.OldMetaDataHeader))
                        {
                            // Exctract currently playing track from metadata.
                            int length = currentStation.MetaDataHeader.IndexOf("';");
                            if (length > 0) currentStation.NowPlaying = TurkifyLetters(currentStation.MetaDataHeader.Substring(0, length).Replace("StreamTitle='", string.Empty).ToLower());
                            currentStation.OldMetaDataHeader = currentStation.MetaDataHeader;
                            currentStation.MetaDataHeader = string.Empty;
                            songNameFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (currentStation.ByteCount++ >= currentStation.MetaDataChunkSize)
                        {
                            currentStation.MetaDataLength = Convert.ToInt32(buffer[i]) * 16;
                            currentStation.ByteCount = 0;
                        }
                    }
                }
            }

            response.Close();
        }


        private void KeepUpdatingTrackInfo() 
        {
            while (true) 
            {
                if (IsPlaying) 
                {
                    UpdateCurrentTrack();

                    Invoke(new Action(() =>
                    {
                        OnlineRadioTrackText.Text = currentStation.NowPlaying;
                    }));
                }

                Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// Sends simple HTTP request. Remember to close when done using!
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private HttpWebResponse SendSimpleRequest(string url) 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Headers.Clear();

            request.Headers.Add("GET", " HTTP/1.0");
            request.UserAgent = "WinampMPEG/5.09";
            request.Headers.Add("Icy-MetaData", "1");

            request.KeepAlive = true;

            return (HttpWebResponse)request.GetResponse();
        }

        /// <summary>
        /// Sends a request to my github that contains a text file formatted like an xml, which contains all audio feeds.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private XDocument GetStreamingFeeds(string url) 
        {
            HttpWebResponse response = SendSimpleRequest(url);

            Stream stream = response.GetResponseStream();
            StreamReader readStream;

            if (response.CharacterSet == null) readStream = new StreamReader(stream);
            else readStream = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));
            
            string data = readStream.ReadToEnd();
            
            response.Close();
            readStream.Close();

            return XDocument.Parse(data);
        }

        /// <summary>
        /// Microsoft is kind of racist not allowing Turkish iso encoding, so hacky solution it is.
        /// </summary>
        private string TurkifyLetters(string trackname) 
        {
            return trackname.Replace("ã", "ö").Replace("ã¼", "ü").Replace("ä°", "i").Replace("ã§", "c").Replace("ä±", "i").Replace("ö§", "i").Replace("ö¶", "ö").Replace("ö¼", "ü").Replace("ä\u009f", "g").Replace("å", "s");
        }
    }
}
