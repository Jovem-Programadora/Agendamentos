using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Agendamentos.Biblioteca.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController(APIContext context) : ControllerBase
    {
        private readonly APIContext _context = context;
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAppointmentAsync([FromBody] AppointmentRegistrationDto request)
        {
            Client? client = await _context.Clients.FindAsync(request.ClientID);
            if (client == null) return StatusCode(404, "Cliente não encontrado");
            Employee? employee = await _context.Employees.FindAsync(request.EmployeeID);
            if (employee == null) return StatusCode(404, "Funcionário não encontrado");
            Service? service = await _context.Services.FindAsync(request.ServiceID);
            if (service == null) return StatusCode(404, "Seriço não encontrado");

            var appointment = new Appointment(request)
            {
                Client = client,
                Employee = employee,
                Service = service
            };

            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();

            return StatusCode(200, new AppointmentDto(appointment));
        }

        [HttpGet("get_all")]
        public async Task<IActionResult> GetAllAppointmentsAsync([FromQuery] DateTime? date)
        {
            IQueryable<Agendamentos.Biblioteca.Appointment> query = _context.Appointments;

            query = _context.Appointments
                .Include(a => a.Client)
                .Include(a => a.Employee)
                .Include(a => a.Service);

            if (date.HasValue)
            {
                var filterDate = date.Value.Date;

                query = query.Where(a => a.ScheduledAt.Date == filterDate);
            }

            List<AppointmentDto>? appointments = await query
                .Select(a => new AppointmentDto(a))
                .ToListAsync();

            return StatusCode(200, appointments);
        }
    }
}
