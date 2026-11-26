using System.ComponentModel.DataAnnotations;
using scaling_enigma.Models.Enums;

namespace scaling_enigma.Models.Dtos;

public class CreateEmployeeDto
{
    public Department Department { get; set; }
    public Team Team { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OtherName { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
    public Designation Designation { get; set; }
    public Role Role { get; set; }
    public WorkShift WorkShift { get; set; }
    // public DateOnly DateJoined { get; set; }
}
