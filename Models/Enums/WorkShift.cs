using System.Text.Json.Serialization;

namespace scaling_enigma.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WorkShift
{
    [JsonStringEnumMemberName("Kenya Regular Shift")]
    KenyaRegularShift,

    [JsonStringEnumMemberName("Kenya Morning 10 AM Shift")]
    KenyaMorning10AMShift,

    [JsonStringEnumMemberName("Kenya Night Shift")]
    KenyaNightShift,

    [JsonStringEnumMemberName("Kenya Day Shift")]
    KenyaDayShift,

    [JsonStringEnumMemberName("Kenya Noon 12 PM Shift")]
    KenyaNoon12PMShift
}
