using Agendamentos.Biblioteca.DTOs;

namespace Agendamentos.Biblioteca;

public class Role
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Employee>? Employees { get; set; }

    public Role() {}

    public Role(RoleRegistrationDto dto) => Name = dto.Name;
}
