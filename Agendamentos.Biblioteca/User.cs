namespace Agendamentos.Biblioteca;

public abstract class User
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
