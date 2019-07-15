using Newtonsoft.Json;

namespace ProjectManagementSoftware
{
    public partial class Data
    {
        [JsonProperty("Projects")]
        public Project[] Projects { get; set; }

    }

    public class Project {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Risks")]
        public Risk[] Risks { get; set; }

        [JsonProperty("FunctionalRequirements")]
        public string[] FunctionalRequirements { get; set; }

        [JsonProperty("NonFunctionalRequirements")]
        public string[] NonFunctionalRequirements { get; set; }

        [JsonProperty("TimeSheet")]
        public TimeSheet TimeSheet { get; set; }

    }

    public class Risk {

        [JsonProperty("RiskFactor")]
        public string RiskFactor { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

    }

    public class TimeSheet {

        [JsonProperty("RequirementsAnalysis")]
        public double RequirementsAnalysis { get; set; }

        [JsonProperty("Designing")]
        public double Designing { get; set; }

        [JsonProperty("Coding")]
        public double Coding { get; set; }

        [JsonProperty("Testing")]
        public double Testing { get; set; }

        [JsonProperty("ProjectManagement")]
        public double ProjectManagement { get; set; }

    }

}