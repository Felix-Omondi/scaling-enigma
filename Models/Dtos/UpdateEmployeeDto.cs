using System.ComponentModel.DataAnnotations;

namespace scaling_enigma.Models.Dtos;

public class UpdateEmployeeDto
{
    public string? Department { get; set; }
    public string? Team { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? OtherName { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Designation { get; set; }
    public string? Role { get; set; }
    public string? WorkShift { get; set; }
    // public DateOnly DateJoined { get; set; }
}
