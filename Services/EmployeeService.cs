using scaling_enigma.Interfaces;
using scaling_enigma.Models.Dtos;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Services;

public class EmployeeService : IEmployeeService
{
    public Task<Employee> AddEmployee(CreateEmployeeDto request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteEmployee(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Employee?> GetEmployee(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetEmployees()
    {
        throw new NotImplementedException();
    }

    public Task<Employee?> UpdateEmployee(int id, UpdateEmployeeDto request)
    {
        throw new NotImplementedException();
    }
}
