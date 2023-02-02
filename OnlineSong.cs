using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpays_Radio
{
    public class OnlineSong
    {
        public string StationName { get; set; }
        public string AudioFeedUrl { get; set; }
        public int MetaDataChunkSize { get; set; } = 0;
        public int MetaDataLength { get; set; } = 0;
        public int ByteCount { get; set; } = 0;
        public string MetaDataHeader { get; set; } = string.Empty;
        public string OldMetaDataHeader { get; set; } = string.Empty;
        public string OfficialStreamName { get; set; }
        public string OfficialPageUrl { get; set; }
        public string OfficialDescription { get; set; }
        public string Genre { get; set; }
        public string CustomGenre { get; set; }
        public string NowPlaying { get; set; }
    }
}
