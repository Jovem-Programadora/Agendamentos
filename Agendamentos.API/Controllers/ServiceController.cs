using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Agendamentos.Biblioteca.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ServiceController(APIContext context) : ControllerBase
{
    private readonly APIContext _context = context;
    [HttpPost("register/")]
    public async Task<IActionResult> RegisterServiceAsync([FromBody] ServiceRegistrationDto request)
    {
        Service? service = await _context.Services.FirstOrDefaultAsync(s => s.Name.Equals(request.Name));
        if (service is not null) return StatusCode(400, "Este serviço já existe");

        service = new Service(request);
        await _context.Services.AddAsync(service);
        await _context.SaveChangesAsync();

        return StatusCode(201, service);
    }

    [HttpGet("get_all/")]
    public async Task<IActionResult> GetAllServicesAsync()
    {
        List<ServiceDto>? services = await _context.Services.
            Select(s => new ServiceDto(s))
            .ToListAsync();
        if (services is null || services.Count.Equals(0)) return StatusCode(404, "Nenhum serviço foi encontrado");

        return StatusCode(200, services);
    }

    [HttpPatch("update/{id}")]
    public async Task<IActionResult> UpdateServiceAsync(int id, [FromBody] ServiceRegistrationDto request)
    {
        Service? service = await _context.Services.FindAsync(id);
        if (service is null) return StatusCode(404, "Serviço não encontrado");

        service.Name = request.Name;
        service.Description = request.Description;
        service.Price = request.Price;
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
    public async Task<IActionResult> DeleteServiceByIdAsync(int id)
    {
        Service? service = await _context.Services.FindAsync(id);
        if (service is null) return StatusCode(404, "Serviço não foi encontrado");

        _context.Services.Remove(service);
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }
}
