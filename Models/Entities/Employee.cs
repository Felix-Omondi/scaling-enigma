using Microsoft.EntityFrameworkCore;

namespace scaling_enigma.Models.Entities;

[Index(nameof(Email), IsUnique = true)]
public class Employee
{
    public int Id { get; set; }
    public required string Department { get; set; }
    public required string Team { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OtherName { get; set; }
    public required string Email { get; set; }
    public required string Designation { get; set; }
    public required string Role { get; set; }
    public required string WorkShift { get; set; }
    public DateOnly DateJoined { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
