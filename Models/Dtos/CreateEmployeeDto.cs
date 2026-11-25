using System.ComponentModel.DataAnnotations;

namespace scaling_enigma.Models.Dtos;

public class CreateEmployeeDto
{
    public required string Department { get; set; }
    public required string Team { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OtherName { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
    public required string Designation { get; set; }
    public required string Role { get; set; }
    public required string WorkShift { get; set; }
    public DateOnly DateJoined { get; set; }
}
