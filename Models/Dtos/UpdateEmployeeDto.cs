using System.ComponentModel.DataAnnotations;
using scaling_enigma.Models.Enums;

namespace scaling_enigma.Models.Dtos;

public class UpdateEmployeeDto
{
    public Department? Department { get; set; }
    public Team? Team { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? OtherName { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public Designation? Designation { get; set; }
    public Role? Role { get; set; }
    public WorkShift? WorkShift { get; set; }
    // public DateOnly DateJoined { get; set; }
}
