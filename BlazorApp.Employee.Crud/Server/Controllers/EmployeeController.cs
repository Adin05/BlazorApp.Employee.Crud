using BlazorApp.Employee.Crud.Server.Services.Employee;
using BlazorApp.Employee.Crud.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Employee.Crud.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        [HttpGet("")]
        public async Task<ActionResult> GetEmployees() { 
            var model = await _employeeService.GetAll();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployee(int id) { 
            var model = await _employeeService.Get(id);
            return Ok(model);
        }
        [HttpPost("create")]
        public async Task<ActionResult> Create(Tb_Employee model) { 
            await _employeeService.Create(model);
            return Ok();
        }
        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update(int id, Tb_Employee model) { 
            await _employeeService.Update(id, model);
            return Ok();
        }
        [HttpDelete("delete")]
        public async Task<ActionResult> Delete(int id)
        {
            await _employeeService.Delete(id);
            return Ok();
        }
    }
}
