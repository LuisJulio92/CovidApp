using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidApp.Models
{
    public partial class Global
    {
        [JsonProperty("NewConfirmed")]
        public long NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public long NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public long NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public long TotalRecovered { get; set; }
    }
}
