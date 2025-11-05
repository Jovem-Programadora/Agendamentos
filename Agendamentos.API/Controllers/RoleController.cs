using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegisterRoleAsync()
    {
        return Created();
    }
    [HttpGet]
    public async Task<IActionResult> GetRoleByIdAsync()
    {
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateRoleAsync()
    {
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteRoleByIdAsync()
    {
        return Ok();
    }
}
