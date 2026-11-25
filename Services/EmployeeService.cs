using Microsoft.EntityFrameworkCore;
using scaling_enigma.Data;
using scaling_enigma.Interfaces;
using scaling_enigma.Models.Dtos;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeDbContext _context;

    public EmployeeService(EmployeeDbContext context)
    {
        _context = context;
    }

    public async Task<Employee> AddEmployee(CreateEmployeeDto request)
    {
        var newEmployee = new Employee
        {
            Department = request.Department,
            Team = request.Team,
            FirstName = request.FirstName,
            LastName = request.LastName,
            OtherName = request.OtherName,
            Email = request.Email,
            Designation = request.Designation,
            Role = request.Role,
            WorkShift = request.WorkShift,
            // DateJoined = request.DateJoined
        };

        _context.Employees.Add(newEmployee);
        await _context.SaveChangesAsync();
        return newEmployee;
    }

    public async Task<bool> DeleteEmployee(int id)
    {
        var employee = await GetEmployee(id);
        if (employee is null) return false;

        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<Employee?> GetEmployee(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<List<Employee>> GetEmployees()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee?> UpdateEmployee(int id, UpdateEmployeeDto request)
    {
        var employee = await GetEmployee(id);
        if (employee is not null)
        {
            UpdateIfRequested(employee, request);
            await _context.SaveChangesAsync();
            return employee;
        }
        return employee;
    }

    private static Employee UpdateIfRequested(Employee employee, UpdateEmployeeDto request)
    {
        if (!string.IsNullOrWhiteSpace(request.Department))
        {
            employee.Department = request.Department;
        }

        if (!string.IsNullOrWhiteSpace(request.Team))
        {
            employee.Team = request.Team;
        }

        if (!string.IsNullOrWhiteSpace(request.FirstName))
        {
            employee.FirstName = request.FirstName;
        }

        if (!string.IsNullOrWhiteSpace(request.LastName))
        {
            employee.LastName = request.LastName;
        }

        if (!string.IsNullOrWhiteSpace(request.OtherName))
        {
            employee.OtherName = request.OtherName;
        }

        if (!string.IsNullOrWhiteSpace(request.Email))
        {
            employee.Email = request.Email;
        }

        if (!string.IsNullOrWhiteSpace(request.Designation))
        {
            employee.Designation = request.Designation;
        }

        if (!string.IsNullOrWhiteSpace(request.Role))
        {
            employee.Role = request.Role;
        }

        if (!string.IsNullOrWhiteSpace(request.WorkShift))
        {
            employee.WorkShift = request.WorkShift;
        }

        return employee;
    }
}
