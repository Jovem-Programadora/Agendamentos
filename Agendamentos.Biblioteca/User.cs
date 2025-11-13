namespace Agendamentos.Biblioteca;

public abstract class User
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly Birth { get; set; }
    public string? Description { get; set; }
}

