using System.Collections.Generic;
using Newtonsoft.Json;

namespace SelfCarePortal.Test.Entities
{
    public class ApplicationResponse
    {

        [JsonProperty("applications")]
        public IList<object> Applications { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Links
    {

        [JsonProperty("application.servers")]
        public string ApplicationServers { get; set; }

        [JsonProperty("application.server")]
        public string ApplicationServer { get; set; }

        [JsonProperty("application.application_hosts")]
        public string ApplicationApplicationHosts { get; set; }

        [JsonProperty("application.application_host")]
        public string ApplicationApplicationHost { get; set; }

        [JsonProperty("application.application_instances")]
        public string ApplicationApplicationInstances { get; set; }

        [JsonProperty("application.application_instance")]
        public string ApplicationApplicationInstance { get; set; }

        [JsonProperty("application.alert_policy")]
        public string ApplicationAlertPolicy { get; set; }
    }

}
