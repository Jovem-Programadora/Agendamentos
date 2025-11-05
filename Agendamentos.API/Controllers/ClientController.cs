using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Controllers;

[Route("[controller]")] // Anotação
[ApiController]
public class ClientController(APIContext context) : ControllerBase
{
    private APIContext _context = context;

    [HttpPost]
    public async Task<IActionResult> RegisterClientAsync([FromBody] Client request)
    {
        await _context.Clients.AddAsync(request);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetClientByIdAsync), new { id = request.ID }, request);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetClientByIdAsync(int id)
    {
        Client? result = await _context.Clients.FindAsync(id);
        if (result is null) return NotFound("Cliente não foi encontrado!");
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateClientAsync([FromBody] Client request)
    {
        if (request.ID <= 0) return BadRequest();

        Client? result = await _context.Clients.FindAsync(request.ID);
        if (result == null) return NotFound();

        _context.Clients.Update(request);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> ToggleEmailFromClientIdAsync(int id)
    {
        Client? result = await _context.Clients.FindAsync(id);
        if (result == null) return NotFound();
        result.CanReceiveEmail = !result.CanReceiveEmail;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClientByIdAsync(int id)
    {
        Client? client = await _context.Clients.FindAsync(id);
        if (client == null) return NotFound();
        _context.Remove(client);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
