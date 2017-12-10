using EddiDataDefinitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EddiEvents
{
    public class DataScannedEvent : Event
    {
        public const string NAME = "Data scanned";
        public const string DESCRIPTION = "Triggered when scanning some types of data links";
        public const string SAMPLE = "{ \"timestamp\":\"2017-08-26T01:58:24Z\", \"event\":\"DataScanned\", \"Type\":\"DataLink\" }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static DataScannedEvent()
        {
            VARIABLES.Add("datalinktype", "The type of Data Link scanned");
            VARIABLES.Add("LocalDatalinkType", "The translation of the Data Link into the chosen language");
        }

        [JsonProperty("datalinktype")]
        public string datalinktype { get; private set; }

        [JsonProperty("LocalDatalinkType")]
        public string LocalDatalinkType { get; }

        public DataScannedEvent(DateTime timestamp, DataScan datalinktype) : base(timestamp, NAME)
        {
            this.datalinktype = datalinktype.name;
            this.LocalDatalinkType = datalinktype.LocalName;
        }
    }
}
