using Agendamentos.Biblioteca.DTOs;

namespace Agendamentos.Biblioteca;

public class Service
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Appointment>? Appointments { get; set; }

    public Service() {}

    public Service(ServiceRegistrationDto dto)
    {
        Name = dto.Name;
        Description = dto.Description;
        Price = dto.Price;
    }
}
