using scaling_enigma.Models.Dtos;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Interfaces;

public interface IEmployeeService
{
    Task<Employee?> GetEmployee(int id);
    Task<Employee?> UpdateEmployee(int id, UpdateEmployeeDto request);
    Task<List<Employee>> GetEmployees();
    Task<bool> DeleteEmployee(int id);

    Task<Employee> AddEmployee(CreateEmployeeDto request);
}
