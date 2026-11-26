using Microsoft.EntityFrameworkCore;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>(e =>
        {
            e.Property(e => e.Department).HasConversion<string>();
            e.Property(e => e.Designation).HasConversion<string>();
            e.Property(e => e.WorkShift).HasConversion<string>();
            e.Property(e => e.Role).HasConversion<string>();
            e.Property(e => e.Team).HasConversion<string>();
        });
    }
    public DbSet<Employee> Employees => Set<Employee>();
}
