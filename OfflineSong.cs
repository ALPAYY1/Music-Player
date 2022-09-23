using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpays_Radio
{
    public class OfflineSong
    {
        public string FullPath { get; set; }
        public string Name { get; set; }
        public int? PreviousIndex { get; set; }
        public int? Index { get; set; }
    }
}
