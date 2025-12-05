namespace Agendamentos.Biblioteca.DTOs;

public abstract class UserDto
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public abstract class UserRegistrationDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public abstract class UserUpdateDto : UserRegistrationDto { }
