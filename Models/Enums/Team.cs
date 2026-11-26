using System.Text.Json.Serialization;

namespace scaling_enigma.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Team
{
    [JsonStringEnumMemberName("Bold Desk")]
    BoldDesk,

    [JsonStringEnumMemberName("Bold Sales")]
    BoldSales,

    [JsonStringEnumMemberName("Bold Sign")]
    BoldSign,

    [JsonStringEnumMemberName("Bold Reports")]
    BoldReports,

    [JsonStringEnumMemberName("Bold BI")]
    BoldBI,

    [JsonStringEnumMemberName("Bold Insights")]
    BoldInsights,

    [JsonStringEnumMemberName("Legal")]
    Legal,

    [JsonStringEnumMemberName("Sales")]
    Sales,

    [JsonStringEnumMemberName("Marketing")]
    Marketing,

    [JsonStringEnumMemberName("Facilities")]
    Facilities,

    [JsonStringEnumMemberName("HR")]
    HR,
}
