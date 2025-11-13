namespace Agendamentos.Biblioteca.DTOs;

public class RoleDto
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;

    public RoleDto() {}
    public RoleDto(Role role)
    {
        ID = role.ID;
        Name = role.Name;
    }
}

public class RoleRegistrationDto
{
    public string Name { get; set; } = string.Empty;
}
