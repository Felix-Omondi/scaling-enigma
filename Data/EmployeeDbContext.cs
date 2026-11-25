using Microsoft.EntityFrameworkCore;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees => Set<Employee>();
}
