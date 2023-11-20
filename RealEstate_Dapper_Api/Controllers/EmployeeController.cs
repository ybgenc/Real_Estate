using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var values = await _employeeRepository.GetEmployeeAsync(id);
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Employee has been successfully updated");
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Employee has been successfully added");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Employee has been successfully deleted");
        }
    }
}
