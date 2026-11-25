using Microsoft.AspNetCore.Mvc;
using scaling_enigma.Interfaces;
using scaling_enigma.Models.Dtos;
using scaling_enigma.Models.Entities;

namespace scaling_enigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee?>> GetEmployee(int id)
        {
            var employee = await _service.GetEmployee(id);
            if (employee is null) return NotFound();
            return Ok(employee);
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var employees = await _service.GetEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee([FromBody] CreateEmployeeDto request)
        {
            try
            {
                var addedEmployee = await _service.AddEmployee(request);
                return Ok(addedEmployee);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Employee?>> UpdateEmployee(int id, [FromBody] UpdateEmployeeDto request)
        {
            try
            {
                var updatedEmployee = await _service.UpdateEmployee(id, request);
                if (updatedEmployee is null) return NotFound();
                return Ok(updatedEmployee);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            try
            {
                var isEmployeeDeleted = await _service.DeleteEmployee(id);
                if (!isEmployeeDeleted) return NotFound();

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
