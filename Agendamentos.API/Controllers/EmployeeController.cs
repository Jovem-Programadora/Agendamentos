using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Agendamentos.Biblioteca.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data.Common;
using System.Threading.Tasks;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class EmployeeController(APIContext context) : ControllerBase
{
    private readonly APIContext _context = context;
    [HttpPost("register/")]
    public async Task<IActionResult> RegisterEmployeeAsync([FromBody] EmployeeRegistrationDto request)
    {
        Employee? employee = await _context.Employees
            .FirstOrDefaultAsync(e => e.Email.Equals(request.Email) || e.Phone.Equals(request.Phone));
        if (employee is not null) return StatusCode(400, "Funcionário já registrado");

        Role? role = await _context.Roles.FindAsync(request.RoleID);
        if (role is null) return StatusCode(404, "Cargo não encontrado");

        employee = new Employee(request)
        {
            Role = role
        };


        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();

        return StatusCode(201, employee);
    }
    [HttpGet("get_all/")]

    public async Task<IActionResult> GetAllEmployeesAsync()
    {
        List<EmployeeDto>? employees = await _context.Employees
            .Include(e => e.Role)
            .Select(e => new EmployeeDto(e))
            .ToListAsync();
        if (employees is null || employees.Count < 1) return StatusCode(404, "Nenhum funcionário foi encontrado");

        return StatusCode(200, employees);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateEmployeeByIdAsync(int id, [FromBody] EmployeeUpdateDto request)
    {
        Employee? employee = await _context.Employees.FindAsync(id);
        if (employee is null) return StatusCode(404, "Funcionário não encontrado");

        employee.Description = request.Description;
        employee.Email = request.Email;
        employee.Name = request.Name;
        employee.Phone = request.Phone;
        employee.RoleID = request.RoleID;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            var innerException = ex.InnerException;

            if (innerException is MySqlException sqlException)
            {
                if (sqlException.Number is 1062)
                {
                    return StatusCode(400, "Email ou telefone já estão em uso");
                }
            }

            throw;
        }
        catch (Exception)
        {
            return StatusCode(500, "Ocorreu um erro inesperado");
        }

        return StatusCode(204);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteEmployeeByIdAsync(int id)
    {
        Employee? employee = await _context.Employees.FindAsync(id);
        if (employee is null) return StatusCode(404, "Funcionário não encontrado");

        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }
}
