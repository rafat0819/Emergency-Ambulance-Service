using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAS.Entities
{
    class Hospital
    {
        public int Hid { get; set; }
        public string HNamed { get; set; }
        public string HCity{ get; set; }
        public string HCountry{ get; set; }
        public float HLat { get; set; }
        public float HLng { get; set; }
    }
}
