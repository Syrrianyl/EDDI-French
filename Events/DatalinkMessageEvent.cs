using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EddiEvents
{
    public class DatalinkMessageEvent : Event
    {
        public const string NAME = "Datalink message";
        public const string DESCRIPTION = "Triggered upon completion of Datalink scan";
        public const string SAMPLE = "{ \"timestamp\":\"2017-09-13T08:52:52Z\", \"event\":\"DatalinkScan\", \"Message\":\"$DATAPOINT_GAMEPLAY_complete;\", \"Message_Localised\":\"Alerte : tous les liens de télémétrie ont été établis avec le point d'accès aux données. Compilation du dossier d'informations.\" }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static DatalinkMessageEvent()
        {
            VARIABLES.Add("message", "Datalink message");
            VARIABLES.Add("LocalMessage", "the localized message in human form");
        }

        [JsonProperty("message")]
        public string message { get; private set; }

        [JsonProperty("LocalMessage")]
        public string LocalMessage { get; private set; }

        public DatalinkMessageEvent(DateTime timestamp, string message, string LocalMessage) : base(timestamp, NAME)
        {
            this.message = message;
            this.LocalMessage = LocalMessage;
        }
    }
}
