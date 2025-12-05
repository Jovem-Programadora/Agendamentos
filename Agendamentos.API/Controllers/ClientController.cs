using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Agendamentos.Biblioteca.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace Agendamentos.API.Controllers;

[Route("[controller]")] // Anotação
[ApiController]
public class ClientController(APIContext context) : ControllerBase
{
    private readonly APIContext _context = context;

    [HttpPost("register/")]
    public async Task<IActionResult> RegisterClientAsync([FromBody] ClientRegistrationDto request)
    {
        Client? client = await _context.Clients.FirstOrDefaultAsync(c => c.Email.Equals(request.Email));
        if (client is not null) return StatusCode(400, "Cliente já existe no sistema");
        client = new(request);
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
        return StatusCode(201, client);
    }

    [HttpGet("get_all/")]
    public async Task<IActionResult> GetAllClientsAsync()
    {
        List<ClientDto>? clients = await _context.Clients
            .Select(c => new ClientDto(c))
            .ToListAsync();
        if (clients is null || clients.Count.Equals(0)) return NotFound("Nenhum cliente foi encontrado");
        return StatusCode(200, clients);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateClientAsync(int id, [FromBody] ClientUpdateDto request)
    {
        if (id <= 0) return StatusCode(400, "O ID é inválido");

        Client? client = await _context.Clients.FindAsync(id);
        if (client is null) return StatusCode(404, "Cliente não encontrado");

        client.Email = request.Email;
        client.Name = request.Name;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            var innerException = ex.InnerException;

            if(innerException is MySqlException sqlException)
            {
                if(sqlException.Number is 1062)
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

    [HttpPatch("toggle_email/{id}")]
    public async Task<IActionResult> ToggleEmailFromClientIdAsync(int id)
    {
        Client? client = await _context.Clients.FindAsync(id);
        if (client is null) return StatusCode(404, "Cliente não encontrado");

        client.CanReceiveEmail = !client.CanReceiveEmail;
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteClientByIdAsync(int id)
    {
        Client? client = await _context.Clients.FindAsync(id);
        if (client is null) return StatusCode(404, "Cliente não encontrado");

        _context.Remove(client);
        await _context.SaveChangesAsync();

        return StatusCode(204);
    }
}
