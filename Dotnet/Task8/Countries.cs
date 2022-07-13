using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task8
{
    public class Countries
    {

        public Name name { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string SubRegion { get; set; }

        public float[] latlng { get; set; }

        public float area { get; set; }

        public int population { get; set; }
    }



    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }

    }
}
