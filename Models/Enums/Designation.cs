using System.Text.Json.Serialization;

namespace scaling_enigma.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Designation
{
    [JsonStringEnumMemberName("Super Pod Lead")]
    SuperPodLead,

    [JsonStringEnumMemberName("Pod Lead")]
    PodLead,

    [JsonStringEnumMemberName("Technical Assistant")]
    TechnicalAssistant,

    [JsonStringEnumMemberName("Technical Sales Assistant")]
    TechnicalSalesAssistant,

    [JsonStringEnumMemberName("Admin Manager")]
    AdminManager,

    [JsonStringEnumMemberName("Research Specialist")]
    ResearchSpecialist,

    [JsonStringEnumMemberName("Collections Specialist")]
    CollectionsSpecialist,

    [JsonStringEnumMemberName("HR Pod lead")]
    HRPodLead,

    [JsonStringEnumMemberName("Bold Partner Associate")]
    BoldPartnerAssociate,

    [JsonStringEnumMemberName("Petty cash operations associate")]
    PettyCashOperationsAssociate,

    [JsonStringEnumMemberName("Legal Assistant")]
    LegalAssistant,

    [JsonStringEnumMemberName("Office Assistant(HR)")]
    OfficeAssistantHR,

    [JsonStringEnumMemberName("Office Assistant(Procurement)")]
    OfficeAssistantProcurement,

    [JsonStringEnumMemberName("Office Assistant(Front Office)")]
    OfficeAssistantFrontOffice
}
