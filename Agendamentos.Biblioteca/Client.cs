namespace Agendamentos.Biblioteca;

public class Client : User
{
    // Propriedades
    public bool CanReceiveEmail { get; set; } = false;
    public List<Appointment>? Appointments { get; set; }

    // Construtores
    public Client() : base() { }
        
    public Client(string name, string email, string phone, DateOnly birth, bool canReceiveEmail) : base(name, email, phone, birth)
    {
        this.CanReceiveEmail = canReceiveEmail;
    }

    public Client(string name, string email, string phone, DateOnly birth, bool canReceiveEmail, Address address, string description, int id) : base(name, email, phone, birth, address, description, id)
    {
        this.CanReceiveEmail = canReceiveEmail;
    }
}