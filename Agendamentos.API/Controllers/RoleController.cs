using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Agendamentos.Biblioteca.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class RoleController(APIContext context) : ControllerBase
{
    private readonly APIContext _context = context;

    [HttpPost("register/")]
    public async Task<IActionResult> RegisterRoleAsync([FromBody] RoleRegistrationDto request)
    {
        Role? role = await _context.Roles.FirstOrDefaultAsync(r => r.Name.Equals(request.Name));
        if (role is not null) return StatusCode(400, "Cargo já existe");
        
        role = new Role(request);
        await _context.Roles.AddAsync(role);
        await _context.SaveChangesAsync();

        return StatusCode(201, new RoleDto(role));
    }

    [HttpGet("get_all/")]
    public async Task<IActionResult> GetAllRolesAsync()
    {
        List<RoleDto>? roles = await _context.Roles
            .Select(r => new RoleDto(r))
            .ToListAsync();
        if (roles is null || roles.Count.Equals(0)) return NotFound("Nenhum cargo foi encontrado");
        return StatusCode(200, roles);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateRoleAsync(int id, [FromBody] RoleRegistrationDto request)
    {
        Role? role = await _context.Roles.FindAsync(id);
        if (role is null) return StatusCode(404, "Cargo não encontrado");

        role.Name = request.Name;

        await _context.SaveChangesAsync();
        return StatusCode(204);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteRoleByIdAsync(int id)
    {
        Role? role = await _context.Roles.FindAsync(id);
        if (role is null) return StatusCode(404, "Cargo não encontrado");

        _context.Roles.Remove(role);
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }
}
