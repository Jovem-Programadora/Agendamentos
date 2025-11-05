using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    [HttpPost]
    [HttpGet]
    [HttpPut]
    [HttpDelete]
}
