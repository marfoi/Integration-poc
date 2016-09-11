using System.Collections.Generic;
using Newtonsoft.Json;

namespace SelfCarePortal.Test.Entities
{
    public class ApplicationResponse
    {
        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("applications")]
        public IList<Application> Applications { get; set; }
    }

    public class Application
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        [JsonProperty("reporting")]
        public string Reporting { get; set; }

        [JsonProperty("last_reported_at")]
        public string LastReportedAt { get; set; }

        [JsonProperty("application_summary")]
        public ApplicationSummary ApplicationSummary { get; set; }

        [JsonProperty("end_user_summary")]
        public EndUserSummary EndUserSummary { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("servers")]
        public IList<string> Servers { get; set; }

        [JsonProperty("application_host")]
        public string ApplicationHost { get; set; }

        [JsonProperty("application_hosts")]
        public IList<string> ApplicationHosts { get; set; }

        [JsonProperty("application_instance")]
        public string ApplicationApplicationInstance { get; set; }

        [JsonProperty("application_instances")]
        public IList<string> ApplicationInstances { get; set; }

        [JsonProperty("alert_policy")]
        public string AlertPolicy { get; set; }
    }

    public class ApplicationSummary
    {
        [JsonProperty("response_time")]
        public string ResponseTime { get; set; }

        [JsonProperty("throughput")]
        public string Throughput { get; set; }

        [JsonProperty("error_rate")]
        public string ErrorRate { get; set; }

        [JsonProperty("apdex_target")]
        public string ApdexTarget { get; set; }

        [JsonProperty("apdex_score")]
        public string ApdexScore { get; set; }

        [JsonProperty("host_count")]
        public string HostCount { get; set; }

        [JsonProperty("instance_count")]
        public string InstanceCount { get; set; }

        [JsonProperty("concurrent_instance_count")]
        public string ConcurrentInstanceCount { get; set; }
    }

    public class EndUserSummary
    {

        [JsonProperty("response_time")]
        public string ResponseTime { get; set; }

        [JsonProperty("throughput")]
        public string Throughput { get; set; }

        [JsonProperty("apdex_target")]
        public string ApdexTarget { get; set; }

        [JsonProperty("apdex_score")]
        public string ApdexScore { get; set; }
    }

    public class Settings
    {
        [JsonProperty("app_apdex_threshold")]
        public string AppApdexThreshold { get; set; }

        [JsonProperty("end_user_apdex_threshold")]
        public string EndUserApdexThreshold { get; set; }

        [JsonProperty("enable_real_user_monitoring")]
        public string EnableRealUserMonitoring { get; set; }

        [JsonProperty("use_server_side_config")]
        public string UseServerSideConfig { get; set; }
    }

    //public class Links
    //{
    //    [JsonProperty("servers")]
    //    public IList<string> Servers { get; set; }

    //    [JsonProperty("application_hosts")]
    //    public IList<string> ApplicationHosts { get; set; }

    //    [JsonProperty("application_instances")]
    //    public IList<string> ApplicationInstances { get; set; }

    //    [JsonProperty("alert_policy")]
    //    public string AlertPolicy { get; set; }
    //}
}

