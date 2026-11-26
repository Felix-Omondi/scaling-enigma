using Microsoft.EntityFrameworkCore;
using scaling_enigma.Models.Enums;

namespace scaling_enigma.Models.Entities;

[Index(nameof(Email), IsUnique = true)]
public class Employee
{
    public int Id { get; set; }
    public Department Department { get; set; }
    public Team Team { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OtherName { get; set; }
    public required string Email { get; set; }
    public Designation Designation { get; set; }
    public Role Role { get; set; }
    public WorkShift WorkShift { get; set; }
    // public DateOnly DateJoined { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
