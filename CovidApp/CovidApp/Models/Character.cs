using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidApp.Models
{
    public partial class Character
    {
        [JsonProperty("Global")]
        public Global Global { get; set; }

        [JsonProperty("Countries")]
        public List<Country> Countries { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }
    }
}
