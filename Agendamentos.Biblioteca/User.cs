namespace Agendamentos.Biblioteca;

public abstract class User
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly Birth { get; set; }
    public Address? Address { get; set; }
    public string? Description { get; set; }

    protected User() { }

    // Construtor Mínimo - Contem as informações obrigatórias
    protected User(string name, string email, string phone, DateOnly birth)
    {
        this.Name = name;
        this.Email = email;
        this.Phone = phone;
        this.Birth = birth;
    }

    // Construtor Total - Contem todas as informações
    protected User(string name, string email, string phone, DateOnly birth, Address address, string description, int id)
        : this(name, email, phone, birth)
    {
        this.Address = address;
        this.Description = description;
        this.ID = id;
    }
}

