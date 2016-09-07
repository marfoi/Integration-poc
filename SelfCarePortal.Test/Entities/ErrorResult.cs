using Newtonsoft.Json;
using System.Collections.Generic;

namespace SelfCarePortal.Test.Entities
{
    public class ErrorResult
    {

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty("error_codes")]
        public IList<int> ErrorCodes { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("trace_id")]
        public string TraceId { get; set; }

        [JsonProperty("correlation_id")]
        public string CorrelationId { get; set; }
    }

}
