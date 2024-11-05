using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmloyoeeApi.Models;
using EmloyoeeApi.Services;
using System.Security.Cryptography.Xml;

namespace EmloyoeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeServices _employeeServices;

        public EmployeeController(EmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

      
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll(int pageNumber, int pageSize)
        {
            var employees = await _employeeServices.GetAllAsync( pageNumber,  pageSize);
            return Ok(employees);
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employee = await _employeeServices.GetAsync(id);
            if (employee == null)
                return NotFound(); 
            return Ok(employee); 
        }

      
        [HttpPost]
        public async Task<ActionResult<Employee>> Create(Employee employee)
        {
            await _employeeServices.AddAsync(employee);
           
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Employee employee)
        {
            var employees = await _employeeServices.UpdateAsync(id, employee);
            return Ok(employees);
        }

      
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            await _employeeServices.DeleteAsync(id);
            return NoContent(); 
        }
    }
}
