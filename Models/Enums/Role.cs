using System.Text.Json.Serialization;

namespace scaling_enigma.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Role
{
    [JsonStringEnumMemberName("Growth Engineer")]
    GrowthEngineer,

    [JsonStringEnumMemberName("Human Resource")]
    HumanResource,

    [JsonStringEnumMemberName("Procurement")]
    Procurement,

    [JsonStringEnumMemberName("Demo Engineer")]
    DemoEngineer,

    [JsonStringEnumMemberName("Facilities")]
    Facilities,

    [JsonStringEnumMemberName("Marketing")]
    Marketing,

    [JsonStringEnumMemberName("Lead Qualification")]
    LeadQualification,

    [JsonStringEnumMemberName("Inventory")]
    Inventory,

    [JsonStringEnumMemberName("Record & Data Coordinator")]
    RecordDataCoordinator,

    [JsonStringEnumMemberName("General Pool")]
    GeneralPool,

    [JsonStringEnumMemberName("Training")]
    Training,

    [JsonStringEnumMemberName("Admin")]
    Admin,

    [JsonStringEnumMemberName("Junior Developer")]
    JuniorDeveloper,

    [JsonStringEnumMemberName("Network")]
    Network
}
