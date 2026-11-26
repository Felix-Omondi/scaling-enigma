using System.Text.Json.Serialization;

namespace scaling_enigma.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Department
{
    [JsonStringEnumMemberName("Sales")]
    Sales,

    [JsonStringEnumMemberName("Recruitment")]
    Recruitment,

    [JsonStringEnumMemberName("Accounts")]
    Accounts,

    [JsonStringEnumMemberName("Admin")]
    Admin,

    [JsonStringEnumMemberName("Audit")]
    Audit,

    [JsonStringEnumMemberName("Business Development")]
    BusinessDevelopment,

    [JsonStringEnumMemberName("Client Services")]
    ClientServices,

    [JsonStringEnumMemberName("CRM")]
    CRM,

    [JsonStringEnumMemberName("Development")]
    Development,

    [JsonStringEnumMemberName("General Pool")]
    GeneralPool,

    [JsonStringEnumMemberName("HR")]
    HR,

    [JsonStringEnumMemberName("IT Asset Management")]
    ITAssetManagement,

    [JsonStringEnumMemberName("IT Procurement")]
    ITProcurement,

    [JsonStringEnumMemberName("Marketing")]
    Marketing,

    [JsonStringEnumMemberName("Obtain Customer Payments")]
    ObtainCustomerPayments,

    [JsonStringEnumMemberName("Order Management")]
    OrderManagement,

    [JsonStringEnumMemberName("Facilities")]
    Facilities,

    [JsonStringEnumMemberName("UX")]
    UX,

    [JsonStringEnumMemberName("Training")]
    Training,

    [JsonStringEnumMemberName("Legal")]
    Legal,

    [JsonStringEnumMemberName("Legal regulatory Compliance")]
    LegalRegulatoryCompliance,

    [JsonStringEnumMemberName("Support")]
    Support,

    [JsonStringEnumMemberName("Technical Support")]
    TechnicalSupport,

    [JsonStringEnumMemberName("Testing")]
    Testing
}
