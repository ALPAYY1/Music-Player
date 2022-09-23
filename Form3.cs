using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Alpays_Radio
{
    public partial class OnlineWindow : Form
    {
        private SortedDictionary<string, string> OnlineStreams = new SortedDictionary<string, string>()
        {
            {"(House) Dogglounge", "https://dogglounge.com:8000/;stream.mp3" },
            {"(House) Deep House Radio RO", "http://live.dancemusic.ro:7000/stream" },
            {"(House) Deep House Network", "http://91.121.175.25:8000/mp3/stream" },
            {"(Dance) Dance Radio UK", "https://dancestream.danceradiouk.com/stream/1/" },
            {"(Dance) Dance Wave!", "https://dancewave.online/dance.ogg" },
            {"(Chill) Milano Lounge", "https://centova.wlservices.org/proxy/pufepstm?mp=/stream" },
            {"(Chill) Hirschmilch Radio", "https://hirschmilch.de:7001/chillout.mp3" },
            {"(Chill) Chill Lounge Florida", "https://vip2.fastcast4u.com/proxy/chillfla?mp=/1"},
            {"(Raggae) Roots Legacy FR", "https://www.rootslegacy.fr:81/;" },
            {"(House) Deep In Radio", "https://ssl1.viastreaming.net:8525/stream.mp3" },
            {"(Psytrance) Psyndora", "https://cast.magicstreams.gr/sc/psyndora/stream" },
            {"(Psytrance) PsyRadio Progressive", "http://streamer.psyradio.org:8010/;listen.mp3" },
            {"(Psytrance) PsyRadio Chillout", "http://streamer.psyradio.org:8020/;listen.mp3" },
            {"(Psytrance) PsyRadio Psytrance", "http://streamer.psyradio.org:8030/;listen.mp3" },
            {"(Rock) Classic Metal Radio", "http://hazel.torontocast.com:2280/stream" },
            {"(Rock) Metal Rock FM", "https://kathy.torontocast.com:2800/;" },
            {"(Rap) Turk Rap FM", "https://player.web.tr/listen/b9b96f7c7d6d6a484e13c494d7221ade" },
            {"(Turku) Damar FM", "https://yayin.damarfm.com:8080/;" },
            {"(Turku) Radyo 7 Oyun Havalari", "https://radyo.radiosonline.net/files?uri=37.247.98.8/stream/30/&tkn=7tfnD28lqOzAD63svJOA4g&tms=1663972562" },
            {"(Turku) Can Radyo Oyun Havalari", "https://radyo.radiosonline.net/files?uri=canradyo.kesintisizyayin.com:3838/;&tkn=qctwM5tDB3dcOdGmjDWV-g&tms=1663972687" },
            {"(HipHop) DTLR Radio", "https://cp8.shoutcheap.com:18195/stream.mp3" },
            {"(HipHop) Sensi HipHop", "https://sensihiphop.radioca.st/;" },
            {"(Rap) Streetz 94.5", "http://104.6.216.93:8000/Streetz" },
            {"(RnB) Hot 21 Radio", "https://usa18.fastcast4u.com/proxy/cbardzin?mp=/1" },
            {"(HipHop) Hot 108 Jamz", "https://live.powerhitz.com/hot108" },
            {"(Country) Wild Country Radio", "http://radio.streemlion.com:3590/;?nocache=1621355991" },
            {"(Rock) Radio Caprice Stoner Rock", "http://79.111.119.111:8000/stonerrock" },
            {"(Chill) ChillSky Lofi HipHop", "https://lfhh.radioca.st/stream" }
        };

        private int SelectedIndex;
        private string Url;
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
            for(int i = 0; i < OnlineStreams.Count; i++) this.StreamsDropDown.Items.Insert(i, OnlineStreams.ElementAt(i).Key);
        }

        private void StreamIndexChanged(object sender, EventArgs e) 
        {
            var propertyInfo = sender.GetType().GetProperty("SelectedIndex");
            SelectedIndex = (int)propertyInfo.GetValue(sender, null);
            KeyValuePair<string, string> kvp = OnlineStreams.ElementAt(SelectedIndex);
            Url = kvp.Value;
            OnlineNowPlayingLabel.Text = $"Now playing: {kvp.Key.Substring(kvp.Key.LastIndexOf(")") + 2)}";
            PlayPause(true);
        }

        private void PlayPause(bool changedManually) 
        {
            if (string.IsNullOrEmpty(Url)) return;

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
                Player.URL = Url;
                Player.controls.play();
                IsPlaying = true;
            }
            else
            {
                Player.URL = Url;
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
    }
}
