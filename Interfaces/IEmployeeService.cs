using scaling_enigma.Models.Dtos;
using scaling_enigma.Models.Entities;
using scaling_enigma.Models.Enums;

namespace scaling_enigma.Interfaces;

public interface IEmployeeService
{
    Task<Employee?> GetEmployee(int id);
    Task<Employee?> UpdateEmployee(int id, UpdateEmployeeDto request);
    Task<List<Employee>> GetEmployees();
    Task<bool> DeleteEmployee(int id);
    Task<Employee> AddEmployee(CreateEmployeeDto request);
    Task<List<Employee>> GetEmployeesByShift(WorkShift shift);
    Task<List<Employee>> GetEmployeesByDepartment(Department department);
    Task<List<Employee>> GetEmployeesByTeam(Team team);
    Task<List<Employee>> GetEmployeesByDesignation(Designation designation);
    Task<List<Employee>> GetEmployeesByRole(Role role);
}
