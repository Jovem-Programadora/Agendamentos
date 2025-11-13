namespace Agendamentos.Biblioteca.DTOs;

public class ServiceDto
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }

    public ServiceDto() { }
    public ServiceDto(Service service)
    {
        ID = service.ID;
        Name = service.Name;
        Description = service.Description;
        Price = service.Price;

    }
}

public class ServiceRegistrationDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}
